#!/usr/bin/env python3
"""Compute an automated risk-reputation score for every GitHub owner in the registry.

Reads `arc56.links.csv` (every row, active or not - a deactivated spec still reflects
real past activity by its owner) and groups rows by the GitHub owner parsed out of each
`ARC56URL` (`https://raw.githubusercontent.com/<owner>/<repo>/...`). For each owner it
computes four 0-25 component scores that sum to a 0-100 `reputationScore`:

- **Account age** - how long the owner's GitHub account has existed, via the GitHub
  Users API (`GET /users/<owner>`, `created_at`). This is fetched once per owner and
  cached forever in that owner's `owners/<owner>/owner.json` (an account's creation
  date never changes), so a re-run never re-fetches an owner it already has cached -
  see `load_cached_created_at()`.
- **Activity** - rewards an owner who periodically adds/updates ARC-56 specs over
  distinct dates, rather than a one-time burst (many rows added the same day only
  ever count as one "distinct seen date" here).
- **Diversity** - rewards an owner with specs across multiple distinct repositories.
- **Longevity** - rewards a long span between the owner's first and last seen date
  (protects against many repos all created and seeded on the same day).

See docs/reputation-scoring.md for the full formula and its rationale.

## Manual ban list

`scripts/owner_ban_list.csv` (`Owner,Weight,Reason,AddedDate`) is a maintainer-edited,
never-deleted list (see `scripts/validate_owner_ban_list.py`) of confirmed-bad owners.
A banned owner's `riskLevel` is always `"banned"` regardless of its computed score, and
its `reputationScore` is capped at `100 - Weight` (Weight 1-100, higher = more certain/
severe) - see `apply_ban_list()`.

## Output

- `owners/<owner>/owner.json` - the canonical per-owner record (written/overwritten
  only when its content actually changes, to keep commit diffs minimal).
- Every existing `approval-programs/**/*.owners.json` and `clear-programs/**/*.owners.json`
  file (written by `generate_hash_registry.py`) gets each of its owner entries enriched
  in place with `reputationScore`/`riskLevel`/`banned`, so a consumer who already fetches
  those files for attribution gets the risk signal in the same fetch - see
  `enrich_owners_files()`. Fields this script doesn't own (`owner`/`repo`/`url`) are left
  untouched, and an owner this run has no data for (e.g. a `--only-owner`-scoped local
  run) is left with whatever reputation fields it already had, not overwritten with
  unknowns.

This script never deletes anything, matching the repo-wide convention: `owners/<owner>/
owner.json` files persist even for an owner every one of whose rows later gets
deactivated, and the enrichment step only ever adds/updates fields, never removes an
owner from a `.owners.json` file's `owners` list (that list is still solely owned by
generate_hash_registry.py).
"""
from __future__ import annotations

import argparse
import csv
import datetime
import glob
import json
import os
import sys
import time
import urllib.error
import urllib.parse
import urllib.request

REPO_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
LINKS_CSV_PATH = os.path.join(REPO_ROOT, "arc56.links.csv")
BAN_LIST_PATH = os.path.join(REPO_ROOT, "scripts", "owner_ban_list.csv")
OWNERS_DIR = os.path.join(REPO_ROOT, "owners")
PROGRAM_DIRS = [
    os.path.join(REPO_ROOT, "approval-programs"),
    os.path.join(REPO_ROOT, "clear-programs"),
]

URL_COLUMN = "ARC56URL"
FROM_COLUMN = "ActiveFrom"

BAN_OWNER_COLUMN = "Owner"
BAN_WEIGHT_COLUMN = "Weight"
BAN_REASON_COLUMN = "Reason"
BAN_ADDED_DATE_COLUMN = "AddedDate"

USERS_API_URL = "https://api.github.com/users/{owner}"
# The Users API is a cheap, non-search REST endpoint (5000 req/hour authenticated,
# 60/hour unauthenticated) - nowhere near as constrained as code search - but a call
# is only ever made once per owner ever (see load_cached_created_at()), so even a
# small courtesy delay costs nothing on a warm run and keeps a cold first run polite.
USER_API_DELAY_SECONDS = 0.5

# Score component weights: each is 0-25 and they sum to a 0-100 reputationScore.
MAX_COMPONENT_SCORE = 25
ACCOUNT_AGE_CAP_DAYS = 3 * 365  # 3 years of account age reaches the full component score
ACTIVITY_DATE_CAP = 10  # 10+ distinct seen-dates reaches the full component score
DIVERSITY_REPO_CAP = 5  # 5+ distinct repos reaches the full component score
LONGEVITY_SPAN_CAP_DAYS = 365  # a full year between first/last seen reaches the full component score
# Used when account age is unknown (API unreachable, no token, or a 404'd/renamed
# account) - a neutral midpoint rather than penalizing or rewarding the unknown.
UNKNOWN_ACCOUNT_AGE_SCORE = MAX_COMPONENT_SCORE // 2

