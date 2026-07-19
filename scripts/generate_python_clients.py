#!/usr/bin/env python3
"""Generate/update the per-repository Python packages of ARC-56 clients.

Mirrors scripts/generate_typescript_clients.py, but for Python instead of TypeScript,
using the ARC-56/ARC-32 client generator from
[algorandfoundation/algokit-client-generator-py](https://github.com/algorandfoundation/algokit-client-generator-py)
(the `algokit-client-generator` PyPI package, whose console-script entry point is
`algokitgen-py`).

This is the second of three stages in the Python pipeline (download -> generate ->
publish; see scripts/download_arc56_specs.py and scripts/publish_python_packages.py).
It makes no network requests for ARC-56 specs and applies no rate-limiting delay of
its own - it only reads specs already downloaded by scripts/download_arc56_specs.py
into clients/<owner>/<repo>/arc56/, and does not publish anything to PyPI (that's
scripts/publish_python_packages.py's job). This script does query the PyPI JSON API
once per run (not per contract) to resolve the generator's current version and, if
necessary, `pip install`s it - the Python equivalent of `npx` fetching the TypeScript
generator package on first use, not the per-contract ARC-56 rate limiting this
pipeline cares about.

For every *active* row in arc56.links.csv whose spec has already been downloaded,
this script:

  1. Reads the local copy of the ARC-56 JSON spec from
     clients/<owner>/<repo>/arc56/<file_slug>_<hash8>.arc56.json.
  2. If its content changed (or the generator's PyPI package version changed, or it's
     new), regenerates the Python client via `algokitgen-py -a <spec> -o <out> -m
     full` into clients/<owner>/<repo>/python/src/<import_pkg>/<file_slug>_<hash8>.py,
     re-exported from that package's src/<import_pkg>/__init__.py
     (`from . import <file_slug>_<hash8> as <file_slug>_<hash8>`). Always tries "full"
     mode first (Client class *and* deploy/create Factory class), and falls back to
     "minimal" (Client only, no Factory) just for the specific contract if "full" mode
     fails to generate or fails the compile check below - see generate_python_client().
  3. Byte-compiles the freshly generated file (`py_compile`) to catch and quarantine
     any contract whose generated code still has a syntax error after the
     full->minimal fallback, so one broken contract doesn't block every other contract
     in the same package. Unlike the TypeScript pipeline's `tsc --noEmit`, this happens
     per-file right after generation rather than as a whole-project retry loop:
     generated Python modules never import each other (each is self-contained,
     importing only the stdlib, algosdk, and algokit_utils), so there is no cross-file
     breakage a project-wide recheck could ever surface that a single file's own
     compile step wouldn't already catch.

One PyPI package is produced per GitHub repository (owner/repo), matching the
.NET/TypeScript pipelines' one-package-per-repo convention. A repo's package version
is only bumped when at least one of its contracts actually changed content, the
generator's PyPI package version changed (forces every package to regenerate), or the
pyproject.toml/README templates under clients/_template_python/ changed. Version
format: `1.<increment>.<yyyyMMddHH>` - the same valid-semver/PEP 440-compatible scheme
the TypeScript pipeline uses (see docs/python-client-pipeline.md). Building (`python -m
build`) and publishing to PyPI are handled entirely by
scripts/publish_python_packages.py, run as its own separate pipeline stage.

Existing rows/files are never deleted, matching the rest of this repo's "never remove,
only deactivate" convention (see docs/arc56-links-pipeline.md).
"""
from __future__ import annotations

import argparse
import csv
import datetime
import hashlib
import json
import os
import re
import shutil
import subprocess
import sys
import time
import urllib.error
import urllib.request

REPO_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
CSV_PATH = os.path.join(REPO_ROOT, "arc56.links.csv")
CLIENTS_DIR = os.path.join(REPO_ROOT, "clients")
TEMPLATE_DIR = os.path.join(CLIENTS_DIR, "_template_python")
INCIDENTS_DIR = os.path.join(CLIENTS_DIR, "_incidents")

