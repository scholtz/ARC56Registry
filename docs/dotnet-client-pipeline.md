# .NET (C#) ARC-56 client generation pipeline

This pipeline turns every active row in [arc56.links.csv](../arc56.links.csv) into a
typed C# client, packaged as one NuGet package per GitHub repository, via
[`generate-dotnet-clients.yml`](../.github/workflows/generate-dotnet-clients.yml) and
[`scripts/generate_dotnet_clients.py`](../scripts/generate_dotnet_clients.py).

It uses the ARC-56 client generator from
[scholtz/dotnet-algorand-sdk](https://github.com/scholtz/dotnet-algorand-sdk), shipped as
the [`scholtz2/dotnet-avm-generated-client`](https://hub.docker.com/r/scholtz2/dotnet-avm-generated-client)
Docker image.

## Naming and packaging conventions

**One NuGet package per GitHub repository.** A repo can contain many ARC-56 specs (e.g.
`akita-protocol/akita-sc` has dozens); all of them ship together in a single package, so
consumers add one package reference per source repo, not one per contract.

- **Package ID**: `Arc56.Generated.<owner>.<repo>` (owner/repo sanitized to safe NuGet ID
  characters). Example: `Arc56.Generated.akita-protocol.akita-sc`.
- **Per-contract namespace**: `Arc56.Generated.<owner>.<repo>.<file_slug>_<hash8>`, where
  `file_slug` is the ARC-56 filename with the `.arc56.json` suffix stripped and
  non-identifier characters replaced, and `hash8` is the first 8 hex characters of
  `sha256(source URL)`. This is where the "unique even with duplicate filenames in the
  same repo" requirement is satisfied: two different `HelloWorld.arc56.json` files in
  the same repo get two different namespaces, because they have different source URLs
  and therefore different hashes. The generated class name inside that namespace (e.g.
  `HelloWorldProxy`) comes from the contract's own `name` field in the ARC-56 spec, not
  from our naming - only the namespace is ours to control.
- **On-disk layout**:
  ```
  clients/dotnet/<owner>/<repo>/
    <PackageId>.csproj
    README.md              # per-project usage doc, includes a table of every contract
    state.json             # generation state: version, increment, per-contract content hashes
    arc56/<file_slug>_<hash8>.arc56.json   # copy of the source spec, also bundled into the nupkg
    src/<file_slug>_<hash8>.cs             # generated client
  ```
- **Shared assets**: `clients/dotnet/_template/` holds `Project.csproj.template`,
  `README.md.template`, and `icon.png` (one shared package icon reused by every project,
  so all Arc56Registry-generated packages are visually recognizable together - see it at
  `clients/dotnet/_template/icon.png`). Every package's `PackageProjectUrl` and
  `RepositoryUrl` point back to this repo.

## Versioning

Versions follow `1.0.<increment>.<yyyyMMddHH>` - the same 4-part legacy scheme the
`Algorand4` package itself uses (e.g. `4.7.3.2026071620`), which NuGet has always
supported alongside strict 3-part SemVer.

A project's version is bumped, and only that project is re-packed, when **the actual
generated C# code for at least one of its contracts changed** - compared by SHA-256 of
the generated `.cs` file's bytes, not merely "we attempted regeneration". Two things can
trigger an attempt at regeneration without necessarily changing anything:

- a contract's ARC-56 content actually changed (compared by SHA-256 of the raw spec
  bytes), or
- the generator Docker image's digest changed since *this project* last recorded one
  (each project's `state.json` stores the digest it was last processed with - there is
  no single shared "last seen" file, so a large run's progress isn't all-or-nothing: a
  project already processed under the current image won't be reprocessed just because
  other projects haven't gotten to it yet, e.g. after an interrupted run).

Either of those can cause a rerun of the generator, but if the resulting `.cs` content is
byte-identical to what's already there (common: the same generator version reproduces
the same output for unchanged input), the version is **not** bumped - only the
bookkeeping (content hash, recorded generator digest) is updated, so the next run knows
not to bother rechecking. Download and generator-crash failures are recorded in
`state.json` for the same reason (so they aren't silently lost or retried every run) but
never bump the version either, since no `.cs` file changed.

`increment` is a per-project counter stored in that project's `state.json`, incremented
by 1 only when the generated code actually changes.

Existing rows are never deleted from `arc56.links.csv` (see
[arc56-links-pipeline.md](arc56-links-pipeline.md)), and this pipeline mirrors that:
generated files and state entries are never removed, only added to or updated in place.

## Rate limiting

Each ARC-56 spec is downloaded directly by this pipeline's script (not by the generator
container) with **at least 7 seconds between downloads**, to avoid tripping GitHub's
anonymous rate limits on raw.githubusercontent.com. The already-downloaded file is then
handed to the generator via its `--file` flag (mounted into the container), so the
generator itself makes no additional network request for the spec.

## Generator failures

The generator is an external tool and can crash on some ARC-56 specs (observed: a
`NullReferenceException` in `ABITypeToCSType` for certain struct shapes). A crash for one
contract does not abort the run:

- the failure is logged and recorded in that project's `state.json` (with a
  `generator_error` field on the contract entry) instead of the usual `class_name`/
  `generated_at`,
