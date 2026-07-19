#!/usr/bin/env python3
"""Generate/update the per-repository .NET client source for ARC-56 specs.

This is the second of three stages in the client-generation pipeline (download ->
generate -> publish; see scripts/download_arc56_specs.py and
scripts/publish_dotnet_packages.py). It makes no network requests of its own and
applies no rate-limiting delay - it only reads ARC-56 spec files already downloaded
by scripts/download_arc56_specs.py into clients/<owner>/<repo>/arc56/, and does not
publish anything to nuget.org (that's scripts/publish_dotnet_packages.py's job).

For every *active* row in arc56.links.csv whose spec has already been downloaded,
this script:

  1. Reads the local copy of the ARC-56 JSON spec from
     clients/<owner>/<repo>/arc56/<file_slug>_<hash8>.arc56.json (written by
     scripts/download_arc56_specs.py). A row whose spec hasn't been downloaded yet is
     skipped for this run - it'll be picked up automatically once the download
     pipeline reaches it.
  2. If its content changed (or the generator docker image changed, or it's new),
     regenerates the C# client via the scholtz2/dotnet-avm-generated-client docker
     image into clients/<owner>/<repo>/dotnet/src/<file_slug>_<hash8>.cs, in a
     namespace unique to that contract (Arc56.Generated.<Owner>.<Repo>.<file_slug>_<hash8>).
  3. Builds the aggregate project (`dotnet build`) to catch and quarantine any
     contract whose generated code fails to compile, so one broken contract doesn't
     block every other contract in the same package.

One NuGet package is produced per GitHub repository (owner/repo), bundling every
ARC-56 client found in that repo. A repo's package version is only bumped when at
least one of its contracts actually changed content, the generator image changed
(which forces every package to regenerate), or the README/csproj templates under
clients/_template/ changed (which forces every package to re-render its docs/metadata
and bump, even with no contract changes). Version format: 1.0.<increment>.<yyyyMMddHH>
(matches the legacy 4-part scheme already used by the Algorand4 package this depends
on). Packing (`dotnet pack`) and publishing to nuget.org are handled entirely by
scripts/publish_dotnet_packages.py, run as its own separate pipeline stage.

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

REPO_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
CSV_PATH = os.path.join(REPO_ROOT, "arc56.links.csv")
CLIENTS_DIR = os.path.join(REPO_ROOT, "clients")
TEMPLATE_DIR = os.path.join(CLIENTS_DIR, "_template")
INCIDENTS_DIR = os.path.join(CLIENTS_DIR, "_incidents")

REGISTRY_REPO_URL = "https://github.com/scholtz/Arc56Registry"
GENERATOR_IMAGE = "scholtz2/dotnet-avm-generated-client:latest"
# How often --commit pushes local commits to the remote while the run is still going,
# rather than only once at the very end. Bounds how much already-finished work could
# be stranded on the runner and lost if the job later dies - see push_commits().
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


def log(message: str) -> None:
    """Every log line is prefixed with a UTC timestamp, so a multi-hour CI run's output
    can be correlated with wall-clock time."""
    timestamp = datetime.datetime.now(datetime.timezone.utc).strftime("%Y-%m-%dT%H:%M:%SZ")
    print(f"{timestamp} {message}", file=sys.stderr)


def sanitize_path_segment(name: str) -> str:
    return re.sub(r"[^A-Za-z0-9_.-]", "-", name)


def sanitize_nuget_id_segment(name: str) -> str:
    """Like sanitize_path_segment, but also satisfies NuGet's PackageId regex
    (^\\w+([_.-]\\w+)*$), which - unlike the filesystem - rejects consecutive '.'/'-'
    separators and a leading/trailing separator. Repo/owner names on GitHub are only
    constrained to be filesystem-safe, so e.g. 'ALGO---BOUNTY' or 'crestFlow-working-'
    are valid repo names but invalid NuGet package ID segments; collapse/trim here so
    the resulting `Arc56.Generated.<owner>.<repo>` PackageId is always packable."""
    slug = sanitize_path_segment(name)
    slug = re.sub(r"[.-]{2,}", "-", slug)
    slug = slug.strip("-.")
    return slug or "x"


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
    and gets marked for republish, instead of silently sitting stale forever."""
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
    """Writes a standalone incident report for a generator/compile failure, with the
    source URL, a repro command, and the full error/stack trace. Does not file or link
    to filing a GitHub issue - that's left for a human to do manually."""
    incident_dir = os.path.join(INCIDENTS_DIR, sanitize_path_segment(owner), sanitize_path_segment(repo))
    os.makedirs(incident_dir, exist_ok=True)
    report_path = os.path.join(incident_dir, f"{contract_id}.md")

    kind_label = FAILURE_LABELS.get(failure_type, failure_type)
    detected_at = datetime.datetime.now(datetime.timezone.utc).isoformat()
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
    so there's always one place to see every open generator/compile failure. Download
    failures live in each repo's clients/<owner>/<repo>/arc56/state.json instead (see
    scripts/download_arc56_specs.py) and are not part of this index."""
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
        "# Open ARC-56 .NET client generation incidents",
        "",
        "Rebuilt automatically by `scripts/generate_dotnet_clients.py` on every run. Each row "
        "links to a report with the source URL, a repro command, and the full error/stack trace. "
        "Download failures are tracked separately in each repo's "
        "`clients/<owner>/<repo>/arc56/state.json` (see scripts/download_arc56_specs.py).",
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
    marker = f"{contract_id}.cs("
    lines = [
        line for line in combined_output.splitlines()
        if marker in line and re.search(r"\):\s*error\b", line)
    ]
    if lines:
        return "\n".join(lines)
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
            log(f"WARNING: quarantining {contract_id} - fails to compile")
        excluded_contract_ids |= broken
        write_project_files(project_dir, owner, repo, package_id, version, contracts_state, excluded_contract_ids)

    raise RuntimeError(f"dotnet build for {csproj_path} still failing after "
                        f"{MAX_BUILD_QUARANTINE_ATTEMPTS} quarantine attempts")


def process_project(
    owner: str,
    repo: str,
    rows: list[dict[str, str]],
    generator_digest: str,
    template_hash: str,
    progress: list[int],
) -> bool:
    owner_slug = sanitize_path_segment(owner)
    repo_slug = sanitize_path_segment(repo)
    repo_dir = os.path.join(CLIENTS_DIR, owner_slug, repo_slug)
    project_dir = os.path.join(repo_dir, "dotnet")
    arc56_dir = os.path.join(repo_dir, "arc56")
    src_dir = os.path.join(project_dir, "src")
    state_path = os.path.join(project_dir, "state.json")
    os.makedirs(src_dir, exist_ok=True)

    state = load_project_state(state_path)
    contracts_state: dict = state.setdefault("contracts", {})
    package_id = f"Arc56.Generated.{sanitize_nuget_id_segment(owner_slug)}.{sanitize_nuget_id_segment(repo_slug)}"
    # Recheck everything in *this* project if the generator image has changed since the
    # last time *this* project recorded a digest - tracked per-project (not a single
    # shared file) so a large run's progress survives being interrupted.
    force_regen = state.get("generator_image_digest") != generator_digest
    state_dirty = False
    code_changed = False

    # Self-heal a project whose on-disk PackageId no longer matches what this script
    # would compute today (e.g. sanitize_nuget_id_segment() started collapsing/trimming
    # separators that NuGet's PackageId regex rejects, after a project was already
    # generated with the old, unsanitized id). Rename in place - never leave the
    # invalid-id file behind as an orphan that dotnet pack will keep failing on forever,
    # but also never regenerate content that hasn't actually changed.
    old_package_id = state.get("package_id")
    if old_package_id is None:
        # First run that tracks package_id in state.json - fall back to whatever
        # single .csproj already exists on disk (named after the id an older version
        # of this script computed) so the migration below still fires instead of
        # silently leaving a second, correctly-named .csproj next to the stale one.
        existing_csprojs = [f for f in os.listdir(project_dir) if f.endswith(".csproj")] \
            if os.path.isdir(project_dir) else []
        if len(existing_csprojs) == 1:
            candidate = existing_csprojs[0][: -len(".csproj")]
            if candidate != package_id:
                old_package_id = candidate
    if old_package_id and old_package_id != package_id:
        old_csproj_path = os.path.join(project_dir, f"{old_package_id}.csproj")
        new_csproj_path = os.path.join(project_dir, f"{package_id}.csproj")
        if os.path.isfile(old_csproj_path) and not os.path.isfile(new_csproj_path):
            with open(old_csproj_path, encoding="utf-8") as f:
                csproj_content = f.read()
            csproj_content = csproj_content.replace(
                f"<PackageId>{old_package_id}</PackageId>", f"<PackageId>{package_id}</PackageId>"
            )
            os.remove(old_csproj_path)
            with open(new_csproj_path, "w", encoding="utf-8", newline="\n") as f:
                f.write(csproj_content)
            log(f"Renamed project id {old_package_id} -> {package_id} (invalid NuGet PackageId fix)")
    if state.get("package_id") != package_id:
        state["package_id"] = package_id
        state_dirty = True

    for row in rows:
        url = row["ARC56URL"]
        progress[0] += 1
        log(f"[{progress[0]}/{progress[1]}] {owner}/{repo}: {url}")
        try:
            _, _, path = parse_raw_url(url)
        except ValueError as exc:
            log(f"WARNING: skipping unparseable URL {url}: {exc}")
            continue
        filename = path.rsplit("/", 1)[-1]
        if not filename.endswith(FILENAME_SUFFIX):
            log(f"WARNING: skipping non-ARC56 URL {url}")
            continue
        file_slug = sanitize_identifier(filename[: -len(FILENAME_SUFFIX)])
        hash8 = url_hash8(url)
        contract_id = f"{file_slug}_{hash8}"
        namespace = f"Arc56.Generated.{sanitize_identifier(owner)}.{sanitize_identifier(repo)}.{contract_id}"
        existing = contracts_state.get(url)

        arc56_path = os.path.join(arc56_dir, f"{contract_id}.arc56.json")
        if not os.path.isfile(arc56_path):
            # Not downloaded yet (or the download failed and is tracked in
            # arc56/state.json) - scripts/download_arc56_specs.py will produce it on a
            # later run; nothing for this stage to do yet.
            continue

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

        log(f"Generating client for {url} -> namespace {namespace}")
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
            # so we don't retry every run until the content or generator image changes.
            log(f"WARNING: generator failed for {url}: {exc}")
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
                   if k not in ("generator_error", "content_sha256", "cs_sha256")},
                "content_sha256": content_hash,
                "cs_sha256": cs_hash,
                "file_slug": file_slug,
                "hash8": hash8,
                "namespace": namespace,
                "class_name": class_name,
            }
            state_dirty = True
            log(f"Regenerated {url} - identical code, not counted as a change")
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
    # bump - otherwise every already-generated package keeps stale docs forever, since
    # nothing else about this project ever changes again.
    template_changed = state.get("template_hash") != template_hash
    needs_version_bump = code_changed or template_changed

    if not (state_dirty or needs_version_bump):
        return False

    if not needs_version_bump:
        # Only failure state changed (a generator crash) - no .cs file was actually
        # added or modified, so don't bump the version or rebuild.
        state["generator_image_digest"] = generator_digest
        state["template_hash"] = template_hash
        save_project_state(state_path, state)
        log(f"Project {package_id}: recorded failure state only, no generated-code "
              f"changes - version not bumped")
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

    log(f"Project {package_id} -> version {version} ({len(contracts_state)} contract(s), "
          f"{len(excluded_contract_ids)} quarantined)")
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
        if "generator_error" in c:
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
    (force=True bypasses the throttle, used for the final flush after the loop).
    Always pulls (rebasing our local commits on top) immediately before pushing, since
    other pipeline runs can move origin/main in between - and retries the pull+push
    cycle up to 3 times total before giving up for this checkpoint, since a rejected
    push usually just means the remote moved again between our pull and push."""
    global _last_push_at
    now = time.monotonic()
    if not force and _last_push_at is not None and now - _last_push_at < PUSH_INTERVAL_SECONDS:
        return
    max_attempts = 3
    for attempt in range(1, max_attempts + 1):
        pull = subprocess.run(["git", "pull", "--rebase"], cwd=REPO_ROOT, capture_output=True, text=True)
        if pull.returncode != 0:
            log(f"WARNING: git pull --rebase failed (attempt {attempt}/{max_attempts}): "
                f"{pull.stdout}\n{pull.stderr}")
        result = subprocess.run(["git", "push"], cwd=REPO_ROOT, capture_output=True, text=True)
        if result.returncode == 0:
            _last_push_at = now
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
    """Commits (but does not push) whatever changed on disk for this one project's
    dotnet/ folder, plus the shared clients/_incidents index."""
    paths = [
        os.path.join("clients", sanitize_path_segment(owner), sanitize_path_segment(repo), "dotnet"),
        os.path.join("clients", "_incidents"),
    ]
    subprocess.run(["git", "add", "--", *paths], cwd=REPO_ROOT, check=True)
    diff = subprocess.run(["git", "diff", "--cached", "--quiet", "--", *paths], cwd=REPO_ROOT)
    if diff.returncode == 0:
        return
    subprocess.run(
        ["git", "commit", "-m", f"chore: regenerate .NET ARC-56 client for {owner}/{repo}"],
        cwd=REPO_ROOT, check=True,
    )
    log(f"Committed changes for {owner}/{repo}")


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    parser.add_argument("--limit-projects", type=int, default=None,
                         help="Only process the first N owner/repo projects (for local testing).")
    parser.add_argument("--only-repo", action="append", default=[],
                         help="Only process owner/repo (exact match, can be passed multiple times).")
    parser.add_argument("--filter", action="append", default=[],
                         help="Only process owner/repo pairs whose \"owner/repo\" string contains this "
                              "substring, case-insensitive (e.g. 'scholtz' or 'scholtz/Biatec'). Can be "
                              "passed multiple times - matches are OR'd together. If --only-repo is also "
                              "given, a project must satisfy both.")
    parser.add_argument("--commit", action="store_true",
                         help="Git-commit each project's changes (including version bumps) as soon as "
                              "that project finishes, instead of leaving everything for the workflow to "
                              "commit in one batch at the end.")
    args = parser.parse_args()

    if not os.path.isdir(CLIENTS_DIR):
        log(f"ERROR: {CLIENTS_DIR} does not exist")
        return 1

    try:
        generator_digest = get_generator_image_digest()
    except subprocess.CalledProcessError as exc:
        log(f"ERROR: could not resolve {GENERATOR_IMAGE} digest: {exc}")
        return 1
    log(f"Generator image digest: {generator_digest}")
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
            if process_project(owner, repo, project_rows, generator_digest, template_hash, progress):
                changed_projects += 1
            rebuild_incidents_index()
            if args.commit:
                commit_project_changes(owner, repo)
                push_commits()
        except Exception as exc:  # noqa: BLE001 - see comment above
            failed_projects += 1
            log(f"ERROR: unexpected failure processing {owner}/{repo}, skipping and "
                  f"continuing with the next project: {exc}")
            continue

    if args.commit:
        push_commits(force=True)

    log(f"Done: {len(selected)}/{len(grouped)} project(s) scanned, "
          f"{changed_projects} regenerated/bumped, {failed_projects} failed unexpectedly")
    return 1 if failed_projects else 0


if __name__ == "__main__":
    sys.exit(main())
