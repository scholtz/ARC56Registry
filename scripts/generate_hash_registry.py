#!/usr/bin/env python3
"""Build lookup registries from compiled-program SHA-256 hash -> ARC-56 spec URL.

Walks every `*.arc56.json` file under `clients/<owner>/<repo>/arc56/` (the downloaded,
attributable source specs - see `find_arc56_files()`), decodes its `byteCode.approval`
and `byteCode.clear` (base64-encoded compiled TEAL bytecode), and hashes each with
SHA-256. For every hash it writes:

    approval-programs/<hash[:3]>/<hash>.txt         (from byteCode.approval)
    approval-programs/<hash[:3]>/<hash>.arc56.json  (from byteCode.approval)
    clear-programs/<hash[:3]>/<hash>.txt            (from byteCode.clear)
    clear-programs/<hash[:3]>/<hash>.arc56.json     (from byteCode.clear)

The `.txt` file contains a single line: the `raw.githubusercontent.com` URL of the
winning ARC-56 spec file, pinned to the commit that last touched that file (so the
link keeps pointing at the exact spec whose program produced this hash, even if the
source file is edited or replaced later - see docs/hash-registry.md). The
`.arc56.json` file sitting right next to it is an exact byte-for-byte copy of that
same winning spec file, so a consumer that already has the hash can read the full
ARC-56 spec straight out of this repo (or its GitHub Pages mirror) without a second
fetch to resolve the `.txt` file's URL first.

This lets a wallet or indexer that only has a deployed app's compiled approval/clear
program compute its SHA-256, look up the matching `<hash>.arc56.json` in this repo (or
via its GitHub Pages mirror - see `pages/index.html`), and decode method calls
directly - the `<hash>.txt` URL remains available for consumers that want the
durable, commit-pinned source location instead.

## GitHub owner/repo attribution

Alongside the winning `.txt`/`.arc56.json` pair, this script also writes:

    approval-programs/<hash[:3]>/<hash>.owners.json  (from byteCode.approval)
    clear-programs/<hash[:3]>/<hash>.owners.json     (from byteCode.clear)

a JSON object `{"owners": [{"owner": "<github-owner>", "repo": "<github-repo>", "url":
"https://github.com/<owner>/<repo>"}, ...]}` listing every distinct GitHub owner/repo
whose indexed ARC-56 spec produced this program hash, sorted by (owner, repo). Unlike
the winner-takes-one `.txt`/`.arc56.json` pair, this is a **union across every indexed
spec sharing the hash** (same shape as `abi-signatures/<selector>.json`'s `apps` list
below) - identical program bytes can legitimately come from more than one repo (a
shared library, a fork, a vendored copy), and a consumer trying to judge whether a
deployed app's code looks trustworthy wants to see every GitHub account that has
published matching source, not just whichever spec happened to win the size tie-break
for the bundled copy. Entries are only ever added, never removed, even if a
contributing repo is later blacklisted or deletes its spec - the attribution was true
at the time it was observed.

Owner/repo are read directly from each spec's own `clients/<owner>/<repo>/arc56/`
location (see `find_arc56_files()`), which is why that glob is restricted to `clients/`
rather than the whole repo: this script's own `approval-programs/`/`clear-programs/`
output would otherwise "attribute" hashes to itself once a byte-for-byte copy exists
there from a previous run, and (worse) could permanently point the winning `.txt` URL
at its own mirror commit instead of the real source repo, since that self-copy sorts
before `clients/...` alphabetically and ties keep the earlier winner (see "Picking a
winner" below).

## ABI method-signature registry

Separately (and independently of the program-hash registries above), this script also
walks every method of every ARC-56 file and builds:

    abi-signatures/<hash[:2]>/<hash>.txt
    abi-signatures/<hash[:2]>/<hash>.json

where `<hash>` is the lowercase 8-hex-char ARC-4 method selector - the first 4 bytes of
SHA-512/256 over the ABI method signature string `name(argtype,argtype,...)returntype`
(the same selector Algorand uses on-chain to dispatch method calls). The `.txt` file's
content is that exact signature string, e.g. `abi-signatures/8a/8aa3b61f.txt` containing
`add(uint64,uint64)uint128`. Struct-typed args/returns use the ABI tuple type already
present in each arg/return's `type` field (ARC-56 specs carry both, e.g.
`{"type": "(string,uint64)", "struct": "EscrowConfig"}`), never the human-readable
struct name, since the selector is computed over the ABI type. Unlike the program-hash
registries, there is no "winner" to pick: the signature string is fully determined by
the hash (barring an astronomically unlikely SHA-512/256 collision), so the first
signature seen for a hash is written and later duplicates are just skipped.

The `.json` file next to it is a pretty-printed JSON object
`{"abi": "<signature>", "apps": ["<approval-program-hash>", ...]}` - `apps` is the
sorted list of SHA-256 approval-program hashes (i.e. `approval-programs/` hash
directory names) of every indexed app whose ARC-56 spec declares a method with this
selector, letting a consumer go straight from a method selector to the set of known
apps that expose it. Unlike the program-hash winner rule, this list is a union across
every indexed spec (not just the largest one per hash), since the point is to name all
apps using the method, not to pick a single "best" spec.

## Picking a winner when multiple specs share a hash

Identical program bytes always hash identically, so a collision here means two (or
more) ARC-56 spec files describe the very same on-chain program (e.g. the same
contract copy-pasted into different repos, or vendored) - this is especially common
for clear-state programs, since many contracts share a trivial `return 1`-style clear
program. Among files sharing a hash, we prefer the *larger* ARC-56 JSON file (more
complete spec: more of `structs`, `sourceInfo`, docs, etc.). Candidates are visited in
a fixed, deterministic order (sorted by repo-relative path); the first one seen for a
hash becomes the current winner, and only a strictly larger later candidate replaces
it. Ties, and later candidates that are the same size or smaller, keep the earlier
winner - matching the repo-wide "never silently move a pointer without a good reason"
convention.

Re-running this script recomputes every hash from scratch (it never deletes files
under `approval-programs/` or `clear-programs/`, but happily overwrites one if the
deterministic winner for its hash changed since last run - e.g. a newly indexed repo
turns out to hold a larger copy of the same spec).
"""
from __future__ import annotations

