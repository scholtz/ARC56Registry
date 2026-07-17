#!/usr/bin/env python3
"""Download every active ARC-56 spec in arc56.links.csv to clients/<owner>/<repo>/arc56/.

This is the first of three stages in the client-generation pipeline (download ->
generate -> publish), split into separate scripts/workflows so that:

  - the slow part (downloading, rate-limited to be polite to
    raw.githubusercontent.com) doesn't block or get re-run by the generation stage,
  - generation (scripts/generate_dotnet_clients.py, scripts/generate_typescript_clients.py)
    never makes a network request for the spec itself - it only reads the local copy
    this script already wrote, and
  - the downloaded spec is shared across every ecosystem's generated client for that
    repo (.NET, TypeScript, ...), so it's fetched once no matter how many client
    languages are generated from it.

For every *active* row, this script:

  1. Downloads the ARC-56 JSON spec (rate-limited: at least DOWNLOAD_DELAY_SECONDS
     between downloads).
  2. Writes it to clients/<owner>/<repo>/arc56/<file_slug>_<hash8>.arc56.json.
  3. Records its SHA-256 (and, on failure, the error) in
     clients/<owner>/<repo>/arc56/state.json, keyed by source URL.

A URL that's already known to be unfetchable (bad path encoding, 404, etc.) is not
retried every single run - only when --retry-failed is passed - since retrying a
dead URL costs a full DOWNLOAD_DELAY_SECONDS for no benefit.

Existing rows/files are never deleted, matching the rest of this repo's "never
remove, only deactivate" convention (see docs/arc56-links-pipeline.md).
"""
from __future__ import annotations

import argparse
import csv
import datetime
import hashlib
import json
import os
import re
import subprocess
import sys
import time
import urllib.request

REPO_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
CSV_PATH = os.path.join(REPO_ROOT, "arc56.links.csv")
CLIENTS_DIR = os.path.join(REPO_ROOT, "clients")

DOWNLOAD_DELAY_SECONDS = 7
PUSH_INTERVAL_SECONDS = 60

RAW_URL_RE = re.compile(
    r"^https://raw\.githubusercontent\.com/(?P<owner>[^/]+)/(?P<repo>[^/]+)/[^/]+/(?P<path>.+)$"
)
FILENAME_SUFFIX = ".arc56.json"

_last_download_at: float | None = None
_last_push_at: float | None = None


def sanitize_path_segment(name: str) -> str:
    return re.sub(r"[^A-Za-z0-9_.-]", "-", name)


def sanitize_identifier(name: str) -> str:
    slug = re.sub(r"[^A-Za-z0-9_]", "_", name)
    if not slug or slug[0].isdigit():
        slug = f"_{slug}"
    return slug


