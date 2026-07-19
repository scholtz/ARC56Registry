# Arc56Registry - instructions for Claude

Registry of public ARC-56 smart-contract specs + a pipeline that generates typed client
libraries from them. Full narrative docs live in [README.md](README.md) and
[docs/](docs/) - read this file first, only open those for details this file doesn't
cover.

## Repo map

- `arc56.links.csv` - the registry. Columns: `ARC56URL,ActiveFrom,ActiveUntil`.
- `scripts/update_arc56_links.py` - finds new ARC-56 files on GitHub, merges into the CSV.
  Skips any repo listed in `scripts/repo_blacklist.txt` (this repo itself is blacklisted
  by default, since its own `*.arc56.json` files are examples/fixtures, not real specs
  meant to be registered; add more `owner/repo` lines there to blacklist others).
- `scripts/validate_arc56_links.py` - PR check enforcing the CSV's rules.
- **Client generation is a 3-stage pipeline, run three times (once per ecosystem) -
  download is shared, generate/publish are per-ecosystem:**
  - `scripts/download_arc56_specs.py` - stage 1 (shared): downloads every active ARC-56
    spec into `clients/<owner>/<repo>/arc56/`.
  - `scripts/generate_dotnet_clients.py` - stage 2 (.NET): reads local specs, generates
    C# source, no network, no publish.
  - `scripts/publish_dotnet_packages.py` - stage 3 (.NET): lists nuget.org's actually-
    published versions, packs+pushes only what's missing.
  - `scripts/generate_typescript_clients.py` - stage 2 (TypeScript): reads local specs,
    generates TS source via `npx @algorandfoundation/algokit-client-generator`, no
    network, no publish.
  - `scripts/publish_npm_packages.py` - stage 3 (TypeScript): lists the npm registry's
    actually-published versions, builds+publishes only what's missing.
  - `scripts/generate_python_clients.py` - stage 2 (Python): reads local specs,
    generates Python source via `algokitgen-py` (the `algokit-client-generator` PyPI
    package's console script), no network beyond a once-per-run PyPI version check +
    `pip install` of the generator itself, no publish.
  - `scripts/publish_python_packages.py` - stage 3 (Python): lists PyPI's actually-
    published versions, builds (`python -m build`) + publishes (`twine`) only what's
    missing.
  - See [docs/dotnet-client-pipeline.md](docs/dotnet-client-pipeline.md),
    [docs/typescript-client-pipeline.md](docs/typescript-client-pipeline.md), and
    [docs/python-client-pipeline.md](docs/python-client-pipeline.md).
- `clients/<owner>/<repo>/arc56/` - downloaded ARC-56 specs, shared across every
  ecosystem's generated client for that repo. `clients/<owner>/<repo>/dotnet/`,
  `clients/<owner>/<repo>/npm/`, and `clients/<owner>/<repo>/python/` are the
  per-ecosystem generated packages.
- `clients/_template/` - shared .NET csproj/README templates + shared package icon.
- `clients/_template_npm/` - shared npm package.json/tsconfig.json/README templates.
- `clients/_template_python/` - shared pyproject.toml/README templates.
- `scripts/generate_hash_registry.py` - builds `approval-programs/` and
  `clear-programs/`, lookups from SHA-256(approval program) / SHA-256(clear program)
  to a durable URL of the matching ARC-56 spec (`<hash>.txt`) *and* a byte-for-byte
  copy of that same spec placed right next to it (`<hash>.arc56.json`), so a consumer
  that only has the hash can decode calls in one fetch instead of two. Lets a wallet
  that only has a deployed app's compiled bytecode find a spec to decode calls against
  it. The same script also builds `abi-signatures/`, a lookup from ARC-4 method
  selector (4-byte SHA-512/256 of the ABI method signature) to the plain-text
  signature string (`<selector>.txt`, e.g. `add(uint64,uint64)uint128` for selector
  `8aa3b61f`) plus a JSON file (`<selector>.json`,
  `{"abi": "<signature>", "apps": ["<hash1>", ...]}`) listing the sorted, deduplicated
  approval-program hashes of every indexed app that exposes that method.
- `approval-programs/<hash[:3]>/<hash>.txt` + `<hash>.arc56.json`,
  `clear-programs/<hash[:3]>/<hash>.txt` + `<hash>.arc56.json` - the hash registry
  itself, one `.txt`/`.arc56.json` pair per distinct program hash.
- `abi-signatures/<selector[:2]>/<selector>.txt` + `<selector>.json` - ARC-4 method
  selector to ABI method signature string (and the apps using it), one pair per
  distinct 4-byte selector, built from every method of every ARC-56 spec in the repo.
- `pages/index.html` - the GitHub Pages landing page for the hash registry, published
  by `deploy-hash-registry-pages.yml`.
- `docker/hash-registry/Dockerfile` + `docker/hash-registry/README.md` +
  `docker/hash-registry/index.html` - builds the `scholtz2/arc56-registry` Docker Hub
  image: an unprivileged (non-root) nginx webserver on port 8080 serving
  `approval-programs/`, `clear-programs/`, `abi-signatures/`, and `arc56.links.csv`
  over plain HTTP, plus a landing page and README, so a wallet can run its own local
  mirror of the whole registry instead of depending on GitHub Pages at call time (note
  `arc56.links.csv` isn't part of the GitHub Pages site - this image is the only place
  it's published outside the source repo). Published by
  `publish-docker-hash-registry.yml`, tagged with both the current UTC date
  (`YYYY-MM-DD`) and `latest`; triggered after either `generate-hash-registry.yml` or
  `update-arc56-links.yml` completes, since it now bundles both of their outputs.
- `docs/arc56-links-pipeline.md` - full detail on the CSV pipeline.
- `docs/dotnet-client-pipeline.md` - full detail on the .NET client pipeline.
- `docs/typescript-client-pipeline.md` - full detail on the TypeScript client pipeline.
- `docs/npm-publishing-setup.md` - one-time `NPM_TOKEN` secret setup for npm publishing.
- `docs/pypi-publishing-setup.md` - one-time `PYPI_TOKEN` secret setup for PyPI publishing.
- `docs/hash-registry.md` - full detail on the hash registry + GitHub Pages pipeline.
- `docs/docker-hash-registry.md` - full detail on the Docker Hub image pipeline.
- `docs/dockerhub-publishing-setup.md` - one-time Docker Hub account + `DOCKERHUB_USERNAME`/
  `DOCKERHUB_TOKEN` secret setup for publishing the image.

## Hard rules - do not violate these

1. **Never delete a row from `arc56.links.csv`, and never delete a generated
   `clients/**` file.** Deactivate instead: set `ActiveUntil` to a date. This
   applies to scripts and to manual edits alike. `approval-programs/**` and
   `clear-programs/**` files (both `<hash>.txt` and `<hash>.arc56.json`) are similarly
   never deleted, but - unlike `clients/**` - their *content* can legitimately be
   rewritten in place when a better (larger) spec is found for the same hash; see
   docs/hash-registry.md. `abi-signatures/**` files follow the same never-delete rule.
   Within a selector's pair, `<selector>.txt` (the signature string) should never need
   to change once written (a selector determines its signature, barring a SHA-512/256
   collision); `<selector>.json` (the signature plus its `apps` list) *can* legitimately
   be rewritten in place as newly indexed specs add more known apps for that selector -
   still never deleted, just grown.
2. **`ActiveFrom`/`ActiveUntil` semantics**: a row is active when `ActiveFrom <= today`
   and (`ActiveUntil` is empty or `ActiveUntil` is in the future). New rows always get
   `ActiveFrom = today`, `ActiveUntil = ""`.
3. **GitHub API rate limits are real and have bitten us before**:
   - Code search (`api.github.com/search/code`) is capped at ~10 requests/minute
     (stricter than other search types) - `update_arc56_links.py` sleeps 7s between
     calls.
   - Code search's own `total_count` field is only an **approximation** once a query
     has >1000 matches - do not use it to decide when to stop paginating/sharding. Use
     actual page fullness instead (see `partition_and_collect` in that script).
   - Raw file downloads (`raw.githubusercontent.com`) - `download_arc56_specs.py`
     enforces 7s between downloads for the same reason. This is the *only* script that
     downloads ARC-56 specs; the generate/publish scripts for all three ecosystems
     never touch the network for a spec (see the 3-stage pipeline above).
4. **CSV must stay valid CSV per GitHub's rendering rules** (RFC 4180 quoting via
   Python's `csv` module, not manual string joins) so it renders as a table on GitHub.
5. **One package per GitHub repo, not per contract** - for all three ecosystems.
   Per-contract uniqueness comes from the namespace/export/module
   (`Arc56.Generated.<owner>.<repo>.<file_slug>_<hash8>` for .NET,
   `export * as <file_slug>_<hash8>` for TypeScript,
   `from . import <file_slug>_<hash8>` for Python), not from splitting into more
   packages.
6. **Never commit changes unless asked.** This applies doubly to `git push` and to
   anything that would trigger a NuGet, npm, or PyPI publish.
7. **Publishing (nuget.org, npm, and PyPI) is rate-limited and list-then-publish,
   never blind-push.** `publish_dotnet_packages.py`/`publish_npm_packages.py`/
   `publish_python_packages.py` query the registry's own live list of published
   versions before deciding what to publish (never a locally-cached flag), and wait at
   least 5s (20s for PyPI) between successive pushes. Don't reintroduce delay into the
   generate scripts - only download and publish are rate-limited; generation
   deliberately has none.
8. **`deploy-hash-registry-pages.yml` needs a one-time manual repo setting** (Settings
   > Pages > Source: "GitHub Actions") that no workflow file can set. If Pages
   deployment ever fails with a permissions/source error, that setting - not the
   workflow YAML - is the first thing to check.

## Local testing

Docker and the .NET SDK are both available in this environment and have been used
successfully. Docker volume mounts need a plain path (no spaces, no short `~1` names) -
mount under the repo itself or another simple path, not a Windows temp dir with a
tilde-shortened segment (that silently produces an empty mount).

Never run `scripts/download_arc56_specs.py` unscoped locally - it processes thousands
of URLs at 7s+ each. Always use `--only-repo owner/repo` or `--limit-projects N` for
local runs; see docs/dotnet-client-pipeline.md. The generate/publish scripts
(`generate_dotnet_clients.py`, `publish_dotnet_packages.py`,
`generate_typescript_clients.py`, `publish_npm_packages.py`,
`generate_python_clients.py`, `publish_python_packages.py`) have no download delay of
their own, but still support the same scoping flags and are worth scoping locally too,
simply because a full run touches every repo in the registry (thousands).

Node.js/npm are also available in this environment and have been used successfully for
the TypeScript pipeline - no Docker needed there (`npx
@algorandfoundation/algokit-client-generator` is a plain npm CLI tool, unlike the .NET
generator's Docker image). See docs/typescript-client-pipeline.md, including why
generation uses the generator's `minimal` mode (its `full` mode's Factory class has
been observed to break across algokit-utils versions) and why
`clients/_template_npm/package.json.template`'s `algokit-utils`/`algosdk` version
ranges must track the generator's own current peer dependencies (`npm view
@algorandfoundation/algokit-client-generator peerDependencies`) - a stale pin there
reproducibly breaks every generated package's type-check, not just one.

The Python pipeline needs no Docker either - `algokitgen-py` (from the
`algokit-client-generator` PyPI package) is a plain `pip`-installable CLI tool.
`generate_python_clients.py` installs/upgrades it itself at the start of a run (a
one-time PyPI metadata + wheel fetch, not per-contract) and also uses `minimal` mode
for the same reason as TypeScript. `clients/_template_python/pyproject.toml.template`'s
`algokit-utils`/`py-algorand-sdk` version ranges must similarly track the generator's
own PyPI dependency pin (`pip show algokit-client-generator`) - see
docs/python-client-pipeline.md. Unlike TypeScript's whole-project `tsc --noEmit` pass,
Python quarantining is a per-file `py_compile` syntax check done immediately after each
file is generated - no multi-attempt retry loop, because generated Python modules never
import each other. There's deliberately no `mypy`/`pyright` type-check step - see
"Known limitations" in docs/python-client-pipeline.md for why.

The generator Docker image (`scholtz2/dotnet-avm-generated-client`) can crash on some
ARC-56 specs (seen: `NullReferenceException` in `ABITypeToCSType`). Separately, some
generated code that *does* generate successfully still fails to *compile* together with
the rest of its project (seen: `FixedArray<Byte>` used without a parameterless
constructor, CS0310). Both are handled (logged, recorded in `state.json`, the offending
contract excluded/quarantined) without aborting the run or blocking other contracts in
the same package - this is not a bug in our script if it happens again. Verified
end-to-end locally: generation, quarantining, and `dotnet pack` all producing a working
`.nupkg` with correct metadata (icon, README, repo link, Algorand4 dependency).

Also watch for: `<Version>` with a `yyyyMMddHH` segment is NOT valid as
`AssemblyVersion`/`FileVersion` (each part must fit in 16 bits) - the csproj template
pins those separately from the package `<Version>`. Don't "simplify" that away.

## Conventions worth knowing before editing scripts

- Every pipeline script (`download_arc56_specs.py`, `generate_dotnet_clients.py`,
  `publish_dotnet_packages.py`, `generate_typescript_clients.py`,
  `publish_npm_packages.py`, `generate_python_clients.py`, `publish_python_packages.py`)
  defines its own local `log(message)` helper that prefixes
  a UTC timestamp and writes to stderr - use it for anything that's genuinely a log
  line. The one exception is each publish script's `--dry-run` "would pack + push ..."
  / "would build + publish ..." preview line, which stays a plain `print()` to stdout
  (no timestamp) since it's scriptable output, not a log. The download/generate
  scripts also log per-URL progress as `[i/N]` (N = total rows selected for that run,
  not the whole registry) at the top of their per-row loop, and the publish scripts log
  `[i/N]` per project - keep both when editing these loops.
- `generate_typescript_clients.py --commit` checkpoints (commits + pushes) **at least
  every 5 minutes**, checked per-row inside a project's contract loop, not only when a
  project finishes - a single large project (dozens of contracts, each its own `npx`
  invocation, plus one `npm install` + `tsc` type-check) can itself run past 5 minutes.
  See `maybe_checkpoint_commit()` and docs/typescript-client-pipeline.md#committing-during-generation.
  Don't revert this back to "commit once per finished project only".
- .NET versioning is the 4-part legacy scheme `1.0.<increment>.<yyyyMMddHH>` - matches
  what `Algorand4` (the runtime dependency of every generated client) already uses.
  TypeScript and Python versioning both share the exact same `1.<increment>.<yyyyMMddHH>`
  string (3-part, valid semver *and* valid PEP 440 - npm rejects the .NET pipeline's
  4-part scheme, and this 3-part one happens to satisfy both ecosystems at once, so
  there's no separate Python-specific scheme).
- No LICENSE file exists yet, so generated `.csproj`/`package.json`/`pyproject.toml`
  files intentionally omit `PackageLicenseExpression`/`license`. Don't add one without
  the user deciding on a license first.
- `dotnet nuget push` to nuget.org is wired up via **Trusted Publishing** (OIDC,
  `NuGet/login@v1`), not a long-lived API key - see
  [docs/dotnet-client-pipeline.md](docs/dotnet-client-pipeline.md#publishing-to-nugetorg).
  Needs a one-time Trusted Publishing policy on nuget.org (naming
  `publish-dotnet-packages.yml`, the *publish*-stage workflow - not
  `generate-dotnet-clients.yml`) plus a `NUGET_USER` repo secret (the nuget.org
  *username*, not a key). Don't add a `NUGET_API_KEY` secret or revert to key-based
  publishing without the user deciding to.
- `npm publish` deliberately uses a classic **Automation** access token
  (`NPM_TOKEN` repo secret), not npm's own OIDC Trusted Publishing, because that
  mechanism is configured per-package on npmjs.com and this pipeline creates new
  packages automatically and continuously - see
  [docs/npm-publishing-setup.md](docs/npm-publishing-setup.md) for the full reasoning
  and setup steps. Don't "upgrade" this to OIDC trusted publishing without checking
  whether npm has since added an account/org-wide policy option.
- `twine upload` to PyPI deliberately uses a classic **account-scoped API token**
  (`PYPI_TOKEN` repo secret), not PyPI's own OIDC Trusted Publishing, for the same
  reason as npm above - and PyPI's version is even stricter: a project must already
  exist on PyPI before Trusted Publishing can be configured for it at all, which is
  incompatible with this pipeline auto-creating brand-new packages - see
  [docs/pypi-publishing-setup.md](docs/pypi-publishing-setup.md). Don't "upgrade" this
  without checking whether PyPI has since added a way to pre-authorize unpublished
  project names.
- `docker push` to Docker Hub uses a classic **access token** (`DOCKERHUB_TOKEN` +
  `DOCKERHUB_USERNAME` repo secrets), same reasoning as npm/PyPI above - Docker Hub has
  no comparable OIDC Trusted Publishing option today. Unlike the npm/PyPI/NuGet publish
  scripts, `publish-docker-hash-registry.yml` doesn't do a "list what's published, push
  what's missing" comparison - every run's dataset can differ from the last (the hash
  registry is regenerated daily) and the image is always pushed under a fresh
  `YYYY-MM-DD` UTC-date tag plus a moved `latest` tag, so there's nothing to diff
  against. It still follows the same secret-gated pattern as the other publish steps:
  missing `DOCKERHUB_USERNAME`/`DOCKERHUB_TOKEN` skips the push (logged, not failed).
- All three publish scripts (`publish_dotnet_packages.py`, `publish_npm_packages.py`,
  `publish_python_packages.py`) decide what to publish by **querying the registry's own
  live list of published versions** (nuget.org's flat-container index / the npm
  registry's package metadata / PyPI's JSON API), never by trusting a locally-recorded
  `published_version` flag - that field is written back only as an informational cache
  after a successful publish. Don't change this to trust the local flag as the source
  of truth; it's what makes a partially-failed previous run self-heal on the next one
  without extra retry bookkeeping.
- Code examples that call a public mainnet algod endpoint (in
  [pages/index.html](pages/index.html), [docker/hash-registry/README.md](docker/hash-registry/README.md),
  and [docker/hash-registry/index.html](docker/hash-registry/index.html)) use
  `https://mainnet-api.4160.nodely.dev` - **not** `https://mainnet-api.algonode.cloud`
  (the older Algonode endpoint these examples used before). Use nodely for any new or
  edited example in this repo unless told otherwise.
