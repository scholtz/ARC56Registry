#!/usr/bin/env python3
"""Generate/update the per-repository TypeScript npm packages of ARC-56 clients.

Mirrors scripts/generate_dotnet_clients.py, but for TypeScript instead of C#, using
the ARC-56/ARC-32 client generator from
[algorandfoundation/algokit-client-generator-ts](https://github.com/algorandfoundation/algokit-client-generator-ts)
(the `@algorandfoundation/algokit-client-generator` npm package, invoked via `npx`).

This is the second of three stages in the TypeScript pipeline (download -> generate ->
publish; see scripts/download_arc56_specs.py and scripts/publish_npm_packages.py). It
makes no network requests for ARC-56 specs and applies no rate-limiting delay of its
own - it only reads specs already downloaded by scripts/download_arc56_specs.py into
clients/<owner>/<repo>/arc56/, and does not publish anything to npm (that's
scripts/publish_npm_packages.py's job). `npx` itself does fetch the generator package
from the npm registry on first use per Node install, but that's a one-time, small
metadata/tarball request, not a per-contract download - unrelated to the ARC-56
rate-limiting this pipeline cares about.

For every *active* row in arc56.links.csv whose spec has already been downloaded,
this script:

  1. Reads the local copy of the ARC-56 JSON spec from
     clients/<owner>/<repo>/arc56/<file_slug>_<hash8>.arc56.json.
  2. If its content changed (or the generator's npm package version changed, or it's
     new), regenerates the TypeScript client via
     `npx @algorandfoundation/algokit-client-generator generate` into
     clients/<owner>/<repo>/npm/src/<file_slug>_<hash8>.ts, re-exported from that
     package's src/index.ts under a namespace unique to that contract
     (`export * as <file_slug>_<hash8> from './<file_slug>_<hash8>'`).
  3. Type-checks the aggregate package (`tsc --noEmit`) to catch and quarantine any
     contract whose generated code fails to compile, so one broken contract doesn't
     block every other contract in the same package.

One npm package is produced per GitHub repository (owner/repo), matching the .NET
pipeline's one-NuGet-package-per-repo convention. A repo's package version is only
bumped when at least one of its contracts actually changed content, the generator's
npm package version changed (forces every package to regenerate), or the
package.json/tsconfig.json/README templates under clients/_template_npm/ changed.
Version format: `1.<increment>.<yyyyMMddHH>` - a valid semver expression of the same
scheme the .NET pipeline uses (see docs/typescript-client-pipeline.md for why it can't
reuse the exact same 4-part string). Building (`npm run build`) and publishing to
npm are handled entirely by scripts/publish_npm_packages.py, run as its own separate
pipeline stage.

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

REPO_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
CSV_PATH = os.path.join(REPO_ROOT, "arc56.links.csv")
CLIENTS_DIR = os.path.join(REPO_ROOT, "clients")
TEMPLATE_DIR = os.path.join(CLIENTS_DIR, "_template_npm")
INCIDENTS_DIR = os.path.join(CLIENTS_DIR, "_incidents")

REGISTRY_REPO_URL = "https://github.com/scholtz/Arc56Registry"
GENERATOR_PACKAGE = "@algorandfoundation/algokit-client-generator"
PUSH_INTERVAL_SECONDS = 60

RAW_URL_RE = re.compile(
    r"^https://raw\.githubusercontent\.com/(?P<owner>[^/]+)/(?P<repo>[^/]+)/[^/]+/(?P<path>.+)$"
)
FILENAME_SUFFIX = ".arc56.json"
# Matches the file name (our contract_id) out of a `tsc` error line like:
# src/HelloWorld_1234abcd.ts(12,5): error TS2339: ...
COMPILE_ERROR_FILE_RE = re.compile(r"[\\/](?P<contract_id>[A-Za-z0-9_]+)\.ts\(\d+,\d+\):\s*error")
MAX_BUILD_QUARANTINE_ATTEMPTS = 10
# subprocess.run(["npm", ...]) fails with WinError 2 on Windows because npm/npx are
# .cmd shims there, not directly-executable binaries, and CreateProcess (unlike a
# shell) won't resolve PATHEXT on its own - shutil.which() does that resolution once
# up front, cross-platform, so we never need shell=True (which would also change how
# the argument list gets quoted/parsed).
NPM_EXE = shutil.which("npm") or "npm"
NPX_EXE = shutil.which("npx") or "npx"
# Prefers the "...Client" class (over the "...Factory" class the generator also emits
# in "full" mode) as the one worth naming in READMEs/state - falls back to the first
# exported class found if no "...Client"-suffixed one matches.
CLIENT_CLASS_RE = re.compile(r"export class (\w*Client)\b")
ANY_CLASS_RE = re.compile(r"export class (\w+)\b")


def sanitize_path_segment(name: str) -> str:
    return re.sub(r"[^A-Za-z0-9_.-]", "-", name)


def sanitize_identifier(name: str) -> str:
    slug = re.sub(r"[^A-Za-z0-9_]", "_", name)
    if not slug or slug[0].isdigit():
        slug = f"_{slug}"
    return slug


def sanitize_npm_segment(name: str) -> str:
    """npm package names must be lowercase and may only contain URL-safe characters -
    unlike sanitize_path_segment (used for the on-disk clients/<owner>/<repo>/ path,
    which stays case-preserving), this lowercases and collapses runs of invalid
    characters (rather than replacing each one with its own '-') so e.g. "MyOrg" and
    "myorg" don't produce visually noisy names, and strips leading/trailing '-'."""
    slug = re.sub(r"[^a-z0-9-]+", "-", name.lower()).strip("-")
    return slug or "x"


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
    """Always contacts the npm registry for GENERATOR_PACKAGE's current "latest" dist-tag
    version, so a fresh publish of the generator is picked up on the very next run -
    mirrors get_generator_image_digest() in scripts/generate_dotnet_clients.py."""
    result = subprocess.run(
        [NPM_EXE, "view", GENERATOR_PACKAGE, "version"],
        capture_output=True, text=True, check=True,
    )
    version = result.stdout.strip()
    if not version:
        raise RuntimeError(f"Could not resolve a version for {GENERATOR_PACKAGE} from 'npm view'")
    return version


