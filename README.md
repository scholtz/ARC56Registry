# Arc56Registry

An automatically maintained registry of every public [ARC-56](https://github.com/algorandfoundation/ARCs/blob/main/ARCs/arc-0056.md)
smart-contract spec on GitHub, and a pipeline that turns each one into a typed,
ready-to-use client library - in C#/.NET, TypeScript, and Python.

No one has to submit anything here manually: if your public repo has an
`*.arc56.json` file anywhere in it, this project finds it, and publishes a NuGet
package, an npm package, and a PyPI package with a typed client for it.

## Spread the word

We announced this registry on X - if you find it useful, please share/retweet the
post: [x.com/EAlgonaut/status/2079233299243757677](https://x.com/EAlgonaut/status/2079233299243757677).

Need help integrating with the registry or its generated clients? Join us on
[Discord](https://t.co/vv87GeXHrs).

## What's in this repo

| Path | What it is |
| --- | --- |
| [arc56.links.csv](arc56.links.csv) | The registry itself: every discovered `*.arc56.json` URL, with `ActiveFrom`/`ActiveUntil` columns controlling whether it's currently included. |
| [scripts/update_arc56_links.py](scripts/update_arc56_links.py) | Finds ARC-56 files on GitHub and updates the CSV. Never removes a row. |
| [scripts/validate_arc56_links.py](scripts/validate_arc56_links.py) | Pull-request check enforcing the CSV's schema and edit rules. |
| [scripts/download_arc56_specs.py](scripts/download_arc56_specs.py) | Downloads every active ARC-56 spec into `clients/<owner>/<repo>/arc56/` - shared by both client-generation pipelines below. |
| [scripts/generate_dotnet_clients.py](scripts/generate_dotnet_clients.py), [scripts/publish_dotnet_packages.py](scripts/publish_dotnet_packages.py) | Generate the C# clients, and separately publish the NuGet packages described below. |
| [scripts/generate_typescript_clients.py](scripts/generate_typescript_clients.py), [scripts/publish_npm_packages.py](scripts/publish_npm_packages.py) | Generate the TypeScript clients, and separately publish the npm packages described below. |
| [scripts/generate_python_clients.py](scripts/generate_python_clients.py), [scripts/publish_python_packages.py](scripts/publish_python_packages.py) | Generate the Python clients, and separately publish the PyPI packages described below. |
| [clients/](clients/) | One folder per GitHub repo (`clients/<owner>/<repo>/`), holding the shared downloaded `arc56/` specs plus one subfolder per ecosystem's generated client package - `dotnet/`, `npm/`, and `python/`. |
| [scripts/generate_hash_registry.py](scripts/generate_hash_registry.py) | Builds `approval-programs/`, `clear-programs/` (compiled-program SHA-256 hash to ARC-56 spec URL + a copy of the spec) and `abi-signatures/` (ARC-4 method selector to ABI method signature + apps using it), described below. |
| [approval-programs/](approval-programs/), [clear-programs/](clear-programs/) | The program hash registry: `<program>-programs/<hash[:3]>/<hash>.txt` (spec URL) and `<hash>.arc56.json` (a copy of that spec), one pair per distinct program hash. |
| [abi-signatures/](abi-signatures/) | The ABI method-signature registry: `abi-signatures/<selector[:2]>/<selector>.txt` (signature) and `<selector>.json` (signature + the apps that use it), one pair per distinct ARC-4 method selector. |
| [pages/index.html](pages/index.html) | Landing page for the registry's GitHub Pages site, published from the folders above. |
| [docker/hash-registry/](docker/hash-registry/) | Dockerfile + README + landing page for the `scholtz2/arc56-registry` Docker Hub image - an unprivileged nginx webserver serving the three folders above plus `arc56.links.csv` over HTTP, for self-hosted lookups. |
| [.github/workflows/](.github/workflows/) | The scheduled/triggered pipelines tying all of the above together. |
| [docs/](docs/) | Detailed docs for each pipeline (linked below). |

## The pipelines

### 1. Keeping the registry up to date

[`update-arc56-links.yml`](.github/workflows/update-arc56-links.yml) runs daily,
searches GitHub's code search API for `*.arc56.json` files (working around its
1,000-result cap by sharding the search), and merges any newly found URLs into
`arc56.links.csv`. [`validate-arc56-links.yml`](.github/workflows/validate-arc56-links.yml)
checks every pull request that touches the CSV against a strict set of rules (sorted,
well-formed, no silent deletions, correct `ActiveFrom`/`ActiveUntil` handling for new,
updated, and deactivated records).

Full details: **[docs/arc56-links-pipeline.md](docs/arc56-links-pipeline.md)**.

Rows are never deleted - a contract that should no longer be tracked is deactivated by
setting `ActiveUntil` to a date, not by removing its row. This matters because the
client-generation pipeline below keys everything off this file.

### 2. Generating typed clients (.NET, TypeScript, and Python)

All three client-generation pipelines share the same **download -> generate ->
publish** shape, split into three separate scripts/workflows so the slow,
rate-limited download step never blocks fast local generation, and publishing is a
simple "list what's already out, push what isn't" job with no coupling to generation
at all:

1. [`download-arc56-specs.yml`](.github/workflows/download-arc56-specs.yml) reads every
   *active* row in the CSV and downloads each spec (rate-limited to one download per
   7+ seconds) into `clients/<owner>/<repo>/arc56/` - **once**, shared by all three
   ecosystems below.
2. [`generate-dotnet-clients.yml`](.github/workflows/generate-dotnet-clients.yml) /
   [`generate-typescript-clients.yml`](.github/workflows/generate-typescript-clients.yml) /
   [`generate-python-clients.yml`](.github/workflows/generate-python-clients.yml)
   read those local specs (no network, no delay) and run them through the ARC-56
   client generators - [scholtz/dotnet-algorand-sdk](https://github.com/scholtz/dotnet-algorand-sdk)'s
   [`scholtz2/dotnet-avm-generated-client`](https://hub.docker.com/r/scholtz2/dotnet-avm-generated-client)
   Docker image for C#,
   [algorandfoundation/algokit-client-generator-ts](https://github.com/algorandfoundation/algokit-client-generator-ts)
   (via `npx`) for TypeScript, and
   [algorandfoundation/algokit-client-generator-py](https://github.com/algorandfoundation/algokit-client-generator-py)
   (via `pip`/`algokitgen-py`) for Python.
3. [`publish-dotnet-packages.yml`](.github/workflows/publish-dotnet-packages.yml) /
   [`publish-npm-packages.yml`](.github/workflows/publish-npm-packages.yml) /
   [`publish-python-packages.yml`](.github/workflows/publish-python-packages.yml) list
   every version **already published** straight from nuget.org / the npm registry /
   PyPI itself, and pack+push (or build+publish) only what's missing - rate-limited to
   one push every 5-20+ seconds depending on registry.

**One package per GitHub repository** (currently 505+ repos and growing) bundles every
contract found in that repo - `Arc56.Generated.<owner>.<repo>` on nuget.org,
`arc56-generated-<owner>-<repo>` on both npm and PyPI. Within a package, each contract
gets its own namespace/export/module incorporating both its filename and a hash of its
source URL, so identically-named specs in different parts of the same repo never
collide.

.NET versions follow `1.0.<increment>.<yyyyMMddHH>`; TypeScript and Python versions
both follow `1.<increment>.<yyyyMMddHH>` (npm requires strict 3-part semver, unlike
NuGet, and that same 3-part string happens to also be a valid PEP 440 version, so
Python reuses it as-is). A new version is published whenever a repo's ARC-56 content
changes, or whenever the relevant generator itself is updated (which forces every
package in that ecosystem to regenerate).

Full details, naming rules, and failure handling:
**[docs/dotnet-client-pipeline.md](docs/dotnet-client-pipeline.md)**,
**[docs/typescript-client-pipeline.md](docs/typescript-client-pipeline.md)**, and
**[docs/python-client-pipeline.md](docs/python-client-pipeline.md)**. npm and PyPI
publishing each need a one-time secret setup - see
**[docs/npm-publishing-setup.md](docs/npm-publishing-setup.md)** and
**[docs/pypi-publishing-setup.md](docs/pypi-publishing-setup.md)**.

### 3. Program hash registry

[`generate-hash-registry.yml`](.github/workflows/generate-hash-registry.yml) walks
every `*.arc56.json` file in the repo, hashes its compiled approval and clear-state
programs with SHA-256, and writes `approval-programs/<hash[:3]>/<hash>.txt` and
`clear-programs/<hash[:3]>/<hash>.txt` containing a durable URL back to the matching
spec (pinned to the commit that last touched it, so the link survives later edits to
the source file), plus `<hash>.arc56.json` right next to it - a byte-for-byte copy of
that same spec, so a consumer that only has the hash can decode a call in one fetch
instead of two. [`deploy-hash-registry-pages.yml`](.github/workflows/deploy-hash-registry-pages.yml)
then publishes both folders, plus a developer-facing usage guide, to
**[scholtz.github.io/ARC56Registry](https://scholtz.github.io/ARC56Registry/)**.

The point: a wallet about to send an app call to some deployed application usually
only has the app ID. It can fetch the app's compiled programs from the network, hash
them, and look up that hash here to find a real ARC-56 spec it can use to decode the
call - method name, argument types, everything - instead of showing the user an
opaque raw transaction.

Full details, including how duplicate hashes are resolved: **[docs/hash-registry.md](docs/hash-registry.md)**.

The same script and workflow also build an **ABI method-signature registry**:
`abi-signatures/<selector[:2]>/<selector>.txt`, keyed by each ARC-56 method's ARC-4
selector (the first 4 bytes of `SHA-512/256` over its ABI signature string), containing
that plain-text signature - e.g. `abi-signatures/8a/8aa3b61f.txt` contains
`add(uint64,uint64)uint128`. Right next to it, `<selector>.json` holds a pretty-printed
`{"abi": "add(uint64,uint64)uint128", "apps": ["<hash1>", "<hash2>", ...]}`, where
`apps` is the sorted list of approval-program hashes (the same hashes that key
`approval-programs/`) of every indexed app that exposes this method. It's published on
the same GitHub Pages site, and lets a wallet that only has a 4-byte method selector
(decoded from an app-call transaction's args) recover a human-readable method signature
- and the set of known apps using it - without needing the whole ARC-56 spec resolved
first.

The same three folders, plus `arc56.links.csv` itself, are also published as a
self-hosted webserver image,
[`scholtz2/arc56-registry`](https://hub.docker.com/r/scholtz2/arc56-registry) (an
unprivileged nginx container listening on port 8080, tagged with today's UTC date and
`latest`), by
[`publish-docker-hash-registry.yml`](.github/workflows/publish-docker-hash-registry.yml),
so a wallet can `docker run` its own local mirror of the whole registry instead of
depending on GitHub Pages being reachable at call time - see
**[docs/docker-hash-registry.md](docs/docker-hash-registry.md)**.

## Status

- ✅ Registry discovery + validation (arc56.links.csv)
- ✅ .NET/C# client generation pipeline (download -> generate -> publish)
- ✅ TypeScript client generation pipeline (download -> generate -> publish)
- ✅ Python client generation pipeline (download -> generate -> publish)
- ✅ Program hash registry (approval-programs/, clear-programs/) + GitHub Pages site
- ✅ ABI method-signature registry (abi-signatures/) + GitHub Pages site
- ✅ Docker Hub image (`scholtz2/arc56-registry`) - workflow wired up, but needs a
  one-time Docker Hub account + `DOCKERHUB_USERNAME`/`DOCKERHUB_TOKEN` repo secrets
  before it actually publishes (see
  [docs/dockerhub-publishing-setup.md](docs/dockerhub-publishing-setup.md))
- ✅ Automated `dotnet nuget push` to nuget.org - wired up via Trusted Publishing (OIDC),
  but needs a one-time `NUGET_USER` repo secret + nuget.org policy before it actually
  publishes (see [docs/dotnet-client-pipeline.md](docs/dotnet-client-pipeline.md#publishing-to-nugetorg))
- ✅ Automated `npm publish` - wired up, but needs a one-time `NPM_TOKEN` repo secret
  before it actually publishes (see [docs/npm-publishing-setup.md](docs/npm-publishing-setup.md))
- ✅ Automated `twine upload` to PyPI - wired up, but needs a one-time `PYPI_TOKEN` repo
  secret before it actually publishes (see [docs/pypi-publishing-setup.md](docs/pypi-publishing-setup.md))

## Contributing

- To add or fix a discovered ARC-56 URL by hand, edit `arc56.links.csv` directly - see
  [docs/arc56-links-pipeline.md](docs/arc56-links-pipeline.md#pull-request-validation)
  for the exact rules the PR check enforces.
- To change how .NET clients are generated or packaged, see
  [docs/dotnet-client-pipeline.md](docs/dotnet-client-pipeline.md) and
  `clients/_template/`.
- To change how TypeScript clients are generated or packaged, see
  [docs/typescript-client-pipeline.md](docs/typescript-client-pipeline.md) and
  `clients/_template_npm/`.
- To change how Python clients are generated or packaged, see
  [docs/python-client-pipeline.md](docs/python-client-pipeline.md) and
  `clients/_template_python/`.
