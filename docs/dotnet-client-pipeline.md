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
- **On-disk layout**: each source GitHub repo gets one directory under `clients/`,
  shared across every ecosystem's generated client for that repo (.NET today, npm and
  Python planned - see [README.md](../README.md)). The downloaded ARC-56 specs live at
  the repo level (`arc56/`), shared across ecosystems since they're the same source
  files regardless of which client language is generated from them; the .NET package
  lives in its own `dotnet/` subfolder:
  ```
  clients/<owner>/<repo>/
    arc56/<file_slug>_<hash8>.arc56.json   # copy of the source spec, shared across ecosystems
    dotnet/
      <PackageId>.csproj
      README.md              # per-project usage doc, includes a table of every contract
      state.json             # generation state: version, increment, per-contract content hashes
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

The generator container is run with `--user "$(getuid):$(getgid)"` on POSIX (a no-op on
Windows, where `os.getuid()` doesn't exist) so it writes into the bind-mounted
`arc56/`/`src/` directories as the same user that owns them on the host. Without this,
a container-default user that differs from the host's (common on GitHub Actions
runners) can hit `UnauthorizedAccessException: Access to the path '/app/out/<file>.cs'
is denied` for some contracts - an ownership mismatch, not a bug in the ARC-56 spec
itself. Like the other generator failures above, this was already non-fatal (recorded
as a `generator_error`, run continues) even before the `--user` fix; the fix just
avoids hitting that failure in the first place.

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

The script packs a project itself (see "Publishing to NuGet.org" below) as soon as
that project's version is bumped - you don't need to run `dotnet pack` separately
unless you want to. To do it manually anyway:

```bash
dotnet pack clients/<owner>/<repo>/dotnet/<PackageId>.csproj --configuration Release --output artifacts/nupkgs
```

`--publish` and `--commit` (both used by CI - see below) are **off by default** for
local runs, specifically so trying the script out locally never pushes a package to
nuget.org or creates a commit in your working copy unless you pass those flags
yourself.

## Publishing to NuGet.org

Publishing is **per-project and immediate, not batched**: the script processes
`owner/repo` projects one at a time (see `process_project`/`main` in
`scripts/generate_dotnet_clients.py`), and the moment a project's version is bumped it
is packed and (with `--publish`) pushed to nuget.org right there, before the script
moves on to the next project. A full run touching many repos therefore shows packages
landing on nuget.org steadily as the run progresses, not all at once in a final step
after every repo has been generated - useful given a full run can take hours (see
"Known limitations").

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
   - Fill in, for this repo (`https://github.com/scholtz/ARC56Registry`, workflow at
     `.github/workflows/generate-dotnet-clients.yml`):
     - **Repository Owner**: `scholtz`
     - **Repository**: `ARC56Registry`
     - **Workflow File**: `generate-dotnet-clients.yml` (file name only - do **not**
       include the `.github/workflows/` path)
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
   every push below) is skipped - the script still runs and packs normally.
2. `python scripts/generate_dotnet_clients.py --publish --commit ...` does the actual
   per-project pack+push+commit, described above and below - see `pack_project`,
   `push_to_nuget`, `ensure_published`, and `commit_project_changes` in the script for
   the exact mechanics.
3. `git push` at the very end pushes whatever local commits the run made - see
   "Committing" below for why commits happen inside the script rather than here.

Within the script, `dotnet nuget push ... --skip-duplicate` is used for every push,
making it safe to retry: pushing a version that's already on nuget.org is a no-op
instead of a failure.

### Committing

Like publishing, committing is **per-project, not batched**: with `--commit`,
`commit_project_changes()` runs right after each project is processed (successfully or
not - a download/generator failure alone still touches `state.json` and an incident
report, which is worth its own commit) and stages+commits only that project's own
`clients/<owner>/<repo>/` directory plus the shared `clients/_incidents/` index -
nothing else. It's a no-op (`git diff --cached --quiet` short-circuits it) when nothing
actually changed for that project. This mirrors the pack/publish reasoning: a run
touching many repos produces one commit per changed repo as it goes, not one giant
commit for the whole run at the end - useful for `git bisect`/history and for the same
"see it progress instead of waiting for everything" reason as incremental publishing.

