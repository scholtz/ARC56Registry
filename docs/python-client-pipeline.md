# Python ARC-56 client generation pipeline

This pipeline turns every active row in [arc56.links.csv](../arc56.links.csv) into a
typed Python client, packaged as one PyPI package per GitHub repository - the same
one-package-per-repo shape as the [.NET](dotnet-client-pipeline.md) and
[TypeScript](typescript-client-pipeline.md) pipelines, split into the same three
independent stages:

| Stage | Script | Workflow | What it does | Network use |
| --- | --- | --- | --- | --- |
| 1. Download | [`scripts/download_arc56_specs.py`](../scripts/download_arc56_specs.py) | [`download-arc56-specs.yml`](../.github/workflows/download-arc56-specs.yml) | Fetches every active ARC-56 spec into `clients/<owner>/<repo>/arc56/` | Rate-limited, 7s+ between downloads |
| 2. Generate | [`scripts/generate_python_clients.py`](../scripts/generate_python_clients.py) | [`generate-python-clients.yml`](../.github/workflows/generate-python-clients.yml) | Regenerates Python source + bumps versions from the locally-downloaded specs | None (resolving/installing the generator package from PyPI is a one-time-per-run metadata + wheel request, not per-contract) |
| 3. Publish | [`scripts/publish_python_packages.py`](../scripts/publish_python_packages.py) | [`publish-python-packages.yml`](../.github/workflows/publish-python-packages.yml) | Builds and publishes to PyPI whatever PyPI doesn't already have | Rate-limited, 20s+ between publishes |

**Stage 1 is shared with the .NET and TypeScript pipelines** - a spec is downloaded
once into `clients/<owner>/<repo>/arc56/` regardless of how many client languages get
generated from it. Only stages 2-3 are Python-specific.