RISK_LOW_THRESHOLD = 75
RISK_MEDIUM_THRESHOLD = 50
RISK_HIGH_THRESHOLD = 25


def log(message: str) -> None:
    timestamp = datetime.datetime.now(datetime.timezone.utc).strftime("%Y-%m-%d %H:%M:%S")
    print(f"[{timestamp}] {message}", file=sys.stderr)


def owner_repo_from_url(url: str) -> tuple[str, str] | None:
    """https://raw.githubusercontent.com/<owner>/<repo>/... -> (owner, repo)."""
    parsed = urllib.parse.urlparse(url)
    if parsed.netloc != "raw.githubusercontent.com":
        return None
    parts = [p for p in parsed.path.split("/") if p]
    if len(parts) < 2:
        return None
    return urllib.parse.unquote(parts[0]), urllib.parse.unquote(parts[1])


def load_owner_activity(path: str) -> dict[str, dict]:
    """owner -> {"repos": set[str], "seen_dates": set[str]} across every row (active or
    not) in arc56.links.csv - a deactivated spec still reflects real past activity."""
    activity: dict[str, dict] = {}
    if not os.path.exists(path):
        return activity
    with open(path, newline="", encoding="utf-8") as f:
        reader = csv.DictReader(f)
        for row in reader:
            url = row.get(URL_COLUMN, "")
            owner_repo = owner_repo_from_url(url)
            if owner_repo is None:
                continue
            owner, repo = owner_repo
            entry = activity.setdefault(owner, {"repos": set(), "seen_dates": set()})
            entry["repos"].add(repo)
            active_from = row.get(FROM_COLUMN, "")
            if active_from:
                entry["seen_dates"].add(active_from)
    return activity


def load_ban_list(path: str) -> dict[str, dict]:
    """Owner (case-insensitive) -> {"weight": int, "reason": str, "addedDate": str}.

    Missing file just means an empty ban list. Malformed rows are logged and skipped
    rather than aborting the whole run - see scripts/validate_owner_ban_list.py for the
    PR-time check that keeps this file well-formed in the first place.
    """
    ban_list: dict[str, dict] = {}
    if not os.path.exists(path):
        return ban_list
    with open(path, newline="", encoding="utf-8") as f:
        reader = csv.DictReader(f)
        for row in reader:
            owner = (row.get(BAN_OWNER_COLUMN) or "").strip()
            if not owner:
                continue
            weight_raw = (row.get(BAN_WEIGHT_COLUMN) or "").strip()
            try:
                weight = int(weight_raw)
            except ValueError:
                log(f"WARNING: owner_ban_list.csv: owner '{owner}' has non-integer Weight "
                    f"'{weight_raw}', skipping this ban entry")
                continue
            weight = max(1, min(100, weight))
            ban_list[owner.lower()] = {
                "weight": weight,
                "reason": (row.get(BAN_REASON_COLUMN) or "").strip(),
                "addedDate": (row.get(BAN_ADDED_DATE_COLUMN) or "").strip(),
            }
    return ban_list


def owner_json_path(owner: str) -> str:
    return os.path.join(OWNERS_DIR, owner, "owner.json")


def load_cached_created_at(owner: str) -> str | None:
    path = owner_json_path(owner)
    if not os.path.exists(path):
        return None
    try:
        with open(path, encoding="utf-8") as f:
            data = json.load(f)
        return data.get("githubAccountCreatedAt")
    except (OSError, ValueError, AttributeError):
        return None


def fetch_account_created_at(owner: str, token: str) -> str | None:
    """GET /users/<owner>, returning its `created_at` or None on any failure.

    A failure here (404 for a deleted/renamed account, rate limit, network error) must
    never abort the run - it just means this owner's account-age component falls back
    to UNKNOWN_ACCOUNT_AGE_SCORE, same as never having had a token at all.
    """
    url = USERS_API_URL.format(owner=urllib.parse.quote(owner))
    req = urllib.request.Request(url)
    req.add_header("Accept", "application/vnd.github+json")
    req.add_header("X-GitHub-Api-Version", "2022-11-28")
    req.add_header("User-Agent", "arc56-reputation-generator")
    if token:
        req.add_header("Authorization", f"Bearer {token}")
    try:
        with urllib.request.urlopen(req) as resp:
            data = json.loads(resp.read().decode("utf-8"))
            return data.get("created_at")
    except urllib.error.HTTPError as exc:
        if exc.code != 404:
            log(f"WARNING: GitHub Users API returned {exc.code} for '{owner}'; "
                f"account age will be treated as unknown for this run")
        return None
    except (urllib.error.URLError, TimeoutError, ValueError) as exc:
        log(f"WARNING: could not fetch GitHub account info for '{owner}': {exc}; "
            f"account age will be treated as unknown for this run")
        return None


