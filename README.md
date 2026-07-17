# Arc56Registry

An automatically maintained registry of every public [ARC-56](https://github.com/algorandfoundation/ARCs/blob/main/ARCs/arc-0056.md)
smart-contract spec on GitHub, and a pipeline that turns each one into a typed,
ready-to-use client library - in C#/.NET today, with TypeScript and Python planned.

No one has to submit anything here manually: if your public repo has an
`*.arc56.json` file anywhere in it, this project finds it, and (for .NET so far)
publishes a NuGet package with a typed client for it.

## What's in this repo

| Path | What it is |
| --- | --- |
| [arc56.links.csv](arc56.links.csv) | The registry itself: every discovered `*.arc56.json` URL, with `ActiveFrom`/`ActiveUntil` columns controlling whether it's currently included. |
| [scripts/update_arc56_links.py](scripts/update_arc56_links.py) | Finds ARC-56 files on GitHub and updates the CSV. Never removes a row. |
| [scripts/validate_arc56_links.py](scripts/validate_arc56_links.py) | Pull-request check enforcing the CSV's schema and edit rules. |
| [scripts/generate_dotnet_clients.py](scripts/generate_dotnet_clients.py) | Generates the C# clients and NuGet packages described below. |
| [clients/](clients/) | One folder per GitHub repo (`clients/<owner>/<repo>/`), each holding one subfolder per ecosystem's generated client package - `dotnet/` today, with `npm/`/`python/` planned so all of a repo's packages live together. |
| [.github/workflows/](.github/workflows/) | The three scheduled/triggered pipelines tying all of the above together. |
| [docs/](docs/) | Detailed docs for each pipeline (linked below). |

## The two pipelines

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

### 2. Generating typed .NET clients

[`generate-dotnet-clients.yml`](.github/workflows/generate-dotnet-clients.yml) reads
every *active* row in the CSV, downloads the spec (rate-limited to one download per 7+
seconds), and runs it through the ARC-56 client generator from
[scholtz/dotnet-algorand-sdk](https://github.com/scholtz/dotnet-algorand-sdk) (the
[`scholtz2/dotnet-avm-generated-client`](https://hub.docker.com/r/scholtz2/dotnet-avm-generated-client)
Docker image) to produce a C# client class.

**One NuGet package per GitHub repository** (currently 505 repos, 4,284 contracts and
growing) bundles every contract found in that repo, e.g. `Arc56.Generated.akita-protocol.akita-sc`.
Within a package, each contract gets its own namespace incorporating both its filename
and a hash of its source URL, so identically-named specs in different parts of the same
repo never collide. Every package carries a shared icon so people can visually recognize
an Arc56Registry-generated package, and links back to this repo.

Versions follow `1.0.<increment>.<yyyyMMddHH>` - a new version is published whenever a
repo's ARC-56 content changes, or whenever the generator Docker image itself is updated
(which forces every package to regenerate).

Full details, naming rules, and failure handling: **[docs/dotnet-client-pipeline.md](docs/dotnet-client-pipeline.md)**.

## Status

- ✅ Registry discovery + validation (arc56.links.csv)
- ✅ .NET/C# client generation pipeline
- ⏳ TypeScript client generation - not started
- ⏳ Python client generation - not started
- ⏳ Automated `dotnet nuget push` to nuget.org - packages are built and uploaded as a
  workflow artifact, but publishing requires a `NUGET_API_KEY` secret to be provisioned
  first (see [docs/dotnet-client-pipeline.md](docs/dotnet-client-pipeline.md#publishing-to-nugetorg))

## Contributing

- To add or fix a discovered ARC-56 URL by hand, edit `arc56.links.csv` directly - see
  [docs/arc56-links-pipeline.md](docs/arc56-links-pipeline.md#pull-request-validation)
  for the exact rules the PR check enforces.
- To change how .NET clients are generated or packaged, see
  [docs/dotnet-client-pipeline.md](docs/dotnet-client-pipeline.md) and
  `clients/_template/`.