REGISTRY_REPO_URL = "https://github.com/scholtz/Arc56Registry"
GENERATOR_PACKAGE = "algokit-client-generator"
PYPI_JSON_URL = "https://pypi.org/pypi/{package}/json"
# Commit (and push) at least this often - checked both between projects and *during* a
# single large project's contract loop, mirroring the TypeScript pipeline's own
# checkpointing (see maybe_checkpoint_commit() below and
# docs/python-client-pipeline.md).
PERIODIC_COMMIT_INTERVAL_SECONDS = 300
# `algokitgen-py` has been observed to hang indefinitely on at least one malformed
# ARC-56 fixture (a test-suite artifact, not a real deployed contract) rather than
# exiting with a nonzero code - without a timeout, that single contract blocks the
# entire run forever, eventually killed only by the CI job's own multi-hour timeout
# (which loses everything generated since the last checkpoint, not just that one
# contract). GENERATOR_TIMEOUT_SECONDS turns that hang into an ordinary, per-contract
# `generator_error` (see run_generator()) so one bad spec can never take down the rest
# of the run. Kept short (not the generous 120s first tried): a real generation
# normally finishes in well under a second (it's a single-file, no-network, no-I/O
# operation), and a repo can contain more than one hanging spec (a compiler
# test-fixture repo, in particular, may have several boundary-value fixtures that each
# individually hang) - a large per-file timeout multiplies against every one of them
# and can still exhaust the job's overall time budget even though no single file blocks
# forever. spec_has_oversized_array() catches the specific known "absurd fixed-array
# length" pathology before ever reaching this timeout at all; this timeout remains as
# the backstop for any other, not-yet-seen kind of hang.
GENERATOR_TIMEOUT_SECONDS = 20
PIP_TIMEOUT_SECONDS = 300  # one-time per run, not per-contract, but still guarded
URLOPEN_TIMEOUT_SECONDS = 30
# compile_check() runs py_compile out-of-process (see its docstring) specifically so it
# can be bounded by a timeout too - a generator bug that produces syntactically valid
# but pathological Python (e.g. a huge literal built from a runaway loop) could in
# principle make even byte-compiling it slow, and an in-process call can't be safely
# killed after a timeout the way a subprocess can.
COMPILE_TIMEOUT_SECONDS = 30
# ARC-56 specs are meant to describe real, deployable AVM contracts, where a single box
# value already tops out at 32,768 bytes (the AVM's own per-box size limit) - so no
# legitimate fixed-array type in a spec can ever declare more elements than that. Seen
# in practice: compiler-test-suite repos (e.g. boundary-value fixtures for a Solidity
# compatibility layer) emit ARC-56 specs with types like `uint8[9223372036854775807]`
# (INT64_MAX) to exercise a language edge case, not to describe a real contract -
# algokit-client-generator has been observed to hang indefinitely trying to process
# one. GENERATOR_TIMEOUT_SECONDS bounds the damage from any single such file, but a
# repo can contain several, and each one still costs a full timeout; this check catches
# the known pattern up front, in microseconds, before ever spawning the generator at
# all - see spec_has_oversized_array().
MAX_SANE_FIXED_ARRAY_LENGTH = 1_000_000
FIXED_ARRAY_LENGTH_RE = re.compile(rb"\[(\d{7,})\]")
# See shorten_identifier() for why: keeps clients/<owner>/<repo>/python/src/<import_pkg>/
# safely short regardless of how long owner/repo get. Kept well under what would merely
# "just fit" a 260-char Windows MAX_PATH budget for the worst-case owner (39 chars) +
# repo (100 chars) combination, since that budget also has to cover the caller's own
# local clone path (e.g. C:\Users\...\ARC56Registry\), which this script has no way to
# know in advance.
MAX_DIST_NAME_LENGTH = 30
# Applied to a contract's file_slug (derived from the ARC-56 filename, which - like
# owner/repo - comes from an arbitrary GitHub repo and isn't otherwise bounded) for the
# same path-length reason.
MAX_FILE_SLUG_LENGTH = 30

RAW_URL_RE = re.compile(
    r"^https://raw\.githubusercontent\.com/(?P<owner>[^/]+)/(?P<repo>[^/]+)/[^/]+/(?P<path>.+)$"
)
FILENAME_SUFFIX = ".arc56.json"
# The algokitgen-py console script is a real executable (a Python entry-point shim),
# not a node .cmd wrapper, so subprocess.run() can launch it directly cross-platform -
# no WinError 2 dance like the TypeScript pipeline needs for npm/npx.
ALGOKITGEN_EXE = shutil.which("algokitgen-py") or "algokitgen-py"
PIP_EXE = shutil.which("pip") or "pip"
# Prefers the "...Client" class as the one worth naming in READMEs/state - falls back
# to the first exported class found if no "...Client"-suffixed one matches. Mirrors
# CLIENT_CLASS_RE in scripts/generate_typescript_clients.py.
CLIENT_CLASS_RE = re.compile(r"^class (\w*Client)\b", re.MULTILINE)
ANY_CLASS_RE = re.compile(r"^class (\w+)\b", re.MULTILINE)


def log(message: str) -> None:
    """Every log line is prefixed with a UTC timestamp, so a multi-hour CI run's output
    can be correlated with wall-clock time. Explicitly flushed: stderr is only
    line-buffered when attached to a terminal - piped into a CI log collector (as
    every workflow here does), Python fully block-buffers it, so without this the
    visible log can lag far behind actual execution, and any lines written just before
    a crash/kill can be lost entirely, making the true point of failure look earlier
    than it really was. Cheap enough to do unconditionally (one flush per log line, not
    per contract-processing step)."""
    timestamp = datetime.datetime.now(datetime.timezone.utc).strftime("%Y-%m-%dT%H:%M:%SZ")
    print(f"{timestamp} {message}", file=sys.stderr, flush=True)


def sanitize_path_segment(name: str) -> str:
    return re.sub(r"[^A-Za-z0-9_.-]", "-", name)


def sanitize_identifier(name: str) -> str:
    slug = re.sub(r"[^A-Za-z0-9_]", "_", name)
    if not slug or slug[0].isdigit():
        slug = f"_{slug}"
    return slug