def parse_iso_date(value: str) -> datetime.date | None:
    try:
        return datetime.date.fromisoformat(value[:10])
    except ValueError:
        return None


def account_age_days(created_at: str | None, today: datetime.date) -> int | None:
    if not created_at:
        return None
    created_date = parse_iso_date(created_at)
    if created_date is None:
        return None
    return (today - created_date).days


def clamp_score(fraction: float) -> int:
    return max(0, min(MAX_COMPONENT_SCORE, round(MAX_COMPONENT_SCORE * fraction)))


def compute_scores(
    age_days: int | None, distinct_seen_dates: int, repo_count: int, span_days: int
) -> dict[str, int]:
    account_age = (
        UNKNOWN_ACCOUNT_AGE_SCORE
        if age_days is None
        else clamp_score(min(age_days, ACCOUNT_AGE_CAP_DAYS) / ACCOUNT_AGE_CAP_DAYS)
    )
    activity = clamp_score(min(distinct_seen_dates, ACTIVITY_DATE_CAP) / ACTIVITY_DATE_CAP)
    diversity = clamp_score(min(repo_count, DIVERSITY_REPO_CAP) / DIVERSITY_REPO_CAP)
    longevity = clamp_score(min(span_days, LONGEVITY_SPAN_CAP_DAYS) / LONGEVITY_SPAN_CAP_DAYS)
    return {
        "accountAge": account_age,
        "activity": activity,
        "diversity": diversity,
        "longevity": longevity,
    }


def risk_level(reputation_score: int, banned: bool) -> str:
    if banned:
        return "banned"
    if reputation_score >= RISK_LOW_THRESHOLD:
        return "low"
    if reputation_score >= RISK_MEDIUM_THRESHOLD:
        return "medium"
    if reputation_score >= RISK_HIGH_THRESHOLD:
        return "high"
    return "very_high"


def build_owner_record(
    owner: str,
    activity: dict,
    ban_entry: dict | None,
    created_at: str | None,
    today: datetime.date,
    computed_at: str,
) -> dict:
    repos = sorted(activity["repos"])
    seen_dates = sorted(activity["seen_dates"])
    first_seen = seen_dates[0] if seen_dates else None
    last_seen = seen_dates[-1] if seen_dates else None
    span_days = 0
    if first_seen and last_seen:
        span_days = (parse_iso_date(last_seen) - parse_iso_date(first_seen)).days

    age_days = account_age_days(created_at, today)
    components = compute_scores(age_days, len(seen_dates), len(repos), span_days)
    base_score = sum(components.values())

    banned = ban_entry is not None
    reputation_score = base_score
    ban_weight = 0
    ban_reason = None
    ban_added_date = None
    if banned:
        ban_weight = ban_entry["weight"]
        ban_reason = ban_entry["reason"] or None
        ban_added_date = ban_entry["addedDate"] or None
        reputation_score = max(0, min(base_score, 100 - ban_weight))

    return {
        "owner": owner,
        "githubUrl": f"https://github.com/{owner}",
        "githubAccountCreatedAt": created_at,
        "accountAgeDays": age_days,
        "firstArc56SeenDate": first_seen,
        "lastArc56SeenDate": last_seen,
        "activeDaySpanDays": span_days,
        "distinctSeenDates": len(seen_dates),
        "repoCount": len(repos),
        "repos": repos,
        "banned": banned,
        "banWeight": ban_weight,
        "banReason": ban_reason,
        "banAddedDate": ban_added_date,
        "scoreComponents": components,
        "reputationScore": reputation_score,
        "riskLevel": risk_level(reputation_score, banned),
        "computedAt": computed_at,
    }


def write_owner_record(owner: str, record: dict, dry_run: bool) -> bool:
    """Returns True if the file was written (or, in --dry-run, would be)."""
    path = owner_json_path(owner)
    content = json.dumps(record, indent=2, ensure_ascii=False) + "\n"
    existing = None
    if os.path.exists(path):
        with open(path, encoding="utf-8") as f:
            existing = f.read()
    if existing == content:
        return False
    if dry_run:
        action = "would update" if existing else "would create"
        print(f"{action} {os.path.relpath(path, REPO_ROOT)} -> "
              f"reputationScore={record['reputationScore']} riskLevel={record['riskLevel']}")
        return True
    os.makedirs(os.path.dirname(path), exist_ok=True)
    with open(path, "w", encoding="utf-8", newline="\n") as f:
        f.write(content)
    return True


