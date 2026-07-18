#!/usr/bin/env python3
"""Publish already-generated TypeScript ARC-56 client packages to npm.

Mirrors scripts/publish_dotnet_packages.py, but for npm instead of nuget.org. This is
the third of three stages in the TypeScript pipeline (download -> generate -> publish;
see scripts/download_arc56_specs.py and scripts/generate_typescript_clients.py). It
does not download any ARC-56 spec or regenerate any TypeScript code - it only builds
(`npm run build`) and publishes projects that scripts/generate_typescript_clients.py
has already generated and committed.

For every `clients/<owner>/<repo>/npm/package.json` project, this script:

  1. Reads the version that project's state.json says it should be at (bumped by
     scripts/generate_typescript_clients.py when that project's generated code
     changed).
  2. Asks the npm registry itself - the source of truth, not a locally cached
     "published_version" flag - which versions of that package name are already
     published: `GET https://registry.npmjs.org/<package-name>`.
  3. If the project's current version isn't in that list, installs dependencies and
     builds it (`npm install && npm run build`) and publishes it (`npm publish --access
     public`), waiting at least PUBLISH_DELAY_SECONDS between publishes so this script
     doesn't hammer the npm registry.

Querying the npm registry for each package's published versions (rather than trusting
a locally-recorded flag) means a partially-failed previous publish run, or a manual
publish done outside this pipeline, is always detected correctly.

Authentication uses a classic npm **automation** access token, passed in via the
NPM_TOKEN environment variable - see docs/typescript-client-pipeline.md and
docs/npm-publishing-setup.md for why (in short: npm's newer OIDC "Trusted Publishing"
has to be configured per-package on npmjs.com one at a time, which doesn't scale to
this repo's ever-growing, auto-created set of packages the way a single account-wide
automation token does).
"""
from __future__ import annotations

import argparse
import datetime
import glob
import json
import os
import shutil
import subprocess
import sys
import tempfile
import time
import urllib.error
import urllib.request

REPO_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
CLIENTS_DIR = os.path.join(REPO_ROOT, "clients")
NPM_REGISTRY = "https://registry.npmjs.org"
# See the matching comment in scripts/generate_typescript_clients.py: npm is a .cmd
# shim on Windows, which subprocess.run() can't launch directly without shell=True.
NPM_EXE = shutil.which("npm") or "npm"

PUBLISH_DELAY_SECONDS = 20  # minimum time between successive `npm publish` calls: npm has no
# published numeric quota for this (unlike nuget.org's documented 350/hour), but every project
# here is a brand-new package name, and real-world reports (npm/cli#8507, changesets#1574) show
# npm's abuse-prevention limiter is much stricter for new-package creation than for publishing a
# new version of an existing package, and that even large fixed delays don't help once you keep
# retrying through a 429 - see RateLimited below, which stops the run instead of doing that.
LIST_DELAY_SECONDS = 1  # minimum time between successive "list published versions" lookups
NEW_PACKAGE_DELAY_SECONDS = 60  # extra wait before the *first-ever* publish of a package name
# (published_versions is empty) - this is the specific case npm's abuse-prevention limiter has
# been reported to hit hardest, since this pipeline creates a brand-new package on every run.

_last_push_at: float | None = None
_last_list_at: float | None = None


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


def find_npm_projects() -> list[tuple[str, str, str]]:
    """Returns (owner, repo, project_dir) for every generated TypeScript project."""
    projects = []
    pattern = os.path.join(CLIENTS_DIR, "*", "*", "npm", "package.json")
    for package_json_path in sorted(glob.glob(pattern)):
        project_dir = os.path.dirname(package_json_path)
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


def list_published_versions(package_name: str) -> set[str]:
    """Queries the public npm registry for every version of `package_name` currently
    published - no auth needed for a read of a public package's metadata."""
    global _last_list_at
    _last_list_at = _rate_limit(_last_list_at, LIST_DELAY_SECONDS)
    url = f"{NPM_REGISTRY}/{package_name}"
    req = urllib.request.Request(url, headers={"User-Agent": "arc56-npm-publisher", "Accept": "application/json"})
    try:
        with urllib.request.urlopen(req) as resp:
            data = json.load(resp)
        return set((data.get("versions") or {}).keys())
    except urllib.error.HTTPError as exc:
        if exc.code == 404:
            return set()  # package never published at all yet
        raise


def npm_build(project_dir: str) -> None:
    result = subprocess.run(
        [NPM_EXE, "install", "--no-audit", "--no-fund"],
        cwd=project_dir, capture_output=True, text=True,
    )
    if result.returncode != 0:
        raise RuntimeError(f"npm install failed in {project_dir}\n{result.stdout}\n{result.stderr}")
    result = subprocess.run(
        [NPM_EXE, "run", "build"],
        cwd=project_dir, capture_output=True, text=True,
    )
    if result.returncode != 0:
        raise RuntimeError(f"npm run build failed in {project_dir}\n{result.stdout}\n{result.stderr}")