It uses the ARC-56/ARC-32 client generator from
[algorandfoundation/algokit-client-generator-py](https://github.com/algorandfoundation/algokit-client-generator-py)
(the `algokit-client-generator` PyPI package, whose console-script entry point is
`algokitgen-py`) - a plain `pip`-installable CLI tool, like the TypeScript pipeline's
generator is a plain `npm`/`npx`-installable one. No Docker image needed, unlike the
.NET generator.

## Naming and packaging conventions

**One PyPI package per GitHub repository**, mirroring the other two pipelines'
one-package-per-repo convention.

- **Distribution name**: `arc56-generated-<owner>-<repo>` (owner/repo lowercased and
  sanitized to valid PyPI name characters, using the exact same sanitizing logic as the
  TypeScript pipeline's npm package names - PyPI compares names case-insensitively with
  `-`/`_`/`.` treated as equivalent per [PEP 503](https://peps.python.org/pep-0503/),
  so the lowercase-hyphenated npm scheme carries over safely). Example:
  `arc56-generated-akita-protocol-akita-sc`.
- **Import package name**: the distribution name with every `-` replaced by `_`
  (Python package/module names can't contain hyphens), e.g.
  `arc56_generated_akita_protocol_akita_sc`. This is what you `import`, even though you
  `pip install` the hyphenated distribution name - completely normal and expected in
  the Python packaging ecosystem (e.g. `pip install pillow` gives you `import PIL`).
- **Per-contract module**: each contract is generated into its own module,
  `src/<import_pkg>/<file_slug>_<hash8>.py`, and re-exported from that package's
  `src/<import_pkg>/__init__.py`: `from . import <file_slug>_<hash8> as
  <file_slug>_<hash8>`. This is the Python equivalent of the TypeScript pipeline's
  namespace re-export (`export * as ... from './...'`) and the .NET pipeline's
  per-contract C# namespace - `hash8` (the first 8 hex characters of
  `sha256(source URL)`) keeps two differently-named-but-colliding contracts, or two
  contracts that happen to generate identically-named classes, from clashing when
  imported through one package.
- **On-disk layout**:
  ```
  clients/<owner>/<repo>/
    arc56/                              # shared with the .NET and TypeScript pipelines
    python/
      pyproject.toml
      README.md                         # per-project usage doc, includes a table of every contract
      state.json                        # generation state: version, increment, per-contract content/code hashes
      src/
        <import_pkg>/
          __init__.py                   # re-exports every non-quarantined contract module
          <file_slug>_<hash8>.py        # generated client
  ```
- **Shared assets**: `clients/_template_python/` holds `pyproject.toml.template` and
  `README.md.template` - the Python-pipeline equivalent of `clients/_template/` (.NET)
  and `clients/_template_npm/` (TypeScript).
- **Build backend: [hatchling](https://hatch.pypa.io/)**, a standard PEP 517 backend
  with no compiled-extension surprises and simple `src/` layout support
  (`[tool.hatch.build.targets.wheel] packages = ["src/<import_pkg>"]`), used purely to
  turn a plain Python package into an installable sdist/wheel - it has no bearing on
  the generated client code itself.
- **Generator mode: `minimal`, not the generator's own default `full`**, for the same
  reason the TypeScript pipeline picks `minimal`: `full` mode also emits a deploy/create
  `Factory` class and deployment metadata (source, bytecode, template variables) that
  roughly doubles output size and is only useful for deploying *new* contract instances
  - dead weight for a registry whose job is decoding/calling contracts that are already
  deployed.

## Versioning

Versions follow `1.<increment>.<yyyyMMddHH>` - **the exact same string** the
TypeScript pipeline produces, because it happens to satisfy both ecosystems' version
rules at once: valid [semver](https://semver.org/) (three numeric components, no
leading zero on a nonzero segment - `yyyyMMddHH` always starts with a nonzero year) and
valid [PEP 440](https://peps.python.org/pep-0440/) (three dot-separated non-negative
integers is always a legal "final release" version). Keeping one shared scheme across
both pipelines - rather than inventing a Python-specific one - means there's exactly one
versioning rule to remember, not three.

Exactly like the .NET and TypeScript pipelines, a project's version is bumped, and only
that project is rebuilt, when:

- **the actual generated Python code for at least one of its contracts changed**
  (compared by SHA-256 of the generated `.py` file's bytes, not merely "we attempted
  regeneration"), triggered by either the contract's ARC-56 content changing or the
  generator PyPI package's version changing since this project last recorded one
  (`generator_version` in `python/state.json`), or
- the shared templates under `clients/_template_python/` change (`template_hash`
  mismatch).

A rerun that reproduces byte-identical `.py` output does **not** bump the version -
only the bookkeeping is updated. Generator-crash and compile failures are recorded in
`python/state.json` (`generator_error` / `py_compile_error`) but never bump the version
either. Download failures are tracked separately in `arc56/state.json` (shared across
all three pipelines) - the generate stage simply skips a contract whose spec hasn't
been downloaded yet.

## Rate limiting

Identical to the other two pipelines: all ARC-56 downloading happens in the shared
**download** stage, 7+ seconds apart. The **generate** stage makes no network request
per contract - it reads the local copy already on disk. It does query the PyPI JSON
API once per run (not per contract) to resolve the generator's current version, and
`pip install`s it if a different version isn't already installed - a one-time-per-run
cost, not per-contract rate limiting.

## Generator and compile failures (quarantining)

Mirrors the other two pipelines' compile-failure quarantining, adapted to Python:

1. **Generator crash**: `algokitgen-py -a <spec> -o <out> -m minimal` itself can fail
   for a given spec. Recorded as `generator_error` on that contract's `python/state.json`
   entry; the project's README lists it as "generation failed - see state.json"; not
   retried every run.
2. **Compile failure**: right after a contract's file is generated, the pipeline
   byte-compiles it (`py_compile.compile(..., doraise=True)`) to catch syntax errors.
   If it fails, the contract is recorded as `py_compile_error` on its `state.json`
   entry, listed in the README as "fails to compile - excluded, see state.json", its
   generated `.py` file is deleted from `src/<import_pkg>/`, and its `from . import ...`
   line is dropped from `__init__.py`.

   Unlike the TypeScript pipeline's `tsc --noEmit`, which type-checks the whole project
   together and therefore needs a multi-attempt retry loop to isolate which of
   potentially several newly-surfaced errors belongs to which file, this check runs
   **per file, immediately after that file is generated**, with no retry loop needed.
   That's a deliberate simplification, not a missing feature: every generated Python
   module is fully self-contained (it only imports the stdlib, `algosdk`, and
   `algokit_utils` - never another generated module), so there is no cross-file
   breakage a whole-project recheck could ever surface that a single file's own compile
   step wouldn't already catch. This also means Python contracts are quarantined for
   syntax errors only, not type errors - there is no Python-ecosystem equivalent of
   `tsc --noEmit` run here (a `mypy`/`pyright` pass was deliberately left out; see
   "Known limitations" below).

## Running it locally

Requires Python 3.10+ and `pip` (no Docker needed for this pipeline, matching the
TypeScript pipeline). Same scoping flags as the other two pipelines:

```bash
python scripts/download_arc56_specs.py --only-repo algorandfoundation/arc55-encryption
python scripts/generate_python_clients.py --only-repo algorandfoundation/arc55-encryption
python -m pip install build twine
python scripts/publish_python_packages.py --only-repo algorandfoundation/arc55-encryption --dry-run
```

`generate_python_clients.py` installs `algokit-client-generator` itself (via `pip`) if
it isn't already at the resolved latest version, and byte-compiles each generated file
to quarantine syntax errors (per above), but does not build a publishable sdist/wheel -
that's `publish_python_packages.py`'s job (`python -m build`). To build manually:

```bash
cd clients/<owner>/<repo>/python
python -m pip install build
python -m build
```

`--commit` (used by CI) is **off by default** for local runs of the download/generate
scripts. `publish_python_packages.py` has no `--commit` flag - see "Publishing to
PyPI" below.

### Committing during generation

Identical to the TypeScript pipeline: `generate_python_clients.py --commit`
checkpoints **at least every 5 minutes** (`PERIODIC_COMMIT_INTERVAL_SECONDS`), checked
on every row of a project's contract loop, not only when a project finishes - see
`maybe_checkpoint_commit()` in the script.

## Publishing to PyPI

Publishing is its own script and workflow (`scripts/publish_python_packages.py` /
`publish-python-packages.yml`), decoupled from generation exactly like the other two
pipelines' publish stages. For every generated
`clients/<owner>/<repo>/python/pyproject.toml` project, it:

1. Reads the version that project's `state.json` says it should be at.
2. **Lists every version of that package name already published**, straight from PyPI
   itself (`GET https://pypi.org/pypi/<package-name>/json`) - not a locally cached
   flag. Same "ask the registry, not a local record" principle as the other two
   pipelines.
3. If the project's current version isn't in that list, builds it (`python -m build`,
   producing an sdist + wheel into `dist/`) and publishes it (`twine upload --verbose
   dist/*`), waiting at least 20 seconds between publishes, plus an extra 60 seconds
   before the *first-ever* publish of a given package name specifically (see
   "Rate limiting" below).

See [docs/pypi-publishing-setup.md](pypi-publishing-setup.md) for the one-time
`PYPI_TOKEN` secret setup this needs, and why this pipeline uses a classic API token
rather than PyPI's newer OIDC Trusted Publishing (the same reasoning the npm pipeline's
own doc gives for `NPM_TOKEN`).

### Rate limiting

PyPI's upload endpoint (`https://upload.pypi.org/legacy/` - the name is a historical
artifact of PyPI's API history, not a sign it's deprecated; it's PyPI's real, current,
and only upload API) applies materially stricter abuse-prevention to **creating a new
project** than to publishing a new version of one that already exists - and every
package this pipeline creates is, by definition, brand new. Seen in practice: a run hit
HTTP 429 on the very first real publish attempt it made, with every project before it
in that run already up to date (no network publish call at all before that point) - so
`PUBLISH_DELAY_SECONDS`'s steady-state pacing between successive publishes never even
had a chance to apply. `NEW_PACKAGE_DELAY_SECONDS` (60s) adds an extra wait specifically
before a package name's first-ever publish, on top of the normal 20s pacing - mirroring
`NEW_PACKAGE_DELAY_SECONDS` in the TypeScript pipeline's own npm publisher, which
documents the same npm-side behavior. `twine upload` is also run with `--verbose`, so a
future rate-limit or other failure shows PyPI's actual response detail (by default,
twine swallows it and just suggests re-running with `--verbose` - too late, since this
script doesn't get a second attempt at the same request).

### Committing

Same as the other two pipelines' publish stages: the only source-tree change is each
project's `published_version` bookkeeping field in `python/state.json` (informational
only - publish decisions always re-derive from PyPI's own version list, never from this
field), committed once at the end of the run.

## Recovering from a failed run (fast catch-up)

Identical reasoning to the .NET and TypeScript pipelines (see
[dotnet-client-pipeline.md](dotnet-client-pipeline.md#recovering-from-a-failed-run-fast-catch-up)):
download failures are recorded and skipped until retried explicitly, generate-stage
content-hash comparisons make catch-up fast, and publish-stage catch-up falls out of
always comparing against PyPI's own live list rather than a local flag.

## Known limitations

- **Run time**: same cold-start cost as the other two pipelines - a full first-time
  download run is the slow part; generate/publish are fast once specs are local and
  only changed content triggers work.
- **Syntax-only quarantining, no type-checking**: unlike the TypeScript pipeline's
  `tsc --noEmit` pass, this pipeline does not run `mypy`/`pyright` over generated code.
  The generator's own output already carries `# mypy: ignore-errors`, so a project-wide
  type-check would mostly be checking the generator's own correctness rather than
  catching per-contract issues, at a real cost in run time (one `mypy` invocation per
  project, every run) - not worth it for this pipeline's actual goal (ship an
  importable client). A future addition could add it if generator bugs that produce
  syntactically valid but semantically broken code turn out to be a real problem.
- **`minimal` generator mode**: no deploy/create `Factory` class is generated (see
  "Naming and packaging conventions" above) - these packages are for decoding/calling
  existing deployed contracts, not deploying new ones.
- **algokit-utils/py-algorand-sdk version pins**: `clients/_template_python/pyproject.toml.template`
  pins `algokit-utils>=4.2.3,<5.0.0` and `py-algorand-sdk>=2.11.1,<3.0.0` - floors at
  the latest release of each verified to generate/build/install cleanly, ceilings
  matching what the generator itself tolerates: `algokit-client-generator`'s own PyPI
  metadata declares `algokit-utils (>=4.0.1,<5.0.0)` (`pip show
  algokit-client-generator`), and `algokit-utils`'s own metadata in turn declares
  `py-algorand-sdk (>=2.11.0,<3.0.0)` (`pip show algokit-utils`) - so neither ceiling
  can silently resolve to an untested future major. If a future generator or
  algokit-utils release changes either requirement, the template's pinned range needs a
  matching manual update, exactly the same maintenance burden the TypeScript pipeline's
  doc describes for `@algorandfoundation/algokit-utils`/`algosdk`. Because a template
  edit bumps and regenerates every project on the next run (see "Versioning" above),
  fixing the template once fixes every package. Verified end-to-end at these pins: a
  generated project builds (`python -m build`), passes `twine check`, and installs and
  imports cleanly in a clean virtualenv with `python -W error` (all warnings promoted
  to errors) - zero errors or warnings at any step.
- **`HEAD`-pinned sources**: like the links CSV itself, ARC-56 URLs point at `HEAD`.
- **No license metadata**: generated `pyproject.toml` files don't set a `license`
  field, matching the .NET and TypeScript pipelines' reasoning (no LICENSE file in this
  repo yet).
