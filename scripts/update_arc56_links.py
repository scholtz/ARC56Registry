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

Before that exhaustive (but unordered) sharded pass, a first pass runs the
same query with `sort=indexed&order=desc` - the closest thing the code search
API offers to "newest changes first" (it sorts by when GitHub's index last
saw the file, not by commit date, since the API exposes no commit-date sort)
- and takes just its first page(s), up to the same 1,000-result cap. This
makes freshly-added ARC-56 files show up in arc56.links.csv (and get
committed) as early in the run as possible, rather than waiting on whichever
size shard happens to contain them. See collect_recent_first(). It's a
priority pass, not a substitute for the sharded pass: the sharded pass still
runs afterwards and is what guarantees completeness.

The CSV has three columns: ARC56URL, ActiveFrom, ActiveUntil. ActiveUntil
being empty means the record is active indefinitely; a maintainer can set it
to deactivate a record manually. This script never removes or overwrites an
existing row (so manually-set ActiveUntil values are preserved even if a
later search run doesn't happen to find that URL again) - it only ever adds
newly discovered URLs, with ActiveFrom set to today and ActiveUntil left
empty.

This run can take well over an hour (thousands of code-search requests plus
a per-repo full-tree verification pass, each throttled to stay under GitHub's
rate limits - see REQUEST_DELAY_SECONDS / REPO_VERIFY_DELAY_SECONDS). Rather
than accumulating everything in memory and writing/committing once at the
very end, every time a batch of new URLs is discovered (one search shard's
worth, or one repo's full-tree verification) it is committed and pushed
immediately - see queue_new_urls()/flush_pending(). This means a crash,
timeout, or rate-limit abort partway through never loses already-discovered
links: whatever was found before the failure is already on origin. Each
flush re-fetches and hard-resets to origin's tip first and only pushes if
its URLs are still missing there, so this is safe even if another commit
(e.g. a human editing arc56.links.csv, or a concurrent run) lands on the
branch mid-run - see flush_pending().
"""
from __future__ import annotations

import csv
import datetime
import json
import os
import subprocess
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
REPO_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
OUTPUT_PATH = os.path.join(REPO_ROOT, "arc56.links.csv")
# Repos to never add links for - see that file's comments for why/how to add more.
REPO_BLACKLIST_PATH = os.path.join(REPO_ROOT, "scripts", "repo_blacklist.txt")
URL_COLUMN = "ARC56URL"
ACTIVE_FROM_COLUMN = "ActiveFrom"
ACTIVE_UNTIL_COLUMN = "ActiveUntil"
FIELDNAMES = [URL_COLUMN, ACTIVE_FROM_COLUMN, ACTIVE_UNTIL_COLUMN]

# Commit/push resilience: how hard to retry when another commit (a maintainer's
# manual edit, or - in principle - a concurrent run) landed on the branch between
# our fetch and our push.
GIT_MAX_RETRIES = 8
GIT_RETRY_BASE_DELAY_SECONDS = 3
GIT_COMMIT_AUTHOR_NAME = "github-actions[bot]"
GIT_COMMIT_AUTHOR_EMAIL = "github-actions[bot]@users.noreply.github.com"

# URLs discovered but not yet confirmed pushed to origin. Entries only leave this
# set once a commit containing them has been successfully pushed (or are found to
# already be present on origin during a later flush).
_pending_urls: set[str] = set()
_branch: str | None = None


def load_repo_blacklist(path: str) -> set[str]:
    """Load the "owner/repo" blacklist (one per line, "#" comments, blank lines ok).

    Missing file just means an empty blacklist - it's not an error condition.
    """
    if not os.path.exists(path):
        return set()
    blacklist: set[str] = set()
    with open(path, encoding="utf-8") as f:
        for line in f:
            line = line.strip()
            if not line or line.startswith("#"):
                continue
            blacklist.add(line.lower())
    return blacklist


def build_request(
    query: str, page: int, token: str, sort: str | None = None, order: str | None = None
) -> tuple[urllib.request.Request, str]:
    url = f"{API_URL}?q={urllib.parse.quote(query)}&per_page={PER_PAGE}&page={page}"
    if sort:
        url += f"&sort={sort}"
    if order:
        url += f"&order={order}"
    req = urllib.request.Request(url)
    req.add_header("Accept", "application/vnd.github+json")
    req.add_header("X-GitHub-Api-Version", "2022-11-28")
    req.add_header("User-Agent", "arc56-links-updater")
    if token:
        req.add_header("Authorization", f"Bearer {token}")
    return req, url


def fetch_page(
    query: str,
    page: int,
    token: str,
    retries: int = 5,
    sort: str | None = None,
    order: str | None = None,
) -> dict:
    for attempt in range(1, retries + 1):
        req, url = build_request(query, page, token, sort=sort, order=order)
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


def add_matching_items(
    items: list[dict], urls: set[str], repos: set[str], blacklist: set[str]
) -> set[str]:
    """Add matching items to urls/repos, returning only the URLs that were new.

    Blacklisted repos (see repo_blacklist.txt) are skipped entirely - not added
    to `repos` either, so they're also excluded from the full-tree verification
    pass below.
    """
    added: set[str] = set()
    for item in items:
        path = item["path"]
        if path.endswith(FILENAME_SUFFIX):
            repo_full_name = item["repository"]["full_name"]
            if repo_full_name.lower() in blacklist:
                continue
            repos.add(repo_full_name)
            url = path_to_url(repo_full_name, path)
            if url not in urls:
                urls.add(url)
                added.add(url)
    return added


def run_git(args: list[str], check: bool = True) -> subprocess.CompletedProcess:
    result = subprocess.run(
        ["git", *args], cwd=REPO_ROOT, capture_output=True, text=True
    )
    if check and result.returncode != 0:
        raise RuntimeError(f"git {' '.join(args)} failed: {result.stderr.strip()}")
    return result


def current_branch() -> str:
    global _branch
    if _branch is None:
        _branch = run_git(["rev-parse", "--abbrev-ref", "HEAD"]).stdout.strip()
    return _branch


def configure_git_identity() -> None:
    run_git(["config", "user.name", GIT_COMMIT_AUTHOR_NAME])
    run_git(["config", "user.email", GIT_COMMIT_AUTHOR_EMAIL])


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


def write_csv(rows: dict[str, dict[str, str]]) -> None:
    with open(OUTPUT_PATH, "w", newline="", encoding="utf-8") as f:
        writer = csv.DictWriter(f, fieldnames=FIELDNAMES, lineterminator="\n")
        writer.writeheader()
        for url in sorted(rows.keys(), key=str.lower):
            row = rows[url]
            writer.writerow({
                URL_COLUMN: url,
                ACTIVE_FROM_COLUMN: row[ACTIVE_FROM_COLUMN],
                ACTIVE_UNTIL_COLUMN: row[ACTIVE_UNTIL_COLUMN],
            })


def queue_new_urls(new_urls: set[str], source: str) -> None:
    """Record newly discovered URLs and immediately try to commit+push them.

    Committing after every single discovery (rather than once at the end of a
    run that can take well over an hour) means a later crash, timeout, or
    rate-limit error never loses progress already made.
    """
    if not new_urls:
        return
    _pending_urls.update(new_urls)
    flush_pending(source)


def flush_pending(source: str) -> None:
    """Try to commit and push everything in _pending_urls.

    Re-syncs to origin's current tip before every attempt and only commits
    URLs still missing there, so this is safe to call even if someone else
    (a maintainer's manual edit, or a concurrent run) has pushed to the same
    branch in the meantime - we just fold our additions on top of theirs and
    retry the push. On persistent failure this logs a warning and leaves the
    URLs in _pending_urls for the next flush attempt (or the final flush at
    the end of the run) to pick up, rather than raising and losing them.
    """
    if not _pending_urls:
        return
    branch = current_branch()
    today = datetime.date.today().isoformat()

    for attempt in range(1, GIT_MAX_RETRIES + 1):
        try:
            run_git(["fetch", "--depth=1", "origin", branch])
            run_git(["reset", "--hard", "FETCH_HEAD"])

            rows = read_existing_rows(OUTPUT_PATH)
            to_add = sorted(u for u in _pending_urls if u not in rows)
            if not to_add:
                # Already present on origin (e.g. a previous attempt's push
                # actually landed even though we didn't see success, or
                # someone else added the same URL).
                _pending_urls.clear()
                return

            for url in to_add:
                rows[url] = {ACTIVE_FROM_COLUMN: today, ACTIVE_UNTIL_COLUMN: ""}
            write_csv(rows)

            run_git(["add", OUTPUT_PATH])
            run_git(["commit", "-m", f"chore: add {len(to_add)} ARC-56 link(s) found via {source}"])
            push = subprocess.run(
                ["git", "push", "origin", f"HEAD:{branch}"],
                cwd=REPO_ROOT, capture_output=True, text=True,
            )
            if push.returncode == 0:
                print(f"Committed and pushed {len(to_add)} new ARC-56 link(s) ({source})",
                      file=sys.stderr)
                _pending_urls.difference_update(to_add)
                return

            print(f"Push rejected (attempt {attempt}/{GIT_MAX_RETRIES}), likely a concurrent "
                  f"commit to {branch}; re-syncing and retrying: {push.stderr.strip()}",
                  file=sys.stderr)
        except RuntimeError as exc:
            print(f"Git operation failed (attempt {attempt}/{GIT_MAX_RETRIES}): {exc}; "
                  f"will retry", file=sys.stderr)

        time.sleep(GIT_RETRY_BASE_DELAY_SECONDS * attempt)

    print(f"WARNING: failed to push {len(_pending_urls)} pending link(s) after "
          f"{GIT_MAX_RETRIES} attempts; will retry on the next discovery or at the end "
          f"of the run", file=sys.stderr)


def collect_recent_first(
    token: str, urls: set[str], repos: set[str], blacklist: set[str]
) -> None:
    """Priority pass: run the base query sorted newest-first, before sharding.

    `sort=indexed&order=desc` is the closest the code search API gets to
    "newest changes" - there's no commit-date sort available. This pass is
    capped at the same 1,000-result (10-page) ceiling as any single query, so
    it can't be exhaustive on its own; partition_and_collect() still runs
    afterwards to guarantee completeness. Running this first just means any
    freshly-added ARC-56 file is likely to be discovered - and committed via
    queue_new_urls() - within the first few requests of the run, instead of
    waiting on whichever size shard happens to contain it.
    """
    items_collected: list[dict] = []
    for page in range(1, MAX_PAGES + 1):
        items = fetch_page(SEARCH_QUERY, page, token, sort="indexed", order="desc").get("items", [])
        if not items:
            break
        items_collected.extend(items)
        if len(items) < PER_PAGE:
            break

    new_urls = add_matching_items(items_collected, urls, repos, blacklist)
    queue_new_urls(new_urls, "code search sorted by newest changes")


def partition_and_collect(
    lo: int, hi: int, token: str, urls: set[str], repos: set[str], blacklist: set[str], depth: int = 0
) -> None:
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
            partition_and_collect(lo, mid, token, urls, repos, blacklist, depth + 1)
            partition_and_collect(mid + 1, hi, token, urls, repos, blacklist, depth + 1)
            return
        print(f"WARNING: size range {lo}..{hi} still hits the {MAX_RESULTS_PER_QUERY}-result "
              f"pagination cap at max shard depth or cannot be split further; some results in "
              f"this range may be missing", file=sys.stderr)

    new_urls = add_matching_items(items_collected, urls, repos, blacklist)
    queue_new_urls(new_urls, f"code search size:{lo}..{hi}")


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

    new_here: set[str] = set()
    for entry in tree.get("tree", []):
        if entry.get("type") != "blob":
            continue
        path = entry.get("path", "")
        if path.endswith(FILENAME_SUFFIX):
            url = path_to_url(repo_full_name, path)
            if url not in urls:
                urls.add(url)
                new_here.add(url)
    if new_here:
        print(f"Full-tree verification for {repo_full_name} found {len(new_here)} additional "
              f"ARC-56 file(s) that code search missed", file=sys.stderr)
        queue_new_urls(new_here, f"full-tree verification of {repo_full_name}")


def collect_urls(token: str) -> set[str]:
    blacklist = load_repo_blacklist(REPO_BLACKLIST_PATH)
    if blacklist:
        print(f"Ignoring {len(blacklist)} blacklisted repo(s) from {REPO_BLACKLIST_PATH}: "
              f"{', '.join(sorted(blacklist))}", file=sys.stderr)

    urls: set[str] = set()
    repos: set[str] = set()

    print("Running priority search sorted by newest changes first...", file=sys.stderr)
    collect_recent_first(token, urls, repos, blacklist)
    print(f"Priority search found {len(urls)} ARC-56 file(s) so far; starting exhaustive "
          f"size-sharded search", file=sys.stderr)

    partition_and_collect(0, MAX_FILE_SIZE_BYTES, token, urls, repos, blacklist)

    print(f"Code search found {len(urls)} ARC-56 file(s) across {len(repos)} repo(s); "
          f"double-checking each repo's full file tree for anything code search missed",
          file=sys.stderr)
    for repo_full_name in sorted(repos):
        verify_repo_full_tree(repo_full_name, token, urls)

    return urls


def main() -> int:
    token = os.environ.get("GH_SEARCH_TOKEN") or os.environ.get("GITHUB_TOKEN") or ""
    if not token:
        print("Warning: no GH_SEARCH_TOKEN/GITHUB_TOKEN set; unauthenticated search "
              "rate limits are very low and this will likely fail.", file=sys.stderr)

    configure_git_identity()

    try:
        found_urls = collect_urls(token)
    except Exception as exc:  # noqa: BLE001 - a failure here must not lose already-pushed progress
        print(f"Aborting early due to error: {exc}", file=sys.stderr)
        try:
            flush_pending("partial run before abort")
        except Exception as flush_exc:  # noqa: BLE001
            print(f"Final flush of pending links also failed: {flush_exc}", file=sys.stderr)
        print("Links discovered before the error were already committed and pushed "
              "incrementally, so no progress was lost.", file=sys.stderr)
        return 1

    if not found_urls:
        print("Aborting: search returned 0 results, which looks wrong for this query.",
              file=sys.stderr)
        return 1

    flush_pending("final sync")
    if _pending_urls:
        print(f"WARNING: {len(_pending_urls)} link(s) could not be pushed even after the "
              f"final flush; they were discovered but are not yet on origin", file=sys.stderr)
        return 1

    final_rows = read_existing_rows(OUTPUT_PATH)
    print(f"Done: {len(final_rows)} total row(s) in {OUTPUT_PATH}, "
          f"{len(found_urls)} link(s) found in this run "
          f"(each already committed and pushed incrementally as it was found)")
    return 0


if __name__ == "__main__":
    sys.exit(main())