def sha256_hex(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def url_hash8(url: str) -> str:
    return hashlib.sha256(url.encode("utf-8")).hexdigest()[:8]


def parse_raw_url(url: str) -> tuple[str, str, str]:
    m = RAW_URL_RE.match(url)
    if not m:
        raise ValueError(f"URL is not a raw.githubusercontent.com URL: {url}")
    return m.group("owner"), m.group("repo"), m.group("path")


def load_active_rows() -> list[dict[str, str]]:
    today = datetime.date.today().isoformat()
    rows = []
    with open(CSV_PATH, newline="", encoding="utf-8") as f:
        for row in csv.DictReader(f):
            active_from = row.get("ActiveFrom") or ""
            active_until = row.get("ActiveUntil") or ""
            if active_from and active_from > today:
                continue
            if active_until and active_until <= today:
                continue
            rows.append(row)
    return rows


def download_with_rate_limit(url: str) -> bytes:
    global _last_download_at
    if _last_download_at is not None:
        elapsed = time.monotonic() - _last_download_at
        wait = DOWNLOAD_DELAY_SECONDS - elapsed
        if wait > 0:
            time.sleep(wait)
    print(f"Downloading {url}", file=sys.stderr)
    req = urllib.request.Request(url, headers={"User-Agent": "arc56-spec-downloader"})
    with urllib.request.urlopen(req) as resp:
        data = resp.read()
    _last_download_at = time.monotonic()
    return data


def load_state(path: str) -> dict:
    if not os.path.exists(path):
        return {"contracts": {}}
    with open(path, encoding="utf-8") as f:
        return json.load(f)


def save_state(path: str, state: dict) -> None:
    with open(path, "w", encoding="utf-8") as f:
        json.dump(state, f, indent=2, sort_keys=True)
        f.write("\n")


def configure_git_identity() -> None:
    subprocess.run(["git", "config", "user.name", "github-actions[bot]"], cwd=REPO_ROOT, check=True)
    subprocess.run(
        ["git", "config", "user.email", "github-actions[bot]@users.noreply.github.com"],
        cwd=REPO_ROOT, check=True,
    )


def push_commits(force: bool = False) -> None:
    """Mirrors the throttled-push behavior of scripts/generate_dotnet_clients.py - see
    that script's push_commits() for the full rationale."""
    global _last_push_at
    now = time.monotonic()
    if not force and _last_push_at is not None and now - _last_push_at < PUSH_INTERVAL_SECONDS:
        return
    result = subprocess.run(["git", "push"], cwd=REPO_ROOT, capture_output=True, text=True)
    if result.returncode != 0:
        print(f"WARNING: git push failed (will retry later): {result.stdout}\n{result.stderr}", file=sys.stderr)
        return
    _last_push_at = now


def commit_project_changes(owner: str, repo: str) -> None:
    path = os.path.join("clients", sanitize_path_segment(owner), sanitize_path_segment(repo), "arc56")
    subprocess.run(["git", "add", "--", path], cwd=REPO_ROOT, check=True)
    diff = subprocess.run(["git", "diff", "--cached", "--quiet", "--", path], cwd=REPO_ROOT)
    if diff.returncode == 0:
        return
    subprocess.run(
        ["git", "commit", "-m", f"chore: download ARC-56 specs for {owner}/{repo}"],
        cwd=REPO_ROOT, check=True,
    )
    print(f"Committed spec downloads for {owner}/{repo}", file=sys.stderr)


def process_project(owner: str, repo: str, rows: list[dict[str, str]], retry_failed: bool) -> bool:
    owner_slug = sanitize_path_segment(owner)
    repo_slug = sanitize_path_segment(repo)
    arc56_dir = os.path.join(CLIENTS_DIR, owner_slug, repo_slug, "arc56")
    state_path = os.path.join(arc56_dir, "state.json")
    os.makedirs(arc56_dir, exist_ok=True)

    state = load_state(state_path)
    contracts_state: dict = state.setdefault("contracts", {})
    dirty = False

    for row in rows:
        url = row["ARC56URL"]
        try:
            _, _, path = parse_raw_url(url)
        except ValueError as exc:
            print(f"WARNING: skipping unparseable URL {url}: {exc}", file=sys.stderr)
            continue
        filename = path.rsplit("/", 1)[-1]
        if not filename.endswith(FILENAME_SUFFIX):
            print(f"WARNING: skipping non-ARC56 URL {url}", file=sys.stderr)
            continue
        file_slug = sanitize_identifier(filename[: -len(FILENAME_SUFFIX)])
        hash8 = url_hash8(url)
        contract_id = f"{file_slug}_{hash8}"
        existing = contracts_state.get(url)

        if existing is not None and "download_error" in existing and not retry_failed:
            continue

        try:
            content = download_with_rate_limit(url)
        except Exception as exc:  # noqa: BLE001 - one bad row must never abort the whole run
            print(f"WARNING: download failed for {url}: {exc}", file=sys.stderr)
            contracts_state[url] = {
                "file_slug": file_slug,
                "hash8": hash8,
                "download_error": str(exc),
            }
            dirty = True
            continue

        content_hash = sha256_hex(content)
        arc56_path = os.path.join(arc56_dir, f"{contract_id}.arc56.json")
        try:
            with open(arc56_path, "wb") as f:
                f.write(content)
        except OSError as exc:
            print(f"WARNING: could not write {arc56_path}: {exc}", file=sys.stderr)
            contracts_state[url] = {
                "file_slug": file_slug,
                "hash8": hash8,
                "download_error": f"failed to write local copy: {exc}",
            }
            dirty = True
            continue

        if existing is not None and existing.get("content_sha256") == content_hash and "download_error" not in existing:
            continue  # unchanged content - nothing to persist

        contracts_state[url] = {
            "file_slug": file_slug,
            "hash8": hash8,
            "content_sha256": content_hash,
            "downloaded_at": datetime.datetime.now(datetime.timezone.utc).isoformat(),
        }
        dirty = True
        print(f"Downloaded {url} -> {arc56_path}", file=sys.stderr)

    if dirty:
        save_state(state_path, state)
    return dirty


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    parser.add_argument("--limit-projects", type=int, default=None,
                         help="Only process the first N owner/repo projects (for local testing).")
    parser.add_argument("--only-repo", action="append", default=[],
                         help="Only process owner/repo (exact match, can be passed multiple times).")
    parser.add_argument("--filter", action="append", default=[],
                         help="Only process owner/repo pairs whose \"owner/repo\" string contains this "
                              "substring, case-insensitive. Can be passed multiple times (OR'd together). "
                              "If --only-repo is also given, a project must satisfy both.")
    parser.add_argument("--retry-failed", action="store_true",
                         help="Retry URLs that previously failed to download, instead of skipping them.")
    parser.add_argument("--commit", action="store_true",
                         help="Git-commit each project's downloaded specs as soon as that project "
                              "finishes. Off by default so local test runs don't create commits.")
    args = parser.parse_args()

    rows = load_active_rows()
    grouped: dict[tuple[str, str], list[dict[str, str]]] = {}
    for row in rows:
        try:
            owner, repo, _ = parse_raw_url(row["ARC56URL"])
        except ValueError as exc:
            print(f"WARNING: {exc}", file=sys.stderr)
            continue
        grouped.setdefault((owner, repo), []).append(row)

    selected = sorted(grouped.items())
    if args.only_repo:
        wanted = {tuple(r.split("/", 1)) for r in args.only_repo}
        selected = [item for item in selected if item[0] in wanted]
    if args.filter:
        keywords = [f.lower() for f in args.filter]
        selected = [
            item for item in selected
            if any(kw in f"{item[0][0]}/{item[0][1]}".lower() for kw in keywords)
        ]
    if args.limit_projects is not None:
        selected = selected[: args.limit_projects]

    if args.commit:
        configure_git_identity()

    changed_projects = 0
    failed_projects = 0
    for (owner, repo), project_rows in selected:
        try:
            if process_project(owner, repo, project_rows, args.retry_failed):
                changed_projects += 1
            if args.commit:
                commit_project_changes(owner, repo)
                push_commits()
        except Exception as exc:  # noqa: BLE001 - one project must never take down the whole run
            failed_projects += 1
            print(f"ERROR: unexpected failure downloading specs for {owner}/{repo}, skipping and "
                  f"continuing with the next project: {exc}", file=sys.stderr)
            continue

    if args.commit:
        push_commits(force=True)

    print(f"Done: {len(selected)}/{len(grouped)} project(s) scanned, "
          f"{changed_projects} with new/changed downloads, {failed_projects} failed unexpectedly", file=sys.stderr)
    return 1 if failed_projects else 0


if __name__ == "__main__":
    sys.exit(main())