def get_template_hash() -> str:
    """Hashes the templates that write_project_files() renders into each project's
    package.json/tsconfig.json/README.md (but NOT the generated .ts code)."""
    parts = []
    for name in ("package.json.template", "tsconfig.json.template", "README.md.template"):
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


def run_generator(arc56_path: str, ts_path: str, mode: str = "minimal") -> None:
    """mode="minimal" (rather than the generator's own "full" default) deliberately
    drops the Factory/deployment class and keeps only the typed Client - "full" mode's
    Factory code type-checks against internal, non-exported shapes of
    @algorandfoundation/algokit-utils's AlgorandClient (e.g. AlgorandClientInterface
    missing private fields the concrete class has) that have been observed to break
    across algokit-utils versions the generator itself doesn't pin against. "minimal"
    avoids that whole class of breakage, at the cost of no generated deploy/create
    helpers - acceptable for a registry whose job is decoding/calling existing deployed
    contracts, not deploying new ones. See docs/typescript-client-pipeline.md."""
    cmd = [
        NPX_EXE, "--yes", GENERATOR_PACKAGE,
        "generate", "-a", arc56_path, "-o", ts_path, "-m", mode,
    ]
    result = subprocess.run(cmd, capture_output=True, text=True)
    if result.returncode != 0:
        raise RuntimeError(
            f"algokit-client-generator exited with code {result.returncode}\n"
            f"--- stdout ---\n{result.stdout}\n--- stderr ---\n{result.stderr}"
        )
    if not os.path.isfile(ts_path):
        raise RuntimeError(f"algokit-client-generator did not produce {ts_path}")


FAILURE_LABELS = {
    "generator_error": "Generator crash",
    "ts_compile_error": "Generated code fails to compile",
}