`--commit` also pushes - throttled, not once per commit and not only at the very end.
`push_commits()` runs after every `commit_project_changes()` call but is a no-op unless
at least `PUSH_INTERVAL_SECONDS` (60s) have passed since the last push, plus one
unconditional final flush after the whole loop finishes. This bounds how much
already-finished work (commits, and the nuget.org publishes that go with them) can be
stranded on the runner if the job dies before its own final step runs - see "Recovering
from a failed run" below, which is the actual point of pushing periodically rather than
only at the end.

CI's own final step ("Commit any remaining changes and push" in
`generate-dotnet-clients.yml`) still exists on top of this, as a defensive fallback: it
commits anything that somehow wasn't captured per-project (shouldn't normally find
anything with `--commit` passed) and then unconditionally runs `git push` once more, to
flush whatever's left since the script's last periodic push.

`--commit` is opt-in (see "Running it locally" above) precisely so it can configure a
repo-local git identity (`github-actions[bot]`, via `git config` with no `--global`)
and create real commits - safe for CI, but not something a plain local test run should
do without asking for it.

### Retrying a failed publish

Each project's `state.json` records a `published_version` field alongside the existing
`version`. A push can fail without aborting the run (network blip, or - see "Known
limitations" below - the OIDC API key expiring mid-run on a very long run); when that
happens `published_version` is simply left behind `version`. The **next** run - even
one that finds no new code changes for that project - notices the mismatch and retries
the pack+push before doing anything else for that project, so a failed publish always
self-heals on the next scheduled/dispatched run rather than being silently dropped.

### Recovering from a failed run (fast catch-up)

A run touching thousands of URLs, 7+ seconds apart, is exactly the kind of long-running
process where *something* eventually goes wrong partway through - a docker/dotnet/git
permissions error, a transient network failure, a runner hiccup. The pipeline is built
so that when that happens, the **next** run picks up close to where the failed one left
off instead of redoing everything from scratch:

1. **One unexpected project failure doesn't abort the run.** `process_project` already
   turns the failure modes seen in practice (download errors, generator crashes,
   compile errors) into recorded, non-fatal state. `main()`'s per-project loop wraps the
   whole iteration (`process_project` + incidents rebuild + commit + push) in a
   try/except as a last line of defense: an exception for one project is logged and
   that project is skipped, but the loop continues on to every other project rather
   than dying. The script still exits nonzero if *any* project hit this path (so CI
   shows red and a human notices), but only after everything else has already been
   packed, published, committed, and pushed.
2. **Completed work is pushed as it happens, not stranded on the runner.** Because
   `--commit` pushes periodically (see above) rather than only at the very end, a run
   that dies loses at most the last `PUSH_INTERVAL_SECONDS` worth of commits - not
   hours of prior progress. The workflow's tail steps (`Upload packed NuGet packages`,
   `Commit any remaining changes and push`) run with `if: always()`, so even a hard
   script crash still gets whatever's left flushed and pushed.
3. **The next run only has real work to do for what's actually missing.** Since
   everything up to the failure point is already committed to `main` and already
   published (`published_version` matches `version` in `state.json`), the next run's
   `needs_regen`/`ensure_published` checks see no work needed for those projects -
   `git status`/content-hash comparisons make that fast, not "download and regenerate
   everything from the beginning to confirm nothing changed." Only the project that was
   genuinely mid-flight (or never reached at all) when the run stopped ends up doing
   real work, which is what makes catch-up fast rather than a full-cost rerun.

## Known limitations

- **Run time**: a full first-time run downloads and generates a client for every active
  URL in `arc56.links.csv` (thousands, and growing), 7+ seconds apart, plus generation and (for changed
  projects) `dotnet pack` time. This can take hours. The workflow's `timeout-minutes` is
  set high (350) to accommodate this; subsequent runs are much faster since only changed
  content triggers regeneration.
- **OIDC API key expiry on very long runs**: the Trusted Publishing API key obtained at
  job start is valid for about an hour. On a run so large that generation is still
  going after that (realistically only an initial full run across thousands of URLs,
  not a routine incremental one), later pushes in that same run will fail once the key
  expires. This is not silently lost - see "Retrying a failed publish" above - but it
  does mean publishing for those later projects lags by one more scheduled run.
- **`HEAD`-pinned sources**: like the links CSV itself, ARC-56 URLs point at `HEAD`, so a
  source repo rewriting its default branch could change what the next run downloads.
- **No license metadata**: generated packages don't set `PackageLicenseExpression` since
  this repository doesn't currently have a LICENSE file. Add one and update
  `clients/_template/Project.csproj.template` accordingly.