class RateLimited(Exception):
    """Raised when npm's registry responds E429 "rate limited exceeded" to a publish.
    Once this happens, every subsequent publish in the same run is likely to hit the
    same limiter - especially here, where each project is a brand-new package name,
    which npm's abuse-prevention treats more strictly than publishing a new version of
    an existing package - so the caller should stop publishing entirely for this run
    rather than burning through the rest of the project list on doomed retries. The
    next scheduled run picks up exactly where this one left off, since nothing here is
    trusted as published until the npm registry's own version list confirms it."""


def publish_to_npm(project_dir: str, npmrc_path: str | None, is_new_package: bool) -> bool:
    global _last_push_at
    _last_push_at = _rate_limit(_last_push_at, PUBLISH_DELAY_SECONDS)
    if is_new_package:
        log(f"first-ever publish of this package name - waiting an extra "
            f"{NEW_PACKAGE_DELAY_SECONDS}s before publishing")
        time.sleep(NEW_PACKAGE_DELAY_SECONDS)
    env = dict(os.environ)
    if npmrc_path:
        env["NPM_CONFIG_USERCONFIG"] = npmrc_path
    result = subprocess.run(
        [NPM_EXE, "publish", "--access", "public"],
        cwd=project_dir, capture_output=True, text=True, env=env,
    )
    if result.returncode != 0:
        combined = result.stdout + result.stderr
        if "E429" in combined or "rate limited exceeded" in combined:
            raise RateLimited(combined)
        log(f"WARNING: npm publish failed for {project_dir} (will retry next run):\n"
            f"{result.stdout}\n{result.stderr}")
        return False
    return True


def write_temp_npmrc(npm_token: str) -> str:
    """Writes a throwaway .npmrc (outside the repo, in the OS temp dir) with the auth
    token embedded - not the repo's own working tree, and not the placeholder
    "${NPM_TOKEN}" syntax some CI guides use, since that requires npm to interpolate an
    env var from a *global* .npmrc; writing the resolved value directly into a
    project-scoped config file (pointed at via NPM_CONFIG_USERCONFIG) works the same
    way regardless of how this script is invoked (CI or a developer's own shell)."""
    fd, path = tempfile.mkstemp(prefix="arc56-npmrc-", suffix=".npmrc")
    with os.fdopen(fd, "w", encoding="utf-8") as f:
        f.write(f"//registry.npmjs.org/:_authToken={npm_token}\n")
    return path


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

    npm_token = os.environ.get("NPM_TOKEN")
    if not npm_token and not args.dry_run:
        log("ERROR: NPM_TOKEN not set (and --dry-run not passed) - nothing to publish")
        return 1

    npmrc_path = write_temp_npmrc(npm_token) if npm_token else None

    try:
        projects = find_npm_projects()
        if args.only_repo:
            wanted = set(args.only_repo)
            projects = [p for p in projects if f"{p[0]}/{p[1]}" in wanted]
        if args.filter:
            keywords = [f.lower() for f in args.filter]
            projects = [p for p in projects if any(kw in f"{p[0]}/{p[1]}".lower() for kw in keywords)]
        if args.limit_projects is not None:
            projects = projects[: args.limit_projects]

        total = len(projects)
        log(f"Found {total} generated TypeScript project(s)")

        published_count = 0
        up_to_date_count = 0
        no_version_count = 0
        failed_count = 0

        for i, (owner, repo, project_dir) in enumerate(projects, start=1):
            log(f"[{i}/{total}] {owner}/{repo}")
            package_json_path = os.path.join(project_dir, "package.json")
            state_path = os.path.join(project_dir, "state.json")
            package_json = load_json(package_json_path)
            state = load_json(state_path)
            package_name = package_json.get("name")
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
                npm_build(project_dir)
            except Exception as exc:  # noqa: BLE001
                log(f"WARNING: build failed for {package_name} {version}: {exc}")
                failed_count += 1
                continue

            try:
                pushed = publish_to_npm(project_dir, npmrc_path, is_new_package=not published_versions)
            except RateLimited as exc:
                log(f"npm registry rate limit hit - stopping this run early instead of retrying "
                    f"the remaining {total - i + 1} project(s), which would likely all fail the "
                    f"same way until the limiter resets; they'll be picked up by the next "
                    f"scheduled run:\n{exc}")
                remaining_skipped = total - i + 1
                verb = "Would publish" if args.dry_run else "Published"
                log(f"Done: {total} project(s) checked, {published_count} {verb.lower()}, "
                    f"{up_to_date_count} already up to date, {no_version_count} with no version yet, "
                    f"{failed_count} failed, {remaining_skipped} skipped due to rate limit")
                return 1

            if pushed:
                state["published_version"] = version
                save_json(state_path, state)
                log(f"Published {package_name} {version} to npm")
                published_count += 1
            else:
                failed_count += 1

        verb = "Would publish" if args.dry_run else "Published"
        log(f"Done: {total} project(s) checked, {published_count if not args.dry_run else 'N/A'} "
            f"{verb.lower()}, {up_to_date_count} already up to date, {no_version_count} with no version yet, "
            f"{failed_count} failed")
        return 1 if failed_count else 0
    finally:
        if npmrc_path and os.path.exists(npmrc_path):
            os.remove(npmrc_path)


if __name__ == "__main__":
    sys.exit(main())
