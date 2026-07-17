#!/usr/bin/env python3
"""Build lookup registries from compiled-program SHA-256 hash -> ARC-56 spec URL.

Walks every `*.arc56.json` file in the repo (in practice, everything under `clients/`),
decodes its `byteCode.approval` and `byteCode.clear` (base64-encoded compiled TEAL
bytecode), and hashes each with SHA-256. For every hash it writes:

    approval-programs/<hash[:3]>/<hash>.txt   (from byteCode.approval)
    clear-programs/<hash[:3]>/<hash>.txt      (from byteCode.clear)

containing a single line: the `raw.githubusercontent.com` URL of the winning ARC-56
spec file, pinned to the commit that last touched that file (so the link keeps
pointing at the exact spec whose program produced this hash, even if the source file
is edited or replaced later - see docs/hash-registry.md).

This lets a wallet or indexer that only has a deployed app's compiled approval/clear
program compute its SHA-256, look up the matching `<hash>.txt` in this repo (or via
its GitHub Pages mirror - see `pages/index.html`), and resolve straight to an ARC-56
spec it can use to decode method calls.

## ABI method-signature registry

Separately (and independently of the program-hash registries above), this script also
walks every method of every ARC-56 file and builds:

    abi-signatures/<hash[:2]>/<hash>.txt

where `<hash>` is the lowercase 8-hex-char ARC-4 method selector - the first 4 bytes of
SHA-512/256 over the ABI method signature string `name(argtype,argtype,...)returntype`
(the same selector Algorand uses on-chain to dispatch method calls) - and the file's
content is that exact signature string, e.g. `abi-signatures/8a/8aa3b61f.txt` containing
`add(uint64,uint64)uint128`. Struct-typed args/returns use the ABI tuple type already
present in each arg/return's `type` field (ARC-56 specs carry both, e.g.
`{"type": "(string,uint64)", "struct": "EscrowConfig"}`), never the human-readable
struct name, since the selector is computed over the ABI type. Unlike the program-hash
registries, there is no "winner" to pick: the signature string is fully determined by
the hash (barring an astronomically unlikely SHA-512/256 collision), so the first
signature seen for a hash is written and later duplicates are just skipped.

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
    pattern = os.path.join(REPO_ROOT, "**", "*.arc56.json")
    paths = glob.glob(pattern, recursive=True)
    rel_paths = [os.path.relpath(p, REPO_ROOT).replace(os.sep, "/") for p in paths]
    return sorted(rel_paths)


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


def build_abi_signature_registry(out_dir: str, specs: dict[str, dict], dry_run: bool) -> None:
    winners: dict[str, str] = {}  # selector -> signature
    conflicts = 0
    for rel_path, spec in specs.items():
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

    print(
        f"[abi-signatures] {len(winners)} distinct method selectors ({conflicts} colliding signatures skipped)",
        file=sys.stderr,
    )

    written = 0
    unchanged = 0
    for selector, signature in sorted(winners.items()):
        out_subdir = os.path.join(out_dir, selector[:2])
        out_path = os.path.join(out_subdir, f"{selector}.txt")

        existing_content = None
        if os.path.exists(out_path):
            with open(out_path, encoding="utf-8") as f:
                existing_content = f.read().strip()

        if existing_content == signature:
            unchanged += 1
            continue

        written += 1
        if dry_run:
            action = "would update" if existing_content else "would create"
            print(f"{action} {os.path.relpath(out_path, REPO_ROOT)} -> {signature}")
            continue

        os.makedirs(out_subdir, exist_ok=True)
        with open(out_path, "w", encoding="utf-8", newline="\n") as f:
            f.write(signature + "\n")

    verb = "Would write" if dry_run else "Wrote"
    print(f"[abi-signatures] {verb} {written} signature file(s), {unchanged} already up to date", file=sys.stderr)


def build_registry(field: str, out_dir: str, specs: dict[str, dict], dry_run: bool) -> None:
    winners: dict[str, tuple[str, int]] = {}  # hash -> (rel_path, size)
    skipped = 0
    for rel_path, spec in specs.items():
        digest = program_sha256(spec, field, rel_path)
        if digest is None:
            skipped += 1
            continue
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
        out_path = os.path.join(out_subdir, f"{digest}.txt")

        existing = None
        if os.path.exists(out_path):
            with open(out_path, encoding="utf-8") as f:
                existing = f.read().strip()

        if existing == url:
            unchanged += 1
            continue

        written += 1
        if dry_run:
            action = "would update" if existing else "would create"
            print(f"{action} {os.path.relpath(out_path, REPO_ROOT)} -> {url}")
            continue

        os.makedirs(out_subdir, exist_ok=True)
        with open(out_path, "w", encoding="utf-8", newline="\n") as f:
            f.write(url + "\n")

    verb = "Would write" if dry_run else "Wrote"
    print(f"[{field}] {verb} {written} hash file(s), {unchanged} already up to date", file=sys.stderr)


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

    for field, out_dir in PROGRAMS.items():
        build_registry(field, out_dir, specs, args.dry_run)

    build_abi_signature_registry(ABI_SIGNATURES_DIR, specs, args.dry_run)

    return 0


if __name__ == "__main__":
    raise SystemExit(main())
