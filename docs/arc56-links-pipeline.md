# ARC-56 links update pipeline

This repository automatically maintains [arc56.links.csv](../arc56.links.csv), a
list of every `*.arc56.json` file found on public GitHub, via the
[`update-arc56-links.yml`](../.github/workflows/update-arc56-links.yml) workflow.

## What the pipeline does

1. **Trigger**: runs on a daily schedule (`0 3 * * *`, 03:00 UTC) and can also be
   run on demand from the **Actions** tab (`workflow_dispatch`).
2. **Checkout**: checks out this repository.
3. **Search**: runs [`scripts/update_arc56_links.py`](../scripts/update_arc56_links.py),
   which queries the GitHub code search API
   (`GET https://api.github.com/search/code`) with the query
   `arc56.json in:path`. Note: the newer glob syntax `path:**/*.arc56.json`
   (used by the github.com/search web UI) is **not** supported by the legacy
   REST `search/code` endpoint and silently returns zero results, which is why
   the query is phrased as a plain substring match instead.

   **Priority pass, run first**: before the exhaustive sharded search below,
   the script runs the same query once more with `sort=indexed&order=desc` -
   the closest thing the code search API offers to "newest changes first"
   (there is no commit-date sort; `indexed` sorts by when GitHub's search
   index last saw the file). This pass is capped at the API's normal
   1,000-result/10-page limit like any single query, so it isn't exhaustive
   on its own, but it means recently-added ARC-56 files tend to get
   discovered - and committed - within the first few requests of a run
   instead of waiting on whichever `size:` shard happens to contain them. See
   `collect_recent_first()` in the script.

   GitHub's code search API never returns more than 1,000 results for a
   single query, no matter how many total matches exist (`total_count` can
   read e.g. 1464 while only the first 1,000 are actually paginable). To get
   past that, the script recursively **shards the query by file `size:`
   range** — e.g. `arc56.json in:path size:0..196608` — splitting each range
   in half until every shard is small enough to paginate fully, then unions
   the results. See `partition_and_collect()` in the script for the
   implementation.

   Splitting decisions are **not** based on the API's `total_count` field —
   GitHub documents that field as only an approximation once a query has more
   than 1,000 matches, and in practice it's noisy enough that a narrower size
   range can report a *higher* `total_count` than its own parent range. Using
   it to decide when to stop splitting caused the search to over-split and
   run far longer than necessary. Instead, the script pages through a shard
   for real and only splits it when pagination actually fills all 10 pages
   (1,000 items) with no early short page — the one signal from this API
   that's trustworthy, since exhausting fewer than 10 pages is concrete proof
   there's nothing left to find in that range.
4. **Filter**: matches are restricted to paths whose filename actually ends
   in `.arc56.json`, since `in:path` is a substring match and could otherwise
   match unrelated paths that merely contain that text.
5. **Transform**: for every match, the script builds a stable raw-content URL
   of the form:

   ```
   https://raw.githubusercontent.com/<owner>/<repo>/HEAD/<path>
   ```

   `HEAD` is used instead of a pinned commit SHA so the link always resolves
   to whatever is currently on the repository's default branch, instead of
   going stale or 404ing if the original commit is garbage-collected.
