# .NET (C#) ARC-56 client generation pipeline

This pipeline turns every active row in [arc56.links.csv](../arc56.links.csv) into a
typed C# client, packaged as one NuGet package per GitHub repository. It's split into
three separate stages - **download**, **generate**, **publish** - each its own script
and its own GitHub Actions workflow, chained together with `workflow_run` triggers:

| Stage | Script | Workflow | What it does | Network use |
| --- | --- | --- | --- | --- |
| 1. Download | [`scripts/download_arc56_specs.py`](../scripts/download_arc56_specs.py) | [`download-arc56-specs.yml`](../.github/workflows/download-arc56-specs.yml) | Fetches every active ARC-56 spec into `clients/<owner>/<repo>/arc56/` | Rate-limited, 7s+ between downloads |
| 2. Generate | [`scripts/generate_dotnet_clients.py`](../scripts/generate_dotnet_clients.py) | [`generate-dotnet-clients.yml`](../.github/workflows/generate-dotnet-clients.yml) | Regenerates C# source + bumps versions from the locally-downloaded specs | None - reads local files only |
| 3. Publish | [`scripts/publish_dotnet_packages.py`](../scripts/publish_dotnet_packages.py) | [`publish-dotnet-packages.yml`](../.github/workflows/publish-dotnet-packages.yml) | Packs and pushes to nuget.org whatever nuget.org doesn't already have | Rate-limited, 15s+ between pushes |

**Why split it up:** the previous single script/workflow did all three in one pass, so
a project's `dotnet build` (fast, no network) was gated behind the same 7-second-per-URL
download throttle that only the *first* stage actually needs, and a partially-failed
run mixed up "did the code regenerate" with "did nuget.org get the new version" in one
state. Splitting means generation is no longer slowed down by anything network-related,
and publishing has a single, simple job: compare what's committed against what
nuget.org actually has, and push the difference - see "Publishing to NuGet.org" below.

The **arc56/ download step is shared with the [TypeScript pipeline](typescript-client-pipeline.md)**
- a spec is downloaded once regardless of how many client languages get generated from
it. Only stages 2-3 are ecosystem-specific.

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
- **On-disk layout**: each source GitHub repo gets one directory under `clients/`,
  shared across every ecosystem's generated client for that repo. The downloaded ARC-56
  specs live at the repo level (`arc56/`), shared across ecosystems (.NET and
  TypeScript today) since they're the same source files regardless of which client
  language is generated from them; the .NET package lives in its own `dotnet/`
  subfolder:
  ```
  clients/<owner>/<repo>/
    arc56/
      <file_slug>_<hash8>.arc56.json   # copy of the source spec, shared across ecosystems
      state.json                       # download bookkeeping: content hash / download error per URL
    dotnet/
      <PackageId>.csproj
      README.md              # per-project usage doc, includes a table of every contract
      state.json              # generation state: version, increment, per-contract content/code hashes
      src/<file_slug>_<hash8>.cs             # generated client
  ```
  The `.csproj` bundles `../arc56/**/*.json` into the nupkg's `contentFiles/`.
- **Shared assets**: `clients/_template/` holds `Project.csproj.template`,
  `README.md.template`, and `icon.png` (one shared package icon reused by every project,
  so all Arc56Registry-generated packages are visually recognizable together - see it at
  `clients/_template/icon.png`). Every package's `PackageProjectUrl` and
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
  bytes, recorded by the **download** stage), or
- the generator Docker image's digest changed since *this project* last recorded one
  (each project's `dotnet/state.json` stores the digest it was last processed with -
  there is no single shared "last seen" file, so a large run's progress isn't
  all-or-nothing).

Either of those can cause a rerun of the generator, but if the resulting `.cs` content is
byte-identical to what's already there (common: the same generator version reproduces
the same output for unchanged input), the version is **not** bumped - only the
bookkeeping (content hash, recorded generator digest) is updated. Generator-crash
failures are recorded in `state.json` (so they aren't silently lost or retried every
run) but never bump the version either, since no `.cs` file changed. Download failures
are tracked separately, in `arc56/state.json` (see "Rate limiting" below) - the generate
stage simply skips a contract whose spec hasn't been downloaded yet.

