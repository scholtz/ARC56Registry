#!/usr/bin/env python3
"""Shared helpers for computing and publishing the registry's live statistics.

Used by scripts/update_arc56_links.py (which recomputes these numbers and
commits the result as the last step of its daily run) to answer: how many
ARC-56 links have been found in total, how many distinct GitHub repositories
they come from, and how many generated packages have actually been published
to nuget.org/npm/PyPI so far.

Package-publish counts are read from the *local* state.json files that
generate_dotnet_clients.py / generate_typescript_clients.py /
generate_python_clients.py write into clients/<owner>/<repo>/<ecosystem>/, and
that the matching publish_*_packages.py script stamps with a
"published_version" field after a successful push - not a live query against
nuget.org/npm/PyPI. This keeps stats computation network-free (consistent
with every part of update_arc56_links.py apart from the GitHub search itself)
at the cost of being only as fresh as the last local publish run recorded in
this checkout.
"""
from __future__ import annotations

import csv
import datetime
import glob
import json
import os
import re

REPO_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
CSV_PATH = os.path.join(REPO_ROOT, "arc56.links.csv")
CLIENTS_DIR = os.path.join(REPO_ROOT, "clients")
README_PATH = os.path.join(REPO_ROOT, "README.md")
STATS_HISTORY_PATH = os.path.join(REPO_ROOT, "arc56_stats_history.csv")

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


def _count_published_packages(ecosystem_subdir: str, state_filename: str = "state.json") -> int:
    """Counts generated projects for one ecosystem whose local state.json
    records a "published_version" - i.e. have been successfully published at
    least once, per the last local publish_*_packages.py run recorded in this
    checkout (see module docstring for why this isn't a live registry query).
    """
    count = 0
    pattern = os.path.join(CLIENTS_DIR, "*", "*", ecosystem_subdir, state_filename)
    for state_path in glob.glob(pattern):
        try:
            with open(state_path, encoding="utf-8") as f:
                state = json.load(f)
        except (OSError, json.JSONDecodeError):
            continue
        if state.get("published_version"):
            count += 1
    return count


def compute_stats() -> dict[str, int]:
    links, repos = count_links_and_repos()
    return {
        "arc56_links": links,
        "repositories": repos,
        "nuget_packages_published": _count_published_packages("dotnet"),
        "npm_packages_published": _count_published_packages("npm"),
        "pypi_packages_published": _count_published_packages("python"),
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
