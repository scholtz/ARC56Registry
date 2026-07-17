# Arc56Registry - instructions for Claude

Registry of public ARC-56 smart-contract specs + a pipeline that generates typed client
libraries from them. Full narrative docs live in [README.md](README.md) and
[docs/](docs/) - read this file first, only open those for details this file doesn't
cover.

## Repo map

- `arc56.links.csv` - the registry. Columns: `ARC56URL,ActiveFrom,ActiveUntil`.
- `scripts/update_arc56_links.py` - finds new ARC-56 files on GitHub, merges into the CSV.
- `scripts/validate_arc56_links.py` - PR check enforcing the CSV's rules.
- `scripts/generate_dotnet_clients.py` - generates C# clients + NuGet packages.
- `clients/<owner>/<repo>/dotnet/` - one .NET project per source GitHub repo. Sibling
  `npm/`/`python/` subfolders are planned so all of a repo's generated packages live
  together under `clients/<owner>/<repo>/`.
- `clients/_template/` - shared csproj/README templates + shared package icon.
- `docs/arc56-links-pipeline.md` - full detail on the CSV pipeline.
- `docs/dotnet-client-pipeline.md` - full detail on the .NET client pipeline.

## Hard rules - do not violate these

1. **Never delete a row from `arc56.links.csv`, and never delete a generated
   `clients/**` file.** Deactivate instead: set `ActiveUntil` to a date. This
   applies to scripts and to manual edits alike.
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
   - Raw file downloads (`raw.githubusercontent.com`) - `generate_dotnet_clients.py`
     enforces 7s between downloads for the same reason.
4. **CSV must stay valid CSV per GitHub's rendering rules** (RFC 4180 quoting via
   Python's `csv` module, not manual string joins) so it renders as a table on GitHub.
5. **One NuGet package per GitHub repo, not per contract.** Per-contract uniqueness
   comes from the namespace (`Arc56.Generated.<owner>.<repo>.<file_slug>_<hash8>`), not
   from splitting into more packages.
6. **Never commit changes unless asked.** This applies doubly to `git push` and to
   anything that would trigger a NuGet publish.

## Local testing

Docker and the .NET SDK are both available in this environment and have been used
successfully. Docker volume mounts need a plain path (no spaces, no short `~1` names) -
mount under the repo itself or another simple path, not a Windows temp dir with a
tilde-shortened segment (that silently produces an empty mount).

Never run `scripts/generate_dotnet_clients.py` unscoped locally - it processes
thousands of URLs at 7s+ each. Always use `--only-repo owner/repo` or
`--limit-projects N` for local runs; see docs/dotnet-client-pipeline.md.

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

- Versioning is the 4-part legacy scheme `1.0.<increment>.<yyyyMMddHH>` - matches what
  `Algorand4` (the runtime dependency of every generated client) already uses.
- No LICENSE file exists yet, so generated `.csproj`s intentionally omit
  `PackageLicenseExpression`. Don't add one without the user deciding on a license first.
- `dotnet nuget push` to nuget.org is NOT wired up (commented out in the workflow) -
  needs a `NUGET_API_KEY` secret the user hasn't provisioned yet. Don't uncomment it
  without confirming that secret exists.