A project's version is also bumped - even with zero contract/code changes - when the
shared templates under `clients/_template/` (`Project.csproj.template`,
`README.md.template`) change. Each project's `state.json` stores a `template_hash`
(SHA-256 over both template files); a mismatch is treated the same as a code change, so
that project's README/csproj get re-rendered from the new templates and its version is
bumped. Because every project shares the same two template files, editing a template
bumps **every** package on the next generate run, not just one.

`increment` is a per-project counter stored in that project's `state.json`, incremented
by 1 when the generated code actually changes, or when the shared templates change.

Existing rows are never deleted from `arc56.links.csv` (see
[arc56-links-pipeline.md](arc56-links-pipeline.md)), and this pipeline mirrors that:
generated files and state entries are never removed, only added to or updated in place.

## Rate limiting

Every ARC-56 spec is downloaded by the **download** stage
(`scripts/download_arc56_specs.py`), with **at least 7 seconds between downloads**, to
avoid tripping GitHub's anonymous rate limits on raw.githubusercontent.com. The
**generate** stage makes no network request for the spec at all - it reads the local
copy the download stage already wrote and hands it to the generator via its `--file`
flag (mounted into the container). A URL that fails to download is recorded in that
repo's `clients/<owner>/<repo>/arc56/state.json` (a `download_error` field) and is not
retried every run - only when `--retry-failed` is passed to the download script (the
workflow's `retry_failed` dispatch input).

## Generator failures

The generator is an external tool and can crash on some ARC-56 specs (observed: a
`NullReferenceException` in `ABITypeToCSType` for certain struct shapes). A crash for one
contract does not abort the run:

- the failure is logged and recorded in that project's `dotnet/state.json` (with a
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

The generator container is run with `--user "$(getuid):$(getgid)"` on POSIX (a no-op on
Windows, where `os.getuid()` doesn't exist) so it writes into the bind-mounted
`arc56/`/`src/` directories as the same user that owns them on the host. Without this,
a container-default user that differs from the host's (common on GitHub Actions
runners) can hit `UnauthorizedAccessException: Access to the path '/app/out/<file>.cs'
is denied` for some contracts - an ownership mismatch, not a bug in the ARC-56 spec
itself.

## Compile failures (quarantining)

Because every contract in a repo shares one compiled project, generation succeeding is
not enough - the generated C# also has to actually *compile* together with every other
contract in the same package. It doesn't always: observed in practice, some ABI type
shapes (e.g. an array of fixed-size byte arrays) produce code where `FixedArray<Byte>` is
used as `VariableArray<T>`'s type parameter without the public parameterless constructor
that requires - `error CS0310`. That's a limitation in the upstream generator's output,
not something fixable by changing our namespace/file naming.

After (re)generating a project's contracts, the **generate** stage runs `dotnet build`
on the aggregate project. If it fails, it parses the compiler output for the specific
file(s) at fault (`src/<contract_id>.cs(line,col): error ...`), and for each one:

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
testing, use the scoping flags (identical across all three scripts):

```bash
python scripts/download_arc56_specs.py --only-repo algorandfoundation/arc55-encryption
python scripts/generate_dotnet_clients.py --only-repo algorandfoundation/arc55-encryption
python scripts/publish_dotnet_packages.py --only-repo algorandfoundation/arc55-encryption --dry-run
```

```bash
--limit-projects 3
--filter scholtz
--filter scholtz/Biatec
```

`--only-repo` matches `owner/repo` exactly; `--filter` matches any `owner/repo` pair
whose (case-insensitive) string *contains* the given keyword. Both flags can be passed
multiple times (repeat the flag; in the GitHub Actions `workflow_dispatch` inputs, use a
comma-separated list instead) - multiple values for the same flag are OR'd together, but
if both `--only-repo` and `--filter` are given, a project must satisfy both.

Full, unscoped runs are meant for CI. Since state is tracked per-project rather than in
one shared file, `--only-repo`/`--filter`/`--limit-projects` runs don't affect anything
outside the projects they touch.

`generate_dotnet_clients.py` doesn't pack a project itself anymore - that's
`publish_dotnet_packages.py`'s job (see below). To pack manually:

```bash
dotnet pack clients/<owner>/<repo>/dotnet/<PackageId>.csproj --configuration Release --output artifacts/nupkgs
```

`--commit` (used by CI - see below) is **off by default** for local runs of the
download/generate scripts, specifically so trying them out locally never creates a
commit in your working copy unless you pass it yourself. `publish_dotnet_packages.py`
has no `--commit` flag at all - see "Publishing to NuGet.org".

## Publishing to NuGet.org

Publishing is its own script and workflow
(`scripts/publish_dotnet_packages.py` / `publish-dotnet-packages.yml`), decoupled from
generation - it never regenerates any code and never downloads any spec. For every
generated `clients/<owner>/<repo>/dotnet/*.csproj` project, it:

1. Reads the version that project's `state.json` says it should be at (set by
   `generate_dotnet_clients.py` when that project's code last changed).
2. **Lists every version of that package ID already published**, straight from
   nuget.org's own package-content index (`GET
   https://api.nuget.org/v3-flatcontainer/<id-lower>/index.json`) - not a locally
   cached "published_version" flag. This is the "list all published library versions
   and publish only what needs publishing" behavior: nuget.org itself is the single
   source of truth for what's live, so a partially-failed previous publish run, or a
   manual push done outside this pipeline, is always detected correctly.
3. If the project's current version isn't in that list, packs it (`dotnet pack`) and
   pushes it (`dotnet nuget push --skip-duplicate`), waiting at least 5 seconds between
   pushes so nuget.org isn't hammered on a run that has many packages to catch up on.

`state.json`'s `published_version` field is still written after a successful push, but
only as an informational cache for humans reading the file - it is never read back to
decide whether to publish; step 2 above is what actually decides that, every run.

Pushing uses **Trusted Publishing** - short-lived, OIDC-issued API keys, not a
long-lived secret stored in the repo. This is the same mechanism as PyPI's Trusted
Publishing: GitHub Actions issues a signed OIDC token for the job, nuget.org validates
it against a policy you configure once, and hands back an API key that's valid for
about an hour.

### One-time setup

1. **Create a Trusted Publishing policy on nuget.org.**
   - Log into [nuget.org](https://www.nuget.org) with an account that owns (or is a
     member of the org that owns) the `Arc56.Generated.*` packages.
   - Click your username -> **Trusted Publishing** -> add a new policy.
   - Fill in, for this repo (`https://github.com/scholtz/ARC56Registry`):
     - **Repository Owner**: `scholtz`
     - **Repository**: `ARC56Registry`
     - **Workflow File**: `publish-dotnet-packages.yml` (file name only - do **not**
       include the `.github/workflows/` path, and note this is the *publish* workflow,
       not `generate-dotnet-clients.yml` - the split pipeline means only the publish
       stage's job ever requests an OIDC token or pushes to nuget.org)
     - **Environment**: leave empty (this workflow doesn't use a GitHub Actions
       `environment:`)
   - Choose the policy **owner** (your user, or the org, whichever owns the packages) -
     this determines which packages the policy is allowed to publish to.
   - If the repo is private, the policy starts in a 7-day "pending activation" window
     and needs one successful publish within that window to become permanent (see
     Microsoft's [Trusted Publishing docs](https://learn.microsoft.com/en-us/nuget/nuget-org/trusted-publishing)
     for why - it's to bind the policy to the repo's durable GitHub ID, preventing
     resurrection attacks after a repo delete/recreate).

2. **Add the `NUGET_USER` repo secret.** Trusted Publishing still needs to know *which*
   nuget.org account to request a temporary key for - that's the `user` input to the
   `NuGet/login` action in the workflow, sourced from `${{ secrets.NUGET_USER }}`. In
   this repo's **Settings > Secrets and variables > Actions**, add:
   - Name: `NUGET_USER`
   - Value: your nuget.org **username** (profile name) - not your email address, and
     not an API key. There is nothing secret about this value on its own; it's stored
     as a secret only so it isn't hardcoded in the workflow file.

   No `NUGET_API_KEY` (or any other long-lived credential) is needed or stored in this
   repo - that's the point of Trusted Publishing. The workflow's `id-token: write`
   permission (already set at the workflow level) is what lets the job request the
   short-lived OIDC token in the first place; without it the `NuGet/login` step fails
   silently to obtain a usable token.

### What the workflow does

1. Once, at job start: if the `NUGET_USER` secret is set, `NuGet/login@v1` exchanges the
   job's GitHub OIDC token for a short-lived nuget.org API key
   (`steps.nuget_login.outputs.NUGET_API_KEY`), passed to the script as the
   `NUGET_API_KEY` env var. If `NUGET_USER` isn't set yet, this step (and therefore
   every push below) is skipped - `publish_dotnet_packages.py` then exits nonzero
   (unless `--dry-run` is passed) rather than silently doing nothing, so a missing
   secret is visible in the workflow's status rather than a quiet no-op.
2. `python scripts/publish_dotnet_packages.py` does the list-then-publish logic
   described above.
3. Any `published_version` bookkeeping the script wrote to `state.json` files is
   committed and pushed in a final step.

Within the script, `dotnet nuget push ... --skip-duplicate` is used for every push,
making it safe to retry: pushing a version that's already on nuget.org is a no-op
instead of a failure.

### Retrying a failed publish

Because step 2 above (list what's actually published) is re-derived from nuget.org on
every run rather than trusted from a local flag, a push that fails partway through a
run (network blip, or - on a very large catch-up run - the OIDC API key expiring after
about an hour) simply leaves that version out of nuget.org's own index. The **next**
run's listing call sees that and retries the pack+push before doing anything else for
that project - no separate "retry" logic or flag needed; it falls out of always
comparing against the live source of truth.

**nuget.org's push quota** (documented at 350/hour per API key, see
[Rate Limits, NuGet API](https://learn.microsoft.com/en-us/nuget/api/rate-limits); in
practice can be enforced more strictly than that) is why `PUBLISH_DELAY_SECONDS` in
`publish_dotnet_packages.py` is 15s, not the 5s used elsewhere - a large catch-up run
publishing hundreds of new package IDs can still exceed it. If nuget.org responds `403
Quota Exceeded`, the script stops pushing immediately (rather than retrying every
remaining project only to get the same 403) and exits nonzero; nothing is lost, since
the same self-healing listing logic above means the next scheduled run just resumes
where this one stopped. Don't "fix" a quota-exceeded failure by lowering
`PUBLISH_DELAY_SECONDS` further or retrying in a tight loop within the same run - it
only makes the quota window reset later.

### Committing

Unlike the download and generate stages, the publish stage's only source-tree changes
are the `published_version` bookkeeping field in each project's `state.json` (informational
only, per above) - there's no per-project commit-as-you-go here, just one final commit
of whatever bookkeeping changed, at the end of the run.

## Recovering from a failed run (fast catch-up)

Each stage is independently resumable:

1. **Download**: a URL that fails is recorded (`download_error`) and skipped on
   subsequent runs unless `--retry-failed` is passed - so a network blip only costs
   that one URL, not the whole run.
2. **Generate**: content-hash comparisons make "did this contract's spec change since
   we last generated it" fast to check, so a run that stops partway through only has
   real work left to do for what's actually missing or changed.
3. **Publish**: since the list of published versions comes from nuget.org itself, a run
   that dies mid-push just leaves that project's version out of the list - the next
   run's listing call notices and retries it, with no separate bookkeeping to get out
   of sync.

Each script's per-project loop wraps processing in a try/except so one unexpected
project failure (a permissions error, a transient network failure, a runner hiccup)
doesn't abort the whole run - it's logged and the loop continues to the next project.
The script still exits nonzero if anything hit that path, so CI shows red and a human
notices, but only after everything else has already been processed.

## Known limitations

- **Run time**: a full first-time download run fetches every active URL in
  `arc56.links.csv` (thousands, and growing), 7+ seconds apart - this alone can take
  hours. The generate and publish stages are much faster once the specs are local,
  since only changed content triggers regeneration/republishing. Workflow
  `timeout-minutes` values are set high to accommodate a cold-start full run.
- **OIDC API key expiry on very long publish runs**: the Trusted Publishing API key
  obtained at job start is valid for about an hour. On a run so large that publishing
  is still going after that (realistically only a large initial catch-up, not a routine
  incremental one), later pushes in that same run will fail once the key expires. This
  is not silently lost - see "Retrying a failed publish" above - but it does mean
  publishing for those later projects lags by one more scheduled run.
- **`HEAD`-pinned sources**: like the links CSV itself, ARC-56 URLs point at `HEAD`, so a
  source repo rewriting its default branch could change what the next download run
  fetches.
- **No license metadata**: generated packages don't set `PackageLicenseExpression` since
  this repository doesn't currently have a LICENSE file. Add one and update
  `clients/_template/Project.csproj.template` accordingly.