6. **Merge with the existing CSV**: the script reads the current
   `arc56.links.csv` and merges the newly found URLs into it — see
   [CSV format and Active columns](#csv-format-and-active-columns) below.
   Existing rows are **never removed or modified**, even if a URL isn't found
   by the current search run; only genuinely new URLs are appended, with
   `ActiveFrom` set to today's date and `ActiveUntil` left empty.
7. **Write**: the merged, alphabetically-sorted (case-insensitive) result is
   written back to `arc56.links.csv` using Python's `csv` module with RFC
   4180 quoting, so the file renders correctly as a table on GitHub (see
   [GitHub's docs on rendering CSV/TSV files](https://docs.github.com/en/repositories/working-with-files/using-files/working-with-non-code-files)).
8. **Commit**: if the file changed, the workflow commits and pushes it back to
   the default branch as `github-actions[bot]`. If nothing changed, the run
   exits without creating a commit.

## CSV format and Active columns

`arc56.links.csv` has three columns:

| Column        | Meaning                                                                                       |
| ------------- | ----------------------------------------------------------------------------------------------- |
| `ARC56URL`    | The raw-content URL of the `*.arc56.json` file.                                                |
| `ActiveFrom`  | The date (`YYYY-MM-DD`) from which this record is considered active. Set automatically to the date the row was first added. |
| `ActiveUntil` | The date this record stops being active, or **empty** if it's active indefinitely.             |

A record is active as long as today falls on or after `ActiveFrom` and
`ActiveUntil` is either empty or in the future. New rows added by the
pipeline always get `ActiveFrom` = today and `ActiveUntil` = empty (i.e.
active by default).

To manually deactivate a record, edit its `ActiveUntil` cell to a past or
current date and commit that change directly — the pipeline will never
overwrite or remove that row, so the manual edit sticks across future runs.

## Required GitHub secrets

| Secret name       | Required? | Purpose                                                                                                   |
| ------------------ | --------- | ----------------------------------------------------------------------------------------------------------- |
| `GH_SEARCH_TOKEN`  | Recommended | Personal Access Token used to authenticate the GitHub code search request.                                |
| `GITHUB_TOKEN`     | Built-in    | Automatically provided by GitHub Actions; used as a fallback for search and to push the commit back.       |

### Why a separate `GH_SEARCH_TOKEN`?

The default `GITHUB_TOKEN` that GitHub injects into every workflow run works
for authenticating search requests and for pushing the commit back to this
repository, so the pipeline **will run without any extra setup**. A dedicated
`GH_SEARCH_TOKEN` is still recommended because:

- It decouples the search step from the workflow run's own token, so you can
  reuse the exact same script locally (`GH_SEARCH_TOKEN=... python
  scripts/update_arc56_links.py`) to test or debug it outside of Actions.
- It gives you an obvious place to rotate/revoke a credential without
  touching repository permissions.

If `GH_SEARCH_TOKEN` is not set, the script automatically falls back to
`GITHUB_TOKEN`.

### Creating and adding `GH_SEARCH_TOKEN`

1. Create a GitHub Personal Access Token:
   - **Fine-grained token** (recommended): GitHub → Settings → Developer
     settings → Personal access tokens → Fine-grained tokens → **Generate new
     token**. No repository or organization access needs to be granted — the
     code search API only searches public repositories the token owner can
     see, and no write scopes are needed.
   - **Classic token** (alternative): GitHub → Settings → Developer settings →
     Personal access tokens (classic) → **Generate new token**. No scopes need
     to be checked for searching public code.
2. Copy the generated token.
3. In this repository, go to **Settings → Secrets and variables → Actions →
   New repository secret**.
4. Name it `GH_SEARCH_TOKEN` and paste the token value.
5. Save. The next scheduled or manually triggered run will pick it up
   automatically via `env: GH_SEARCH_TOKEN: ${{ secrets.GH_SEARCH_TOKEN }}` in
   the workflow.

### Permissions needed for the commit-back step

The workflow declares:

```yaml
permissions:
  contents: write
```

This lets the built-in `GITHUB_TOKEN` push the updated `arc56.links.csv`
directly to the default branch. If this repository has branch protection
rules on the default branch that block direct pushes (e.g. required pull
request reviews), the push step will fail — in that case, either:

- allow the `github-actions[bot]` actor to bypass the protection rule, or
- change the workflow to open a pull request instead of pushing directly
  (e.g. using `peter-evans/create-pull-request`).

## Failure handling

The script never overwrites `arc56.links.csv` unless the search completed
successfully:

- If any page fails after retries (HTTP errors, or GitHub's search backend
  returning 0 items for a page where results were expected — a known
  transient glitch), the script exits with a non-zero status **before**
  opening the output file, leaving the existing CSV untouched.
- If the search completes but returns zero results overall, the script also
  aborts without writing (mostly a defense-in-depth check now, since existing
  rows are merged rather than replaced — but it still guards against writing
  a file with no new rows added when a run is clearly broken).
- A non-zero exit from the script fails the workflow step, so the subsequent
  "Commit and push if changed" step never runs and no partial/empty file is
  ever committed.

## Known limitations

- **1,000-result cap, mostly worked around**: the GitHub code search API
  returns at most 1,000 results for any single query. The script shards by
  file `size:` range to get past this (see above), so it can recover results
  well beyond 1,000 total matches. It can still miss files in the rare case
  where a single size shard alone has more than 1,000 files of the *exact
  same size* — `MAX_SHARD_DEPTH` (25 halvings) caps how far it will keep
  splitting a range before giving up and logging a warning. Even then,
  nothing is lost permanently: since existing rows are never removed, any
  file already in the CSV stays there regardless of whether a later run
  happens to rediscover it, and the sharding means most previously
  unreachable files should get picked up on a subsequent run.
- **Search index freshness**: GitHub's code search index is not always
  instantaneous — very recently pushed files may not appear until the index
  catches up.
- **Rate limiting and run time**: the code search endpoint specifically is
  limited to about 10 requests/minute (stricter than the 30/minute limit for
  other search types), even when authenticated. The script waits 7 seconds
  before every call to stay under this limit; if you still see HTTP 403/429
  errors in the workflow logs, it will retry with exponential backoff. Since
  sharding by size issues multiple queries instead of one, a full run now
  takes noticeably longer (several minutes) than a single 1,000-result
  search would.
- **`HEAD` links can change silently**: because links point at `HEAD` rather
  than a fixed commit, the content behind a URL in `arc56.links.csv` can
  change (or disappear) if the source repository's default branch is
  rewritten, renamed, or the file is deleted/moved.

## Pull request validation

Any pull request that touches `arc56.links.csv` (including manual edits, not
just ones made by the update pipeline) is checked by
[`validate-arc56-links.yml`](../.github/workflows/validate-arc56-links.yml),
which runs [`scripts/validate_arc56_links.py`](../scripts/validate_arc56_links.py).
It requires no secrets — it only reads the repository's own git history — and
needs `permissions: contents: read`.

It compares the PR's version of the file against the base branch's version
and enforces:

1. **Schema**: the header must be exactly `ARC56URL,ActiveFrom,ActiveUntil`.
2. **URL suffix**: every `ARC56URL` must end with `.arc56.json`.
3. **No duplicate URLs**.
4. **Valid dates**: `ActiveFrom` must be a `YYYY-MM-DD` date; `ActiveUntil`
   must be empty or a `YYYY-MM-DD` date.
5. **Alphabetical order**: the `ARC56URL` column must be sorted
   alphabetically, case-insensitive.
6. **No removed records**: every `ARC56URL` present on the base branch must
   still be present in the PR (rows are deactivated, never deleted — see
   [CSV format and Active columns](#csv-format-and-active-columns)).
7. **Per-record change rules**, comparing each existing row to its base-branch
   version:
   - **New record** (URL not on the base branch): `ActiveFrom` must equal
     today's date and `ActiveUntil` must be empty.
   - **Updated record** (existing URL, `ActiveUntil` left/made empty): treated
     as a reactivation — `ActiveFrom` must equal today's date.
   - **Deleted/deactivated record** (existing URL, `ActiveUntil` set to
     today's date): `ActiveFrom` must be unchanged from the base branch.
   - Any other combination of changes to an existing record (e.g. `ActiveUntil`
     set to a date other than today, or `ActiveFrom` changed without
     `ActiveUntil` becoming empty) is rejected.
   - Rows that are byte-for-byte identical to the base branch are always
     allowed, regardless of the rules above.

"Today's date" is evaluated using the date the workflow runs (UTC, since
GitHub-hosted runners default to UTC) — not the date the PR was opened. If a
PR sits open across a day boundary, re-run the check (or push a new commit)
after updating the date.

### Requiring this check before merge

To actually block merges on failure, add `Validate ARC-56 links CSV / validate`
as a required status check under **Settings → Branches → Branch protection
rules** for the default branch.
