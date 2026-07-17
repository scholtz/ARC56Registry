#!/usr/bin/env python3
"""Update arc56.links.csv from a GitHub code search for ARC-56 files.

Queries the GitHub code search API (`arc56.json in:path`, since the legacy
REST search/code endpoint does not support the newer `path:**/*.ext` glob
syntax), filters results to paths actually ending in ".arc56.json", and
converts each match into a raw.githubusercontent.com URL pinned to the HEAD
of the file's default branch.

GitHub's code search never returns more than 1,000 results for a single
query (10 pages x 100/page), no matter how many total matches actually exist.
To get past that, the search is recursively sharded by file `size:` ranges
(a supported qualifier) until every shard's total_count is <= 1000, and the
results are unioned - see partition_and_collect().

The CSV has three columns: ARC56URL, ActiveFrom, ActiveUntil. ActiveUntil
being empty means the record is active indefinitely; a maintainer can set it
to deactivate a record manually. This script never removes or overwrites an
existing row (so manually-set ActiveUntil values are preserved even if a
later search run doesn't happen to find that URL again) - it only ever adds
newly discovered URLs, with ActiveFrom set to today and ActiveUntil left
empty. The file is written with the `csv` module using RFC 4180 quoting so it
renders correctly as a table on GitHub.

Code search alone is known to under-report: GitHub's search index can lag or
skip files for reasons that have nothing to do with sharding (indexing lag,
forked/archived repos, etc.), and this has been observed in practice - a repo
whose owner confirmed several `*.arc56.json` files existed only had about half
of them turn up via search. To compensate, every repo that code search proves
is "ARC-56 positive" (at least one real match in it) gets a second pass: the
actual git tree of its default branch is listed via the Trees API and scanned
for `*.arc56.json` paths directly, which is exhaustive and doesn't depend on
the search index at all. See verify_repo_full_tree().
"""
from __future__ import annotations

import csv
import datetime
import json
import os
import sys
import time
import urllib.error
import urllib.parse
import urllib.request

SEARCH_QUERY = "arc56.json in:path"
FILENAME_SUFFIX = ".arc56.json"
API_URL = "https://api.github.com/search/code"
PER_PAGE = 100
MAX_PAGES = 10  # GitHub code search caps results at 1000 (10 x 100) *per query*.
MAX_RESULTS_PER_QUERY = 1000
# GitHub code search doesn't index files above 384 KiB, so no match can be larger
# than that; starting the shard range there (instead of some arbitrary larger bound)
# avoids wasting splits on a byte range that's provably empty.
MAX_FILE_SIZE_BYTES = 384 * 1024
MAX_SHARD_DEPTH = 25  # safety net against pathological size distributions
REQUEST_DELAY_SECONDS = 7  # code search is limited to 10 requests/minute, so stay safely under that.
# The Trees/Repos REST endpoints used for the full-tree verification pass aren't subject
# to code search's stricter 10/min cap (authenticated REST is ~5000/hour), but we still
# pace requests conservatively to be a good citizen.
REPO_VERIFY_DELAY_SECONDS = 1
OUTPUT_PATH = os.path.join(os.path.dirname(os.path.dirname(os.path.abspath(__file__))), "arc56.links.csv")
URL_COLUMN = "ARC56URL"
ACTIVE_FROM_COLUMN = "ActiveFrom"
ACTIVE_UNTIL_COLUMN = "ActiveUntil"
FIELDNAMES = [URL_COLUMN, ACTIVE_FROM_COLUMN, ACTIVE_UNTIL_COLUMN]


def build_request(query: str, page: int, token: str) -> tuple[urllib.request.Request, str]:
    url = f"{API_URL}?q={urllib.parse.quote(query)}&per_page={PER_PAGE}&page={page}"
    req = urllib.request.Request(url)
    req.add_header("Accept", "application/vnd.github+json")
    req.add_header("X-GitHub-Api-Version", "2022-11-28")
    req.add_header("User-Agent", "arc56-links-updater")
    if token:
        req.add_header("Authorization", f"Bearer {token}")
    return req, url


def fetch_page(query: str, page: int, token: str, retries: int = 5) -> dict:
    for attempt in range(1, retries + 1):
        req, url = build_request(query, page, token)
        print(f"Calling GitHub API: GET {url} (attempt {attempt}/{retries})", file=sys.stderr)
        time.sleep(REQUEST_DELAY_SECONDS)
        try:
            with urllib.request.urlopen(req) as resp:
                data = json.loads(resp.read().decode("utf-8"))
                total_count = data.get("total_count", 0)
                items = data.get("items", [])
                print(f"Response for page {page}: total_count={total_count}, "
                      f"items_returned={len(items)}", file=sys.stderr)

                expected_remaining = total_count - (page - 1) * PER_PAGE
                if not items and expected_remaining > 0:
                    if attempt < retries:
                        wait = 5 * attempt
                        print(f"Page {page} returned 0 items but {expected_remaining} were "
                              f"expected (total_count={total_count}); treating as a transient "
                              f"GitHub search glitch, retrying in {wait}s "
                              f"(attempt {attempt}/{retries})", file=sys.stderr)
                        time.sleep(wait)
                        continue
                    raise RuntimeError(
                        f"Page {page} returned 0 items but {expected_remaining} were expected "
                        f"(total_count={total_count}) after {retries} attempts"
                    )
                return data
        except urllib.error.HTTPError as exc:
            if exc.code in (403, 429) and attempt < retries:
                retry_after = exc.headers.get("Retry-After")
                wait = int(retry_after) if retry_after else 10 * attempt
                print(f"Rate limited (HTTP {exc.code}) fetching page {page}, "
                      f"retrying in {wait}s (attempt {attempt}/{retries})", file=sys.stderr)
                time.sleep(wait)
                continue
            body = exc.read().decode("utf-8", errors="replace")
            print(f"GitHub API error {exc.code} on page {page}: {body}", file=sys.stderr)
            raise
    raise RuntimeError(f"Failed to fetch page {page} after {retries} attempts")


