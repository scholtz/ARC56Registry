#!/usr/bin/env python3
"""Regenerate arc56.links.csv from a GitHub code search for ARC-56 files.

Queries the GitHub code search API for `path:**/*.arc56.json`, converts each
match into a raw.githubusercontent.com URL pinned to the HEAD of the file's
default branch, de-duplicates, sorts alphabetically, and writes the result to
arc56.links.csv with a single "ARC56URL" header line.
"""
from __future__ import annotations

import json
import os
import sys
import time
import urllib.error
import urllib.parse
import urllib.request

SEARCH_QUERY = "path:**/*.arc56.json"
API_URL = "https://api.github.com/search/code"
PER_PAGE = 100
MAX_PAGES = 10  # GitHub code search caps results at 1000 (10 x 100).
OUTPUT_PATH = os.path.join(os.path.dirname(os.path.dirname(os.path.abspath(__file__))), "arc56.links.csv")
CSV_HEADER = "ARC56URL"


def build_request(page: int, token: str) -> urllib.request.Request:
    url = f"{API_URL}?q={urllib.parse.quote(SEARCH_QUERY)}&per_page={PER_PAGE}&page={page}"
    req = urllib.request.Request(url)
    req.add_header("Accept", "application/vnd.github+json")
    req.add_header("X-GitHub-Api-Version", "2022-11-28")
    req.add_header("User-Agent", "arc56-links-updater")
    if token:
        req.add_header("Authorization", f"Bearer {token}")
    return req


def fetch_page(page: int, token: str, retries: int = 5) -> dict:
    for attempt in range(1, retries + 1):
        req = build_request(page, token)
        try:
            with urllib.request.urlopen(req) as resp:
                return json.loads(resp.read().decode("utf-8"))
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


def collect_urls(token: str) -> set[str]:
    urls: set[str] = set()
    for page in range(1, MAX_PAGES + 1):
        data = fetch_page(page, token)
        items = data.get("items", [])
        if not items:
            break
        for item in items:
            repo_full_name = item["repository"]["full_name"]
            path = item["path"]
            urls.add(f"https://raw.githubusercontent.com/{repo_full_name}/HEAD/{path}")
        if len(items) < PER_PAGE:
            break
        time.sleep(2)  # stay comfortably under the search API's secondary rate limit
    return urls


def main() -> int:
    token = os.environ.get("GH_SEARCH_TOKEN") or os.environ.get("GITHUB_TOKEN") or ""
    if not token:
        print("Warning: no GH_SEARCH_TOKEN/GITHUB_TOKEN set; unauthenticated search "
              "rate limits are very low and this will likely fail.", file=sys.stderr)

    urls = collect_urls(token)
    sorted_urls = sorted(urls, key=str.lower)

    with open(OUTPUT_PATH, "w", encoding="utf-8", newline="\n") as f:
        f.write(CSV_HEADER + "\n")
        for url in sorted_urls:
            f.write(url + "\n")

    print(f"Wrote {len(sorted_urls)} ARC-56 links to {OUTPUT_PATH}")
    return 0


if __name__ == "__main__":
    sys.exit(main())