def find_owners_files() -> list[str]:
    paths: list[str] = []
    for base in PROGRAM_DIRS:
        pattern = os.path.join(base, "**", "*.owners.json")
        paths.extend(glob.glob(pattern, recursive=True))
    return sorted(paths)


def enrich_owners_files(records_by_owner: dict[str, dict], dry_run: bool) -> None:
    """Adds/updates reputationScore/riskLevel/banned on each owner entry of every
    existing `*.owners.json` file, leaving owner/repo/url and any owner this run has
    no record for untouched (see module docstring)."""
    paths = find_owners_files()
    written = 0
    unchanged = 0
    skipped_owners = 0
    for path in paths:
        try:
            with open(path, encoding="utf-8") as f:
                data = json.load(f)
        except (OSError, ValueError) as exc:
            log(f"WARNING: could not parse {os.path.relpath(path, REPO_ROOT)}: {exc}; leaving it untouched")
            continue

        owners = data.get("owners")
        if not isinstance(owners, list):
            continue

        changed = False
        for entry in owners:
            owner = entry.get("owner")
            record = records_by_owner.get(owner)
            if record is None:
                skipped_owners += 1
                continue
            new_fields = {
                "reputationScore": record["reputationScore"],
                "riskLevel": record["riskLevel"],
                "banned": record["banned"],
            }
            if {k: entry.get(k) for k in new_fields} != new_fields:
                entry.update(new_fields)
                changed = True

        if not changed:
            unchanged += 1
            continue

        content = json.dumps(data, indent=2, ensure_ascii=False) + "\n"
        written += 1
        if dry_run:
            print(f"would update {os.path.relpath(path, REPO_ROOT)} with reputation data")
            continue
        with open(path, "w", encoding="utf-8", newline="\n") as f:
            f.write(content)

    verb = "Would update" if dry_run else "Updated"
    log(f"{verb} {written} owners.json file(s) with reputation data, {unchanged} already up to date "
        f"({skipped_owners} owner entries left untouched - no reputation record for that owner in this run)")


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    parser.add_argument("--dry-run", action="store_true", help="Report what would change without writing any files.")
    parser.add_argument("--only-owner", action="append", default=[],
                         help="Restrict to this GitHub owner (repeatable). For local testing.")
    parser.add_argument("--limit-owners", type=int, default=None,
                         help="Only process the first N owners (alphabetically). For local testing.")
    args = parser.parse_args()

    token = os.environ.get("GH_SEARCH_TOKEN") or os.environ.get("GITHUB_TOKEN") or ""
    if not token:
        log("WARNING: no GH_SEARCH_TOKEN/GITHUB_TOKEN set; account-age lookups will use the "
            "unauthenticated rate limit and mostly fail, falling back to an unknown/neutral score")

    activity_by_owner = load_owner_activity(LINKS_CSV_PATH)
    ban_list = load_ban_list(BAN_LIST_PATH)
    log(f"Loaded activity for {len(activity_by_owner)} owner(s) from {os.path.relpath(LINKS_CSV_PATH, REPO_ROOT)}, "
        f"{len(ban_list)} ban list entry(ies)")

    owners = sorted(activity_by_owner.keys(), key=str.lower)
    if args.only_owner:
        wanted = {o.lower() for o in args.only_owner}
        owners = [o for o in owners if o.lower() in wanted]
    if args.limit_owners is not None:
        owners = owners[: args.limit_owners]

    today = datetime.date.today()
    computed_at = datetime.datetime.now(datetime.timezone.utc).strftime("%Y-%m-%dT%H:%M:%SZ")

    records_by_owner: dict[str, dict] = {}
    written = 0
    for i, owner in enumerate(owners, start=1):
        log(f"[{i}/{len(owners)}] {owner}")
        created_at = load_cached_created_at(owner)
        if created_at is None:
            time.sleep(USER_API_DELAY_SECONDS)
            created_at = fetch_account_created_at(owner, token)

        ban_entry = ban_list.get(owner.lower())
        record = build_owner_record(owner, activity_by_owner[owner], ban_entry, created_at, today, computed_at)
        records_by_owner[owner] = record
        if write_owner_record(owner, record, args.dry_run):
            written += 1

    verb = "Would write" if args.dry_run else "Wrote"
    log(f"{verb}/updated {written} owner record(s) out of {len(owners)} processed")

    enrich_owners_files(records_by_owner, args.dry_run)
    return 0


if __name__ == "__main__":
    sys.exit(main())