- the project's README lists it as "generation failed - see state.json" rather than a
  working class,
- it will not be retried on every subsequent run - only when its content changes or the
  generator image changes - so a persistently-broken spec doesn't waste time forever.

If a contract that previously generated successfully starts failing after its spec
content changes, the old generated `.cs` is left in place (still compiles, still part of
the package) but will be **out of sync** with the newly-copied `arc56/*.json` spec until
the generator is fixed or the content reverts. This is a known, logged trade-off rather
than a silent one.

## Compile failures (quarantining)

Because every contract in a repo shares one compiled project, generation succeeding is
not enough - the generated C# also has to actually *compile* together with every other
contract in the same package. It doesn't always: observed in practice, some ABI type
shapes (e.g. an array of fixed-size byte arrays) produce code where `FixedArray<Byte>` is
used as `VariableArray<T>`'s type parameter without the public parameterless constructor
that requires - `error CS0310`. That's a limitation in the upstream generator's output,
not something fixable by changing our namespace/file naming.

After (re)generating a project's contracts, the pipeline runs `dotnet build` on the
aggregate project. If it fails, it parses the compiler output for the specific file(s) at
fault (`src/<contract_id>.cs(line,col): error ...`), and for each one:

- adds `<Compile Remove="src/<contract_id>.cs" />` to that project's `.csproj`, excluding
  just that file from compilation (the `.cs` and its `arc56/*.json` copy stay on disk and
  in the package's `contentFiles`, for reference/debugging - they're just not compiled),
- records `"compile_error"` on that contract's `state.json` entry,
- lists it in the project README as "fails to compile - excluded, see state.json",

then retries the build. This repeats (up to `MAX_BUILD_QUARANTINE_ATTEMPTS`, currently 10)
until the build succeeds or a build failure can no longer be attributed to a specific new
file, at which point the run fails loudly rather than silently shipping a broken package.
Like generator failures, a quarantined contract isn't retried every run - only when its
content or the generator image changes.

## Running it locally

Requires Docker and the .NET SDK. To avoid a multi-hour run across thousands of URLs while
testing, use the scoping flags:

```bash
python scripts/generate_dotnet_clients.py --only-repo algorandfoundation/arc55-encryption
python scripts/generate_dotnet_clients.py --limit-projects 3
```

Full, unscoped runs are meant for CI. Since the generator-image digest is tracked
per-project rather than in one shared file, `--only-repo`/`--limit-projects` runs don't
affect anything outside the projects they touch - a later full run will still correctly
detect and act on a pending generator image change for every other project.

To pack a project after generation:

```bash
dotnet pack clients/dotnet/<owner>/<repo>/<PackageId>.csproj --configuration Release --output artifacts/nupkgs
```

## Publishing to NuGet.org

The workflow builds and uploads `.nupkg` files as a workflow artifact but does **not**
push to nuget.org yet - that requires a `NUGET_API_KEY` secret (an API key from
nuget.org scoped to the `Arc56.Generated.*` package prefix) and uncommenting the push
step in `generate-dotnet-clients.yml`. This is left as a deliberate manual step until
that key is provisioned.

## Known limitations

- **Run time**: a full first-time run downloads and generates a client for every active
  URL in `arc56.links.csv` (thousands, and growing), 7+ seconds apart, plus generation and (for changed
  projects) `dotnet pack` time. This can take hours. The workflow's `timeout-minutes` is
  set high (350) to accommodate this; subsequent runs are much faster since only changed
  content triggers regeneration.
- **`HEAD`-pinned sources**: like the links CSV itself, ARC-56 URLs point at `HEAD`, so a
  source repo rewriting its default branch could change what the next run downloads.
- **No license metadata**: generated packages don't set `PackageLicenseExpression` since
  this repository doesn't currently have a LICENSE file. Add one and update
  `clients/dotnet/_template/Project.csproj.template` accordingly.
