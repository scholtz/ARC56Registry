#!/usr/bin/env python3
"""Publish already-generated .NET ARC-56 client packages to nuget.org.

This is the third of three stages in the client-generation pipeline (download ->
generate -> publish; see scripts/download_arc56_specs.py and
scripts/generate_dotnet_clients.py). It does not download any ARC-56 spec or
regenerate any C# code - it only packs (`dotnet pack`) and pushes projects that
scripts/generate_dotnet_clients.py has already generated and committed.

For every `clients/<owner>/<repo>/dotnet/*.csproj` project, this script:

  1. Reads the version that project's state.json says it should be at (bumped by
     scripts/generate_dotnet_clients.py when that project's generated code changed).
  2. Asks nuget.org's own package-content index - the source of truth, not a locally
     cached "published_version" flag - which versions of that package ID are already
     published: `GET https://api.nuget.org/v3-flatcontainer/<id-lower>/index.json`.
  3. If the project's current version isn't in that list, packs it (`dotnet pack`) and
     pushes it (`dotnet nuget push --skip-duplicate`), waiting at least
     PUBLISH_DELAY_SECONDS between pushes so this script doesn't hammer nuget.org.

Querying nuget.org for each package's published versions (rather than trusting a
locally-recorded flag) means a partially-failed previous publish run, or a manual
push done outside this pipeline, is always detected correctly - there is only one
source of truth for "is this version published," and it's nuget.org itself.

Publishing uses **Trusted Publishing** (OIDC, short-lived API key via NUGET_API_KEY),
not a long-lived secret - see docs/dotnet-client-pipeline.md.
"""
from __future__ import annotations

import argparse
import glob
import json
import os
import re
import subprocess
import sys
import time
import urllib.error
import urllib.request

REPO_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
CLIENTS_DIR = os.path.join(REPO_ROOT, "clients")
NUPKG_OUTPUT_DIR = os.path.join(REPO_ROOT, "artifacts", "nupkgs")
NUGET_SOURCE = "https://api.nuget.org/v3/index.json"
FLAT_CONTAINER_BASE = "https://api.nuget.org/v3-flatcontainer"

PUBLISH_DELAY_SECONDS = 5  # minimum time between successive `dotnet nuget push` calls
LIST_DELAY_SECONDS = 1  # minimum time between successive "list published versions" lookups

_last_push_at: float | None = None
_last_list_at: float | None = None


def _rate_limit(last_at: float | None, delay_seconds: float) -> float:
    if last_at is not None:
        elapsed = time.monotonic() - last_at
        wait = delay_seconds - elapsed
        if wait > 0:
            time.sleep(wait)
    return time.monotonic()


def find_dotnet_projects() -> list[tuple[str, str, str, str]]:
    """Returns (owner, repo, project_dir, package_id) for every generated .NET project,
    discovered from the .csproj file itself (named after its own PackageId) rather than
    re-deriving owner/repo sanitization rules here."""
    projects = []
    pattern = os.path.join(CLIENTS_DIR, "*", "*", "dotnet", "*.csproj")
    for csproj_path in sorted(glob.glob(pattern)):
        project_dir = os.path.dirname(csproj_path)
        repo_dir = os.path.dirname(project_dir)
        owner_dir = os.path.dirname(repo_dir)
        owner = os.path.basename(owner_dir)
        repo = os.path.basename(repo_dir)
        package_id = os.path.splitext(os.path.basename(csproj_path))[0]
        projects.append((owner, repo, project_dir, package_id))
    return projects


def load_state(path: str) -> dict:
    if not os.path.exists(path):
        return {}
    with open(path, encoding="utf-8") as f:
        return json.load(f)


def save_state(path: str, state: dict) -> None:
    with open(path, "w", encoding="utf-8") as f:
        json.dump(state, f, indent=2, sort_keys=True)
        f.write("\n")


def list_published_versions(package_id: str) -> set[str]:
    """Queries nuget.org's package base address (flat container) index, which is the
    plain-JSON, no-auth-needed source of every version of `package_id` currently
    published - not an approximation or a search index, so a version present here is
    unambiguously already live."""
    global _last_list_at
    _last_list_at = _rate_limit(_last_list_at, LIST_DELAY_SECONDS)
    url = f"{FLAT_CONTAINER_BASE}/{package_id.lower()}/index.json"
    req = urllib.request.Request(url, headers={"User-Agent": "arc56-nuget-publisher"})
    try:
        with urllib.request.urlopen(req) as resp:
            data = json.load(resp)
        return set(data.get("versions", []))
    except urllib.error.HTTPError as exc:
        if exc.code == 404:
            return set()  # package never published at all yet
        raise


