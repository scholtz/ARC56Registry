#!/usr/bin/env python3
"""Shared helpers for computing and publishing the registry's live statistics.

Used by scripts/update_arc56_links.py (which recomputes these numbers and
commits the result as the last step of its daily run) to answer: how many
ARC-56 links have been found in total, how many distinct GitHub repositories
they come from, and how many generated packages have actually been published
to nuget.org/npm/PyPI so far.

Package-publish counts are obtained by **querying each registry's own live
package index** (nuget.org's flat-container index, the npm registry's package
metadata, PyPI's JSON API) for every generated project - the same "ask the
registry, don't trust a local flag" principle publish_dotnet_packages.py /
publish_npm_packages.py / publish_python_packages.py already use to decide
what needs publishing (see those scripts' docstrings). Each project's local
state.json also records a "published_version" field after a successful
publish, but that field is only ever an informational cache written back by
this pipeline's own commit-back step - if that step doesn't land for some
repos (a failed push, a missed workflow_run trigger, etc.), the local flag
silently undercounts real publishes. This module was originally written to
trust that local flag and was found to undercount nuget.org's own reported
total by ~140 packages - see the live queries below instead.

These are read-only, unauthenticated GETs against public CDN-backed/JSON
endpoints (no push quota applies, unlike actually publishing a package), run
concurrently per ecosystem the same way publish_dotnet_packages.py already
does for its own "list published versions" lookups (see LIST_MAX_WORKERS
there) - a full run across all three ecosystems (500+ packages each) takes on
the order of ten seconds per ecosystem in practice, not the multi-minute,
rate-limited pacing that pushing a new version needs.
"""
from __future__ import annotations

import concurrent.futures
import csv
import datetime
import glob
import json
import os
import re
import urllib.error
import urllib.request

REPO_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
CSV_PATH = os.path.join(REPO_ROOT, "arc56.links.csv")
CLIENTS_DIR = os.path.join(REPO_ROOT, "clients")
README_PATH = os.path.join(REPO_ROOT, "README.md")
STATS_HISTORY_PATH = os.path.join(REPO_ROOT, "arc56_stats_history.csv")

NUGET_FLAT_CONTAINER_BASE = "https://api.nuget.org/v3-flatcontainer"
NPM_REGISTRY = "https://registry.npmjs.org"
PYPI_JSON_URL = "https://pypi.org/pypi/{package}/json"
LIST_MAX_WORKERS = 16  # matches the reasoning in publish_dotnet_packages.py's
# LIST_MAX_WORKERS: these are public, unauthenticated, no-quota reads, unlike pushing.

DIST_NAME_RE = re.compile(r'^name\s*=\s*"([^"]+)"', re.MULTILINE)

RAW_URL_RE = re.compile(
    r"^https://raw\.githubusercontent\.com/(?P<owner>[^/]+)/(?P<repo>[^/]+)/[^/]+/(?P<path>.+)$"
)

# Never remove or reorder columns here - arc56_stats_history.csv is append-only
# (same never-delete philosophy as arc56.links.csv) so it can be charted as a
# time series later; a changed schema would break that.
STATS_HISTORY_FIELDNAMES = [
    "Timestamp",
    "ARC56Links",
    "Repositories",
    "NuGetPackagesPublished",
    "NpmPackagesPublished",
    "PyPIPackagesPublished",
]

README_STATS_START = "<!-- LIVE-STATS:START -->"
README_STATS_END = "<!-- LIVE-STATS:END -->"


def count_links_and_repos(csv_path: str = CSV_PATH) -> tuple[int, int]:
    """Returns (total ARC56 link rows, distinct owner/repo repositories among them).

    Counts every row regardless of Active status - rows are never deleted, so
    this is a running total of every ARC-56 file ever found, matching "how
    many ARC56 links were found" rather than "how many are active right now".
    """
    if not os.path.exists(csv_path):
        return 0, 0
    links = 0
    repos: set[str] = set()
    with open(csv_path, newline="", encoding="utf-8") as f:
        for row in csv.DictReader(f):
            url = row.get("ARC56URL", "")
            if not url:
                continue
            links += 1
            m = RAW_URL_RE.match(url)
            if m:
                repos.add(f"{m.group('owner')}/{m.group('repo')}".lower())
    return links, len(repos)


def _fetch_json(url: str, retries: int = 3) -> dict | None:
    """GET a public JSON endpoint, returning None on a 404 (package/version
    list genuinely doesn't exist yet) and retrying transient errors a few
    times before giving up - a single flaky lookup shouldn't have to abort an
    entire stats run."""
    req = urllib.request.Request(url, headers={"User-Agent": "arc56-registry-stats", "Accept": "application/json"})
    for attempt in range(1, retries + 1):
        try:
            with urllib.request.urlopen(req, timeout=15) as resp:
                return json.load(resp)
        except urllib.error.HTTPError as exc:
            if exc.code == 404:
                return None
            if attempt == retries:
                return None
        except (urllib.error.URLError, TimeoutError, OSError):
            if attempt == retries:
                return None
    return None


def _is_published_on_nuget(package_id: str) -> bool:
    data = _fetch_json(f"{NUGET_FLAT_CONTAINER_BASE}/{package_id.lower()}/index.json")
    return bool(data and data.get("versions"))


def _is_published_on_npm(package_name: str) -> bool:
    data = _fetch_json(f"{NPM_REGISTRY}/{package_name}")
    return bool(data and (data.get("versions") or {}))


def _is_published_on_pypi(package_name: str) -> bool:
    data = _fetch_json(PYPI_JSON_URL.format(package=package_name))
    return bool(data and (data.get("releases") or {}))


