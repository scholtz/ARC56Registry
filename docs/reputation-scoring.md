# Owner reputation scoring

`scripts/generate_reputation.py` computes an automated, heuristic risk-reputation
score for every GitHub owner represented in the registry, and writes it to
`owners/<owner>/owner.json`. It also enriches every existing
`approval-programs/**/*.owners.json` and `clear-programs/**/*.owners.json` file (built
by [`generate_hash_registry.py`](hash-registry.md)) with the same score, so a consumer
who already fetches those files for attribution gets the risk signal in the same
fetch, with no second lookup.

**This is a heuristic, not a guarantee.** A brand-new, low-activity account isn't
necessarily malicious - lots of real projects start that way. A well-aged, active,
multi-repo account isn't necessarily safe either. The only component meant to carry
real certainty is the manually-maintained [ban list](#ban-list), for owners a
maintainer has actually confirmed to be bad actors. Consumers should treat everything
else as a prioritization signal for how much extra scrutiny to apply before signing a
transaction, never as a substitute for reviewing the actual contract.

## Why per-owner, not per-repo or per-contract

Risk in this context is about *who* you're trusting, not which specific contract you're
about to call. The same GitHub account publishing its 20th well-maintained contract
across 6 repos is a different risk profile than a brand-new account whose only activity
is a single spec added yesterday - even before looking at what either contract does.
Scoring at the owner level also makes the ban list effective: once an owner is confirmed
bad, every one of their repos and contracts inherits that verdict immediately.

## Data sources

All four inputs come from data the pipeline already collects or can cheaply fetch -
nothing requires manual submission, matching the rest of this registry.

1. **Account age** - `created_at` from the GitHub Users API (`GET /users/<owner>`).
   Fetched once per owner and cached forever in that owner's `owner.json`
   (`githubAccountCreatedAt`) - an account's creation date never changes, so a
   re-run only fetches it for owners that don't have it cached yet (see
   `load_cached_created_at()`). This is a plain REST call (5000 requests/hour
   authenticated, 60/hour unauthenticated), nowhere near as constrained as the code
   search API the rest of the pipeline has to work around - see
   [arc56-links-pipeline.md](arc56-links-pipeline.md). If the account has been
   deleted/renamed (404) or the API is unreachable, account age is treated as
   **unknown**, not zero - see [scoring formula](#scoring-formula).
2. **Activity pattern** - every distinct `ActiveFrom` date across *all* of that
   owner's rows in `arc56.links.csv`, active or deactivated (a deactivated spec still
   reflects real past activity). Multiple rows added the same day only ever count as
   one distinct date, so a single bulk import doesn't look like sustained activity.
