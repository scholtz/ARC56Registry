#!/usr/bin/env python3
"""One-off migration: move clients/<owner>/<repo>/dotnet/arc56/ up to
clients/<owner>/<repo>/arc56/, and patch every existing .csproj's `None Include`
path for the ARC-56 specs from "arc56/**/*.json" to "../arc56/**/*.json" to match.

Rationale: the downloaded ARC-56 spec copies are the same source files regardless of
which ecosystem's client is generated from them (.NET today, npm/Python planned - see
README.md), so they belong at the repo level (clients/<owner>/<repo>/arc56/), not
nested inside the dotnet/ subfolder. See docs/dotnet-client-pipeline.md.

Uses `git mv` so history is preserved. Safe to re-run: skips anything already
migrated. Never deletes anything - this is a pure move + in-place text patch,
consistent with this repo's "never remove, only relocate/update" convention.
"""
from __future__ import annotations

import os
import subprocess
import sys

REPO_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
CLIENTS_DIR = os.path.join(REPO_ROOT, "clients")

OLD_INCLUDE = '<None Include="arc56/**/*.json" Pack="true" PackagePath="contentFiles/any/any/arc56/" />'
NEW_INCLUDE = '<None Include="../arc56/**/*.json" Pack="true" PackagePath="contentFiles/any/any/arc56/" />'


def git_mv(src: str, dst: str) -> None:
    os.makedirs(os.path.dirname(dst), exist_ok=True)
    print(f"git mv {os.path.relpath(src, REPO_ROOT)} -> {os.path.relpath(dst, REPO_ROOT)}", file=sys.stderr)
    subprocess.run(["git", "mv", src, dst], check=True, cwd=REPO_ROOT)


def patch_csproj(project_dir: str) -> bool:
    """Rewrites the ARC-56 `None Include` path in the project's .csproj, if present
    and still pointing at the old (pre-migration) location. Returns True if patched."""
    csproj_files = [f for f in os.listdir(project_dir) if f.endswith(".csproj")]
    patched = False
    for name in csproj_files:
        path = os.path.join(project_dir, name)
        with open(path, encoding="utf-8") as f:
            text = f.read()
        if OLD_INCLUDE not in text:
            continue
        text = text.replace(OLD_INCLUDE, NEW_INCLUDE)
        with open(path, "w", encoding="utf-8", newline="\n") as f:
            f.write(text)
        print(f"Patched {os.path.relpath(path, REPO_ROOT)}", file=sys.stderr)
        patched = True
    return patched


def main() -> int:
    if not os.path.isdir(CLIENTS_DIR):
        print(f"ERROR: {CLIENTS_DIR} does not exist", file=sys.stderr)
        return 1

    moved = 0
    patched = 0
    for owner in sorted(os.listdir(CLIENTS_DIR)):
        owner_dir = os.path.join(CLIENTS_DIR, owner)
        if owner.startswith("_") or not os.path.isdir(owner_dir):
            continue
        for repo in sorted(os.listdir(owner_dir)):
            repo_dir = os.path.join(owner_dir, repo)
            dotnet_dir = os.path.join(repo_dir, "dotnet")
            old_arc56_dir = os.path.join(dotnet_dir, "arc56")
            new_arc56_dir = os.path.join(repo_dir, "arc56")

            if os.path.isdir(old_arc56_dir):
                if os.path.exists(new_arc56_dir):
                    print(f"SKIP move (destination already exists): "
                          f"{os.path.relpath(new_arc56_dir, REPO_ROOT)}", file=sys.stderr)
                else:
                    git_mv(old_arc56_dir, new_arc56_dir)
                    moved += 1

            if os.path.isdir(dotnet_dir) and patch_csproj(dotnet_dir):
                patched += 1

    print(f"Done: {moved} arc56 dir(s) moved, {patched} .csproj file(s) patched.", file=sys.stderr)
    return 0


if __name__ == "__main__":
    sys.exit(main())