def sanitize_dist_segment(name: str) -> str:
    """PyPI distribution names are compared case-insensitively with '-', '_', and '.'
    all treated as equivalent (PEP 503 normalization), so - exactly like
    sanitize_npm_segment() in scripts/generate_typescript_clients.py - this lowercases
    and collapses runs of invalid characters into a single '-' rather than replacing
    each one individually, and strips leading/trailing '-'."""
    slug = re.sub(r"[^a-z0-9-]+", "-", name.lower()).strip("-")
    return slug or "x"


def shorten_identifier(name: str, max_length: int) -> str:
    """Deterministically truncates `name` to at most `max_length` characters, appending
    an 8-hex-char SHA-256 digest of the *full, untruncated* name so two different long
    names that happen to share a prefix can never collide after shortening. A no-op if
    `name` already fits.

    Unlike the TypeScript/`.NET` pipelines, the Python pipeline's on-disk layout embeds
    the whole distribution name a second time as a nested directory
    (clients/<owner>/<repo>/python/src/<import_pkg>/<contract>.py) - for a long
    owner/repo combination (GitHub allows up to 39 + 100 characters) that doubling can
    push the full path past Windows' legacy 260-character MAX_PATH limit, breaking a
    plain `git clone`/`git pull` for anyone without `core.longpaths` enabled (seen in
    practice: `atsoc1993/Populate-App-Resources-Bug-Example-algokit_utils-python-library`
    produced a 211-character relative path on its own, before even prepending the local
    clone's own directory). Capping the distribution/import-package name specifically
    (not the shared clients/<owner>/<repo>/ prefix, which every ecosystem uses
    identically and isn't the source of the doubling) keeps every future path safely
    short regardless of how long a GitHub owner/repo name gets."""
    if len(name) <= max_length:
        return name
    digest = hashlib.sha256(name.encode("utf-8")).hexdigest()[:8]
    keep = max_length - len(digest) - 1
    return f"{name[:keep]}_{digest}"