def repro_command(arc56_url: str) -> str:
    return (
        f'npx --yes {GENERATOR_PACKAGE} generate \\\n'
        f'  -a <(curl -sL {arc56_url}) -o client.generated.ts'
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
    report_path = os.path.join(incident_dir, f"{contract_id}.ts.md")

    kind_label = FAILURE_LABELS.get(failure_type, failure_type)
    detected_at = datetime.datetime.now(datetime.timezone.utc).isoformat()
    repro_cmd = repro_command(url)

    report = f"""# {kind_label}: {contract_id} (TypeScript)

- **Repo**: [{owner}/{repo}](https://github.com/{owner}/{repo})
- **Source ARC-56 spec**: [{url}]({url})
- **Detected**: {detected_at}
- **Generator package**: `{GENERATOR_PACKAGE}@{generator_version}`

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


def extract_client_class_name(ts_path: str) -> str:
    with open(ts_path, encoding="utf-8") as f:
        text = f.read()
    m = CLIENT_CLASS_RE.search(text)
    if m:
        return m.group(1)
    m = ANY_CLASS_RE.search(text)
    return m.group(1) if m else "(unknown)"


def run_tsc_typecheck(project_dir: str) -> subprocess.CompletedProcess:
    return subprocess.run(
        [NPX_EXE, "--yes", "tsc", "--noEmit", "-p", "tsconfig.json"],
        cwd=project_dir, capture_output=True, text=True,
    )


def find_broken_contract_ids(build_output: str) -> set[str]:
    return {m.group("contract_id") for m in COMPILE_ERROR_FILE_RE.finditer(build_output)}


def extract_error_lines_for(contract_id: str, combined_output: str) -> str:
    marker = f"{contract_id}.ts("
    lines = [
        line for line in combined_output.splitlines()
        if marker in line and re.search(r"\):\s*error\b", line)
    ]
    if lines:
        return "\n".join(lines)
    lines = [line for line in combined_output.splitlines() if marker in line]
    return "\n".join(lines) if lines else combined_output[-2000:]


def npm_install(project_dir: str) -> None:
    result = subprocess.run(
        [NPM_EXE, "install", "--no-audit", "--no-fund"],
        cwd=project_dir, capture_output=True, text=True,
    )
    if result.returncode != 0:
        raise RuntimeError(
            f"npm install failed in {project_dir}\n--- stdout ---\n{result.stdout}\n--- stderr ---\n{result.stderr}"
        )


def typecheck_and_quarantine(
    project_dir: str,
    owner: str,
    repo: str,
    contracts_state: dict,
    excluded_contract_ids: set[str],
    generator_version: str,
    version: str,
) -> set[str]:
    """Mirrors build_and_quarantine() in scripts/generate_dotnet_clients.py: type-checks
    the aggregate package and, on failure, attributes the failure to specific generated
    files, excludes them (from tsconfig.json's "exclude" and src/index.ts's exports),
    and retries until it type-checks clean or no further broken file can be attributed."""
    contract_id_to_url = {contract_id_for(c): url for url, c in contracts_state.items() if "file_slug" in c}

    for _ in range(MAX_BUILD_QUARANTINE_ATTEMPTS):
        result = run_tsc_typecheck(project_dir)
        if result.returncode == 0:
            return excluded_contract_ids

        combined_output = result.stdout + result.stderr
        broken = find_broken_contract_ids(combined_output) - excluded_contract_ids
        if not broken:
            raise RuntimeError(
                f"tsc --noEmit failed for {project_dir} and no (new) broken contract file "
                f"could be attributed from the output:\n{result.stdout[-4000:]}\n{result.stderr[-2000:]}"
            )
        for contract_id in broken:
            url = contract_id_to_url.get(contract_id)
            error_text = extract_error_lines_for(contract_id, combined_output)
            if url is not None:
                contracts_state[url]["ts_compile_error"] = (
                    "generated code fails to type-check in the aggregate package"
                )
                write_incident_report(
                    owner, repo, url, contract_id, "ts_compile_error", error_text, generator_version,
                )
            print(f"WARNING: quarantining {contract_id} - fails to type-check", file=sys.stderr)
        excluded_contract_ids |= broken
        write_project_files(project_dir, owner, repo, contracts_state, excluded_contract_ids, version=version)

    raise RuntimeError(f"tsc --noEmit for {project_dir} still failing after "
                        f"{MAX_BUILD_QUARANTINE_ATTEMPTS} quarantine attempts")


def process_project(
    owner: str,
    repo: str,
    rows: list[dict[str, str]],
    generator_version: str,
    template_hash: str,
) -> bool:
    owner_slug = sanitize_path_segment(owner)
    repo_slug = sanitize_path_segment(repo)
    repo_dir = os.path.join(CLIENTS_DIR, owner_slug, repo_slug)
    project_dir = os.path.join(repo_dir, "npm")
    arc56_dir = os.path.join(repo_dir, "arc56")
    src_dir = os.path.join(project_dir, "src")
    state_path = os.path.join(project_dir, "state.json")
    os.makedirs(src_dir, exist_ok=True)

    state = load_project_state(state_path)
    contracts_state: dict = state.setdefault("contracts", {})
    force_regen = state.get("generator_version") != generator_version
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

        ts_path = os.path.join(src_dir, f"{contract_id}.ts")
        print(f"Generating TS client for {url} -> {ts_path}", file=sys.stderr)
        try:
            run_generator(arc56_path, ts_path)
            class_name = extract_client_class_name(ts_path)
            with open(ts_path, "rb") as f:
                ts_hash = sha256_hex(f.read())
        except Exception as exc:  # noqa: BLE001 - a single bad contract must never abort the whole run
            print(f"WARNING: generator failed for {url}: {exc}", file=sys.stderr)
            contracts_state[url] = {
                **{k: v for k, v in (existing or {}).items() if k != "content_sha256"},
                "content_sha256": content_hash,
                "file_slug": file_slug,
                "hash8": hash8,
                "generator_error": str(exc),
            }
            write_incident_report(owner, repo, url, contract_id, "generator_error", str(exc), generator_version)
            state_dirty = True
            continue

        previous_ts_hash = (existing or {}).get("ts_sha256")
        if previous_ts_hash is not None and previous_ts_hash == ts_hash:
            contracts_state[url] = {
                **{k: v for k, v in (existing or {}).items()
                   if k not in ("generator_error", "content_sha256", "ts_sha256", "class_name")},
                "content_sha256": content_hash,
                "ts_sha256": ts_hash,
                "file_slug": file_slug,
                "hash8": hash8,
                "class_name": class_name,
            }
            state_dirty = True
            print(f"Regenerated {url} - identical code, not counted as a change", file=sys.stderr)
        else:
            contracts_state[url] = {
                "content_sha256": content_hash,
                "ts_sha256": ts_hash,
                "file_slug": file_slug,
                "hash8": hash8,
                "class_name": class_name,
                "generated_at": datetime.datetime.now(datetime.timezone.utc).isoformat(),
            }
            code_changed = True

    template_changed = state.get("template_hash") != template_hash
    needs_version_bump = code_changed or template_changed

    if not (state_dirty or needs_version_bump):
        return False

    if not needs_version_bump:
        state["generator_version"] = generator_version
        state["template_hash"] = template_hash
        save_project_state(state_path, state)
        print(f"Project clients/{owner}/{repo}/npm: recorded failure state only, no generated-code "
              f"changes - version not bumped", file=sys.stderr)
        return False

    increment = state.get("increment", 0) + 1
    version = f"1.{increment}.{datetime.datetime.now(datetime.timezone.utc):%Y%m%d%H}"
    state["increment"] = increment
    state["version"] = version
    state["generator_version"] = generator_version
    state["template_hash"] = template_hash

    excluded_contract_ids = {
        contract_id_for(c) for c in contracts_state.values()
        if "file_slug" in c and "ts_compile_error" in c
    }
    write_project_files(project_dir, owner, repo, contracts_state, excluded_contract_ids, version=version)
    try:
        npm_install(project_dir)
        excluded_contract_ids = typecheck_and_quarantine(
            project_dir, owner, repo, contracts_state, excluded_contract_ids, generator_version, version
        )
    except Exception as exc:  # noqa: BLE001 - an npm/tsc infra failure must not abort the whole run
        print(f"ERROR: npm install/typecheck failed for clients/{owner}/{repo}/npm: {exc}", file=sys.stderr)
        raise
    save_project_state(state_path, state)

    print(f"Project clients/{owner}/{repo}/npm -> version {version} ({len(contracts_state)} contract(s), "
          f"{len(excluded_contract_ids)} quarantined)", file=sys.stderr)
    return True


def write_project_files(
    project_dir: str,
    owner: str,
    repo: str,
    contracts_state: dict,
    excluded_contract_ids: set[str] = frozenset(),
    version: str | None = None,
) -> None:
    owner_slug = sanitize_path_segment(owner)
    repo_slug = sanitize_path_segment(repo)
    package_name = f"arc56-generated-{sanitize_npm_segment(owner_slug)}-{sanitize_npm_segment(repo_slug)}"

    with open(os.path.join(TEMPLATE_DIR, "package.json.template"), encoding="utf-8") as f:
        package_json_template = f.read()
    with open(os.path.join(TEMPLATE_DIR, "tsconfig.json.template"), encoding="utf-8") as f:
        tsconfig_template = f.read()
    with open(os.path.join(TEMPLATE_DIR, "README.md.template"), encoding="utf-8") as f:
        readme_template = f.read()

    description = f"Generated ARC-56 Algorand smart-contract clients for {owner}/{repo}."
    package_json = render_template(package_json_template, {
        "PACKAGE_NAME": package_name,
        "VERSION": version or "0.0.0",
        "OWNER": owner,
        "REPO": repo,
        "DESCRIPTION": description,
        "REGISTRY_REPO_URL": REGISTRY_REPO_URL,
    })
    with open(os.path.join(project_dir, "package.json"), "w", encoding="utf-8", newline="\n") as f:
        f.write(package_json)

    excluded_ts_files = "\n".join(
        f'    "src/{cid}.ts",' for cid in sorted(excluded_contract_ids)
    )
    tsconfig = render_template(tsconfig_template, {"EXCLUDED_TS_FILES": excluded_ts_files})
    with open(os.path.join(project_dir, "tsconfig.json"), "w", encoding="utf-8", newline="\n") as f:
        f.write(tsconfig)

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
        elif "ts_compile_error" in c:
            table_rows.append(f"| `{contract_id}` | _(fails to type-check - excluded, see state.json)_ | [{url}]({url}) |")
        else:
            table_rows.append(f"| `{contract_id}` | `{c.get('class_name', '(unknown)')}` | [{url}]({url}) |")
            index_lines.append(f"export * as {contract_id} from './{contract_id}';")
    contracts_table = "\n".join(table_rows) if table_rows else "| _(none yet)_ | | |"

    src_dir = os.path.join(project_dir, "src")
    os.makedirs(src_dir, exist_ok=True)
    index_content = "\n".join(index_lines) + "\n" if index_lines else "export {};\n"
    with open(os.path.join(src_dir, "index.ts"), "w", encoding="utf-8", newline="\n") as f:
        f.write(index_content)

    first_contract_id = None
    first_class_name = None
    for url in sorted_urls:
        c = contracts_state[url]
        if "file_slug" in c and "generator_error" not in c and "ts_compile_error" not in c:
            first_contract_id = contract_id_for(c)
            first_class_name = c.get("class_name")
            break
    readme = render_template(readme_template, {
        "PACKAGE_NAME": package_name,
        "OWNER": owner,
        "REPO": repo,
        "CONTRACTS_TABLE": contracts_table,
        "FIRST_CONTRACT_NAMESPACE": first_contract_id or "ContractName_hash",
        "FIRST_CONTRACT_CLASS": first_class_name or "ContractClient",
    })
    with open(os.path.join(project_dir, "README.md"), "w", encoding="utf-8", newline="\n") as f:
        f.write(readme)


_last_push_at: float | None = None


def push_commits(force: bool = False) -> None:
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
    subprocess.run(["git", "config", "user.name", "github-actions[bot]"], cwd=REPO_ROOT, check=True)
    subprocess.run(
        ["git", "config", "user.email", "github-actions[bot]@users.noreply.github.com"],
        cwd=REPO_ROOT, check=True,
    )


def commit_project_changes(owner: str, repo: str) -> None:
    paths = [
        os.path.join("clients", sanitize_path_segment(owner), sanitize_path_segment(repo), "npm"),
        os.path.join("clients", "_incidents"),
    ]
    subprocess.run(["git", "add", "--", *paths], cwd=REPO_ROOT, check=True)
    diff = subprocess.run(["git", "diff", "--cached", "--quiet", "--", *paths], cwd=REPO_ROOT)
    if diff.returncode == 0:
        return
    subprocess.run(
        ["git", "commit", "-m", f"chore: regenerate TypeScript ARC-56 client for {owner}/{repo}"],
        cwd=REPO_ROOT, check=True,
    )
    print(f"Committed changes for {owner}/{repo}", file=sys.stderr)


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
        print(f"ERROR: {CLIENTS_DIR} does not exist", file=sys.stderr)
        return 1

    try:
        generator_version = get_generator_version()
    except subprocess.CalledProcessError as exc:
        print(f"ERROR: could not resolve {GENERATOR_PACKAGE} version: {exc}", file=sys.stderr)
        return 1
    print(f"Generator package version: {GENERATOR_PACKAGE}@{generator_version}", file=sys.stderr)
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
        try:
            if process_project(owner, repo, project_rows, generator_version, template_hash):
                changed_projects += 1
            if args.commit:
                commit_project_changes(owner, repo)
                push_commits()
        except Exception as exc:  # noqa: BLE001 - one project must never take down the whole run
            failed_projects += 1
            print(f"ERROR: unexpected failure processing {owner}/{repo}, skipping and "
                  f"continuing with the next project: {exc}", file=sys.stderr)
            continue

    if args.commit:
        push_commits(force=True)

    print(f"Done: {len(selected)}/{len(grouped)} project(s) scanned, "
          f"{changed_projects} regenerated/bumped, {failed_projects} failed unexpectedly", file=sys.stderr)
    return 1 if failed_projects else 0


if __name__ == "__main__":
    sys.exit(main())
