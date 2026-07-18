#!/usr/bin/env python3
"""Publish already-generated Python ARC-56 client packages to PyPI.

Mirrors scripts/publish_npm_packages.py, but for PyPI instead of npm. This is the
third of three stages in the Python pipeline (download -> generate -> publish; see
scripts/download_arc56_specs.py and scripts/generate_python_clients.py). It does not
download any ARC-56 spec or regenerate any Python code - it only builds
(`python -m build`) and publishes projects that scripts/generate_python_clients.py has
already generated and committed.

For every `clients/<owner>/<repo>/python/pyproject.toml` project, this script:

  1. Reads the version that project's state.json says it should be at (bumped by
     scripts/generate_python_clients.py when that project's generated code changed).
  2. Asks the PyPI registry itself - the source of truth, not a locally cached
     "published_version" flag - which versions of that package name are already
     published: `GET https://pypi.org/pypi/<package-name>/json`.
  3. If the project's current version isn't in that list, builds it (`python -m build`,
     producing an sdist + wheel in dist/) and publishes it (`twine upload dist/*`),
     waiting at least PUBLISH_DELAY_SECONDS between publishes so this script doesn't
     hammer the PyPI registry.

Querying the PyPI registry for each package's published versions (rather than trusting
a locally-recorded flag) means a partially-failed previous publish run, or a manual
publish done outside this pipeline, is always detected correctly.

Authentication uses a PyPI **API token**, passed in via the PYPI_TOKEN environment
variable - see docs/python-client-pipeline.md and docs/pypi-publishing-setup.md for
why (in short: PyPI's Trusted Publishing has to be configured per-project on pypi.org
one at a time before that project's very first release, which doesn't scale to this
repo's ever-growing, auto-created set of packages the way a single account-wide API
token does - the same reasoning the npm pipeline already documents for its own
NPM_TOKEN).
"""
from __future__ import annotations

import argparse
import datetime
import glob
import json
import os
import re
import shutil
import subprocess
import sys
import time
import urllib.error
import urllib.request

REPO_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
CLIENTS_DIR = os.path.join(REPO_ROOT, "clients")
PYPI_JSON_URL = "https://pypi.org/pypi/{package}/json"
TWINE_EXE = shutil.which("twine") or "twine"

PUBLISH_DELAY_SECONDS = 20  # minimum time between successive `twine upload` calls - mirrors
# PUBLISH_DELAY_SECONDS in scripts/publish_npm_packages.py; PyPI has no documented numeric
# quota like nuget.org's 350/hour, but every project here is a brand-new package name, so a
# conservative fixed delay is kept for the same reason the npm pipeline keeps one.
LIST_DELAY_SECONDS = 1  # minimum time between successive "list published versions" lookups

_last_push_at: float | None = None
_last_list_at: float | None = None

DIST_NAME_RE = re.compile(r'^name\s*=\s*"([^"]+)"', re.MULTILINE)


def log(message: str) -> None:
    """Every log line is prefixed with a UTC timestamp - always to stderr, never the
    dry-run "would ..." preview lines below, which intentionally stay plain stdout
    output rather than a log."""
    timestamp = datetime.datetime.now(datetime.timezone.utc).strftime("%Y-%m-%dT%H:%M:%SZ")
    print(f"{timestamp} {message}", file=sys.stderr)


def _rate_limit(last_at: float | None, delay_seconds: float) -> float:
    if last_at is not None:
        elapsed = time.monotonic() - last_at
        wait = delay_seconds - elapsed
        if wait > 0:
            time.sleep(wait)
    return time.monotonic()


def find_python_projects() -> list[tuple[str, str, str]]:
    """Returns (owner, repo, project_dir) for every generated Python project."""
    projects = []
    pattern = os.path.join(CLIENTS_DIR, "*", "*", "python", "pyproject.toml")
    for pyproject_path in sorted(glob.glob(pattern)):
        project_dir = os.path.dirname(pyproject_path)
        repo_dir = os.path.dirname(project_dir)
        owner_dir = os.path.dirname(repo_dir)
        owner = os.path.basename(owner_dir)
        repo = os.path.basename(repo_dir)
        projects.append((owner, repo, project_dir))
    return projects


def load_json(path: str) -> dict:
    if not os.path.exists(path):
        return {}
    with open(path, encoding="utf-8") as f:
        return json.load(f)


def save_json(path: str, data: dict) -> None:
    with open(path, "w", encoding="utf-8") as f:
        json.dump(data, f, indent=2, sort_keys=True)
        f.write("\n")


def read_dist_name(pyproject_path: str) -> str | None:
    with open(pyproject_path, encoding="utf-8") as f:
        text = f.read()
    m = DIST_NAME_RE.search(text)
    return m.group(1) if m else None


def list_published_versions(package_name: str) -> set[str]:
    """Queries the public PyPI JSON API for every version of `package_name` currently
    published - no auth needed for a read of a public package's metadata."""
    global _last_list_at
    _last_list_at = _rate_limit(_last_list_at, LIST_DELAY_SECONDS)
    url = PYPI_JSON_URL.format(package=package_name)
    req = urllib.request.Request(url, headers={"User-Agent": "arc56-python-publisher", "Accept": "application/json"})
    try:
        with urllib.request.urlopen(req) as resp:
            data = json.load(resp)
        return set((data.get("releases") or {}).keys())
    except urllib.error.HTTPError as exc:
        if exc.code == 404:
            return set()  # package never published at all yet
        raise


def clean_dist_dir(project_dir: str) -> str:
    dist_dir = os.path.join(project_dir, "dist")
    if os.path.isdir(dist_dir):
        shutil.rmtree(dist_dir)
    return dist_dir


