# Program hash registry

This pipeline turns every `*.arc56.json` file in the repo into lookup entries keyed by
the SHA-256 hash of its compiled **approval** and **clear-state** programs, and every
ARC-56 **method** into a lookup entry keyed by its ARC-4 method selector, via
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
approval-programs/<hash[:3]>/<hash>.txt         # keyed by sha256(byteCode.approval)
approval-programs/<hash[:3]>/<hash>.arc56.json  # keyed by sha256(byteCode.approval)
clear-programs/<hash[:3]>/<hash>.txt            # keyed by sha256(byteCode.clear)
clear-programs/<hash[:3]>/<hash>.arc56.json     # keyed by sha256(byteCode.clear)
abi-signatures/<selector[:2]>/<selector>.txt    # keyed by the method's ARC-4 selector
abi-signatures/<selector[:2]>/<selector>.json   # keyed by the method's ARC-4 selector
```

Each `.txt` file under `approval-programs/`/`clear-programs/` contains one line: the
`raw.githubusercontent.com` URL of the ARC-56 spec whose program hashes to `<hash>`,
pinned to the commit that last touched that spec file - not the commit that happens to
be `HEAD` when the registry was regenerated. That's what makes the link durable: even
after the source spec is edited, replaced, or the repo's history moves on, this URL
keeps resolving to the exact bytes that produced this hash.

The `.arc56.json` file next to it is a byte-for-byte copy of that same winning spec
file, placed directly in the hash registry. This means a consumer that has just hashed
a deployed app's compiled program doesn't need a second fetch to resolve the `.txt`
file's URL before it can decode a call - it can read `<hash>.arc56.json` straight out
of this repo (or its GitHub Pages mirror) and get the full spec in one request. The
`.txt` file is still written and kept, since its durable, commit-pinned URL is useful
to consumers that want to track a spec's source history rather than a snapshot.

Splitting into `<hash[:3]>/` subfolders keeps any single directory from holding
thousands of files.

Clear-state programs collide far more than approval programs (many contracts share a
trivial `return 1`-style clear program byte-for-byte), so `clear-programs/` has far
fewer distinct hash files than `approval-programs/` - that's expected, not a bug.

## GitHub Pages site

`deploy-hash-registry-pages.yml` runs after every successful hash-registry
regeneration (via a `workflow_run` trigger) and publishes `approval-programs/`,
`clear-programs/`, `abi-signatures/`, and [`pages/index.html`](../pages/index.html) (a
developer-facing page explaining how to hash a program and look it up) as a static
site at `https://scholtz.github.io/ARC56Registry/`.

This exists because the hash *tables themselves* need a stable entry point - a
consumer shouldn't need to know a commit SHA just to fetch
`approval-programs/<hash[:3]>/<hash>.txt`. The Pages site always serves the latest
tables off `main`. Only the *targets* those tables point to (the ARC-56 spec URLs
inside each `.txt` file) stay commit-pinned, per the durability requirement above.

Requires a one-time, non-code repo setting: **Settings > Pages > Source: "GitHub
Actions"**. Nothing else needs configuring; the workflow handles the rest.

## Docker Hub image

The same three folders are also published as a self-hosted webserver image,
[`scholtz2/arc56-registry`](https://hub.docker.com/r/scholtz2/arc56-registry) (an
unprivileged nginx container listening on port 8080), tagged with today's UTC date and
`latest`, so a wallet can run its own local mirror instead of depending on the GitHub
Pages site being reachable at call time. See
**[docs/docker-hash-registry.md](docker-hash-registry.md)**.

## How to use it (as a consumer)

1. Fetch the target app's compiled programs (e.g. via `algod`'s
   `/v2/applications/{app-id}` endpoint, fields `params.approval-program` and/or
   `params.clear-state-program`, base64 decoded).
2. Compute `sha256(program_bytes)`, hex-encoded.
3. Fetch `https://scholtz.github.io/ARC56Registry/approval-programs/<hash[:3]>/<hash>.arc56.json`
   (or `clear-programs/...` for the clear program) - or, if you have the repo checked
   out, read the file directly. This is the full ARC-56 spec already - use it directly
   to decode the app call, no second fetch needed.
4. If you'd rather resolve to the spec's durable, commit-pinned source location instead
   of reading the copy in the registry, fetch the `.txt` file at the same path instead;
   its content is a URL to the matching ARC-56 spec.