def size_qualifier(lo: int, hi: int) -> str:
    return f"size:{lo}..{hi}"


def path_to_url(repo_full_name: str, path: str) -> str:
    # GitHub paths can contain spaces and other reserved characters (seen in
    # practice: "PICT 2.0/farmer-pay-contract/..."). Percent-encode each path
    # segment (but not the "/" separators) so the URL is actually valid and
    # fetchable - an unencoded space here isn't just wrong, it makes Python's
    # http.client outright refuse the request with InvalidURL.
    encoded_path = urllib.parse.quote(path, safe="/")
    return f"https://raw.githubusercontent.com/{repo_full_name}/HEAD/{encoded_path}"


def add_matching_items(items: list[dict], urls: set[str], repos: set[str]) -> None:
    for item in items:
        path = item["path"]
        if path.endswith(FILENAME_SUFFIX):
            repo_full_name = item["repository"]["full_name"]
            repos.add(repo_full_name)
            urls.add(path_to_url(repo_full_name, path))


def partition_and_collect(lo: int, hi: int, token: str, urls: set[str], repos: set[str], depth: int = 0) -> None:
    # Deciding whether to split based on the API's reported total_count doesn't work:
    # GitHub explicitly documents total_count as only an approximation once a query
    # has more than 1,000 matches, and in practice it fluctuates wildly (e.g. a narrow
    # size range can report a higher total_count than its parent range). Instead, we
    # paginate for real and only split when we actually observe MAX_PAGES consecutive
    # full pages - the one signal from this API that's trustworthy - since exhausting
    # every page before that point is real, correct proof there's nothing more to find.
    query = f"{SEARCH_QUERY} {size_qualifier(lo, hi)}"
    items_collected: list[dict] = []
    hit_pagination_cap = True
    for page in range(1, MAX_PAGES + 1):
        items = fetch_page(query, page, token).get("items", [])
        if not items:
            hit_pagination_cap = False
            break
        items_collected.extend(items)
        if len(items) < PER_PAGE:
            hit_pagination_cap = False
            break

    if hit_pagination_cap:
        if lo < hi and depth < MAX_SHARD_DEPTH:
            mid = (lo + hi) // 2
            partition_and_collect(lo, mid, token, urls, repos, depth + 1)
            partition_and_collect(mid + 1, hi, token, urls, repos, depth + 1)
            return
        print(f"WARNING: size range {lo}..{hi} still hits the {MAX_RESULTS_PER_QUERY}-result "
              f"pagination cap at max shard depth or cannot be split further; some results in "
              f"this range may be missing", file=sys.stderr)

    add_matching_items(items_collected, urls, repos)


def fetch_api_json(url: str, token: str, retries: int = 3) -> dict | None:
    """GET a plain (non-search) GitHub REST API URL, returning None on failure.

    Used for the full-tree verification pass, which must never abort the whole
    run just because one repo is inaccessible (renamed, deleted, empty, etc.) -
    the code-search results already collected are still worth writing out.
    """
    for attempt in range(1, retries + 1):
        req = urllib.request.Request(url)
        req.add_header("Accept", "application/vnd.github+json")
        req.add_header("X-GitHub-Api-Version", "2022-11-28")
        req.add_header("User-Agent", "arc56-links-updater")
        if token:
            req.add_header("Authorization", f"Bearer {token}")
        try:
            with urllib.request.urlopen(req) as resp:
                return json.loads(resp.read().decode("utf-8"))
        except urllib.error.HTTPError as exc:
            if exc.code in (403, 429) and attempt < retries:
                retry_after = exc.headers.get("Retry-After")
                wait = int(retry_after) if retry_after else 10 * attempt
                print(f"Rate limited (HTTP {exc.code}) fetching {url}, retrying in {wait}s "
                      f"(attempt {attempt}/{retries})", file=sys.stderr)
                time.sleep(wait)
                continue
            body = exc.read().decode("utf-8", errors="replace")
            print(f"GitHub API error {exc.code} for {url}: {body}", file=sys.stderr)
            return None
        except urllib.error.URLError as exc:
            print(f"Network error fetching {url}: {exc}", file=sys.stderr)
            return None
    return None