import argparse
import base64
import glob
import hashlib
import json
import os
import subprocess
import sys

REPO_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
REGISTRY_RAW_BASE = "https://raw.githubusercontent.com/scholtz/ARC56Registry"

PROGRAMS = {
    "approval": os.path.join(REPO_ROOT, "approval-programs"),
    "clear": os.path.join(REPO_ROOT, "clear-programs"),
}

ABI_SIGNATURES_DIR = os.path.join(REPO_ROOT, "abi-signatures")


def find_arc56_files() -> list[str]:
    # Restricted to clients/<owner>/<repo>/arc56/*.arc56.json - the downloaded, truly
    # attributable source specs - rather than a repo-wide glob. approval-programs/ and
    # clear-programs/ contain this same script's own byte-for-byte winner copies from
    # previous runs; including those as candidates here would let a copy out-rank (and
    # then permanently self-reference against) its own true source once created, since
    # a same-size later candidate never displaces the earlier winner (see "Picking a
    # winner" above) and both owner attribution and the .txt source URL are derived
    # from whichever rel_path wins.
    pattern = os.path.join(REPO_ROOT, "clients", "**", "*.arc56.json")
    paths = glob.glob(pattern, recursive=True)
    rel_paths = [os.path.relpath(p, REPO_ROOT).replace(os.sep, "/") for p in paths]
    return sorted(rel_paths)


def owner_repo_from_rel_path(rel_path: str) -> tuple[str, str] | None:
    """clients/<owner>/<repo>/arc56/<file>.arc56.json -> (owner, repo), or None if the
    path isn't under clients/ - defensive only, since find_arc56_files() already
    restricts candidates to that layout."""
    parts = rel_path.split("/")
    if len(parts) < 3 or parts[0] != "clients":
        return None
    return parts[1], parts[2]


def load_spec(rel_path: str) -> dict | None:
    abs_path = os.path.join(REPO_ROOT, rel_path)
    try:
        with open(abs_path, encoding="utf-8") as f:
            return json.load(f)
    except (OSError, ValueError) as exc:
        print(f"WARNING: could not parse {rel_path}: {exc}", file=sys.stderr)
        return None


def program_sha256(spec: dict, field: str, rel_path: str) -> str | None:
    program_b64 = (spec.get("byteCode") or {}).get(field)
    if not program_b64:
        print(f"WARNING: {rel_path} has no byteCode.{field}, skipping", file=sys.stderr)
        return None

    try:
        program_bytes = base64.b64decode(program_b64, validate=True)
    except (ValueError, TypeError) as exc:
        print(f"WARNING: {rel_path} has invalid byteCode.{field} base64: {exc}", file=sys.stderr)
        return None

    return hashlib.sha256(program_bytes).hexdigest()


def last_commit_for_path(rel_path: str) -> str | None:
    result = subprocess.run(
        ["git", "log", "-1", "--format=%H", "--", rel_path],
        cwd=REPO_ROOT,
        capture_output=True,
        text=True,
        check=True,
    )
    commit = result.stdout.strip()
    return commit or None


