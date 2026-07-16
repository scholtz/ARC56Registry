#!/usr/bin/env python3
"""Validate a pull request's changes to arc56.links.csv.

Checks, against the PR's base branch:

- The CSV has exactly the header ARC56URL,ActiveFrom,ActiveUntil.
- Every ARC56URL ends with ".arc56.json", has no duplicates, and the column
  is sorted alphabetically (case-insensitive).
- ActiveFrom/ActiveUntil are empty or valid YYYY-MM-DD dates.
- No existing record (identified by ARC56URL) is removed.
- New records have ActiveFrom == today and ActiveUntil == "".
- Records whose ActiveUntil is left/made empty ("updated"/reactivated) have
  ActiveFrom == today.
- Records whose ActiveUntil is set to today ("deleted"/deactivated) keep
  ActiveFrom unchanged from the base branch.
- Any other kind of change to an existing record's ActiveFrom/ActiveUntil is
  rejected.
"""
from __future__ import annotations

import argparse
import csv
import datetime
import re
import subprocess
import sys

CSV_PATH = "arc56.links.csv"
URL_COL = "ARC56URL"
FROM_COL = "ActiveFrom"
UNTIL_COL = "ActiveUntil"
FIELDNAMES = [URL_COL, FROM_COL, UNTIL_COL]
URL_SUFFIX = ".arc56.json"
DATE_RE = re.compile(r"^\d{4}-\d{2}-\d{2}$")


def parse_csv(text: str, source: str) -> list[dict[str, str]]:
    reader = csv.DictReader(text.splitlines())
    if reader.fieldnames != FIELDNAMES:
        raise ValueError(
            f"{source}: header must be exactly {FIELDNAMES}, got {reader.fieldnames}"
        )
    return list(reader)


def load_base_csv(base_sha: str) -> str | None:
    result = subprocess.run(
        ["git", "show", f"{base_sha}:{CSV_PATH}"],
        capture_output=True,
        text=True,
    )
    if result.returncode != 0:
        return None  # file did not exist on the base branch
    return result.stdout


def main() -> int:
    parser = argparse.ArgumentParser()
    parser.add_argument("--base-sha", required=True, help="Git SHA of the PR's base branch")
    args = parser.parse_args()

    errors: list[str] = []
    today = datetime.date.today().isoformat()

    try:
        with open(CSV_PATH, encoding="utf-8") as f:
            head_text = f.read()
    except FileNotFoundError:
        print(f"ERROR: {CSV_PATH} does not exist; it must not be deleted.")
        return 1

    try:
        head_rows = parse_csv(head_text, "head")
    except ValueError as exc:
        print(f"ERROR: {exc}")
        return 1

    seen_urls: set[str] = set()
    for i, row in enumerate(head_rows, start=2):  # data starts on line 2
        url = row.get(URL_COL, "")
        active_from = row.get(FROM_COL, "")
        active_until = row.get(UNTIL_COL, "")

        if not url.endswith(URL_SUFFIX):
            errors.append(f"line {i}: {URL_COL} must end with '{URL_SUFFIX}': '{url}'")
        if url in seen_urls:
            errors.append(f"line {i}: duplicate {URL_COL}: '{url}'")
        seen_urls.add(url)
        if not DATE_RE.match(active_from):
            errors.append(f"line {i}: {FROM_COL} must be a YYYY-MM-DD date, got '{active_from}' ({url})")
        if active_until and not DATE_RE.match(active_until):
            errors.append(
                f"line {i}: {UNTIL_COL} must be empty or a YYYY-MM-DD date, got '{active_until}' ({url})"
            )

    head_urls = [row.get(URL_COL, "") for row in head_rows]
    if head_urls != sorted(head_urls, key=str.lower):
        errors.append(f"{URL_COL} column must be sorted alphabetically (case-insensitive)")

    base_text = load_base_csv(args.base_sha)
    base_rows = parse_csv(base_text, "base") if base_text is not None else []
    base_by_url = {row[URL_COL]: row for row in base_rows}
    head_by_url = {row[URL_COL]: row for row in head_rows}

    for url, base_row in base_by_url.items():
        if url not in head_by_url:
            errors.append(f"record removed, which is not allowed: '{url}'")
            continue
        head_row = head_by_url[url]
        if head_row == base_row:
            continue

        head_from = head_row.get(FROM_COL, "")
        head_until = head_row.get(UNTIL_COL, "")
        base_from = base_row.get(FROM_COL, "")

        if head_until == "":
            if head_from != today:
                errors.append(
                    f"updated record '{url}': {FROM_COL} must be today ({today}), got '{head_from}'"
                )
        elif head_until == today:
            if head_from != base_from:
                errors.append(
                    f"deactivated record '{url}': {FROM_COL} must not change "
                    f"(was '{base_from}', got '{head_from}')"
                )
        else:
            errors.append(
                f"record '{url}' changed in an unsupported way: {UNTIL_COL} must be either empty "
                f"(update, with {FROM_COL}=today) or today's date ({today}) to deactivate it; "
                f"got {FROM_COL}='{head_from}', {UNTIL_COL}='{head_until}'"
            )

    for url, head_row in head_by_url.items():
        if url in base_by_url:
            continue
        head_from = head_row.get(FROM_COL, "")
        head_until = head_row.get(UNTIL_COL, "")
        if head_from != today:
            errors.append(f"new record '{url}': {FROM_COL} must be today ({today}), got '{head_from}'")
        if head_until != "":
            errors.append(f"new record '{url}': {UNTIL_COL} must be empty, got '{head_until}'")

    if errors:
        print(f"Found {len(errors)} problem(s) with {CSV_PATH}:\n")
        for error in errors:
            print(f"  - {error}")
        return 1

    print(f"{CSV_PATH} is valid: {len(head_rows)} rows, sorted, schema valid, diff rules satisfied.")
    return 0


if __name__ == "__main__":
    sys.exit(main())
