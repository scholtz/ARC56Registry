#!/usr/bin/env python3
"""Generate/update the per-repository .NET NuGet packages of ARC-56 clients.

For every *active* row in arc56.links.csv, this script:

  1. Downloads the ARC-56 JSON spec (rate-limited: at least DOWNLOAD_DELAY_SECONDS
     between downloads, so we don't hammer raw.githubusercontent.com).
  2. Copies it into clients/<owner>/<repo>/arc56/<file_slug>_<hash8>.arc56.json - at the
     repo level, not under dotnet/, since it's shared across every ecosystem's generated
     client for that repo (.NET today, npm/Python planned).
  3. If its content changed (or the generator docker image changed, or it's new),
     regenerates the C# client via the scholtz2/dotnet-avm-generated-client docker
     image into clients/<owner>/<repo>/dotnet/src/<file_slug>_<hash8>.cs, in a
     namespace unique to that contract (Arc56.Generated.<Owner>.<Repo>.<file_slug>_<hash8>).

One NuGet package is produced per GitHub repository (owner/repo), bundling every
ARC-56 client found in that repo. A repo's package version is only bumped, and only
`dotnet pack` re-run, when at least one of its contracts actually changed content, the
generator image changed (which forces every package to regenerate), or the
README/csproj templates under clients/_template/ changed (which forces every package
to re-render its docs/metadata and republish, even with no contract changes). Version
format: 1.0.<increment>.<yyyyMMddHH> (matches the legacy 4-part scheme already used by
the Algorand4 package this depends on).

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
import subprocess
import sys
import time
import urllib.request

REPO_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
CSV_PATH = os.path.join(REPO_ROOT, "arc56.links.csv")
CLIENTS_DIR = os.path.join(REPO_ROOT, "clients")
TEMPLATE_DIR = os.path.join(CLIENTS_DIR, "_template")
INCIDENTS_DIR = os.path.join(CLIENTS_DIR, "_incidents")

REGISTRY_REPO_URL = "https://github.com/scholtz/Arc56Registry"
GENERATOR_IMAGE = "scholtz2/dotnet-avm-generated-client:latest"
DOWNLOAD_DELAY_SECONDS = 7
NUPKG_OUTPUT_DIR = os.path.join(REPO_ROOT, "artifacts", "nupkgs")
NUGET_SOURCE = "https://api.nuget.org/v3/index.json"
# How often --commit pushes local commits to the remote while the run is still going,
# rather than only once at the very end. Bounds how much already-finished work (commits,
# and the nuget.org publishes that go with them) could be stranded on the runner and
# lost if the job later dies (crash, runner timeout, etc.) - see push_commits().
PUSH_INTERVAL_SECONDS = 60

RAW_URL_RE = re.compile(
    r"^https://raw\.githubusercontent\.com/(?P<owner>[^/]+)/(?P<repo>[^/]+)/[^/]+/(?P<path>.+)$"
)
CLASS_NAME_RE = re.compile(r"public\s+class\s+(\w+)\s*:\s*ProxyBase")
FILENAME_SUFFIX = ".arc56.json"
# Matches the file name (our contract_id) out of a dotnet build error line like:
# ...\src\Multisig_0579f8cd.cs(835,86): error CS0310: ...
COMPILE_ERROR_FILE_RE = re.compile(r"[\\/](?P<contract_id>[A-Za-z0-9_]+)\.cs\(\d+,\d+\):\s*error")
MAX_BUILD_QUARANTINE_ATTEMPTS = 10

_last_download_at: float | None = None


def sanitize_path_segment(name: str) -> str:
    return re.sub(r"[^A-Za-z0-9_.-]", "-", name)


def sanitize_identifier(name: str) -> str:
    slug = re.sub(r"[^A-Za-z0-9_]", "_", name)
    if not slug or slug[0].isdigit():
        slug = f"_{slug}"
    return slug


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


def download_with_rate_limit(url: str) -> bytes:
    global _last_download_at
    if _last_download_at is not None:
        elapsed = time.monotonic() - _last_download_at
        wait = DOWNLOAD_DELAY_SECONDS - elapsed
        if wait > 0:
            time.sleep(wait)
    print(f"Downloading {url}", file=sys.stderr)
    req = urllib.request.Request(url, headers={"User-Agent": "arc56-dotnet-client-generator"})
    with urllib.request.urlopen(req) as resp:
        data = resp.read()
    _last_download_at = time.monotonic()
    return data


def get_generator_image_digest() -> str:
    """Always contacts the registry for GENERATOR_IMAGE's current digest (a real `docker
    pull`, not a cached/local answer), so a fresh image push is picked up on the very
    next run. The digest is parsed directly from `docker pull`'s own output rather than
    `docker image inspect --format '{{index .RepoDigests 0}}'`, since RepoDigests can
    list multiple entries if the same image ID was ever pulled/tagged under another
    reference - index 0 isn't guaranteed to be the digest for *this* tag."""
    result = subprocess.run(["docker", "pull", GENERATOR_IMAGE], capture_output=True, text=True, check=True)
    match = re.search(r"Digest:\s*(sha256:[0-9a-f]+)", result.stdout)
    if not match:
        raise RuntimeError(
            f"Could not parse a digest out of 'docker pull {GENERATOR_IMAGE}' output:\n{result.stdout}"
        )
    repo_name = GENERATOR_IMAGE.split(":", 1)[0]
    return f"{repo_name}@{match.group(1)}"


def get_template_hash() -> str:
    """Hashes the templates that write_project_files() renders into each project's
    README.md/csproj (but NOT the generated .cs code). Compared against each project's
    stored state["template_hash"] so a documentation/template-only edit - which never
    touches any contract's content_sha256/cs_sha256 - still bumps that project's version
    and gets republished, instead of silently sitting stale forever."""
    parts = []
    for name in ("Project.csproj.template", "README.md.template"):
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


def docker_user_args() -> list[str]:
    """On POSIX, runs the generator container as the same uid:gid that owns the
    bind-mounted host directories (getuid()/getgid() don't exist on Windows, where this
    is a no-op). Without this, the container's baked-in default user can differ from
    whoever created/owns those host directories - on GitHub Actions runners this has
    been observed to make the generator crash with `UnauthorizedAccessException:
    Access to the path '/app/out/<file>.cs' is denied` for some (not all - only
    pre-existing or oddly-permissioned paths) contracts, exiting 139 (SIGSEGV) instead
    of a clean nonzero exit."""
    if hasattr(os, "getuid"):
        return ["--user", f"{os.getuid()}:{os.getgid()}"]
    return []


def run_generator(arc56_dir: str, src_dir: str, arc56_filename: str, namespace: str) -> str:
    """Runs the docker generator and returns the path to the generated .cs file."""
    before = set(os.listdir(src_dir)) if os.path.isdir(src_dir) else set()
    os.makedirs(src_dir, exist_ok=True)
    cmd = [
        "docker", "run", "--rm", *docker_user_args(),
        "-v", f"{arc56_dir}:/app/artifacts",
        "-v", f"{src_dir}:/app/out",
        GENERATOR_IMAGE,
        "dotnet", "client-generator.dll",
        "--namespace", namespace,
        "--file", f"artifacts/{arc56_filename}",
    ]
    result = subprocess.run(cmd, capture_output=True, text=True)
    if result.returncode != 0:
        raise RuntimeError(
            f"docker generator exited with code {result.returncode}\n"
            f"--- stdout ---\n{result.stdout}\n--- stderr ---\n{result.stderr}"
        )
    after = set(os.listdir(src_dir))
    new_files = [f for f in (after - before) if f.endswith(".cs")]
    if len(new_files) != 1:
        raise RuntimeError(
            f"Expected exactly one new .cs file in {src_dir} after generation, found {new_files}"
        )
    return os.path.join(src_dir, new_files[0])


def extract_class_name(cs_path: str) -> str:
    with open(cs_path, encoding="utf-8") as f:
        text = f.read()
    m = CLASS_NAME_RE.search(text)
    return m.group(1) if m else "(unknown)"


FAILURE_LABELS = {
    "download_error": "Download failed",
    "generator_error": "Generator crash",
    "compile_error": "Generated code fails to compile",
}


def repro_command(namespace: str, url: str) -> str:
    return (
        'docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \\\n'
        f'  dotnet client-generator.dll --namespace "{namespace}" \\\n'
        f'  --url {url}'
    )


def write_incident_report(
    owner: str,
    repo: str,
    url: str,
    contract_id: str,
    namespace: str,
    failure_type: str,
    error_text: str,
    generator_digest: str,
) -> str:
    """Writes a standalone incident report for a download/generator/compile failure,
    with the source URL, a repro command, and the full error/stack trace. Does not
    file or link to filing a GitHub issue - that's left for a human to do manually."""
    incident_dir = os.path.join(INCIDENTS_DIR, sanitize_path_segment(owner), sanitize_path_segment(repo))
    os.makedirs(incident_dir, exist_ok=True)
    report_path = os.path.join(incident_dir, f"{contract_id}.md")

    kind_label = FAILURE_LABELS.get(failure_type, failure_type)
    detected_at = datetime.datetime.now(datetime.timezone.utc).isoformat()

    if failure_type == "download_error":
        report = f"""# {kind_label}: {contract_id}

- **Repo**: [{owner}/{repo}](https://github.com/{owner}/{repo})
- **Source ARC-56 spec URL**: {url}
- **Detected**: {detected_at}

This is a fetch/network problem (invalid URL, renamed/deleted file, unreachable host,
etc.), not a bug in the generator. Check whether the URL above is still correct (the
source repo may have moved, renamed, or deleted the file);
[arc56.links.csv]({REGISTRY_REPO_URL}/blob/main/arc56.links.csv) can be corrected if the
file has permanently moved.

## Error

```
{error_text}
```
"""
        with open(report_path, "w", encoding="utf-8", newline="\n") as f:
            f.write(report)
        return report_path

    repro_cmd = repro_command(namespace, url)

    report = f"""# {kind_label}: {contract_id}

- **Repo**: [{owner}/{repo}](https://github.com/{owner}/{repo})
- **Source ARC-56 spec**: [{url}]({url})
- **Namespace used**: `{namespace}`
- **Detected**: {detected_at}
- **Generator image**: `{generator_digest}`

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


def rebuild_incidents_index() -> None:
    """Rebuilds clients/_incidents/README.md from every project's state.json,
    so there's always one place to see every open generator/compile/download failure."""
    rows = []
    for root, _dirs, files in os.walk(CLIENTS_DIR):
        if "state.json" not in files:
            continue
        if os.path.commonpath([root, INCIDENTS_DIR]) == INCIDENTS_DIR or os.path.commonpath([root, TEMPLATE_DIR]) == TEMPLATE_DIR:
            continue
        rel = os.path.relpath(root, CLIENTS_DIR)
        parts = rel.split(os.sep)
        if len(parts) != 3 or parts[2] != "dotnet":
            continue
        owner, repo, _ecosystem = parts
        state = load_project_state(os.path.join(root, "state.json"))
        for url, c in state.get("contracts", {}).items():
            failure_type = next((ft for ft in FAILURE_LABELS if ft in c), None)
            if failure_type is None or "file_slug" not in c:
                continue
            contract_id = contract_id_for(c)
            report_rel = f"{sanitize_path_segment(owner)}/{sanitize_path_segment(repo)}/{contract_id}.md"
            rows.append((owner, repo, contract_id, failure_type, report_rel))

    rows.sort(key=lambda r: (r[0].lower(), r[1].lower(), r[2].lower()))

    lines = [
        "# Open ARC-56 client generation incidents",
        "",
        "Rebuilt automatically by `scripts/generate_dotnet_clients.py` on every run. Each row "
        "links to a report with the source URL, a repro command, and the full error/stack trace.",
        "",
        "| Repo | Contract | Failure | Report |",
        "| --- | --- | --- | --- |",
    ]
    if rows:
        for owner, repo, contract_id, failure_type, report_rel in rows:
            label = FAILURE_LABELS.get(failure_type, failure_type)
            lines.append(
                f"| [{owner}/{repo}](https://github.com/{owner}/{repo}) | `{contract_id}` | "
                f"{label} | [{report_rel}]({report_rel}) |"
            )
    else:
        lines.append("| _(none currently)_ | | | |")

    os.makedirs(INCIDENTS_DIR, exist_ok=True)
    with open(os.path.join(INCIDENTS_DIR, "README.md"), "w", encoding="utf-8", newline="\n") as f:
        f.write("\n".join(lines) + "\n")


def contract_id_for(contract: dict) -> str:
    return f"{contract['file_slug']}_{contract['hash8']}"


def run_dotnet_build(csproj_path: str) -> subprocess.CompletedProcess:
    return subprocess.run(
        ["dotnet", "build", csproj_path, "--configuration", "Release", "--nologo"],
        capture_output=True, text=True,
    )


def find_broken_contract_ids(build_output: str) -> set[str]:
    return {m.group("contract_id") for m in COMPILE_ERROR_FILE_RE.finditer(build_output)}


def extract_error_lines_for(contract_id: str, combined_output: str) -> str:
    # Only actual "): error" lines - a broken file's build output is otherwise dominated
    # by unrelated "): warning" noise (e.g. hundreds of CS8632 nullable-annotation
    # warnings) that would drown out the one line that actually matters.
    marker = f"{contract_id}.cs("
    lines = [
        line for line in combined_output.splitlines()
        if marker in line and re.search(r"\):\s*error\b", line)
    ]
    if lines:
        return "\n".join(lines)
    # Fall back to any mention of the file if no "error" line matched, so we still
    # surface something rather than an empty report.
    lines = [line for line in combined_output.splitlines() if marker in line]
    return "\n".join(lines) if lines else combined_output[-2000:]


def build_and_quarantine(
    project_dir: str,
    owner: str,
    repo: str,
    package_id: str,
    version: str,
    contracts_state: dict,
    excluded_contract_ids: set[str],
    generator_digest: str,
) -> set[str]:
    """Builds the aggregate project; if it fails, attributes the failure to specific
    generated files (a known upstream generator limitation for some ABI type shapes,
    not a bug in this pipeline) and excludes them so one broken contract doesn't block
    every other contract in the same repo's package. Retries until it builds clean or
    no further broken file can be attributed."""
    csproj_path = os.path.join(project_dir, f"{package_id}.csproj")
    contract_id_to_url = {contract_id_for(c): url for url, c in contracts_state.items() if "file_slug" in c}

    for _ in range(MAX_BUILD_QUARANTINE_ATTEMPTS):
        result = run_dotnet_build(csproj_path)
        if result.returncode == 0:
            return excluded_contract_ids

        combined_output = result.stdout + result.stderr
        broken = find_broken_contract_ids(combined_output) - excluded_contract_ids
        if not broken:
            raise RuntimeError(
                f"dotnet build failed for {csproj_path} and no (new) broken contract file "
                f"could be attributed from the output:\n{result.stdout[-4000:]}\n{result.stderr[-2000:]}"
            )
        for contract_id in broken:
            url = contract_id_to_url.get(contract_id)
            error_text = extract_error_lines_for(contract_id, combined_output)
            if url is not None:
                contracts_state[url]["compile_error"] = (
                    "generated code fails to compile in the aggregate project "
                    "(known upstream generator limitation for some ABI type shapes)"
                )
                write_incident_report(
                    owner, repo, url, contract_id, contracts_state[url]["namespace"],
                    "compile_error", error_text, generator_digest,
                )
            print(f"WARNING: quarantining {contract_id} - fails to compile", file=sys.stderr)
        excluded_contract_ids |= broken
        write_project_files(project_dir, owner, repo, package_id, version, contracts_state, excluded_contract_ids)

    raise RuntimeError(f"dotnet build for {csproj_path} still failing after "
                        f"{MAX_BUILD_QUARANTINE_ATTEMPTS} quarantine attempts")


def pack_project(project_dir: str, package_id: str, version: str) -> str:
    """Packs a single project's .csproj right away (not batched with every other
    project) and returns the resulting .nupkg path, so a package can be pushed to
    nuget.org as soon as its own version is ready instead of waiting for the whole
    run to finish."""
    csproj_path = os.path.join(project_dir, f"{package_id}.csproj")
    os.makedirs(NUPKG_OUTPUT_DIR, exist_ok=True)
    print(f"Packing {package_id} {version}", file=sys.stderr)
    result = subprocess.run(
        ["dotnet", "pack", csproj_path, "--configuration", "Release", "--output", NUPKG_OUTPUT_DIR],
        capture_output=True, text=True,
    )
    if result.returncode != 0:
        raise RuntimeError(
            f"dotnet pack failed for {csproj_path}\n--- stdout ---\n{result.stdout}\n--- stderr ---\n{result.stderr}"
        )
    return os.path.join(NUPKG_OUTPUT_DIR, f"{package_id}.{version}.nupkg")


def push_to_nuget(nupkg_path: str) -> bool:
    """Pushes one already-packed .nupkg to nuget.org using the short-lived API key the
    workflow obtained via Trusted Publishing (NUGET_API_KEY env var - see
    docs/dotnet-client-pipeline.md). Returns False (never raises) on any failure, since
    a push failure for one project must not abort generation of the rest, and
    ensure_published() below leaves the version unmarked so it's retried on the next
    run rather than silently lost."""
    api_key = os.environ.get("NUGET_API_KEY")
    if not api_key:
        print(f"NUGET_API_KEY not set - skipping nuget push for {os.path.basename(nupkg_path)}", file=sys.stderr)
        return False
    result = subprocess.run(
        ["dotnet", "nuget", "push", nupkg_path, "--api-key", api_key,
         "--source", NUGET_SOURCE, "--skip-duplicate"],
        capture_output=True, text=True,
    )
    if result.returncode != 0:
        print(
            f"WARNING: nuget push failed for {nupkg_path} (will retry next run):\n"
            f"{result.stdout}\n{result.stderr}",
            file=sys.stderr,
        )
        return False
    return True


def ensure_published(
    project_dir: str, package_id: str, state: dict, state_path: str, publish: bool
) -> bool:
    """Packs and (if --publish) pushes package_id's current state["version"] the
    moment it's known to need it - whether that's because this run just bumped it, or
    because an earlier run bumped it but never got it published (e.g. a nuget push
    failed, or that earlier run wasn't a --publish run at all). Idempotent: a no-op
    once state["published_version"] already matches state["version"]."""
    version = state.get("version")
    if not version or state.get("published_version") == version:
        return False
    csproj_path = os.path.join(project_dir, f"{package_id}.csproj")
    if not os.path.exists(csproj_path):
        return False
    try:
        nupkg_path = pack_project(project_dir, package_id, version)
    except Exception as exc:  # noqa: BLE001 - a pack failure must never abort the whole run
        print(f"WARNING: pack failed for {package_id} {version}: {exc}", file=sys.stderr)
        return False
    if not publish:
        return False
    if push_to_nuget(nupkg_path):
        state["published_version"] = version
        save_project_state(state_path, state)
        print(f"Published {package_id} {version} to nuget.org", file=sys.stderr)
        return True
    return False


def process_project(
    owner: str,
    repo: str,
    rows: list[dict[str, str]],
    generator_digest: str,
    template_hash: str,
    publish: bool,
) -> bool:
    owner_slug = sanitize_path_segment(owner)
    repo_slug = sanitize_path_segment(repo)
    repo_dir = os.path.join(CLIENTS_DIR, owner_slug, repo_slug)
    project_dir = os.path.join(repo_dir, "dotnet")
    arc56_dir = os.path.join(repo_dir, "arc56")
    src_dir = os.path.join(project_dir, "src")
    state_path = os.path.join(project_dir, "state.json")
    os.makedirs(arc56_dir, exist_ok=True)
    os.makedirs(src_dir, exist_ok=True)

    state = load_project_state(state_path)
    contracts_state: dict = state.setdefault("contracts", {})
    package_id = f"Arc56.Generated.{owner_slug}.{repo_slug}"
    # Recheck everything in *this* project if the generator image has changed since the
    # last time *this* project recorded a digest - tracked per-project (not a single
    # shared file) so a large run's progress survives being interrupted: a project that
    # already completed under the current image is not reprocessed just because other
    # projects haven't gotten to it yet.
    force_regen = state.get("generator_image_digest") != generator_digest
    # state_dirty: something in state.json changed (including failure records) and must
    # be persisted. code_changed: the actual generated code changed, which is the only
    # thing that should bump the package version / trigger a rebuild+repack - a download
    # or generator failure alone doesn't touch any .cs file, so it shouldn't produce a
    # new NuGet version, and neither does regenerating byte-identical code.
    state_dirty = False
    code_changed = False

    for row in rows:
        url = row["ARC56URL"]
        try:
            _, _, path = parse_raw_url(url)
        except ValueError as exc:
            print(f"WARNING: skipping unparseable URL {url}: {exc}", file=sys.stderr)
            continue
        filename = path.rsplit("/", 1)[-1]
        if not filename.endswith(FILENAME_SUFFIX):
            print(f"WARNING: skipping non-ARC56 URL {url}", file=sys.stderr)
            continue
        file_slug = sanitize_identifier(filename[: -len(FILENAME_SUFFIX)])
        hash8 = url_hash8(url)
        contract_id = f"{file_slug}_{hash8}"
        namespace = f"Arc56.Generated.{sanitize_identifier(owner)}.{sanitize_identifier(repo)}.{contract_id}"
        existing = contracts_state.get(url)

        # A URL that's already known to be unfetchable (bad path encoding, 404, etc.)
        # isn't worth retrying every single run - only recheck it when the generator
        # image changes, since that's our only "maybe something changed" signal here.
        if existing is not None and "download_error" in existing and not force_regen:
            continue

        try:
            content = download_with_rate_limit(url)
        except Exception as exc:  # noqa: BLE001 - a single bad row must never abort the whole run
            print(f"WARNING: download failed for {url}: {exc}", file=sys.stderr)
            contracts_state[url] = {
                **{k: v for k, v in (existing or {}).items() if k != "content_sha256"},
                "file_slug": file_slug,
                "hash8": hash8,
                "namespace": namespace,
                "download_error": str(exc),
            }
            write_incident_report(
                owner, repo, url, contract_id, namespace, "download_error", str(exc), generator_digest
            )
            state_dirty = True  # persist the failure so it isn't silently lost/retried every run;
            continue           # no .cs file changed, so this alone must not bump the package version

        content_hash = sha256_hex(content)
        needs_regen = (
            force_regen
            or existing is None
            or existing.get("content_sha256") != content_hash
        )

        try:
            arc56_path = os.path.join(arc56_dir, f"{contract_id}.arc56.json")
            with open(arc56_path, "wb") as f:
                f.write(content)
        except OSError as exc:
            print(f"WARNING: could not write {arc56_path}: {exc}", file=sys.stderr)
            contracts_state[url] = {
                **{k: v for k, v in (existing or {}).items() if k != "content_sha256"},
                "file_slug": file_slug,
                "hash8": hash8,
                "namespace": namespace,
                "download_error": f"failed to write local copy: {exc}",
            }
            write_incident_report(
                owner, repo, url, contract_id, namespace, "download_error",
                f"failed to write local copy: {exc}", generator_digest,
            )
            state_dirty = True
            continue

        if not needs_regen:
            continue

        print(f"Generating client for {url} -> namespace {namespace}", file=sys.stderr)
        try:
            generated_path = run_generator(arc56_dir, src_dir, f"{contract_id}.arc56.json", namespace)
            final_path = os.path.join(src_dir, f"{contract_id}.cs")
            if generated_path != final_path:
                os.replace(generated_path, final_path)
            class_name = extract_class_name(final_path)
            with open(final_path, "rb") as f:
                cs_hash = sha256_hex(f.read())
        except Exception as exc:  # noqa: BLE001 - a single bad contract must never abort the whole run
            # The generator tool itself can crash on certain ARC-56 specs (observed:
            # NullReferenceException in ABITypeToCSType for some struct shapes). Don't
            # let one broken contract abort the whole project/run - record the failure
            # so we don't retry every run until the content or generator image changes,
            # and note that any previously generated .cs for this contract may now be
            # stale relative to the spec copy we just wrote to arc56_path above.
            print(f"WARNING: generator failed for {url}: {exc}", file=sys.stderr)
            contracts_state[url] = {
                **{k: v for k, v in (existing or {}).items() if k != "content_sha256"},
                "content_sha256": content_hash,
                "file_slug": file_slug,
                "hash8": hash8,
                "namespace": namespace,
                "generator_error": str(exc),
            }
            write_incident_report(
                owner, repo, url, contract_id, namespace, "generator_error", str(exc), generator_digest
            )
            # No .cs file was produced/changed here (the old one, if any, is left as-is),
            # so this alone must not bump the package version - just persist the failure.
            state_dirty = True
            continue

        # Compare the newly generated code itself (not just whether we attempted
        # regeneration) - a rerun triggered by force_regen (e.g. the generator image
        # changed) very often reproduces byte-identical output, and that must not count
        # as a change: it's what actually differentiates "we regenerated" from "the
        # package's contents changed".
        previous_cs_hash = (existing or {}).get("cs_sha256")
        if previous_cs_hash is not None and previous_cs_hash == cs_hash:
            contracts_state[url] = {
                **{k: v for k, v in (existing or {}).items()
                   if k not in ("generator_error", "download_error", "content_sha256", "cs_sha256")},
                "content_sha256": content_hash,
                "cs_sha256": cs_hash,
                "file_slug": file_slug,
                "hash8": hash8,
                "namespace": namespace,
                "class_name": class_name,
            }
            state_dirty = True
            print(f"Regenerated {url} - identical code, not counted as a change", file=sys.stderr)
        else:
            contracts_state[url] = {
                "content_sha256": content_hash,
                "cs_sha256": cs_hash,
                "file_slug": file_slug,
                "hash8": hash8,
                "namespace": namespace,
                "class_name": class_name,
                "generated_at": datetime.datetime.now(datetime.timezone.utc).isoformat(),
            }
            code_changed = True

    # A template-only edit (e.g. README.md.template) never touches any contract's
    # content_sha256/cs_sha256, so it must be treated as its own trigger for a version
    # bump + republish - otherwise every already-generated package keeps stale docs
    # forever, since nothing else about this project ever changes again.
    template_changed = state.get("template_hash") != template_hash
    needs_version_bump = code_changed or template_changed

    if not (state_dirty or needs_version_bump):
        # Nothing changed this run, but an earlier run may have bumped the version
        # without successfully publishing it (failed push, or a non-publish run) -
        # retry that now rather than waiting for the next code change.
        ensure_published(project_dir, package_id, state, state_path, publish)
        return False

    if not needs_version_bump:
        # Only failure state changed (download/generator errors) - no .cs file was
        # actually added or modified, so don't bump the version or rebuild/repack.
        state["generator_image_digest"] = generator_digest
        state["template_hash"] = template_hash
        save_project_state(state_path, state)
        print(f"Project {package_id}: recorded failure state only, no generated-code "
              f"changes - version not bumped", file=sys.stderr)
        ensure_published(project_dir, package_id, state, state_path, publish)
        return False

    increment = state.get("increment", 0) + 1
    version = f"1.0.{increment}.{datetime.datetime.now(datetime.timezone.utc):%Y%m%d%H}"
    state["increment"] = increment
    state["version"] = version
    state["generator_image_digest"] = generator_digest
    state["template_hash"] = template_hash

    excluded_contract_ids = {
        contract_id_for(c) for c in contracts_state.values()
        if "file_slug" in c and "compile_error" in c
    }
    write_project_files(project_dir, owner, repo, package_id, version, contracts_state, excluded_contract_ids)
    excluded_contract_ids = build_and_quarantine(
        project_dir, owner, repo, package_id, version, contracts_state, excluded_contract_ids, generator_digest
    )
    save_project_state(state_path, state)

    print(f"Project {package_id} -> version {version} ({len(contracts_state)} contract(s), "
          f"{len(excluded_contract_ids)} quarantined)", file=sys.stderr)
    # Pack (and, with --publish, push to nuget.org) this project's package right away -
    # not after every other project has also finished generating - so packages show up
    # on nuget.org incrementally as the run progresses instead of all at once at the end.
    ensure_published(project_dir, package_id, state, state_path, publish)
    return True


def write_project_files(
    project_dir: str,
    owner: str,
    repo: str,
    package_id: str,
    version: str,
    contracts_state: dict,
    excluded_contract_ids: set[str] = frozenset(),
) -> None:
    with open(os.path.join(TEMPLATE_DIR, "Project.csproj.template"), encoding="utf-8") as f:
        csproj_template = f.read()
    with open(os.path.join(TEMPLATE_DIR, "README.md.template"), encoding="utf-8") as f:
        readme_template = f.read()

    description = f"Generated ARC-56 Algorand smart-contract clients for {owner}/{repo}."
    excluded_items = "\n".join(
        f'    <Compile Remove="src/{cid}.cs" />' for cid in sorted(excluded_contract_ids)
    )
    csproj = render_template(csproj_template, {
        "PACKAGE_ID": package_id,
        "VERSION": version,
        "OWNER": owner,
        "REPO": repo,
        "DESCRIPTION": description,
        "REGISTRY_REPO_URL": REGISTRY_REPO_URL,
        "EXCLUDED_COMPILE_ITEMS": excluded_items,
    })
    with open(os.path.join(project_dir, f"{package_id}.csproj"), "w", encoding="utf-8", newline="\n") as f:
        f.write(csproj)

    sorted_urls = sorted(contracts_state.keys(), key=str.lower)
    table_rows = []
    for url in sorted_urls:
        c = contracts_state[url]
        if "download_error" in c:
            table_rows.append(f"| _(unfetchable)_ | _(download failed - see state.json)_ | [{url}]({url}) |")
        elif "generator_error" in c:
            table_rows.append(f"| `{c['namespace']}` | _(generation failed - see state.json)_ | [{url}]({url}) |")
        elif "compile_error" in c:
            table_rows.append(f"| `{c['namespace']}` | _(fails to compile - excluded, see state.json)_ | [{url}]({url}) |")
        else:
            table_rows.append(f"| `{c['namespace']}` | `{c['class_name']}` | [{url}]({url}) |")
    contracts_table = "\n".join(table_rows) if table_rows else "| _(none yet)_ | | |"

    successful_urls = [
        u for u in sorted_urls
        if "class_name" in contracts_state[u] and "compile_error" not in contracts_state[u]
    ]
    first = contracts_state[successful_urls[0]] if successful_urls else None
    readme = render_template(readme_template, {
        "PACKAGE_ID": package_id,
        "OWNER": owner,
        "REPO": repo,
        "CONTRACTS_TABLE": contracts_table,
        "FIRST_CONTRACT_NAMESPACE": first["namespace"] if first else "Arc56.Generated.Owner.Repo.Contract_hash",
        "FIRST_CONTRACT_CLASS": first["class_name"] if first else "ContractProxy",
    })
    with open(os.path.join(project_dir, "README.md"), "w", encoding="utf-8", newline="\n") as f:
        f.write(readme)


_last_push_at: float | None = None


def push_commits(force: bool = False) -> None:
    """Pushes whatever local commits exist so far. Called after every
    commit_project_changes() but throttled to at most once per PUSH_INTERVAL_SECONDS
    (force=True bypasses the throttle, used for the final flush after the loop) - so a
    long run doesn't do a network round-trip per project, while still bounding how much
    already-finished, already-committed work could be lost if the job dies before
    reaching its own final push step. Never raises: a push failure here just means the
    next periodic push (or the workflow's own final push step) picks it up instead."""
    global _last_push_at
    now = time.monotonic()
    if not force and _last_push_at is not None and now - _last_push_at < PUSH_INTERVAL_SECONDS:
        return
    result = subprocess.run(["git", "push"], cwd=REPO_ROOT, capture_output=True, text=True)
    if result.returncode != 0:
        print(f"WARNING: git push failed (will retry later): {result.stdout}\n{result.stderr}", file=sys.stderr)
        return
    _last_push_at = now


def configure_git_identity() -> None:
    """Sets the git identity used by commit_project_changes(). Repo-local only (no
    --global), so this never touches a developer's own git config outside this
    checkout - safe to call even for a local --commit test run."""
    subprocess.run(["git", "config", "user.name", "github-actions[bot]"], cwd=REPO_ROOT, check=True)
    subprocess.run(
        ["git", "config", "user.email", "github-actions[bot]@users.noreply.github.com"],
        cwd=REPO_ROOT, check=True,
    )


def commit_project_changes(owner: str, repo: str) -> None:
    """Commits (but does not push) whatever changed on disk for this one project -
    including a version bump - right after it's processed, so the run produces one
    commit per changed project as it goes instead of a single giant commit for
    everything at the very end. A no-op if nothing changed for this project. Also
    stages clients/_incidents, since rebuild_incidents_index() (called right before
    this, in main()) may have updated it to reflect this project's own incidents."""
    paths = [
        os.path.join("clients", sanitize_path_segment(owner), sanitize_path_segment(repo)),
        os.path.join("clients", "_incidents"),
    ]
    subprocess.run(["git", "add", "--", *paths], cwd=REPO_ROOT, check=True)
    diff = subprocess.run(["git", "diff", "--cached", "--quiet", "--", *paths], cwd=REPO_ROOT)
    if diff.returncode == 0:
        return  # nothing staged for this project
    subprocess.run(
        ["git", "commit", "-m", f"chore: regenerate .NET ARC-56 client for {owner}/{repo}"],
        cwd=REPO_ROOT, check=True,
    )
    print(f"Committed changes for {owner}/{repo}", file=sys.stderr)


def main() -> int:
    parser = argparse.ArgumentParser()
    parser.add_argument("--limit-projects", type=int, default=None,
                         help="Only process the first N owner/repo projects (for local testing).")
    parser.add_argument("--only-repo", action="append", default=[],
                         help="Only process owner/repo (exact match, can be passed multiple times).")
    parser.add_argument("--filter", action="append", default=[],
                         help="Only process owner/repo pairs whose \"owner/repo\" string contains this "
                              "substring, case-insensitive (e.g. 'scholtz' or 'scholtz/Biatec'). Can be "
                              "passed multiple times - matches are OR'd together. If --only-repo is also "
                              "given, a project must satisfy both.")
    parser.add_argument("--publish", action="store_true",
                         help="Push each changed project's package to nuget.org (via NUGET_API_KEY) "
                              "as soon as that project is packed, instead of only packing.")
    parser.add_argument("--commit", action="store_true",
                         help="Git-commit each project's changes (including version bumps) as soon as "
                              "that project finishes, instead of leaving everything for the workflow to "
                              "commit in one batch at the end. Off by default so local test runs don't "
                              "create commits unless explicitly asked to.")
    args = parser.parse_args()

    if not os.path.isdir(CLIENTS_DIR):
        print(f"ERROR: {CLIENTS_DIR} does not exist", file=sys.stderr)
        return 1

    try:
        generator_digest = get_generator_image_digest()
    except subprocess.CalledProcessError as exc:
        print(f"ERROR: could not resolve {GENERATOR_IMAGE} digest: {exc}", file=sys.stderr)
        return 1
    print(f"Generator image digest: {generator_digest}", file=sys.stderr)
    template_hash = get_template_hash()

    rows = load_active_rows()
    grouped: dict[tuple[str, str], list[dict[str, str]]] = {}
    for row in rows:
        try:
            owner, repo, _ = parse_raw_url(row["ARC56URL"])
        except ValueError as exc:
            print(f"WARNING: {exc}", file=sys.stderr)
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

    changed_projects = 0
    failed_projects = 0
    for (owner, repo), project_rows in selected:
        # A single project must never be able to take down the whole run - process_project
        # already handles the failure modes we've seen in practice (download/generator/
        # compile errors) without raising, but this is the last line of defense against
        # anything unanticipated (e.g. a permissions error from docker/dotnet/git) so a
        # fresh failure mode degrades to "skip this one project" instead of aborting
        # everything after it. Combined with pushing progress as we go (below), this is
        # what makes the *next* run's catch-up fast: only the project that actually
        # failed (or was mid-flight) needs to be redone, not everything after it too.
        try:
            if process_project(owner, repo, project_rows, generator_digest, template_hash, args.publish):
                changed_projects += 1
            # Rebuilt per-project (not just once at the end) so a --commit run's
            # per-project commit always includes this project's own incidents, if any.
            rebuild_incidents_index()
            if args.commit:
                commit_project_changes(owner, repo)
                push_commits()
        except Exception as exc:  # noqa: BLE001 - see comment above
            failed_projects += 1
            print(f"ERROR: unexpected failure processing {owner}/{repo}, skipping and "
                  f"continuing with the next project: {exc}", file=sys.stderr)
            continue

    if args.commit:
        push_commits(force=True)

    print(f"Done: {len(selected)}/{len(grouped)} project(s) scanned, "
          f"{changed_projects} regenerated/bumped, {failed_projects} failed unexpectedly", file=sys.stderr)
    # Exit nonzero if anything hit the unexpected-failure path above, so CI still shows
    # red and a human notices - but only after every successfully-processed project has
    # already been packed/published/committed/pushed, so nothing already-done is lost
    # or blocked on the failed one(s).
    return 1 if failed_projects else 0


if __name__ == "__main__":
    sys.exit(main())