A missing file just means this registry hasn't indexed a spec for that program yet
(or the program isn't ARC-56 at all) - not an error. See
[pages/index.html](../pages/index.html) for a worked example.

## How entries are chosen

Identical program bytes always hash identically, so a hash collision here means
multiple ARC-56 spec files in this repo describe the very same on-chain program
(vendored copies, forks, near-duplicate example repos, shared clear programs, etc.).
When that happens, the registry keeps a link (and a copy) of the **largest** of those
spec files (by file size) - larger generally means a more complete spec (fuller
`structs`, `sourceInfo`, docs), which is more useful to a wallet trying to decode a
call. Candidates are visited in a fixed, deterministic order (sorted by repo-relative
path); the first file seen for a given hash becomes the current winner, and a later
file only replaces it if it's *strictly* larger. A later file that's the same size or
smaller never displaces the existing link - the first one found is trusted as good
enough. Approval and clear hashes are picked independently of each other. Both the
`.txt` URL and the `.arc56.json` copy always point at the same winning spec file for a
given hash - there is only ever one winner per hash, not one winner per file type.

Because the winner is recomputed by rule on every run (not just carried forward from
the previous run's output), the registry is self-healing: if a newly indexed repo
turns out to hold a larger copy of an already-known program, the next scheduled run
repoints the hash file - and rewrites the `.arc56.json` copy - at it.

Existing files under `approval-programs/**` and `clear-programs/**` are only ever
added or updated in place, matching the rest of this repo's "never silently delete"
convention (see the main [CLAUDE.md](../CLAUDE.md)) - though unlike `arc56.links.csv`
and `clients/**`, an existing hash file's *content* can legitimately change (to a
longer spec for the same hash), since it's a derived pointer/copy, not a historical
record. This applies equally to `<hash>.txt` and `<hash>.arc56.json`.

## ABI method-signature registry

Separately from the two program-hash tables above (same script, same workflow, no
relation to `byteCode` at all), the script also walks every `methods[]` entry of every
indexed ARC-56 spec and writes:

```
abi-signatures/<selector[:2]>/<selector>.txt
abi-signatures/<selector[:2]>/<selector>.json
```

`<selector>` is the lowercase 8-hex-char ARC-4 method selector - the first 4 bytes of
`SHA-512/256` (**not** SHA-256) over the ABI method signature string
`name(argtype,argtype,...)returntype` - the same selector Algorand uses on-chain to
route an application call to the right method. The `.txt` file's content is that exact
signature string. For example, `add(uint64,uint64)uint128` hashes to selector
`8aa3b61f`, so the registry contains `abi-signatures/8a/8aa3b61f.txt` with the single
line `add(uint64,uint64)uint128`.

Struct-typed args and return values use the plain ABI tuple type already present in
each arg/return's `type` field - never the human-readable `struct` name ARC-56 also
carries alongside it (e.g. `{"type": "(string,uint64)", "struct": "EscrowConfig"}`) -
because the on-chain selector is computed over the ABI type, not the struct name. A
method with no return value uses the literal `void`, per the ARC-4 selector
convention.

Unlike the program-hash tables, there's no "pick the bigger one" tie-break here: for a
given selector, the signature string is fully determined by the hash (barring an
astronomically unlikely SHA-512/256 collision), so the first signature seen for a
selector is written and any later duplicate is simply skipped without comparison. If a
genuine collision is ever found (two different signatures hashing to the same 4-byte
selector), the script logs a warning and keeps the first one - see
`build_abi_signature_registry` in
[`scripts/generate_hash_registry.py`](../scripts/generate_hash_registry.py).

This lets a wallet that already knows an app's ABI method selector (e.g. from decoding
the first 4 bytes of an application-call transaction's args, without needing the whole
ARC-56 spec resolved first) recover the human-readable method signature directly -
useful for showing a preview of what a transaction calls before the full spec lookup
(via `approval-programs/`/`clear-programs/`) resolves.

The `.json` file next to it is a pretty-printed JSON object of the form:

```json
{
  "abi": "add(uint64,uint64)uint128",
  "apps": [
    "3b519ab76aa327a8aa169563711f923056b7f2244f9cf5ff2a59706a827b2be5",
    "919b031c47d5e7f763a470376b194bf8ce75cf4571f448ced2ec48cd3279ae29"
  ]
}
```

`apps` is the sorted list of SHA-256 approval-program hashes (the same hashes that key
`approval-programs/`) of every indexed app whose ARC-56 spec declares a method with
this selector. Unlike the "first one wins" rule for `abi`, `apps` is a **union across
every indexed spec** sharing the selector, not just the current winner's spec - the
point of this list is to name every known app exposing the method, not to pick one
best spec. This lets a consumer go straight from a decoded method selector to "which
apps in this registry are known to expose this method" without walking every indexed
spec itself.

## Running locally

```bash
python scripts/generate_hash_registry.py --dry-run   # preview what would change
python scripts/generate_hash_registry.py              # write approval-programs/, clear-programs/, abi-signatures/
```

Needs a full (non-shallow) git history to resolve `git log -1 --format=%H -- <path>`
correctly for every spec file - the GitHub Actions workflow checks out with
`fetch-depth: 0` for this reason.