def sha256_hex(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def url_hash8(url: str) -> str:
    return hashlib.sha256(url.encode("utf-8")).hexdigest()[:8]


def parse_raw_url(url: str) -> tuple[str, str, str]:
    m = RAW_URL_RE.match(url)
    if not m:
        raise ValueError(f"URL is not a raw.githubusercontent.com URL: {url}")
    return m.group("owner"), m.group("repo"), m.group("path")


def load_active_rows() -> list[dict[str, str]]:
    today = datetime.date.today().isoformat()
    rows = []
    with open(CSV_PATH, newline="", encoding="utf-8") as f:
        for row in csv.DictReader(f):
            active_from = row.get("ActiveFrom") or ""
            active_until = row.get("ActiveUntil") or ""
            if active_from and active_from > today:
                continue
            if active_until and active_until <= today:
                continue
            rows.append(row)
    return rows


def render_template(text: str, mapping: dict[str, str]) -> str:
    for key, value in mapping.items():
        text = text.replace("{{" + key + "}}", value)
    return text


def get_generator_version() -> str:
    """Always contacts the PyPI JSON API for GENERATOR_PACKAGE's current version, so a
    fresh publish of the generator is picked up on the very next run - mirrors
    get_generator_version() in scripts/generate_typescript_clients.py (which uses `npm
    view` for the same purpose)."""
    req = urllib.request.Request(
        PYPI_JSON_URL.format(package=GENERATOR_PACKAGE),
        headers={"User-Agent": "arc56-python-generator"},
    )
    with urllib.request.urlopen(req, timeout=URLOPEN_TIMEOUT_SECONDS) as resp:
        data = json.load(resp)
    version = data.get("info", {}).get("version")
    if not version:
        raise RuntimeError(f"Could not resolve a version for {GENERATOR_PACKAGE} from PyPI")
    return version


def ensure_generator_installed(version: str) -> None:
    """Installs GENERATOR_PACKAGE at exactly `version` unless it's already installed at
    that version - a one-time (per run), not per-contract, network operation."""
    result = subprocess.run(
        [sys.executable, "-c",
         f"import importlib.metadata as m; print(m.version('{GENERATOR_PACKAGE}'))"],
        capture_output=True, text=True, timeout=PIP_TIMEOUT_SECONDS,
    )
    installed_version = result.stdout.strip() if result.returncode == 0 else None
    if installed_version == version:
        return
    log(f"Installing {GENERATOR_PACKAGE}=={version} (currently installed: {installed_version or 'none'})")
    subprocess.run(
        [PIP_EXE, "install", "--quiet", f"{GENERATOR_PACKAGE}=={version}"],
        check=True, timeout=PIP_TIMEOUT_SECONDS,
    )


def spec_has_oversized_array(content: bytes) -> int | None:
    """Scans a raw ARC-56 spec's JSON bytes for a fixed-array type declaration
    (`<type>[<length>]`, e.g. `uint8[32]` for a real one or `uint8[9223372036854775807]`
    for a pathological test fixture) whose length exceeds MAX_SANE_FIXED_ARRAY_LENGTH.
    Returns the offending length, or None if the spec looks sane. Deliberately a plain
    regex over the raw bytes rather than a structured walk of the parsed JSON (methods'
    arg/return types, struct fields, state key/map valueType/keyType) - every one of
    those is a `type` *string* using the same `[<length>]` suffix syntax, so a single
    regex over the whole file catches all of them at once, and false positives are a
    non-issue (a 7+ digit number appearing anywhere in a real spec's box/global/local
    values, source maps, or bytecode is already implausible, and even if one somehow
    did, the worst outcome is one contract skipped with a clear error rather than a
    hung generator)."""
    m = FIXED_ARRAY_LENGTH_RE.search(content)
    if not m:
        return None
    length = int(m.group(1))
    return length if length > MAX_SANE_FIXED_ARRAY_LENGTH else None


def get_template_hash() -> str:
    """Hashes the templates that write_project_files() renders into each project's
    pyproject.toml/README.md (but NOT the generated .py code)."""
    parts = []
    for name in ("pyproject.toml.template", "README.md.template"):
        with open(os.path.join(TEMPLATE_DIR, name), "rb") as f:
            parts.append(f.read())
    return sha256_hex(b"\x00".join(parts))


def load_project_state(path: str) -> dict:
    if not os.path.exists(path):
        return {"increment": 0, "version": None, "contracts": {}}
    with open(path, encoding="utf-8") as f:
        return json.load(f)


def save_project_state(path: str, state: dict) -> None:
    with open(path, "w", encoding="utf-8") as f:
        json.dump(state, f, indent=2, sort_keys=True)
        f.write("\n")


def run_generator(arc56_path: str, py_path: str, mode: str) -> None:
    """Invokes the generator in the given mode ("full" or "minimal"). "full" mode emits
    both the typed Client and the deploy/create Factory class; "minimal" drops the
    Factory and keeps only the typed Client. Callers should always try "full" first and
    fall back to "minimal" only for the specific contract(s) that actually fail to
    generate/compile in full mode (see generate_python_client()) - mirrors the
    TypeScript pipeline's identical fallback (see generate_ts_client() in
    scripts/generate_typescript_clients.py).

    Runs under GENERATOR_TIMEOUT_SECONDS: algokitgen-py has been observed to hang
    (rather than crash) on at least one malformed ARC-56 fixture, and a hang here would
    otherwise block every contract after it for the rest of the run - see the
    GENERATOR_TIMEOUT_SECONDS comment above. A timeout is raised as a RuntimeError so
    it's handled by the caller exactly like any other generator failure: recorded as
    that one contract's generator_error, then move on to the next one."""
    cmd = [ALGOKITGEN_EXE, "-a", arc56_path, "-o", py_path, "-m", mode]
    try:
        result = subprocess.run(
            cmd, capture_output=True, text=True, timeout=GENERATOR_TIMEOUT_SECONDS,
        )
    except subprocess.TimeoutExpired as exc:
        raise RuntimeError(
            f"algokitgen-py did not finish within {GENERATOR_TIMEOUT_SECONDS}s (killed)\n"
            f"--- stdout so far ---\n{exc.stdout or ''}\n--- stderr so far ---\n{exc.stderr or ''}"
        ) from exc
    if result.returncode != 0:
        raise RuntimeError(
            f"algokitgen-py exited with code {result.returncode}\n"
            f"--- stdout ---\n{result.stdout}\n--- stderr ---\n{result.stderr}"
        )
    if not os.path.isfile(py_path):
        raise RuntimeError(f"algokitgen-py did not produce {py_path}")


FAILURE_LABELS = {
    "generator_error": "Generator crash",
    "py_compile_error": "Generated code fails to compile",
}


def repro_command(arc56_url: str) -> str:
    return (
        f"pip install {GENERATOR_PACKAGE}\n"
        f'curl -sL {arc56_url} -o application.json\n'
        f'algokitgen-py -a application.json -o client.generated.py -m minimal'
    )


def write_incident_report(
    owner: str,
    repo: str,
    url: str,
    contract_id: str,
    failure_type: str,
    error_text: str,
    generator_version: str,
) -> str:
    incident_dir = os.path.join(INCIDENTS_DIR, sanitize_path_segment(owner), sanitize_path_segment(repo))
    os.makedirs(incident_dir, exist_ok=True)
    report_path = os.path.join(incident_dir, f"{contract_id}.py.md")

    kind_label = FAILURE_LABELS.get(failure_type, failure_type)
    detected_at = datetime.datetime.now(datetime.timezone.utc).isoformat()
    repro_cmd = repro_command(url)

    report = f"""# {kind_label}: {contract_id} (Python)

- **Repo**: [{owner}/{repo}](https://github.com/{owner}/{repo})
- **Source ARC-56 spec**: [{url}]({url})
- **Detected**: {detected_at}
- **Generator package**: `{GENERATOR_PACKAGE}=={generator_version}`

## Reproduce

```bash
{repro_cmd}
```

## Error

```
{error_text}
```
"""
    with open(report_path, "w", encoding="utf-8", newline="\n") as f:
        f.write(report)
    return report_path


def contract_id_for(contract: dict) -> str:
    return f"{contract['file_slug']}_{contract['hash8']}"


def extract_client_class_name(py_path: str) -> str:
    with open(py_path, encoding="utf-8") as f:
        text = f.read()
    m = CLIENT_CLASS_RE.search(text)
    if m:
        return m.group(1)
    m = ANY_CLASS_RE.search(text)
    return m.group(1) if m else "(unknown)"


def compile_check(py_path: str) -> str | None:
    """Byte-compiles a single generated file to catch syntax errors - the Python
    equivalent of the TypeScript pipeline's per-file `tsc` error, but checked
    immediately after generation rather than as a whole-project pass (see the module
    docstring for why that's safe here). Returns an error string, or None if it
    compiled cleanly.

    Runs `py_compile` in a subprocess (bounded by COMPILE_TIMEOUT_SECONDS) rather than
    calling `py_compile.compile()` in-process, for the same reason run_generator() runs
    algokitgen-py with a timeout: a subprocess can be killed outright on timeout, while
    an in-process call has no safe way to be interrupted after the fact - see the
    COMPILE_TIMEOUT_SECONDS comment above."""
    try:
        result = subprocess.run(
            [sys.executable, "-m", "py_compile", py_path],
            capture_output=True, text=True, timeout=COMPILE_TIMEOUT_SECONDS,
        )
    except subprocess.TimeoutExpired as exc:
        return (
            f"py_compile did not finish within {COMPILE_TIMEOUT_SECONDS}s (killed)\n"
            f"--- stdout so far ---\n{exc.stdout or ''}\n--- stderr so far ---\n{exc.stderr or ''}"
        )
    if result.returncode != 0:
        return result.stdout + result.stderr
    return None


def generate_python_client(arc56_path: str, py_path: str) -> tuple[str, str | None, str | None]:
    """Generates py_path in "full" mode and byte-compiles it; if generation crashes/
    times out or the full-mode output fails to compile, regenerates in "minimal" mode
    (dropping the Factory class, which is almost always what full mode's failures trace
    back to) instead. Returns (mode_used, failure_type, error_text): failure_type/
    error_text are None on success (whichever mode succeeded), otherwise failure_type is
    "generator_error" or "py_compile_error" and error_text is the detail for the
    incident report. Mirrors generate_ts_client() in
    scripts/generate_typescript_clients.py, except the compile check is per-file here
    (see compile_check()) so both the generate and verify steps happen inside this one
    helper, rather than being split across generation time and a later aggregate pass."""
    for mode in ("full", "minimal"):
        try:
            run_generator(arc56_path, py_path, mode=mode)
        except Exception as exc:  # noqa: BLE001
            if mode == "minimal":
                return mode, "generator_error", str(exc)
            log(f"WARNING: full-mode generation failed for {py_path}, falling back to minimal: {exc}")
            continue
        compile_error = compile_check(py_path)
        if compile_error is None:
            return mode, None, None
        if mode == "minimal":
            return mode, "py_compile_error", compile_error
        log(f"WARNING: full-mode output for {py_path} fails to compile, falling back to minimal")
    raise AssertionError("unreachable")


def process_project(
    owner: str,
    repo: str,
    rows: list[dict[str, str]],
    generator_version: str,
    template_hash: str,
    progress: list[int],
    commit_enabled: bool,
) -> bool:
    owner_slug = sanitize_path_segment(owner)
    repo_slug = sanitize_path_segment(repo)
    repo_dir = os.path.join(CLIENTS_DIR, owner_slug, repo_slug)
    project_dir = os.path.join(repo_dir, "python")
    arc56_dir = os.path.join(repo_dir, "arc56")
    dist_name = f"arc56-generated-{sanitize_dist_segment(owner_slug)}-{sanitize_dist_segment(repo_slug)}"
    dist_name = shorten_identifier(dist_name, MAX_DIST_NAME_LENGTH)
    import_pkg = sanitize_identifier(dist_name.replace("-", "_"))
    src_dir = os.path.join(project_dir, "src", import_pkg)
    state_path = os.path.join(project_dir, "state.json")
    os.makedirs(src_dir, exist_ok=True)

    state = load_project_state(state_path)
    contracts_state: dict = state.setdefault("contracts", {})
    # dist_name/import_pkg are recomputed fresh from owner/repo on every run, never
    # cached - so if shorten_identifier()'s output (or the naming scheme generally)
    # ever changes, an *already-generated* project whose ARC-56 content hasn't changed
    # would otherwise never notice: every contract's needs_regen check below only looks
    # at content_sha256, so nothing would re-trigger write_project_files() and the
    # project would stay stuck on its old (possibly Windows-path-breaking) directory
    # name forever. Comparing against the dist_name actually used last time turns a
    # naming-scheme change into the same kind of forced regen as a generator/template
    # version bump, but scoped to only the specific project(s) whose computed name
    # actually changed - not a full-registry regeneration.
    naming_changed = state.get("dist_name") != dist_name
    force_regen = state.get("generator_version") != generator_version or naming_changed
    state_dirty = False
    code_changed = naming_changed and state.get("dist_name") is not None

    for row in rows:
        url = row["ARC56URL"]
        progress[0] += 1
        log(f"[{progress[0]}/{progress[1]}] {owner}/{repo}: {url}")
        # Checked on every row, mirroring the TypeScript pipeline's identical
        # per-row checkpoint - see maybe_checkpoint_commit().
        maybe_checkpoint_commit(owner, repo, commit_enabled)
        try:
            _, _, path = parse_raw_url(url)
        except ValueError as exc:
            log(f"WARNING: skipping unparseable URL {url}: {exc}")
            continue
        filename = path.rsplit("/", 1)[-1]
        if not filename.endswith(FILENAME_SUFFIX):
            log(f"WARNING: skipping non-ARC56 URL {url}")
            continue
        file_slug = shorten_identifier(sanitize_identifier(filename[: -len(FILENAME_SUFFIX)]), MAX_FILE_SLUG_LENGTH)
        hash8 = url_hash8(url)
        contract_id = f"{file_slug}_{hash8}"
        existing = contracts_state.get(url)

        arc56_path = os.path.join(arc56_dir, f"{contract_id}.arc56.json")
        if not os.path.isfile(arc56_path):
            continue  # not downloaded yet - scripts/download_arc56_specs.py will produce it later

        with open(arc56_path, "rb") as f:
            content = f.read()
        content_hash = sha256_hex(content)
        needs_regen = (
            force_regen
            or existing is None
            or existing.get("content_sha256") != content_hash
        )
        if not needs_regen:
            continue

        oversized_length = spec_has_oversized_array(content)
        if oversized_length is not None:
            error = (
                f"spec declares a fixed-array type of length {oversized_length}, "
                f"exceeding MAX_SANE_FIXED_ARRAY_LENGTH ({MAX_SANE_FIXED_ARRAY_LENGTH}) "
                f"- skipped without invoking the generator (see spec_has_oversized_array())"
            )
            log(f"WARNING: skipping {contract_id} - {error}")
            contracts_state[url] = {
                **{k: v for k, v in (existing or {}).items() if k != "content_sha256"},
                "content_sha256": content_hash,
                "file_slug": file_slug,
                "hash8": hash8,
                "generator_error": error,
            }
            write_incident_report(owner, repo, url, contract_id, "generator_error", error, generator_version)
            state_dirty = True
            continue

        py_path = os.path.join(src_dir, f"{contract_id}.py")
        log(f"Generating Python client for {url} -> {py_path}")
        generation_mode, failure_type, error_text = generate_python_client(arc56_path, py_path)
        if failure_type is not None:
            log(f"WARNING: quarantining {contract_id} - {FAILURE_LABELS.get(failure_type, failure_type)}")
            contracts_state[url] = {
                **{k: v for k, v in (existing or {}).items() if k != "content_sha256"},
                "content_sha256": content_hash,
                "file_slug": file_slug,
                "hash8": hash8,
                "generation_mode": generation_mode,
                failure_type: error_text if failure_type == "generator_error" else "generated code fails to compile",
            }
            write_incident_report(owner, repo, url, contract_id, failure_type, error_text, generator_version)
            state_dirty = True
            continue

        class_name = extract_client_class_name(py_path)
        with open(py_path, "rb") as f:
            py_hash = sha256_hex(f.read())

        previous_py_hash = (existing or {}).get("py_sha256")
        if previous_py_hash is not None and previous_py_hash == py_hash:
            contracts_state[url] = {
                **{k: v for k, v in (existing or {}).items()
                   if k not in ("generator_error", "py_compile_error", "content_sha256", "py_sha256",
                                "class_name", "generation_mode")},
                "content_sha256": content_hash,
                "py_sha256": py_hash,
                "file_slug": file_slug,
                "hash8": hash8,
                "class_name": class_name,
                "generation_mode": generation_mode,
            }
            state_dirty = True
            log(f"Regenerated {url} - identical code, not counted as a change")
        else:
            contracts_state[url] = {
                "content_sha256": content_hash,
                "py_sha256": py_hash,
                "file_slug": file_slug,
                "hash8": hash8,
                "class_name": class_name,
                "generation_mode": generation_mode,
                "generated_at": datetime.datetime.now(datetime.timezone.utc).isoformat(),
            }
            code_changed = True

    template_changed = state.get("template_hash") != template_hash
    needs_version_bump = code_changed or template_changed

    if not (state_dirty or needs_version_bump):
        return False

    excluded_contract_ids = {
        contract_id_for(c) for c in contracts_state.values()
        if "file_slug" in c and ("py_compile_error" in c or "generator_error" in c)
    }

    if not needs_version_bump:
        state["generator_version"] = generator_version
        state["template_hash"] = template_hash
        state["dist_name"] = dist_name
        save_project_state(state_path, state)
        log(f"Project clients/{owner}/{repo}/python: recorded failure state only, no generated-code "
              f"changes - version not bumped")
        return False

    increment = state.get("increment", 0) + 1
    version = f"1.{increment}.{datetime.datetime.now(datetime.timezone.utc):%Y%m%d%H}"
    state["increment"] = increment
    state["version"] = version
    state["generator_version"] = generator_version
    state["template_hash"] = template_hash
    state["dist_name"] = dist_name

    write_project_files(
        project_dir, owner, repo, dist_name, import_pkg, contracts_state, excluded_contract_ids, version=version,
    )
    save_project_state(state_path, state)

    log(f"Project clients/{owner}/{repo}/python -> version {version} ({len(contracts_state)} contract(s), "
          f"{len(excluded_contract_ids)} quarantined)")
    return True


def write_project_files(
    project_dir: str,
    owner: str,
    repo: str,
    dist_name: str,
    import_pkg: str,
    contracts_state: dict,
    excluded_contract_ids: set[str] = frozenset(),
    version: str | None = None,
) -> None:
    with open(os.path.join(TEMPLATE_DIR, "pyproject.toml.template"), encoding="utf-8") as f:
        pyproject_template = f.read()
    with open(os.path.join(TEMPLATE_DIR, "README.md.template"), encoding="utf-8") as f:
        readme_template = f.read()

    description = f"Generated ARC-56 Algorand smart-contract clients for {owner}/{repo}."
    pyproject = render_template(pyproject_template, {
        "DIST_NAME": dist_name,
        "IMPORT_PACKAGE": import_pkg,
        "VERSION": version or "0.0.0",
        "OWNER": owner,
        "REPO": repo,
        "DESCRIPTION": description,
        "REGISTRY_REPO_URL": REGISTRY_REPO_URL,
    })
    with open(os.path.join(project_dir, "pyproject.toml"), "w", encoding="utf-8", newline="\n") as f:
        f.write(pyproject)

    sorted_urls = sorted(contracts_state.keys(), key=str.lower)
    table_rows = []
    index_lines = []
    for url in sorted_urls:
        c = contracts_state[url]
        if "file_slug" not in c:
            continue
        contract_id = contract_id_for(c)
        if "generator_error" in c:
            table_rows.append(f"| `{contract_id}` | _(generation failed - see state.json)_ | [{url}]({url}) |")
        elif "py_compile_error" in c:
            table_rows.append(f"| `{contract_id}` | _(fails to compile - excluded, see state.json)_ | [{url}]({url}) |")
        elif c.get("generation_mode") == "minimal":
            table_rows.append(
                f"| `{contract_id}` | `{c.get('class_name', '(unknown)')}` _(minimal mode - "
                f"full mode failed to generate/compile for this contract)_ | [{url}]({url}) |"
            )
            index_lines.append(f"from . import {contract_id} as {contract_id}")
        else:
            table_rows.append(f"| `{contract_id}` | `{c.get('class_name', '(unknown)')}` | [{url}]({url}) |")
            index_lines.append(f"from . import {contract_id} as {contract_id}")
    contracts_table = "\n".join(table_rows) if table_rows else "| _(none yet)_ | | |"

    src_dir = os.path.join(project_dir, "src", import_pkg)
    os.makedirs(src_dir, exist_ok=True)
    init_content = "\n".join(index_lines) + "\n" if index_lines else "# no contracts generated yet\n"
    with open(os.path.join(src_dir, "__init__.py"), "w", encoding="utf-8", newline="\n") as f:
        f.write(init_content)

    # Remove quarantined/failed contract files from the importable package so a
    # broken generated file can never accidentally be imported (it's still recorded
    # in state.json and listed in the README, just not shipped in src/).
    for contract_id in excluded_contract_ids:
        stale_path = os.path.join(src_dir, f"{contract_id}.py")
        if os.path.isfile(stale_path):
            os.remove(stale_path)

    first_contract_id = None
    first_class_name = None
    for url in sorted_urls:
        c = contracts_state[url]
        if "file_slug" in c and "generator_error" not in c and "py_compile_error" not in c:
            first_contract_id = contract_id_for(c)
            first_class_name = c.get("class_name")
            break
    readme = render_template(readme_template, {
        "DIST_NAME": dist_name,
        "IMPORT_PACKAGE": import_pkg,
        "OWNER": owner,
        "REPO": repo,
        "CONTRACTS_TABLE": contracts_table,
        "FIRST_CONTRACT_MODULE": first_contract_id or "contract_name_hash",
        "FIRST_CONTRACT_CLASS": first_class_name or "ContractClient",
    })
    with open(os.path.join(project_dir, "README.md"), "w", encoding="utf-8", newline="\n") as f:
        f.write(readme)


def push_commits() -> None:
    """Pushes whatever local commits exist so far. Always pulls (rebasing our local
    commits on top) immediately before pushing, since other pipeline runs can move
    origin/main in between - and retries the pull+push cycle up to 3 times total
    before giving up for this checkpoint, since a rejected push usually just means the
    remote moved again between our pull and push. Never raises: a push failure here
    just means the next checkpoint (or the workflow's own final push step) retries it."""
    max_attempts = 3
    for attempt in range(1, max_attempts + 1):
        pull = subprocess.run(["git", "pull", "--rebase"], cwd=REPO_ROOT, capture_output=True, text=True)
        if pull.returncode != 0:
            log(f"WARNING: git pull --rebase failed (attempt {attempt}/{max_attempts}): "
                f"{pull.stdout}\n{pull.stderr}")
        result = subprocess.run(["git", "push"], cwd=REPO_ROOT, capture_output=True, text=True)
        if result.returncode == 0:
            return
        log(f"WARNING: git push failed (attempt {attempt}/{max_attempts}): {result.stdout}\n{result.stderr}")
    log(f"WARNING: git push still failing after {max_attempts} attempts - will retry at next checkpoint")


def configure_git_identity() -> None:
    subprocess.run(["git", "config", "user.name", "github-actions[bot]"], cwd=REPO_ROOT, check=True)
    subprocess.run(
        ["git", "config", "user.email", "github-actions[bot]@users.noreply.github.com"],
        cwd=REPO_ROOT, check=True,
    )


def commit_project_changes(owner: str, repo: str) -> None:
    paths = [
        os.path.join("clients", sanitize_path_segment(owner), sanitize_path_segment(repo), "python"),
        os.path.join("clients", "_incidents"),
    ]
    subprocess.run(["git", "add", "--", *paths], cwd=REPO_ROOT, check=True)
    diff = subprocess.run(["git", "diff", "--cached", "--quiet", "--", *paths], cwd=REPO_ROOT)
    if diff.returncode == 0:
        return
    subprocess.run(
        ["git", "commit", "-m", f"chore: regenerate Python ARC-56 client for {owner}/{repo}"],
        cwd=REPO_ROOT, check=True,
    )
    log(f"Committed changes for {owner}/{repo}")


_last_checkpoint_at: float | None = None


def maybe_checkpoint_commit(owner: str, repo: str, commit_enabled: bool, force: bool = False) -> None:
    """Mirrors maybe_checkpoint_commit() in scripts/generate_typescript_clients.py:
    commits and pushes whatever's changed under this project's python/ dir so far, at
    most once every PERIODIC_COMMIT_INTERVAL_SECONDS unless force=True."""
    global _last_checkpoint_at
    if not commit_enabled:
        return
    now = time.monotonic()
    if not force and _last_checkpoint_at is not None and now - _last_checkpoint_at < PERIODIC_COMMIT_INTERVAL_SECONDS:
        return
    commit_project_changes(owner, repo)
    push_commits()
    _last_checkpoint_at = now


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    parser.add_argument("--limit-projects", type=int, default=None,
                         help="Only process the first N owner/repo projects (for local testing).")
    parser.add_argument("--only-repo", action="append", default=[],
                         help="Only process owner/repo (exact match, can be passed multiple times).")
    parser.add_argument("--filter", action="append", default=[],
                         help="Only process owner/repo pairs whose \"owner/repo\" string contains this "
                              "substring, case-insensitive. Can be passed multiple times (OR'd together). "
                              "If --only-repo is also given, a project must satisfy both.")
    parser.add_argument("--commit", action="store_true",
                         help="Git-commit each project's changes (including version bumps) as soon as "
                              "that project finishes.")
    args = parser.parse_args()

    if not os.path.isdir(CLIENTS_DIR):
        log(f"ERROR: {CLIENTS_DIR} does not exist")
        return 1

    try:
        generator_version = get_generator_version()
        ensure_generator_installed(generator_version)
    except Exception as exc:  # noqa: BLE001
        log(f"ERROR: could not resolve/install {GENERATOR_PACKAGE}: {exc}")
        return 1
    log(f"Generator package version: {GENERATOR_PACKAGE}=={generator_version}")
    template_hash = get_template_hash()

    rows = load_active_rows()
    grouped: dict[tuple[str, str], list[dict[str, str]]] = {}
    for row in rows:
        try:
            owner, repo, _ = parse_raw_url(row["ARC56URL"])
        except ValueError as exc:
            log(f"WARNING: {exc}")
            continue
        grouped.setdefault((owner, repo), []).append(row)

    selected = sorted(grouped.items())
    if args.only_repo:
        wanted = {tuple(r.split("/", 1)) for r in args.only_repo}
        selected = [item for item in selected if item[0] in wanted]
    if args.filter:
        keywords = [f.lower() for f in args.filter]
        selected = [
            item for item in selected
            if any(kw in f"{item[0][0]}/{item[0][1]}".lower() for kw in keywords)
        ]
    if args.limit_projects is not None:
        selected = selected[: args.limit_projects]

    if args.commit:
        configure_git_identity()

    total_rows = sum(len(project_rows) for _, project_rows in selected)
    progress = [0, total_rows]  # [rows processed so far, total rows selected this run]

    changed_projects = 0
    failed_projects = 0
    for (owner, repo), project_rows in selected:
        try:
            if process_project(owner, repo, project_rows, generator_version, template_hash, progress, args.commit):
                changed_projects += 1
            maybe_checkpoint_commit(owner, repo, args.commit, force=True)
        except Exception as exc:  # noqa: BLE001 - one project must never take down the whole run
            failed_projects += 1
            log(f"ERROR: unexpected failure processing {owner}/{repo}, skipping and "
                  f"continuing with the next project: {exc}")
            continue

    if args.commit:
        push_commits()

    log(f"Done: {len(selected)}/{len(grouped)} project(s) scanned, "
          f"{changed_projects} regenerated/bumped, {failed_projects} failed unexpectedly")
    return 1 if failed_projects else 0


if __name__ == "__main__":
    sys.exit(main())