def pack_project(project_dir: str, package_id: str, version: str) -> str:
    os.makedirs(NUPKG_OUTPUT_DIR, exist_ok=True)
    csproj_path = os.path.join(project_dir, f"{package_id}.csproj")
    print(f"Packing {package_id} {version}", file=sys.stderr)
    result = subprocess.run(
        ["dotnet", "pack", csproj_path, "--configuration", "Release", "--output", NUPKG_OUTPUT_DIR],
        capture_output=True, text=True,
    )
    if result.returncode != 0:
        raise RuntimeError(
            f"dotnet pack failed for {csproj_path}\n--- stdout ---\n{result.stdout}\n--- stderr ---\n{result.stderr}"
        )
    return os.path.join(NUPKG_OUTPUT_DIR, f"{package_id}.{version}.nupkg")


def push_to_nuget(nupkg_path: str, api_key: str) -> bool:
    global _last_push_at
    _last_push_at = _rate_limit(_last_push_at, PUBLISH_DELAY_SECONDS)
    result = subprocess.run(
        ["dotnet", "nuget", "push", nupkg_path, "--api-key", api_key,
         "--source", NUGET_SOURCE, "--skip-duplicate"],
        capture_output=True, text=True,
    )
    if result.returncode != 0:
        print(
            f"WARNING: nuget push failed for {nupkg_path} (will retry next run):\n"
            f"{result.stdout}\n{result.stderr}",
            file=sys.stderr,
        )
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
                         help="List what would be packed/published without actually doing it.")
    args = parser.parse_args()

    api_key = os.environ.get("NUGET_API_KEY")
    if not api_key and not args.dry_run:
        print("ERROR: NUGET_API_KEY not set (and --dry-run not passed) - nothing to push", file=sys.stderr)
        return 1

    projects = find_dotnet_projects()
    if args.only_repo:
        wanted = set(args.only_repo)
        projects = [p for p in projects if f"{p[0]}/{p[1]}" in wanted]
    if args.filter:
        keywords = [f.lower() for f in args.filter]
        projects = [p for p in projects if any(kw in f"{p[0]}/{p[1]}".lower() for kw in keywords)]
    if args.limit_projects is not None:
        projects = projects[: args.limit_projects]

    print(f"Found {len(projects)} generated .NET project(s)", file=sys.stderr)

    published_count = 0
    up_to_date_count = 0
    no_version_count = 0
    failed_count = 0

    for owner, repo, project_dir, package_id in projects:
        state_path = os.path.join(project_dir, "state.json")
        state = load_state(state_path)
        version = state.get("version")
        if not version:
            no_version_count += 1
            continue

        try:
            published_versions = list_published_versions(package_id)
        except Exception as exc:  # noqa: BLE001 - one project's lookup must not abort the run
            print(f"WARNING: could not list published versions for {package_id}: {exc}", file=sys.stderr)
            failed_count += 1
            continue

        if version in published_versions:
            up_to_date_count += 1
            continue

        print(f"{package_id} needs publishing: {version} not in {len(published_versions)} published version(s)",
              file=sys.stderr)
        if args.dry_run:
            print(f"would pack + push {package_id} {version}")
            continue

        try:
            nupkg_path = pack_project(project_dir, package_id, version)
        except Exception as exc:  # noqa: BLE001
            print(f"WARNING: pack failed for {package_id} {version}: {exc}", file=sys.stderr)
            failed_count += 1
            continue

        if push_to_nuget(nupkg_path, api_key):
            state["published_version"] = version
            save_state(state_path, state)
            print(f"Published {package_id} {version} to nuget.org", file=sys.stderr)
            published_count += 1
        else:
            failed_count += 1

    verb = "Would publish" if args.dry_run else "Published"
    print(
        f"Done: {len(projects)} project(s) checked, {published_count if not args.dry_run else 'N/A'} "
        f"{verb.lower()}, {up_to_date_count} already up to date, {no_version_count} with no version yet, "
        f"{failed_count} failed",
        file=sys.stderr,
    )
    return 1 if failed_count else 0


if __name__ == "__main__":
    sys.exit(main())
