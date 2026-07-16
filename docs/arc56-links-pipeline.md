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
   `arc56.json in:path`, paginating through up to 1,000 results (the maximum
   the search API returns for any single query). Note: the newer glob syntax
   `path:**/*.arc56.json` (used by the github.com/search web UI) is **not**
   supported by the legacy REST `search/code` endpoint and silently returns
   zero results, which is why the query is phrased as a plain substring match
   instead.
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
6. **Dedupe & sort**: the resulting URLs are de-duplicated and sorted
   alphabetically (case-insensitive).
7. **Write**: `arc56.links.csv` is rewritten with a single header line
   (`ARC56URL`) followed by one URL per line.
8. **Commit**: if the file changed, the workflow commits and pushes it back to
   the default branch as `github-actions[bot]`. If nothing changed, the run
   exits without creating a commit.

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

## Known limitations

- **1,000-result cap**: the GitHub code search API returns at most 1,000
  results per query (10 pages of 100). If the number of `*.arc56.json` files
  on GitHub grows beyond that, some files may not appear in the CSV. There is
  no pagination workaround for this GitHub API limit.
- **Search index freshness**: GitHub's code search index is not always
  instantaneous — very recently pushed files may not appear until the index
  catches up.
- **Rate limiting**: authenticated code search requests are limited to about
  30 requests/minute. The script pauses between pages to stay under this
  limit; if you see HTTP 403/429 errors in the workflow logs, GitHub's search
  rate limit was hit and the script will retry with backoff.
- **`HEAD` links can change silently**: because links point at `HEAD` rather
  than a fixed commit, the content behind a URL in `arc56.links.csv` can
  change (or disappear) if the source repository's default branch is
  rewritten, renamed, or the file is deleted/moved.
