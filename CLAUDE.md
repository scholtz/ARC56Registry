# Arc56Registry - instructions for Claude

Registry of public ARC-56 smart-contract specs + a pipeline that generates typed client
libraries from them. Full narrative docs live in [README.md](README.md) and
[docs/](docs/) - read this file first, only open those for details this file doesn't
cover.

## Repo map

- `arc56.links.csv` - the registry. Columns: `ARC56URL,ActiveFrom,ActiveUntil`.
- `scripts/update_arc56_links.py` - finds new ARC-56 files on GitHub, merges into the CSV.
- `scripts/validate_arc56_links.py` - PR check enforcing the CSV's rules.
- **Client generation is a 3-stage pipeline, run twice (once per ecosystem) - download
  is shared, generate/publish are per-ecosystem:**
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
  - See [docs/dotnet-client-pipeline.md](docs/dotnet-client-pipeline.md) and
    [docs/typescript-client-pipeline.md](docs/typescript-client-pipeline.md).
- `clients/<owner>/<repo>/arc56/` - downloaded ARC-56 specs, shared across every
  ecosystem's generated client for that repo. `clients/<owner>/<repo>/dotnet/` and
  `clients/<owner>/<repo>/npm/` are the per-ecosystem generated packages; a `python/`
  sibling is planned.
- `clients/_template/` - shared .NET csproj/README templates + shared package icon.
- `clients/_template_npm/` - shared npm package.json/tsconfig.json/README templates.
- `scripts/generate_hash_registry.py` - builds `approval-programs/` and
  `clear-programs/`, lookups from SHA-256(approval program) / SHA-256(clear program)
  to a durable URL of the matching ARC-56 spec. Lets a wallet that only has a
  deployed app's compiled bytecode find a spec to decode calls against it. The same
  script also builds `abi-signatures/`, a lookup from ARC-4 method selector (4-byte
  SHA-512/256 of the ABI method signature) to the plain-text signature string, e.g.
  `add(uint64,uint64)uint128` for selector `8aa3b61f`.
- `approval-programs/<hash[:3]>/<hash>.txt`, `clear-programs/<hash[:3]>/<hash>.txt` -
  the hash registry itself, one file per distinct program hash.
- `abi-signatures/<selector[:2]>/<selector>.txt` - ARC-4 method selector to ABI method
  signature string, one file per distinct 4-byte selector, built from every method of
  every ARC-56 spec in the repo.
- `pages/index.html` - the GitHub Pages landing page for the hash registry, published
  by `deploy-hash-registry-pages.yml`.
- `docs/arc56-links-pipeline.md` - full detail on the CSV pipeline.
- `docs/dotnet-client-pipeline.md` - full detail on the .NET client pipeline.
- `docs/typescript-client-pipeline.md` - full detail on the TypeScript client pipeline.
- `docs/npm-publishing-setup.md` - one-time `NPM_TOKEN` secret setup for npm publishing.
- `docs/hash-registry.md` - full detail on the hash registry + GitHub Pages pipeline.

## Hard rules - do not violate these

1. **Never delete a row from `arc56.links.csv`, and never delete a generated
   `clients/**` file.** Deactivate instead: set `ActiveUntil` to a date. This
   applies to scripts and to manual edits alike. `approval-programs/**` and
   `clear-programs/**` files are similarly never deleted, but - unlike `clients/**` -
   their *content* can legitimately be rewritten in place when a better (larger) spec
   is found for the same hash; see docs/hash-registry.md. `abi-signatures/**` files
   follow the same never-delete rule; their content should never need to change once
   written (a selector determines its signature, barring a SHA-512/256 collision), so
   the generator only ever adds new files there, never rewrites existing ones.
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
     downloads ARC-56 specs; the generate/publish scripts for both ecosystems never
     touch the network for a spec (see the 3-stage pipeline above).
4. **CSV must stay valid CSV per GitHub's rendering rules** (RFC 4180 quoting via
   Python's `csv` module, not manual string joins) so it renders as a table on GitHub.
5. **One package per GitHub repo, not per contract** - for both ecosystems.
   Per-contract uniqueness comes from the namespace/export
   (`Arc56.Generated.<owner>.<repo>.<file_slug>_<hash8>` for .NET,
   `export * as <file_slug>_<hash8>` for TypeScript), not from splitting into more
   packages.
6. **Never commit changes unless asked.** This applies doubly to `git push` and to
   anything that would trigger a NuGet or npm publish.
7. **Publishing (nuget.org and npm) is rate-limited and list-then-publish, never
   blind-push.** `publish_dotnet_packages.py`/`publish_npm_packages.py` query the
   registry's own live list of published versions before deciding what to publish
   (never a locally-cached flag), and wait at least 5s between successive pushes. Don't
   reintroduce delay into the generate scripts - only download and publish are
   rate-limited; generation deliberately has none.
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
`generate_typescript_clients.py`, `publish_npm_packages.py`) have no download delay of
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
  `publish_npm_packages.py`) defines its own local `log(message)` helper that prefixes
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
  TypeScript versioning is `1.<increment>.<yyyyMMddHH>` (3-part, valid semver - npm
  rejects the .NET pipeline's 4-part scheme) - same information, shifted to fit.
- No LICENSE file exists yet, so generated `.csproj`/`package.json` files intentionally
  omit `PackageLicenseExpression`/`license`. Don't add one without the user deciding on
  a license first.
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
- Both publish scripts (`publish_dotnet_packages.py`, `publish_npm_packages.py`) decide
  what to publish by **querying the registry's own live list of published versions**
  (nuget.org's flat-container index / the npm registry's package metadata), never by
  trusting a locally-recorded `published_version` flag - that field is written back
  only as an informational cache after a successful publish. Don't change this to
  trust the local flag as the source of truth; it's what makes a partially-failed
  previous run self-heal on the next one without extra retry bookkeeping.
