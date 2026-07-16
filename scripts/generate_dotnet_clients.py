#!/usr/bin/env python3
"""Generate/update the per-repository .NET NuGet packages of ARC-56 clients.

For every *active* row in arc56.links.csv, this script:

  1. Downloads the ARC-56 JSON spec (rate-limited: at least DOWNLOAD_DELAY_SECONDS
     between downloads, so we don't hammer raw.githubusercontent.com).
  2. Copies it into clients/dotnet/<owner>/<repo>/arc56/<file_slug>_<hash8>.arc56.json.
  3. If its content changed (or the generator docker image changed, or it's new),
     regenerates the C# client via the scholtz2/dotnet-avm-generated-client docker
     image into clients/dotnet/<owner>/<repo>/src/<file_slug>_<hash8>.cs, in a
     namespace unique to that contract (Arc56.Generated.<Owner>.<Repo>.<file_slug>_<hash8>).

One NuGet package is produced per GitHub repository (owner/repo), bundling every
ARC-56 client found in that repo. A repo's package version is only bumped, and only
`dotnet pack` re-run, when at least one of its contracts actually changed content, or
the generator image changed (which forces every package to regenerate). Version
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
CLIENTS_DOTNET_DIR = os.path.join(REPO_ROOT, "clients", "dotnet")
TEMPLATE_DIR = os.path.join(CLIENTS_DOTNET_DIR, "_template")
GLOBAL_STATE_PATH = os.path.join(CLIENTS_DOTNET_DIR, "generator-image-state.json")
INCIDENTS_DIR = os.path.join(CLIENTS_DOTNET_DIR, "_incidents")

REGISTRY_REPO_URL = "https://github.com/scholtz/Arc56Registry"
GENERATOR_IMAGE = "scholtz2/dotnet-avm-generated-client:latest"
DOWNLOAD_DELAY_SECONDS = 7

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


def load_global_state() -> dict:
    if not os.path.exists(GLOBAL_STATE_PATH):
        return {}
    with open(GLOBAL_STATE_PATH, encoding="utf-8") as f:
        return json.load(f)


def save_global_state(state: dict) -> None:
    with open(GLOBAL_STATE_PATH, "w", encoding="utf-8") as f:
        json.dump(state, f, indent=2)
        f.write("\n")


def load_project_state(path: str) -> dict:
    if not os.path.exists(path):
        return {"increment": 0, "version": None, "contracts": {}}
    with open(path, encoding="utf-8") as f:
        return json.load(f)


def save_project_state(path: str, state: dict) -> None:
    with open(path, "w", encoding="utf-8") as f:
        json.dump(state, f, indent=2, sort_keys=True)
        f.write("\n")


def run_generator(arc56_dir: str, src_dir: str, arc56_filename: str, namespace: str) -> str:
    """Runs the docker generator and returns the path to the generated .cs file."""
    before = set(os.listdir(src_dir)) if os.path.isdir(src_dir) else set()
    os.makedirs(src_dir, exist_ok=True)
    cmd = [
        "docker", "run", "--rm",
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
    """Rebuilds clients/dotnet/_incidents/README.md from every project's state.json,
    so there's always one place to see every open generator/compile/download failure."""
    rows = []
    for root, _dirs, files in os.walk(CLIENTS_DOTNET_DIR):
        if "state.json" not in files:
            continue
        if os.path.commonpath([root, INCIDENTS_DIR]) == INCIDENTS_DIR or os.path.commonpath([root, TEMPLATE_DIR]) == TEMPLATE_DIR:
            continue
        rel = os.path.relpath(root, CLIENTS_DOTNET_DIR)
        parts = rel.split(os.sep)
        if len(parts) != 2:
            continue
        owner, repo = parts
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


