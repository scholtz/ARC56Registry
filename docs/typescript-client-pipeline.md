# TypeScript ARC-56 client generation pipeline

This pipeline turns every active row in [arc56.links.csv](../arc56.links.csv) into a
typed TypeScript client, packaged as one npm package per GitHub repository - the same
one-package-per-repo shape as the [.NET pipeline](dotnet-client-pipeline.md), split into
the same three independent stages:

| Stage | Script | Workflow | What it does | Network use |
| --- | --- | --- | --- | --- |
| 1. Download | [`scripts/download_arc56_specs.py`](../scripts/download_arc56_specs.py) | [`download-arc56-specs.yml`](../.github/workflows/download-arc56-specs.yml) | Fetches every active ARC-56 spec into `clients/<owner>/<repo>/arc56/` | Rate-limited, 7s+ between downloads |
| 2. Generate | [`scripts/generate_typescript_clients.py`](../scripts/generate_typescript_clients.py) | [`generate-typescript-clients.yml`](../.github/workflows/generate-typescript-clients.yml) | Regenerates TypeScript source + bumps versions from the locally-downloaded specs | None (`npx` fetching the generator package itself is a one-time metadata request, not per-contract) |
| 3. Publish | [`scripts/publish_npm_packages.py`](../scripts/publish_npm_packages.py) | [`publish-npm-packages.yml`](../.github/workflows/publish-npm-packages.yml) | Builds and publishes to npm whatever npm doesn't already have | Rate-limited, 5s+ between publishes |

**Stage 1 is shared with the [.NET pipeline](dotnet-client-pipeline.md)** - a spec is
downloaded once into `clients/<owner>/<repo>/arc56/` regardless of how many client
languages get generated from it. Only stages 2-3 are TypeScript-specific.