3. **Project diversity** - the count of distinct repositories (parsed out of each
   `ARC56URL`'s `raw.githubusercontent.com/<owner>/<repo>/...` path) the owner has
   published ARC-56 specs in.
4. **Manual ban list** - `scripts/owner_ban_list.csv`, see [below](#ban-list).

## Scoring formula

Four components, each scored 0-25 and summed into a 0-100 `reputationScore`:

| Component | Formula | Full score (25) at |
| --- | --- | --- |
| `accountAge` | `25 * min(accountAgeDays, 1095) / 1095`, or a neutral `12` if account age is unknown | 3+ years old |
| `activity` | `25 * min(distinctSeenDates, 10) / 10` | 10+ distinct discovery dates |
| `diversity` | `25 * min(repoCount, 5) / 5` | 5+ distinct repositories |
| `longevity` | `25 * min(activeDaySpanDays, 365) / 365` | a full year between first and last seen date |

`activeDaySpanDays` is the gap between the owner's earliest and latest `ActiveFrom`
date across all their rows - it's what separates "one account, one contract, one day,
never touched again" (a single date, spanning zero days) from "same account, still
publishing/updating specs a year later."

`riskLevel` is derived from the unbanned `reputationScore`:

| `reputationScore` | `riskLevel` |
| --- | --- |
| 75-100 | `low` |
| 50-74 | `medium` |
| 25-49 | `high` |
| 0-24 | `very_high` |

## Ban list

`scripts/owner_ban_list.csv` is a small, maintainer-edited CSV with columns:

```
Owner,Weight,Reason,AddedDate
```

- `Owner` - the GitHub username, matched case-insensitively.
- `Weight` - an integer from 1 to 100: how severe/certain the finding is. `100` means
  "confirmed scammer, treat as maximally dangerous"; a lower value is used for a more
  circumstantial or less severe finding.
- `Reason` - free text, e.g. a link to the report or incident that led to the listing.
- `AddedDate` - `YYYY-MM-DD`, the date the entry was added.

An owner on this list always gets `riskLevel: "banned"` regardless of their computed
score, and their `reputationScore` is capped at `100 - Weight` (so a `Weight: 100`
entry always scores `0`, and a `Weight: 30` entry can score at most `70` even if every
other signal looks pristine) - a banned owner should never be able to outscore an
un-investigated one on paper.

Like `arc56.links.csv`, entries are **never deleted**, only added or edited (e.g.
raising `Weight` as more evidence comes in) - enforced on every pull request by
[`scripts/validate_owner_ban_list.py`](../scripts/validate_owner_ban_list.py) /
[`validate-owner-ban-list.yml`](../.github/workflows/validate-owner-ban-list.yml). To
report an owner, add a row by hand in a pull request; there's no automated discovery
for this list, deliberately - it only ever contains what a human has actually
confirmed.

## Output files

### `owners/<owner>/owner.json`

The canonical per-owner record:

```json
{
  "owner": "scholtz",
  "githubUrl": "https://github.com/scholtz",
  "githubAccountCreatedAt": "2011-11-27T16:01:18Z",
  "accountAgeDays": 5420,
  "firstArc56SeenDate": "2026-07-16",
  "lastArc56SeenDate": "2026-08-03",
  "activeDaySpanDays": 18,
  "distinctSeenDates": 3,
  "repoCount": 10,
  "repos": ["AVMGasStation", "..."],
  "banned": false,
  "banWeight": 0,
  "banReason": null,
  "banAddedDate": null,
  "scoreComponents": { "accountAge": 25, "activity": 8, "diversity": 25, "longevity": 1 },
  "reputationScore": 59,
  "riskLevel": "medium",
  "computedAt": "2026-09-29T07:41:27Z"
}
```

Only written/overwritten when its content actually changes, to keep commit diffs
minimal on a re-run where most owners' data hasn't moved.

### Enriched `*.owners.json`

Each owner entry in the existing hash-registry attribution files (see
[hash-registry.md](hash-registry.md#github-ownerrepo-attribution)) gets three fields
added/updated in place:

```json
{
  "owners": [
    {
      "owner": "Argimirodelpozo",
      "repo": "puya-sol",
      "url": "https://github.com/Argimirodelpozo/puya-sol",
      "reputationScore": 58,
      "riskLevel": "medium",
      "banned": false
    }
  ]
}
```

`owner`/`repo`/`url` remain solely owned by `generate_hash_registry.py`; this script
only ever adds/updates the three reputation fields, and only for an owner it actually
has a record for in that run - an owner entry left over from a `--only-owner`-scoped
local run keeps whatever reputation fields it already had rather than being
overwritten with unknowns.

## Pipeline integration

[`generate-reputation.yml`](../.github/workflows/generate-reputation.yml) runs after
both [`generate-hash-registry.yml`](../.github/workflows/generate-hash-registry.yml)
and [`update-arc56-links.yml`](../.github/workflows/update-arc56-links.yml) complete
(the same `workflow_run` chaining
[`publish-docker-hash-registry.yml`](../.github/workflows/publish-docker-hash-registry.yml)
already uses, since automated-commit pushes don't trigger another workflow's own
`push` filter), committing `owners/` and any touched `*.owners.json` files.

## Local testing

```sh
python scripts/generate_reputation.py --dry-run --only-owner <github-owner>
```

`--only-owner` (repeatable) and `--limit-owners N` scope a local run the same way the
other generate scripts do - see [CLAUDE.md](../CLAUDE.md#local-testing). A full local
run without `GITHUB_TOKEN`/`GH_SEARCH_TOKEN` set still works, it just falls back to the
unauthenticated Users API rate limit (60/hour) and treats most owners' account age as
unknown once that's exhausted.

## Known limitations

- Account age and activity are both easy for a sufficiently patient bad actor to age
  artificially (buy/age a GitHub account, publish low-value specs over time). This
  raises the cost of an attack; it doesn't eliminate it. The ban list exists precisely
  for the cases where a heuristic score alone isn't enough.
- `owners/` is not yet mirrored into the
  [Docker Hub self-hosted image](docker-hash-registry.md) or the
  [GitHub Pages site](hash-registry.md); only the enriched `*.owners.json` fields are
  available there today. Extending both to serve `owners/<owner>/owner.json` directly
  is a natural follow-up.
- The Users API's `created_at` reflects the GitHub account's creation date, which for
  an account that existed long before ever touching Algorand is a weaker signal than
  it looks. It's still one of the cheapest, hardest-to-fake-in-the-short-term signals
  available without asking users to submit anything by hand.
