# ARC-56 program hash + ABI signature registry (Docker image)

Look up a deployed Algorand app's compiled TEAL by SHA-256 hash and get back a real
[ARC-56](https://github.com/algorandfoundation/ARCs/blob/main/ARCs/arc-0056.md) spec
you can use to decode its calls - or look up a raw 4-byte ARC-4 method selector and
get back the human-readable method signature it came from. **This image is a
self-hosted webserver: run it, and every lookup below is a plain HTTP request against
your own container - no dependency on a third-party host at call time.**

This is the same registry published at
[scholtz.github.io/ARC56Registry](https://scholtz.github.io/ARC56Registry/) and
maintained in [scholtz/ARC56Registry](https://github.com/scholtz/ARC56Registry),
repackaged as `scholtz2/arc56-registry`: an unprivileged
[nginx](https://hub.docker.com/r/nginxinc/nginx-unprivileged) container serving the
registry's static files, so a wallet can run its own local/private mirror instead of
depending on GitHub Pages being reachable at call time.

## Why this exists

A wallet about to send an application call usually only has the app ID. It can fetch
the app's compiled approval and clear programs from the network, but without a spec it
has no idea what methods exist, what arguments they take, or how to render the call to
a user instead of a wall of opaque bytes.

This registry closes that gap: every ARC-56 spec indexed by
[scholtz/ARC56Registry](https://github.com/scholtz/ARC56Registry) has its compiled
approval and clear programs hashed with SHA-256, and each hash maps to a full copy of
a matching spec. Running this image gives you your own HTTP endpoint serving that
whole dataset, refreshed by re-pulling `latest` (or a dated tag) and restarting the
container, instead of hitting GitHub Pages for every lookup.

## Running the image

```bash
docker run -d --name arc56-registry -p 8080:8080 scholtz2/arc56-registry:latest
curl http://localhost:8080/README.md
```

Listens on port `8080` as an **unprivileged, non-root** nginx process (runs as uid
`101`, the image's default user) - no `--user root`, no `--cap-add`, no privileged
port binding needed to run it anywhere, including under container platforms that
enforce non-root policies. Visiting `http://localhost:8080/` in a browser serves a
landing page with the same content as this README, plus worked examples.

## Tags

```bash
docker pull scholtz2/arc56-registry:latest
# or pin to a specific day's snapshot, e.g.:
docker pull scholtz2/arc56-registry:2026-07-19
```

`latest` always points at the most recently published snapshot; a `YYYY-MM-DD`-dated
tag (UTC) is kept for every past publish so you can pin to a known snapshot instead of
floating on `latest`.

## What's in this image

```
/usr/share/nginx/html/approval-programs/<hash[:3]>/<hash>.txt         # keyed by sha256(byteCode.approval)
/usr/share/nginx/html/approval-programs/<hash[:3]>/<hash>.arc56.json  # keyed by sha256(byteCode.approval)
/usr/share/nginx/html/clear-programs/<hash[:3]>/<hash>.txt            # keyed by sha256(byteCode.clear)
/usr/share/nginx/html/clear-programs/<hash[:3]>/<hash>.arc56.json     # keyed by sha256(byteCode.clear)
/usr/share/nginx/html/abi-signatures/<selector[:2]>/<selector>.txt    # keyed by the method's ARC-4 selector
/usr/share/nginx/html/abi-signatures/<selector[:2]>/<selector>.json   # keyed by the method's ARC-4 selector
/usr/share/nginx/html/arc56.links.csv                                 # the full registry: every discovered ARC-56 spec URL
/usr/share/nginx/html/README.md                                      # this file
/usr/share/nginx/html/index.html                                     # the landing page served at /
```

nginx serves all of the above at the container's document root, so from outside the
container every path above is just `http://<host>:8080/approval-programs/...`,
`/clear-programs/...`, `/abi-signatures/...`, `/arc56.links.csv`, `/README.md`, or
`/`.

Splitting on the hash's/selector's first few hex characters keeps any one folder from
holding thousands of files. Each program-hash `.txt` file contains exactly one line: a
`raw.githubusercontent.com` URL pinned to the commit that last touched the matching
ARC-56 spec, so it keeps resolving to the exact spec that produced this hash even
after the source file is edited or replaced later. The `.arc56.json` file right next
to it is a byte-for-byte copy of that same spec, so you can skip resolving the URL
entirely and read the full spec straight from this server. Each `abi-signatures/`
`.txt` file contains the plain-text ABI method signature itself, e.g.
`add(uint64,uint64)uint128`, and its `.json` file holds that signature plus the sorted
list of approval-program hashes of every indexed app known to expose it.

## How to look up a hash

1. Fetch the app's compiled programs, e.g. via algod's `GET /v2/applications/{app-id}`,
   and base64-decode `params.approval-program` and/or `params.clear-state-program`.
2. Compute `sha256(program_bytes)`, hex-encoded, lowercase.
3. Fetch this hash's spec from your running container -
   `http://<host>:8080/approval-programs/<hash[:3]>/<hash>.arc56.json` or
   `.../clear-programs/<hash[:3]>/<hash>.arc56.json`. A 404 just means this registry
   hasn't indexed a spec producing that hash yet, not an error.
4. If found, it's the full ARC-56 JSON spec - use it directly to decode the app's
   methods, argument types, and state layout. (The `.txt` file at the same path
   instead holds a durable, commit-pinned URL to the spec's source location, if you
   want that instead of the copy.)

### Example: program hash to spec

```python
import base64, hashlib, json, urllib.request

app_id = 123456789
info = json.load(urllib.request.urlopen(f"https://mainnet-api.algonode.cloud/v2/applications/{app_id}"))
approval = base64.b64decode(info["params"]["approval-program"])
digest = hashlib.sha256(approval).hexdigest()

lookup_url = f"http://localhost:8080/approval-programs/{digest[:3]}/{digest}.arc56.json"
try:
    spec = json.load(urllib.request.urlopen(lookup_url))
    print("Found spec for", spec["name"])
except urllib.error.HTTPError:
    print("No ARC-56 spec indexed for this program yet")
```

## How to look up a method selector

Every ARC-4/ARC-56 application call's first argument is a 4-byte method *selector*:
the first 4 bytes of `SHA-512/256` (not SHA-256) over the method's ABI signature
string, `name(argtype,argtype,...)returntype`. If you've extracted that selector from
a transaction but don't have the app's ARC-56 spec, this registry can still resolve it
to a human-readable signature:

1. Hex-encode the 4 selector bytes, lowercase, e.g. `8aa3b61f`.
2. Fetch `http://<host>:8080/abi-signatures/<selector[:2]>/<selector>.json` from your
   running container. A 404 just means this registry hasn't indexed a method with that
   selector yet, not an error.
3. If found, it's a JSON object `{"abi": "<signature>", "apps": [...]}` - `abi` is the
   plain-text ABI signature, e.g. `add(uint64,uint64)uint128`, and `apps` is the
   sorted list of approval-program hashes of every indexed app known to expose it.

### Example: method selector to signature

```python
import urllib.request, json

selector = "8aa3b61f"  # first 4 bytes of an app call's method-call arg, hex-encoded
lookup_url = f"http://localhost:8080/abi-signatures/{selector[:2]}/{selector}.json"
try:
    entry = json.load(urllib.request.urlopen(lookup_url))
    print("Selector resolves to", entry["abi"])  # add(uint64,uint64)uint128
    print("Known apps:", entry["apps"])
except urllib.error.HTTPError:
    print("No ABI method indexed for this selector yet")
```

## Browsing the full registry (arc56.links.csv)

The three lookups above only cover ARC-56 specs whose *compiled* programs have been
successfully hashed. `arc56.links.csv` is the underlying source list this whole
project is built from: every `*.arc56.json` file discovered on GitHub, one row per
spec, with `ActiveFrom`/`ActiveUntil` columns marking whether it's currently
considered active (rows are never deleted - a retired spec is deactivated by setting
`ActiveUntil`, not removed). Useful if you want to enumerate every known spec
directly, independent of the hash tables:

```bash
curl -s http://localhost:8080/arc56.links.csv | head
```

```csv
ARC56URL,ActiveFrom,ActiveUntil
https://raw.githubusercontent.com/<owner>/<repo>/HEAD/path/to/spec.arc56.json,2026-07-16,
```

A row is active when `ActiveFrom <= today` and (`ActiveUntil` is empty or in the
future). See
[docs/arc56-links-pipeline.md](https://github.com/scholtz/ARC56Registry/blob/main/docs/arc56-links-pipeline.md)
for the full column/lifecycle rules. Note this file is **not** part of the GitHub
Pages site - it's only published here and in the source repo itself.

## Getting the raw files onto disk instead

If you'd rather have the folders as plain files (e.g. to bundle into another image's
build) than query them over HTTP, `docker cp` still works - this is a normal
filesystem, not a scratch/data-only image:

```bash
id=$(docker create scholtz2/arc56-registry:latest)
docker cp "$id":/usr/share/nginx/html/approval-programs ./approval-programs
docker cp "$id":/usr/share/nginx/html/clear-programs ./clear-programs
docker cp "$id":/usr/share/nginx/html/abi-signatures ./abi-signatures
docker cp "$id":/usr/share/nginx/html/arc56.links.csv ./arc56.links.csv
docker rm "$id"
```

Or in a multi-stage `Dockerfile`:

```dockerfile
FROM scholtz2/arc56-registry:latest AS registry
FROM your-wallet-base-image
COPY --from=registry /usr/share/nginx/html/approval-programs /data/approval-programs
COPY --from=registry /usr/share/nginx/html/clear-programs /data/clear-programs
COPY --from=registry /usr/share/nginx/html/abi-signatures /data/abi-signatures
COPY --from=registry /usr/share/nginx/html/arc56.links.csv /data/arc56.links.csv
```

## Freshness

Both program-hash tables and the ABI signature registry are regenerated daily by
[generate-hash-registry.yml](https://github.com/scholtz/ARC56Registry/blob/main/.github/workflows/generate-hash-registry.yml),
and `arc56.links.csv` is separately updated daily by
[update-arc56-links.yml](https://github.com/scholtz/ARC56Registry/blob/main/.github/workflows/update-arc56-links.yml).
This image is rebuilt and republished after either one finishes, by
[publish-docker-hash-registry.yml](https://github.com/scholtz/ARC56Registry/blob/main/.github/workflows/publish-docker-hash-registry.yml)
- the same underlying data as the [GitHub Pages site](https://scholtz.github.io/ARC56Registry/)
for the hash/ABI tables (plus `arc56.links.csv`, which the Pages site doesn't publish),
just served from your own container instead. Re-pull `latest` (or a newer dated tag)
and restart the container to pick up the newest snapshot. If two indexed specs
compile to the same program bytes, the hash points at whichever spec file is larger
(generally the more complete one) - see
[docs/hash-registry.md](https://github.com/scholtz/ARC56Registry/blob/main/docs/hash-registry.md)
for the exact tie-breaking rule and the ABI signature registry's own rules.

## Source

[github.com/scholtz/ARC56Registry](https://github.com/scholtz/ARC56Registry)
