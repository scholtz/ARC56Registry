#!/usr/bin/env python3
"""Validate a pull request's changes to scripts/owner_ban_list.csv.

Checks, against the PR's base branch:

- The CSV has exactly the header Owner,Weight,Reason,AddedDate.
- Every Owner is non-empty and unique (case-insensitive).
- Weight is an integer between 1 and 100 (inclusive) - see
  docs/reputation-scoring.md#ban-list for what the scale means.
- AddedDate is a valid YYYY-MM-DD date.
- No existing entry (identified by Owner, case-insensitive) is removed -
  matching this repo's general never-delete convention. Weight/Reason/AddedDate
  may be edited freely on an existing entry (e.g. raising Weight as more
  evidence comes in), just never removed outright.
"""
from __future__ import annotations

import argparse
import csv
import io
import re
import subprocess
import sys

CSV_PATH = "scripts/owner_ban_list.csv"
OWNER_COL = "Owner"
WEIGHT_COL = "Weight"
REASON_COL = "Reason"
ADDED_DATE_COL = "AddedDate"
FIELDNAMES = [OWNER_COL, WEIGHT_COL, REASON_COL, ADDED_DATE_COL]
DATE_RE = re.compile(r"^\d{4}-\d{2}-\d{2}$")


def parse_csv(text: str, source: str) -> list[dict[str, str]]:
    # csv.DictReader(io.StringIO(text)), not text.splitlines() - the latter splits on
    # every newline before csv.reader ever sees the file's quoting, so a quoted Reason
    # field containing an embedded newline would be split into a bogus extra row.
    reader = csv.DictReader(io.StringIO(text))
    if reader.fieldnames != FIELDNAMES:
        raise ValueError(f"{source}: header must be exactly {FIELDNAMES}, got {reader.fieldnames}")
    return list(reader)


def load_base_csv(base_sha: str) -> str | None:
    result = subprocess.run(["git", "show", f"{base_sha}:{CSV_PATH}"], capture_output=True, text=True)
    if result.returncode == 0:
        return result.stdout
    # Only treat this as "the file didn't exist on the base branch" (not an error) when
    # git itself says so - any other failure (bad SHA, corrupt repo, ...) must be raised
    # loudly instead of silently disabling the never-delete check below by pretending
    # the base branch had zero entries.
    if "does not exist" in result.stderr or "exists on disk, but not in" in result.stderr:
        return None
    raise RuntimeError(f"git show {base_sha}:{CSV_PATH} failed unexpectedly: {result.stderr.strip()}")


def main() -> int:
    parser = argparse.ArgumentParser()
    parser.add_argument("--base-sha", required=True, help="Git SHA of the PR's base branch")
    args = parser.parse_args()

    errors: list[str] = []

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

    seen_owners: set[str] = set()
    for i, row in enumerate(head_rows, start=2):  # data starts on line 2
        owner = row.get(OWNER_COL, "").strip()
        weight = row.get(WEIGHT_COL, "").strip()
        added_date = row.get(ADDED_DATE_COL, "").strip()

        if not owner:
            errors.append(f"line {i}: {OWNER_COL} must not be empty")
        elif owner.lower() in seen_owners:
            errors.append(f"line {i}: duplicate {OWNER_COL} (case-insensitive): '{owner}'")
        seen_owners.add(owner.lower())

        try:
            weight_int = int(weight)
            if not 1 <= weight_int <= 100:
                errors.append(f"line {i}: {WEIGHT_COL} must be between 1 and 100, got {weight_int} ({owner})")
        except ValueError:
            errors.append(f"line {i}: {WEIGHT_COL} must be an integer, got '{weight}' ({owner})")

        if not DATE_RE.match(added_date):
            errors.append(f"line {i}: {ADDED_DATE_COL} must be a YYYY-MM-DD date, got '{added_date}' ({owner})")

    try:
        base_text = load_base_csv(args.base_sha)
    except RuntimeError as exc:
        print(f"ERROR: {exc}")
        return 1
    base_rows = parse_csv(base_text, "base") if base_text is not None else []
    base_owners = {row.get(OWNER_COL, "").strip().lower() for row in base_rows if row.get(OWNER_COL, "").strip()}
    head_owners = {row.get(OWNER_COL, "").strip().lower() for row in head_rows if row.get(OWNER_COL, "").strip()}

    for owner in base_owners - head_owners:
        errors.append(f"entry removed, which is not allowed: '{owner}'")

    if errors:
        print(f"Found {len(errors)} problem(s) with {CSV_PATH}:\n")
        for error in errors:
            print(f"  - {error}")
        return 1

    print(f"{CSV_PATH} is valid: {len(head_rows)} entries, schema valid, never-delete rule satisfied.")
    return 0


if __name__ == "__main__":
    sys.exit(main())