def _count_published_bulk(identifiers: list[str], is_published) -> int:
    """Runs `is_published` for every identifier concurrently (bounded by
    LIST_MAX_WORKERS) and returns how many came back published - mirrors
    publish_dotnet_packages.py's list_published_versions_bulk, but collapsed
    to a plain count since stats doesn't need each package's actual version
    list, only whether it has at least one."""
    if not identifiers:
        return 0
    with concurrent.futures.ThreadPoolExecutor(max_workers=LIST_MAX_WORKERS) as pool:
        results = list(pool.map(is_published, identifiers))
    return sum(1 for r in results if r)


def _dotnet_package_ids() -> list[str]:
    """Package IDs for every generated .NET project, taken from the .csproj
    filename itself - mirrors find_dotnet_projects() in
    publish_dotnet_packages.py."""
    pattern = os.path.join(CLIENTS_DIR, "*", "*", "dotnet", "*.csproj")
    return [os.path.splitext(os.path.basename(p))[0] for p in glob.glob(pattern)]


def _npm_package_names() -> list[str]:
    """Package names for every generated TypeScript project, read from each
    project's package.json - mirrors find_npm_projects() in
    publish_npm_packages.py."""
    names = []
    pattern = os.path.join(CLIENTS_DIR, "*", "*", "npm", "package.json")
    for package_json_path in glob.glob(pattern):
        try:
            with open(package_json_path, encoding="utf-8") as f:
                data = json.load(f)
        except (OSError, json.JSONDecodeError):
            continue
        name = data.get("name")
        if name:
            names.append(name)
    return names


def _python_package_names() -> list[str]:
    """Distribution names for every generated Python project, parsed out of
    pyproject.toml - mirrors read_dist_name() in publish_python_packages.py."""
    names = []
    pattern = os.path.join(CLIENTS_DIR, "*", "*", "python", "pyproject.toml")
    for pyproject_path in glob.glob(pattern):
        try:
            with open(pyproject_path, encoding="utf-8") as f:
                text = f.read()
        except OSError:
            continue
        m = DIST_NAME_RE.search(text)
        if m:
            names.append(m.group(1))
    return names


def compute_stats() -> dict[str, int]:
    links, repos = count_links_and_repos()
    return {
        "arc56_links": links,
        "repositories": repos,
        "nuget_packages_published": _count_published_bulk(_dotnet_package_ids(), _is_published_on_nuget),
        "npm_packages_published": _count_published_bulk(_npm_package_names(), _is_published_on_npm),
        "pypi_packages_published": _count_published_bulk(_python_package_names(), _is_published_on_pypi),
    }


def append_stats_history(stats: dict[str, int], history_path: str = STATS_HISTORY_PATH) -> None:
    """Appends one timestamped row to arc56_stats_history.csv - never rewritten
    or deleted, so this file accumulates a full time series that can later be
    charted to show the registry's (and the wider Algorand ecosystem's) growth
    over time."""
    file_exists = os.path.exists(history_path)
    with open(history_path, "a", newline="", encoding="utf-8") as f:
        writer = csv.DictWriter(f, fieldnames=STATS_HISTORY_FIELDNAMES, lineterminator="\n")
        if not file_exists:
            writer.writeheader()
        writer.writerow({
            "Timestamp": datetime.datetime.now(datetime.timezone.utc).strftime("%Y-%m-%dT%H:%M:%SZ"),
            "ARC56Links": stats["arc56_links"],
            "Repositories": stats["repositories"],
            "NuGetPackagesPublished": stats["nuget_packages_published"],
            "NpmPackagesPublished": stats["npm_packages_published"],
            "PyPIPackagesPublished": stats["pypi_packages_published"],
        })


def render_readme_stats_block(stats: dict[str, int]) -> str:
    timestamp = datetime.datetime.now(datetime.timezone.utc).strftime("%Y-%m-%d %H:%M UTC")
    return (
        f"{README_STATS_START}\n"
        f"| Metric | Count |\n"
        f"| --- | ---: |\n"
        f"| ARC-56 links found | {stats['arc56_links']:,} |\n"
        f"| Repositories containing ARC-56 links | {stats['repositories']:,} |\n"
        f"| NuGet packages published | {stats['nuget_packages_published']:,} |\n"
        f"| npm packages published | {stats['npm_packages_published']:,} |\n"
        f"| PyPI packages published | {stats['pypi_packages_published']:,} |\n\n"
        f"_Last updated {timestamp} by `scripts/update_arc56_links.py`. Historical snapshots "
        f"(for charting growth over time): "
        f"[arc56_stats_history.csv](arc56_stats_history.csv)._\n"
        f"{README_STATS_END}"
    )


def update_readme_stats(stats: dict[str, int], readme_path: str = README_PATH) -> bool:
    """Replaces the content between the LIVE-STATS markers in README.md with a
    freshly rendered stats block. Returns True if the file's content changed.
    Requires the markers to already be present in README.md."""
    with open(readme_path, encoding="utf-8") as f:
        content = f.read()
    if README_STATS_START not in content or README_STATS_END not in content:
        raise RuntimeError(
            f"{readme_path} is missing the {README_STATS_START}/{README_STATS_END} markers"
        )
    pattern = re.compile(re.escape(README_STATS_START) + r".*?" + re.escape(README_STATS_END), re.DOTALL)
    new_content = pattern.sub(lambda _m: render_readme_stats_block(stats), content, count=1)
    if new_content == content:
        return False
    with open(readme_path, "w", encoding="utf-8") as f:
        f.write(new_content)
    return True