def verify_repo_full_tree(repo_full_name: str, token: str, urls: set[str]) -> None:
    """Cross-check a known ARC-56-positive repo against its full git tree.

    Code search missing real files in a repo it already matched has been
    observed in practice, so for any repo we know contains at least one
    *.arc56.json (found above via search), list every file in the default
    branch directly via the Trees API and add any *.arc56.json paths that
    the search pass didn't find. This is exhaustive per-repo and doesn't
    depend on GitHub's search index at all.
    """
    time.sleep(REPO_VERIFY_DELAY_SECONDS)
    repo_info = fetch_api_json(f"https://api.github.com/repos/{repo_full_name}", token)
    if not repo_info:
        print(f"WARNING: could not fetch repo info for {repo_full_name}; skipping full-tree "
              f"verification for this repo", file=sys.stderr)
        return
    default_branch = repo_info.get("default_branch")
    if not default_branch:
        return

    time.sleep(REPO_VERIFY_DELAY_SECONDS)
    tree_url = (f"https://api.github.com/repos/{repo_full_name}/git/trees/"
                f"{urllib.parse.quote(default_branch, safe='')}?recursive=1")
    tree = fetch_api_json(tree_url, token)
    if not tree:
        print(f"WARNING: could not fetch file tree for {repo_full_name}; skipping full-tree "
              f"verification for this repo", file=sys.stderr)
        return
    if tree.get("truncated"):
        print(f"WARNING: file tree for {repo_full_name} was truncated by GitHub (repo too "
              f"large for a single Trees API response); full-tree verification may be "
              f"incomplete for this repo", file=sys.stderr)

    before = len(urls)
    for entry in tree.get("tree", []):
        if entry.get("type") != "blob":
            continue
        path = entry.get("path", "")
        if path.endswith(FILENAME_SUFFIX):
            urls.add(path_to_url(repo_full_name, path))
    added = len(urls) - before
    if added:
        print(f"Full-tree verification for {repo_full_name} found {added} additional "
              f"ARC-56 file(s) that code search missed", file=sys.stderr)


def collect_urls(token: str) -> set[str]:
    urls: set[str] = set()
    repos: set[str] = set()
    partition_and_collect(0, MAX_FILE_SIZE_BYTES, token, urls, repos)

    print(f"Code search found {len(urls)} ARC-56 file(s) across {len(repos)} repo(s); "
          f"double-checking each repo's full file tree for anything code search missed",
          file=sys.stderr)
    for repo_full_name in sorted(repos):
        verify_repo_full_tree(repo_full_name, token, urls)

    return urls


def read_existing_rows(path: str) -> dict[str, dict[str, str]]:
    if not os.path.exists(path):
        return {}
    rows: dict[str, dict[str, str]] = {}
    with open(path, newline="", encoding="utf-8") as f:
        reader = csv.DictReader(f)
        for row in reader:
            url = row.get(URL_COLUMN, "")
            if not url:
                continue
            rows[url] = {
                ACTIVE_FROM_COLUMN: row.get(ACTIVE_FROM_COLUMN) or "",
                ACTIVE_UNTIL_COLUMN: row.get(ACTIVE_UNTIL_COLUMN) or "",
            }
    return rows


def main() -> int:
    token = os.environ.get("GH_SEARCH_TOKEN") or os.environ.get("GITHUB_TOKEN") or ""
    if not token:
        print("Warning: no GH_SEARCH_TOKEN/GITHUB_TOKEN set; unauthenticated search "
              "rate limits are very low and this will likely fail.", file=sys.stderr)

    try:
        found_urls = collect_urls(token)
    except Exception as exc:  # noqa: BLE001 - any failure must abort without touching the file
        print(f"Aborting without writing {OUTPUT_PATH}: {exc}", file=sys.stderr)
        return 1

    if not found_urls:
        print(f"Aborting without writing {OUTPUT_PATH}: search returned 0 results, "
              f"which looks wrong for this query.", file=sys.stderr)
        return 1

    existing_rows = read_existing_rows(OUTPUT_PATH)
    today = datetime.date.today().isoformat()

    added = 0
    for url in found_urls:
        if url not in existing_rows:
            existing_rows[url] = {ACTIVE_FROM_COLUMN: today, ACTIVE_UNTIL_COLUMN: ""}
            added += 1

    sorted_urls = sorted(existing_rows.keys(), key=str.lower)

    with open(OUTPUT_PATH, "w", newline="", encoding="utf-8") as f:
        writer = csv.DictWriter(f, fieldnames=FIELDNAMES, lineterminator="\n")
        writer.writeheader()
        for url in sorted_urls:
            row = existing_rows[url]
            writer.writerow({
                URL_COLUMN: url,
                ACTIVE_FROM_COLUMN: row[ACTIVE_FROM_COLUMN],
                ACTIVE_UNTIL_COLUMN: row[ACTIVE_UNTIL_COLUMN],
            })

    print(f"Wrote {len(sorted_urls)} rows to {OUTPUT_PATH} "
          f"({added} newly added, {len(sorted_urls) - added} preserved unchanged)")
    return 0


if __name__ == "__main__":
    sys.exit(main())