def build_url(commit: str, rel_path: str) -> str:
    return f"{REGISTRY_RAW_BASE}/{commit}/{rel_path}"


def method_signature(method: dict) -> str:
    arg_types = ",".join(arg["type"] for arg in method.get("args", []))
    return_type = (method.get("returns") or {}).get("type", "void")
    return f"{method['name']}({arg_types}){return_type}"


def abi_selector(signature: str) -> str:
    return hashlib.new("sha512_256", signature.encode("utf-8")).hexdigest()[:8]


def compute_field_digests(field: str, specs: dict[str, dict]) -> dict[str, str]:
    """rel_path -> SHA-256 hex digest of spec's byteCode.<field>, skipping specs without one."""
    digests: dict[str, str] = {}
    for rel_path, spec in specs.items():
        digest = program_sha256(spec, field, rel_path)
        if digest is not None:
            digests[rel_path] = digest
    return digests


def build_abi_signature_registry(
    out_dir: str, specs: dict[str, dict], approval_digests: dict[str, str], dry_run: bool
) -> None:
    winners: dict[str, str] = {}  # selector -> signature
    apps: dict[str, set[str]] = {}  # selector -> set of approval-program hashes
    conflicts = 0
    for rel_path, spec in specs.items():
        approval_hash = approval_digests.get(rel_path)
        for method in spec.get("methods", []):
            try:
                signature = method_signature(method)
            except KeyError:
                print(f"WARNING: {rel_path} has a method missing a name/type, skipping", file=sys.stderr)
                continue
            selector = abi_selector(signature)
            existing = winners.get(selector)
            if existing is None:
                winners[selector] = signature
            elif existing != signature:
                conflicts += 1
                print(
                    f"WARNING: selector {selector} maps to both {existing!r} and {signature!r} "
                    f"(from {rel_path}) - keeping the first one seen",
                    file=sys.stderr,
                )
            if approval_hash is not None:
                apps.setdefault(selector, set()).add(approval_hash)

    print(
        f"[abi-signatures] {len(winners)} distinct method selectors ({conflicts} colliding signatures skipped)",
        file=sys.stderr,
    )

    written = 0
    unchanged = 0
    for selector, signature in sorted(winners.items()):
        out_subdir = os.path.join(out_dir, selector[:2])
        txt_path = os.path.join(out_subdir, f"{selector}.txt")
        json_path = os.path.join(out_subdir, f"{selector}.json")

        existing_content = None
        if os.path.exists(txt_path):
            with open(txt_path, encoding="utf-8") as f:
                existing_content = f.read().strip()

        app_list = sorted(apps.get(selector, ()))
        json_content = json.dumps({"abi": signature, "apps": app_list}, indent=2, ensure_ascii=False) + "\n"
        existing_json = None
        if os.path.exists(json_path):
            with open(json_path, encoding="utf-8") as f:
                existing_json = f.read()

        if existing_content == signature and existing_json == json_content:
            unchanged += 1
            continue

        written += 1
        if dry_run:
            action = "would update" if existing_content else "would create"
            print(f"{action} {os.path.relpath(txt_path, REPO_ROOT)} -> {signature}")
            action = "would update" if existing_json else "would create"
            print(f"{action} {os.path.relpath(json_path, REPO_ROOT)} -> {len(app_list)} app(s)")
            continue

        os.makedirs(out_subdir, exist_ok=True)
        if existing_content != signature:
            with open(txt_path, "w", encoding="utf-8", newline="\n") as f:
                f.write(signature + "\n")
        if existing_json != json_content:
            with open(json_path, "w", encoding="utf-8", newline="\n") as f:
                f.write(json_content)

    verb = "Would write" if dry_run else "Wrote"
    print(f"[abi-signatures] {verb} {written} signature file(s), {unchanged} already up to date", file=sys.stderr)