def python_build(project_dir: str) -> None:
    dist_dir = clean_dist_dir(project_dir)
    result = subprocess.run(
        [sys.executable, "-m", "build", "--outdir", dist_dir],
        cwd=project_dir, capture_output=True, text=True,
    )
    if result.returncode != 0:
        raise RuntimeError(f"python -m build failed in {project_dir}\n{result.stdout}\n{result.stderr}")


class RateLimited(Exception):
    """Raised when PyPI's upload endpoint responds with an HTTP 429 to a publish. Once
    this happens, every subsequent publish in the same run is likely to hit the same
    limiter, so the caller should stop publishing entirely for this run rather than
    burning through the rest of the project list on doomed retries - mirrors
    RateLimited in scripts/publish_npm_packages.py. The next scheduled run picks up
    exactly where this one left off, since nothing here is trusted as published until
    PyPI's own version list confirms it."""


def publish_to_pypi(project_dir: str, pypi_token: str) -> bool:
    global _last_push_at
    _last_push_at = _rate_limit(_last_push_at, PUBLISH_DELAY_SECONDS)
    dist_dir = os.path.join(project_dir, "dist")
    env = dict(os.environ)
    env["TWINE_USERNAME"] = "__token__"
    env["TWINE_PASSWORD"] = pypi_token
    result = subprocess.run(
        [TWINE_EXE, "upload", "--non-interactive", os.path.join(dist_dir, "*")],
        cwd=project_dir, capture_output=True, text=True, env=env, shell=False,
    )
    if result.returncode != 0:
        combined = result.stdout + result.stderr
        if "429" in combined and "Too Many Requests" in combined:
            raise RateLimited(combined)
        log(f"WARNING: twine upload failed for {project_dir} (will retry next run):\n"
            f"{result.stdout}\n{result.stderr}")
        return False
    return True


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    parser.add_argument("--limit-projects", type=int, default=None,
                         help="Only consider the first N owner/repo projects (for local testing).")
    parser.add_argument("--only-repo", action="append", default=[],
                         help="Only consider owner/repo (exact match, can be passed multiple times).")
    parser.add_argument("--filter", action="append", default=[],
                         help="Only consider owner/repo pairs whose \"owner/repo\" string contains this "
                              "substring, case-insensitive. Can be passed multiple times (OR'd together). "
                              "If --only-repo is also given, a project must satisfy both.")
    parser.add_argument("--dry-run", action="store_true",
                         help="List what would be built/published without actually doing it.")
    args = parser.parse_args()

    pypi_token = os.environ.get("PYPI_TOKEN")
    if not pypi_token and not args.dry_run:
        log("ERROR: PYPI_TOKEN not set (and --dry-run not passed) - nothing to publish")
        return 1

    projects = find_python_projects()
    if args.only_repo:
        wanted = set(args.only_repo)
        projects = [p for p in projects if f"{p[0]}/{p[1]}" in wanted]
    if args.filter:
        keywords = [f.lower() for f in args.filter]
        projects = [p for p in projects if any(kw in f"{p[0]}/{p[1]}".lower() for kw in keywords)]
    if args.limit_projects is not None:
        projects = projects[: args.limit_projects]

    total = len(projects)
    log(f"Found {total} generated Python project(s)")

    published_count = 0
    up_to_date_count = 0
    no_version_count = 0
    failed_count = 0

    for i, (owner, repo, project_dir) in enumerate(projects, start=1):
        log(f"[{i}/{total}] {owner}/{repo}")
        pyproject_path = os.path.join(project_dir, "pyproject.toml")
        state_path = os.path.join(project_dir, "state.json")
        package_name = read_dist_name(pyproject_path)
        state = load_json(state_path)
        version = state.get("version")
        if not package_name or not version:
            no_version_count += 1
            continue

        try:
            published_versions = list_published_versions(package_name)
        except Exception as exc:  # noqa: BLE001 - one project's lookup must not abort the run
            log(f"WARNING: could not list published versions for {package_name}: {exc}")
            failed_count += 1
            continue

        if version in published_versions:
            up_to_date_count += 1
            continue

        log(f"{package_name} needs publishing: {version} not in {len(published_versions)} "
            f"published version(s)")
        if args.dry_run:
            print(f"would build + publish {package_name} {version}")
            continue

        try:
            python_build(project_dir)
        except Exception as exc:  # noqa: BLE001
            log(f"WARNING: build failed for {package_name} {version}: {exc}")
            failed_count += 1
            continue

        try:
            pushed = publish_to_pypi(project_dir, pypi_token)
        except RateLimited as exc:
            log(f"PyPI rate limit hit - stopping this run early instead of retrying "
                f"the remaining {total - i + 1} project(s), which would likely all fail the "
                f"same way until the limiter resets; they'll be picked up by the next "
                f"scheduled run:\n{exc}")
            remaining_skipped = total - i + 1
            log(f"Done: {total} project(s) checked, {published_count} published, "
                f"{up_to_date_count} already up to date, {no_version_count} with no version yet, "
                f"{failed_count} failed, {remaining_skipped} skipped due to rate limit")
            return 1

        if pushed:
            state["published_version"] = version
            save_json(state_path, state)
            log(f"Published {package_name} {version} to PyPI")
            published_count += 1
        else:
            failed_count += 1

    verb = "Would publish" if args.dry_run else "Published"
    log(f"Done: {total} project(s) checked, {published_count if not args.dry_run else 'N/A'} "
        f"{verb.lower()}, {up_to_date_count} already up to date, {no_version_count} with no version yet, "
        f"{failed_count} failed")
    return 1 if failed_count else 0


if __name__ == "__main__":
    sys.exit(main())