def process_project(
    owner: str,
    repo: str,
    rows: list[dict[str, str]],
    global_force_regen: bool,
    generator_digest: str,
) -> bool:
    owner_slug = sanitize_path_segment(owner)
    repo_slug = sanitize_path_segment(repo)
    project_dir = os.path.join(CLIENTS_DOTNET_DIR, owner_slug, repo_slug)
    arc56_dir = os.path.join(project_dir, "arc56")
    src_dir = os.path.join(project_dir, "src")
    state_path = os.path.join(project_dir, "state.json")
    os.makedirs(arc56_dir, exist_ok=True)
    os.makedirs(src_dir, exist_ok=True)

    state = load_project_state(state_path)
    contracts_state: dict = state.setdefault("contracts", {})
    package_id = f"Arc56.Generated.{owner_slug}.{repo_slug}"
    # state_dirty: something in state.json changed (including failure records) and must
    # be persisted. code_changed: the actual generated code changed, which is the only
    # thing that should bump the package version / trigger a rebuild+repack - a download
    # or generator failure alone doesn't touch any .cs file, so it shouldn't produce a
    # new NuGet version.
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
        if existing is not None and "download_error" in existing and not global_force_regen:
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
            global_force_regen
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

        contracts_state[url] = {
            "content_sha256": content_hash,
            "file_slug": file_slug,
            "hash8": hash8,
            "namespace": namespace,
            "class_name": class_name,
            "generated_at": datetime.datetime.now(datetime.timezone.utc).isoformat(),
        }
        code_changed = True

    if not (state_dirty or code_changed):
        return False

    if not code_changed:
        # Only failure state changed (download/generator errors) - no .cs file was
        # actually added or modified, so don't bump the version or rebuild/repack.
        state["generator_image_digest"] = generator_digest
        save_project_state(state_path, state)
        print(f"Project {package_id}: recorded failure state only, no generated-code "
              f"changes - version not bumped", file=sys.stderr)
        return False

    increment = state.get("increment", 0) + 1
    version = f"1.0.{increment}.{datetime.datetime.now(datetime.timezone.utc):%Y%m%d%H}"
    state["increment"] = increment
    state["version"] = version
    state["generator_image_digest"] = generator_digest

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


def main() -> int:
    parser = argparse.ArgumentParser()
    parser.add_argument("--limit-projects", type=int, default=None,
                         help="Only process the first N owner/repo projects (for local testing).")
    parser.add_argument("--only-repo", action="append", default=[],
                         help="Only process owner/repo (can be passed multiple times).")
    args = parser.parse_args()

    if not os.path.isdir(CLIENTS_DOTNET_DIR):
        print(f"ERROR: {CLIENTS_DOTNET_DIR} does not exist", file=sys.stderr)
        return 1

    try:
        generator_digest = get_generator_image_digest()
    except subprocess.CalledProcessError as exc:
        print(f"ERROR: could not resolve {GENERATOR_IMAGE} digest: {exc}", file=sys.stderr)
        return 1
    print(f"Generator image digest: {generator_digest}", file=sys.stderr)

    global_state = load_global_state()
    global_force_regen = global_state.get("digest") != generator_digest
    if global_force_regen:
        print("Generator image changed since last run - regenerating every project",
              file=sys.stderr)

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
    is_partial_run = bool(args.only_repo) or args.limit_projects is not None
    if args.limit_projects is not None:
        selected = selected[: args.limit_projects]

    changed_projects = 0
    for (owner, repo), project_rows in selected:
        if process_project(owner, repo, project_rows, global_force_regen, generator_digest):
            changed_projects += 1

    rebuild_incidents_index()

    if is_partial_run:
        print("Partial run (--only-repo/--limit-projects used): not updating the global "
              "generator-image state, so a full run will still see any pending image change.",
              file=sys.stderr)
    else:
        save_global_state({"image": GENERATOR_IMAGE, "digest": generator_digest})

    print(f"Done: {len(selected)}/{len(grouped)} project(s) scanned, "
          f"{changed_projects} regenerated/bumped", file=sys.stderr)
    return 0


if __name__ == "__main__":
    sys.exit(main())
