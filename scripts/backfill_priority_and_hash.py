#!/usr/bin/env python3
"""One-time migration: add the Priority and Hash columns to arc56.links.csv.

Run once to backfill both new columns onto every existing row:

- Priority: 0 for every row, except a row whose ARC56URL contains "scholtz"
  (case-insensitive) gets 2000000001, and a row whose ARC56URL contains
  "txnlab" (case-insensitive) gets 2000000000. See
  docs/arc56-links-pipeline.md for the full priority scheme (new rows added
  by hand get Priority=1; new rows discovered by update_arc56_links.py get
  the current Unix timestamp at discovery time).
- Hash: the first 8 hex characters of SHA-256(ARC56URL) - the same "hash8"
  value already computed independently by download_arc56_specs.py and every
  generate_*_clients.py script to namespace each contract's generated code.
  Storing it in the CSV means it never needs to be recomputed by hand, and
  the PR check (validate_arc56_links.py) can verify a contributor computed
  it correctly.

Not part of any scheduled workflow - this script is meant to be run once
during the migration that introduced these columns, then left alone.
"""
from __future__ import annotations

import csv
import hashlib
import os

REPO_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
CSV_PATH = os.path.join(REPO_ROOT, "arc56.links.csv")

URL_COLUMN = "ARC56URL"
FROM_COLUMN = "ActiveFrom"
UNTIL_COLUMN = "ActiveUntil"
PRIORITY_COLUMN = "Priority"
HASH_COLUMN = "Hash"
OLD_FIELDNAMES = [URL_COLUMN, FROM_COLUMN, UNTIL_COLUMN]
NEW_FIELDNAMES = [URL_COLUMN, FROM_COLUMN, UNTIL_COLUMN, PRIORITY_COLUMN, HASH_COLUMN]

PRIORITY_SCHOLTZ = 2000000001
PRIORITY_TXNLAB = 2000000000
PRIORITY_DEFAULT = 0


def url_hash8(url: str) -> str:
    return hashlib.sha256(url.encode("utf-8")).hexdigest()[:8]


def priority_for(url: str) -> int:
    lowered = url.lower()
    if "scholtz" in lowered:
        return PRIORITY_SCHOLTZ
    if "txnlab" in lowered:
        return PRIORITY_TXNLAB
    return PRIORITY_DEFAULT


def main() -> int:
    with open(CSV_PATH, newline="", encoding="utf-8") as f:
        reader = csv.DictReader(f)
        if reader.fieldnames == NEW_FIELDNAMES:
            print(f"{CSV_PATH} already has {NEW_FIELDNAMES}; nothing to do.")
            return 0
        if reader.fieldnames != OLD_FIELDNAMES:
            print(f"ERROR: unexpected header {reader.fieldnames}, expected {OLD_FIELDNAMES}")
            return 1
        rows = list(reader)

    with open(CSV_PATH, "w", newline="", encoding="utf-8") as f:
        writer = csv.DictWriter(f, fieldnames=NEW_FIELDNAMES, lineterminator="\n")
        writer.writeheader()
        for row in rows:
            url = row[URL_COLUMN]
            writer.writerow({
                URL_COLUMN: url,
                FROM_COLUMN: row[FROM_COLUMN],
                UNTIL_COLUMN: row[UNTIL_COLUMN],
                PRIORITY_COLUMN: str(priority_for(url)),
                HASH_COLUMN: url_hash8(url),
            })

    print(f"Backfilled Priority and Hash for {len(rows)} row(s) in {CSV_PATH}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
