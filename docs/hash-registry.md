# Program hash registry

This pipeline turns every `*.arc56.json` file in the repo into lookup entries keyed by
the SHA-256 hash of its compiled **approval** and **clear-state** programs, via
[`generate-hash-registry.yml`](../.github/workflows/generate-hash-registry.yml) and
[`scripts/generate_hash_registry.py`](../scripts/generate_hash_registry.py). A second
workflow, [`deploy-hash-registry-pages.yml`](../.github/workflows/deploy-hash-registry-pages.yml),
publishes the result as a static site on GitHub Pages.

## Why

A wallet (or any indexer/client) that's about to send an app call to some deployed
Algorand application usually only has the app ID - it has to fetch the app's compiled
programs from the network before it knows anything about how to call it. If either
program's SHA-256 hash matches one already known here, the wallet can jump straight to
a real ARC-56 spec and decode the app's methods, argument types, and
box/global/local state layout, instead of showing the user an opaque raw transaction.

## Layout

```
approval-programs/<hash[:3]>/<hash>.txt   # keyed by sha256(byteCode.approval)
clear-programs/<hash[:3]>/<hash>.txt      # keyed by sha256(byteCode.clear)
```

Each `.txt` file contains one line: the `raw.githubusercontent.com` URL of the ARC-56
spec whose program hashes to `<hash>`, pinned to the commit that last touched that
spec file - not the commit that happens to be `HEAD` when the registry was
regenerated. That's what makes the link durable: even after the source spec is
edited, replaced, or the repo's history moves on, this URL keeps resolving to the
exact bytes that produced this hash.

Splitting into `<hash[:3]>/` subfolders keeps any single directory from holding
thousands of files.

Clear-state programs collide far more than approval programs (many contracts share a
trivial `return 1`-style clear program byte-for-byte), so `clear-programs/` has far
fewer distinct hash files than `approval-programs/` - that's expected, not a bug.

## GitHub Pages site

`deploy-hash-registry-pages.yml` runs after every successful hash-registry
regeneration (via a `workflow_run` trigger) and publishes `approval-programs/`,
`clear-programs/`, and [`pages/index.html`](../pages/index.html) (a developer-facing
page explaining how to hash a program and look it up) as a static site at
`https://scholtz.github.io/ARC56Registry/`.

This exists because the hash *tables themselves* need a stable entry point - a
consumer shouldn't need to know a commit SHA just to fetch
`approval-programs/<hash[:3]>/<hash>.txt`. The Pages site always serves the latest
tables off `main`. Only the *targets* those tables point to (the ARC-56 spec URLs
inside each `.txt` file) stay commit-pinned, per the durability requirement above.

Requires a one-time, non-code repo setting: **Settings > Pages > Source: "GitHub
Actions"**. Nothing else needs configuring; the workflow handles the rest.

## How to use it (as a consumer)

1. Fetch the target app's compiled programs (e.g. via `algod`'s
   `/v2/applications/{app-id}` endpoint, fields `params.approval-program` and/or
   `params.clear-state-program`, base64 decoded).
2. Compute `sha256(program_bytes)`, hex-encoded.
3. Fetch `https://scholtz.github.io/ARC56Registry/approval-programs/<hash[:3]>/<hash>.txt`
   (or `clear-programs/...` for the clear program) - or, if you have the repo checked
   out, read the file directly.
4. If it exists, its content is a URL to the matching ARC-56 spec - fetch that and use
   it to decode the app call.

A missing file just means this registry hasn't indexed a spec for that program yet
(or the program isn't ARC-56 at all) - not an error. See
[pages/index.html](../pages/index.html) for a worked example.

## How entries are chosen

Identical program bytes always hash identically, so a hash collision here means
multiple ARC-56 spec files in this repo describe the very same on-chain program
(vendored copies, forks, near-duplicate example repos, shared clear programs, etc.).
When that happens, the registry keeps a link to the **largest** of those spec files
(by file size) - larger generally means a more complete spec (fuller `structs`,
`sourceInfo`, docs), which is more useful to a wallet trying to decode a call.
Candidates are visited in a fixed, deterministic order (sorted by repo-relative
path); the first file seen for a given hash becomes the current winner, and a later
file only replaces it if it's *strictly* larger. A later file that's the same size or
smaller never displaces the existing link - the first one found is trusted as good
enough. Approval and clear hashes are picked independently of each other.

Because the winner is recomputed by rule on every run (not just carried forward from
the previous run's output), the registry is self-healing: if a newly indexed repo
turns out to hold a larger copy of an already-known program, the next scheduled run
repoints the hash file at it.

Existing files under `approval-programs/**` and `clear-programs/**` are only ever
added or updated in place, matching the rest of this repo's "never silently delete"
convention (see the main [CLAUDE.md](../CLAUDE.md)) - though unlike `arc56.links.csv`
and `clients/**`, an existing hash file's *content* can legitimately change (to a
longer spec for the same hash), since it's a derived pointer, not a historical
record.

## Running locally

```bash
python scripts/generate_hash_registry.py --dry-run   # preview what would change
python scripts/generate_hash_registry.py              # write approval-programs/, clear-programs/
```

Needs a full (non-shallow) git history to resolve `git log -1 --format=%H -- <path>`
correctly for every spec file - the GitHub Actions workflow checks out with
`fetch-depth: 0` for this reason.