def build_registry(field: str, out_dir: str, specs: dict[str, dict], digests: dict[str, str], dry_run: bool) -> None:
    winners: dict[str, tuple[str, int]] = {}  # hash -> (rel_path, size)
    skipped = len(specs) - len(digests)
    for rel_path, digest in digests.items():
        size = os.path.getsize(os.path.join(REPO_ROOT, rel_path))
        current = winners.get(digest)
        if current is None or size > current[1]:
            winners[digest] = (rel_path, size)

    print(
        f"[{field}] {len(winners)} distinct program hashes ({skipped} files skipped)",
        file=sys.stderr,
    )

    written = 0
    unchanged = 0
    for digest, (rel_path, _size) in sorted(winners.items()):
        commit = last_commit_for_path(rel_path)
        if commit is None:
            print(f"WARNING: {rel_path} is not committed yet, skipping hash {digest}", file=sys.stderr)
            continue
        url = build_url(commit, rel_path)

        out_subdir = os.path.join(out_dir, digest[:3])
        txt_path = os.path.join(out_subdir, f"{digest}.txt")
        json_path = os.path.join(out_subdir, f"{digest}.arc56.json")

        existing = None
        if os.path.exists(txt_path):
            with open(txt_path, encoding="utf-8") as f:
                existing = f.read().strip()

        abs_spec_path = os.path.join(REPO_ROOT, rel_path)
        with open(abs_spec_path, "rb") as f:
            spec_bytes = f.read()
        existing_spec_bytes = None
        if os.path.exists(json_path):
            with open(json_path, "rb") as f:
                existing_spec_bytes = f.read()

        if existing == url and existing_spec_bytes == spec_bytes:
            unchanged += 1
            continue

        written += 1
        if dry_run:
            action = "would update" if existing else "would create"
            print(f"{action} {os.path.relpath(txt_path, REPO_ROOT)} -> {url}")
            action = "would update" if existing_spec_bytes else "would create"
            print(f"{action} {os.path.relpath(json_path, REPO_ROOT)} <- {rel_path}")
            continue

        os.makedirs(out_subdir, exist_ok=True)
        if existing != url:
            with open(txt_path, "w", encoding="utf-8", newline="\n") as f:
                f.write(url + "\n")
        if existing_spec_bytes != spec_bytes:
            with open(json_path, "wb") as f:
                f.write(spec_bytes)

    verb = "Would write" if dry_run else "Wrote"
    print(f"[{field}] {verb} {written} hash file(s), {unchanged} already up to date", file=sys.stderr)


def build_owner_registry(field: str, out_dir: str, digests: dict[str, str], dry_run: bool) -> None:
    owners_by_hash: dict[str, set[tuple[str, str]]] = {}
    for rel_path, digest in digests.items():
        owner_repo = owner_repo_from_rel_path(rel_path)
        if owner_repo is None:
            continue
        owners_by_hash.setdefault(digest, set()).add(owner_repo)

    written = 0
    unchanged = 0
    for digest, owners in sorted(owners_by_hash.items()):
        out_subdir = os.path.join(out_dir, digest[:3])
        json_path = os.path.join(out_subdir, f"{digest}.owners.json")

        existing_owners: set[tuple[str, str]] = set()
        if os.path.exists(json_path):
            with open(json_path, encoding="utf-8") as f:
                existing_data = json.load(f)
            existing_owners = {(o["owner"], o["repo"]) for o in existing_data.get("owners", [])}

        # Union-grows only, per the repo-wide "never silently delete" convention -
        # a repo dropping out of this run's candidates (blacklisted, spec removed,
        # discovery lag, ...) never removes its past attribution.
        merged = existing_owners | owners
        if merged == existing_owners:
            unchanged += 1
            continue

        entries = [
            {"owner": owner, "repo": repo, "url": f"https://github.com/{owner}/{repo}"}
            for owner, repo in sorted(merged)
        ]
        json_content = json.dumps({"owners": entries}, indent=2, ensure_ascii=False) + "\n"

        written += 1
        if dry_run:
            action = "would update" if existing_owners else "would create"
            print(f"{action} {os.path.relpath(json_path, REPO_ROOT)} -> {len(entries)} owner(s)")
            continue

        os.makedirs(out_subdir, exist_ok=True)
        with open(json_path, "w", encoding="utf-8", newline="\n") as f:
            f.write(json_content)

    verb = "Would write" if dry_run else "Wrote"
    print(f"[{field}] {verb} {written} owners file(s), {unchanged} already up to date", file=sys.stderr)


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    parser.add_argument(
        "--dry-run",
        action="store_true",
        help="Compute winners and report what would change, without writing any files.",
    )
    args = parser.parse_args()

    arc56_files = find_arc56_files()
    print(f"Found {len(arc56_files)} *.arc56.json files", file=sys.stderr)

    specs: dict[str, dict] = {}
    for rel_path in arc56_files:
        spec = load_spec(rel_path)
        if spec is not None:
            specs[rel_path] = spec

    field_digests = {field: compute_field_digests(field, specs) for field in PROGRAMS}

    for field, out_dir in PROGRAMS.items():
        build_registry(field, out_dir, specs, field_digests[field], args.dry_run)
        build_owner_registry(field, out_dir, field_digests[field], args.dry_run)

    build_abi_signature_registry(ABI_SIGNATURES_DIR, specs, field_digests["approval"], args.dry_run)

    return 0


if __name__ == "__main__":
    raise SystemExit(main())