It uses the ARC-56/ARC-32 client generator from
[algorandfoundation/algokit-client-generator-ts](https://github.com/algorandfoundation/algokit-client-generator-ts)
(the `@algorandfoundation/algokit-client-generator` npm package), invoked via `npx` -
there's no Docker image for this one, unlike the .NET generator.

## Naming and packaging conventions

**One npm package per GitHub repository**, mirroring the .NET pipeline's one-NuGet-
package-per-repo convention.

- **Package name**: `arc56-generated-<owner>-<repo>` (owner/repo lowercased and
  sanitized to valid, URL-safe npm name characters - npm package names must be all
  lowercase, unlike the case-preserving on-disk `clients/<owner>/<repo>/` path or the
  .NET pipeline's `Arc56.Generated.<owner>.<repo>` package ID). Example:
  `arc56-generated-akita-protocol-akita-sc`.
- **Per-contract export**: each contract is generated into its own module,
  `src/<file_slug>_<hash8>.ts`, and re-exported from the package's `src/index.ts` under
  a namespace import: `export * as <file_slug>_<hash8> from './<file_slug>_<hash8>'`.
  This is the TypeScript equivalent of the .NET pipeline's per-contract C# namespace -
  it keeps two differently-named-but-colliding contracts (or even two contracts that
  happen to export identically-named classes) from clashing when re-exported through
  one package's `index.ts`, since `hash8` (the first 8 hex characters of
  `sha256(source URL)`) is unique per source URL.
- **On-disk layout**:
  ```
  clients/<owner>/<repo>/
    arc56/                              # shared with the .NET pipeline - see dotnet-client-pipeline.md
    npm/
      package.json
      tsconfig.json
      README.md                # per-project usage doc, includes a table of every contract
      state.json                # generation state: version, increment, per-contract content/code hashes
      src/
        index.ts                        # re-exports every non-quarantined contract
        <file_slug>_<hash8>.ts           # generated client
  ```
- **Shared assets**: `clients/_template_npm/` holds `package.json.template`,
  `tsconfig.json.template`, and `README.md.template` - the TypeScript-pipeline
  equivalent of `clients/_template/` for .NET.
- **Generator mode: `full` by default, `minimal` only as a per-contract fallback.**
  `full` mode emits both the typed `Client` class and a deploy/create `Factory` class;
  every contract is generated in `full` mode first so its `Factory` is available.
  `full` mode's Factory code has, on some ARC-56 specs, been observed to type-check
  against non-exported internal shapes of `@algorandfoundation/algokit-utils`'s
  `AlgorandClient` (observed: a `type 'AlgorandClientInterface' is missing the
  following properties from type 'AlgorandClient'` error) that break across
  algokit-utils versions the generator doesn't itself pin against. When that happens
  for a specific contract, `generate_ts_client()`/`typecheck_and_quarantine()` fall
  back to `minimal` mode (`Client` only, no `Factory`) for **that contract only** -
  every other contract in the project keeps its `full`-mode `Factory`. See "Generator
  and type-check failures" below.

## Versioning

Versions follow `1.<increment>.<yyyyMMddHH>` - **not** the exact 4-part
`1.0.<increment>.<yyyyMMddHH>` string the .NET pipeline uses, because npm requires
strict [semver](https://semver.org/) (exactly three numeric components); the .NET
pipeline's scheme is a legacy 4-part format NuGet has always tolerated but npm does not.
Dropping the always-`0` second component and shifting `increment` into semver's `minor`
slot keeps the same information (a monotonic per-project counter, plus a
`yyyyMMddHH` build timestamp) in a valid three-part version.

Exactly like the .NET pipeline, a project's version is bumped, and only that project is
rebuilt, when:

- **the actual generated TypeScript code for at least one of its contracts changed**
  (compared by SHA-256 of the generated `.ts` file's bytes, not merely "we attempted
  regeneration"), triggered by either the contract's ARC-56 content changing or the
  generator npm package's version changing since this project last recorded one
  (`generator_version` in `npm/state.json`, the TypeScript equivalent of the .NET
  pipeline's `generator_image_digest`), or
- the shared templates under `clients/_template_npm/` change (`template_hash`
  mismatch).

A rerun that reproduces byte-identical `.ts` output does **not** bump the version -
only the bookkeeping is updated. Generator-crash failures are recorded in
`npm/state.json` (`generator_error`) but never bump the version either. Download
failures are tracked separately in `arc56/state.json` (shared with the .NET pipeline) -
the generate stage simply skips a contract whose spec hasn't been downloaded yet.

## Rate limiting

Identical to the .NET pipeline: all ARC-56 downloading happens in the shared
**download** stage (`scripts/download_arc56_specs.py`), 7+ seconds apart. The
**generate** stage makes no network request for the spec - it reads the local copy
already on disk. `npx --yes @algorandfoundation/algokit-client-generator` does make a
small registry request to resolve/install that package on first use per Node
environment, but that's unrelated to (and much cheaper than) the ARC-56 rate limiting
this pipeline cares about, so no artificial delay is added around it.

## Generator and type-check failures (quarantining)

Mirrors the .NET pipeline's compile-failure quarantining, adapted to TypeScript:

1. **Generator crash**: `npx @algorandfoundation/algokit-client-generator generate`
   itself can fail for a given spec. `generate_ts_client()` tries `full` mode first; if
   that fails outright it retries the same contract in `minimal` mode before giving up.
   Only if both fail is it recorded as `generator_error` on that contract's
   `npm/state.json` entry; the project's README lists it as "generation failed - see
   state.json"; not retried every run.
2. **Type-check failure**: after regenerating a project's contracts, the pipeline runs
   `tsc --noEmit` on the aggregate package. If it fails, it parses the compiler output
   for the specific file(s) at fault (`src/<contract_id>.ts(line,col): error TSxxxx:
   ...` - `tsc`'s non-pretty output format, matching the shape the .NET pipeline's
   regex already looks for in `dotnet build` output) and for each one:
   - if that contract is still on `full` mode, `typecheck_and_quarantine()` regenerates
     it in `minimal` mode in place and leaves it in the project (no exclusion, no
     `state.json` error) for the next `tsc` pass - dropping only the `Factory`, not the
     whole contract,
   - only if the contract is already on `minimal` mode (or the `minimal`-mode
     regeneration itself fails) does it actually get quarantined:
     - excluded from `tsconfig.json`'s `"exclude"` array,
     - its `export * as ...` line dropped from `src/index.ts`,
     - `"ts_compile_error"` recorded on that contract's `state.json` entry,
     - listed in the project README as "fails to type-check - excluded, see
       state.json",

   then retries, up to `MAX_BUILD_QUARANTINE_ATTEMPTS` (20 - roughly double the number
   of contracts a single quarantine pass could otherwise need, since a `full`-mode
   failure costs one extra attempt to downgrade to `minimal` before it can be excluded)
   times, until it type-checks clean or no further broken file can be attributed - at
   which point the run fails loudly rather than silently shipping a broken package.
   Every contract successfully generated in `minimal` mode this way is flagged in the
   project README's contracts table so consumers know that one has no `Factory`.

## Running it locally

Requires Node.js and npm (no Docker needed for this pipeline). Same scoping flags as
the .NET pipeline:

```bash
python scripts/download_arc56_specs.py --only-repo algorandfoundation/arc55-encryption
python scripts/generate_typescript_clients.py --only-repo algorandfoundation/arc55-encryption
python scripts/publish_npm_packages.py --only-repo algorandfoundation/arc55-encryption --dry-run
```

`generate_typescript_clients.py` runs `npm install` and `tsc --noEmit` itself (to
type-check and quarantine, per above) but does not build a publishable `dist/` - that's
`publish_npm_packages.py`'s job (`npm run build`, which the generated `package.json`
wires to `tsc -p tsconfig.json`). To build manually:

```bash
cd clients/<owner>/<repo>/npm
npm install
npm run build
```

`--commit` (used by CI) is **off by default** for local runs of the download/generate
scripts. `publish_npm_packages.py` has no `--commit` flag - see "Publishing to npm"
below.

### Committing during generation

Unlike the .NET pipeline's generate stage (which commits once per finished project),
`generate_typescript_clients.py --commit` checkpoints **at least every 5 minutes**
(`PERIODIC_COMMIT_INTERVAL_SECONDS`), checked on every row of a project's contract
loop - not only when a project finishes. This matters here specifically because a
single TypeScript project can itself run past 5 minutes: dozens of contracts, each its
own `npx @algorandfoundation/algokit-client-generator` invocation, followed by one
`npm install` and `tsc --noEmit` type-check for the whole package. Without a mid-project
checkpoint, a crash partway through a large repo (e.g. `akita-protocol/akita-sc`'s 86
contracts) would lose everything generated since that project started, not just since
the last commit. Finishing a project is still its own checkpoint too (forced,
bypassing the 5-minute throttle), so committing isn't delayed just because a project
happened to finish early in the window. See `maybe_checkpoint_commit()` in the script.

## Publishing to npm

Publishing is its own script and workflow
(`scripts/publish_npm_packages.py` / `publish-npm-packages.yml`), decoupled from
generation exactly like the .NET pipeline's `publish_dotnet_packages.py`. For every
generated `clients/<owner>/<repo>/npm/package.json` project, it:

1. Reads the version that project's `state.json` says it should be at.
2. **Lists every version of that package name already published**, straight from the
   npm registry itself (`GET https://registry.npmjs.org/<package-name>`) - not a
   locally cached flag. Same "ask the registry, not a local record" principle as the
   .NET pipeline's nuget.org query.
3. If the project's current version isn't in that list, installs dependencies and
   builds it (`npm install && npm run build`) and publishes it (`npm publish --access
   public`), waiting at least 5 seconds between publishes.

See [docs/npm-publishing-setup.md](npm-publishing-setup.md) for the one-time
`NPM_TOKEN` secret setup this needs, and why this pipeline uses a classic automation
token rather than npm's newer OIDC Trusted Publishing (the mechanism the .NET pipeline
uses for nuget.org).

### Committing

Same as the .NET pipeline's publish stage: the only source-tree change is each
project's `published_version` bookkeeping field in `npm/state.json` (informational
only - publish decisions always re-derive from the npm registry, never from this
field), committed once at the end of the run.

## Recovering from a failed run (fast catch-up)

Identical reasoning to the .NET pipeline (see
[dotnet-client-pipeline.md](dotnet-client-pipeline.md#recovering-from-a-failed-run-fast-catch-up)):
download failures are recorded and skipped until retried explicitly, generate-stage
content-hash comparisons make catch-up fast, and publish-stage catch-up falls out of
always comparing against the npm registry's own live list rather than a local flag.

## Known limitations

- **Run time**: same cold-start cost as the .NET pipeline - a full first-time download
  run is the slow part (thousands of URLs, 7+ seconds apart); generate/publish are fast
  once specs are local and only changed content triggers work.
- **`npm install` per project**: unlike the .NET pipeline's single shared
  `scholtz2/dotnet-avm-generated-client` Docker image, each TypeScript project gets its
  own `node_modules/` (dependencies are identical across every project - only the
  package name/version differ - but nothing here shares a single install across
  projects). This is a known cost of the current implementation, not a fundamental
  limitation; a future optimization could share a single `node_modules` install (e.g.
  via a workspace or a cached install) across projects if generation time becomes a
  problem.
- **Per-contract `minimal` fallback**: most contracts are generated in `full` mode and
  include a working deploy/create `Factory` class, but a contract whose `full`-mode
  output fails to generate or fails to type-check falls back to `minimal` mode (see
  "Naming and packaging conventions" above), which has no `Factory` - only usable for
  decoding/calling that specific contract's already-deployed instances, not deploying
  new ones. The project README's contracts table flags any contract generated this way.
- **algokit-utils/algosdk version pins**: `clients/_template_npm/package.json.template`
  pins `@algorandfoundation/algokit-utils` and `algosdk` to ranges matching the
  generator's *current* peer dependencies. If a future generator upgrade changes those
  peer requirements (as happened once already during this pipeline's development - see
  the generator's own `npm view @algorandfoundation/algokit-client-generator
  peerDependencies`), the template's pinned ranges need a matching manual update, or
  every generated package will fail to type-check against whatever version npm actually
  resolves. Because a template edit bumps and regenerates every project on the next
  run (see "Versioning" above), fixing the template once fixes every package.
- **`typescript` devDependency version drift**: `clients/_template_npm/tsconfig.json.template`
  pins `"moduleResolution": "node10"` with `"ignoreDeprecations": "6.0"` because
  TypeScript 6 deprecated the old `"node"` value (renamed to `"node10"`) and turned the
  deprecation into a hard `tsc` error by default - hit once already when
  `package.json.template`'s `typescript` range was bumped to `^6.0.3`. If a future
  TypeScript major actually removes `"node10"` resolution, this template needs a real
  module-resolution strategy change (e.g. `"node16"`/`"nodenext"`), which also requires
  adding explicit `.js` extensions to every generated file's relative imports - not a
  one-line fix like this was.
- **`HEAD`-pinned sources**: like the links CSV itself, ARC-56 URLs point at `HEAD`.
- **No license metadata**: generated `package.json` files don't set a `license` field,
  matching the .NET pipeline's reasoning (no LICENSE file in this repo yet).
