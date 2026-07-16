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
    subprocess.run(["docker", "pull", GENERATOR_IMAGE], check=True)
    result = subprocess.run(
        ["docker", "image", "inspect", GENERATOR_IMAGE, "--format", "{{index .RepoDigests 0}}"],
        capture_output=True, text=True, check=True,
    )
    return result.stdout.strip()


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
    subprocess.run(
        [
            "docker", "run", "--rm",
            "-v", f"{arc56_dir}:/app/artifacts",
            "-v", f"{src_dir}:/app/out",
            GENERATOR_IMAGE,
            "dotnet", "client-generator.dll",
            "--namespace", namespace,
            "--file", f"artifacts/{arc56_filename}",
        ],
        check=True,
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


def contract_id_for(contract: dict) -> str:
    return f"{contract['file_slug']}_{contract['hash8']}"


def run_dotnet_build(csproj_path: str) -> subprocess.CompletedProcess:
    return subprocess.run(
        ["dotnet", "build", csproj_path, "--configuration", "Release", "--nologo"],
        capture_output=True, text=True,
    )


def find_broken_contract_ids(build_output: str) -> set[str]:
    return {m.group("contract_id") for m in COMPILE_ERROR_FILE_RE.finditer(build_output)}


def build_and_quarantine(
    project_dir: str,
    owner: str,
    repo: str,
    package_id: str,
    version: str,
    contracts_state: dict,
    excluded_contract_ids: set[str],
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

        broken = find_broken_contract_ids(result.stdout + result.stderr) - excluded_contract_ids
        if not broken:
            raise RuntimeError(
                f"dotnet build failed for {csproj_path} and no (new) broken contract file "
                f"could be attributed from the output:\n{result.stdout[-4000:]}\n{result.stderr[-2000:]}"
            )
        for contract_id in broken:
            url = contract_id_to_url.get(contract_id)
            if url is not None:
                contracts_state[url]["compile_error"] = (
                    "generated code fails to compile in the aggregate project "
                    "(known upstream generator limitation for some ABI type shapes)"
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
    project_dirty = False

    for row in rows:
        url = row["ARC56URL"]
        _, _, path = parse_raw_url(url)
        filename = path.rsplit("/", 1)[-1]
        if not filename.endswith(FILENAME_SUFFIX):
            print(f"WARNING: skipping non-ARC56 URL {url}", file=sys.stderr)
            continue
        file_slug = sanitize_identifier(filename[: -len(FILENAME_SUFFIX)])
        hash8 = url_hash8(url)
        contract_id = f"{file_slug}_{hash8}"

        content = download_with_rate_limit(url)
        content_hash = sha256_hex(content)

        existing = contracts_state.get(url)
        needs_regen = (
            global_force_regen
            or existing is None
            or existing.get("content_sha256") != content_hash
        )

        arc56_path = os.path.join(arc56_dir, f"{contract_id}.arc56.json")
        with open(arc56_path, "wb") as f:
            f.write(content)

        if not needs_regen:
            continue

        namespace = f"Arc56.Generated.{sanitize_identifier(owner)}.{sanitize_identifier(repo)}.{contract_id}"
        print(f"Generating client for {url} -> namespace {namespace}", file=sys.stderr)
        try:
            generated_path = run_generator(arc56_dir, src_dir, f"{contract_id}.arc56.json", namespace)
            final_path = os.path.join(src_dir, f"{contract_id}.cs")
            if generated_path != final_path:
                os.replace(generated_path, final_path)
            class_name = extract_class_name(final_path)
        except (subprocess.CalledProcessError, RuntimeError) as exc:
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
            continue

        contracts_state[url] = {
            "content_sha256": content_hash,
            "file_slug": file_slug,
            "hash8": hash8,
            "namespace": namespace,
            "class_name": class_name,
            "generated_at": datetime.datetime.now(datetime.timezone.utc).isoformat(),
        }
        project_dirty = True

    if not project_dirty:
        return False

    increment = state.get("increment", 0) + 1
    version = f"1.0.{increment}.{datetime.datetime.now(datetime.timezone.utc):%Y%m%d%H}"
    state["increment"] = increment
    state["version"] = version
    state["generator_image_digest"] = generator_digest

    package_id = f"Arc56.Generated.{owner_slug}.{repo_slug}"
    excluded_contract_ids = {
        contract_id_for(c) for c in contracts_state.values()
        if "file_slug" in c and "compile_error" in c
    }
    write_project_files(project_dir, owner, repo, package_id, version, contracts_state, excluded_contract_ids)
    excluded_contract_ids = build_and_quarantine(
        project_dir, owner, repo, package_id, version, contracts_state, excluded_contract_ids
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
