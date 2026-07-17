#!/usr/bin/env python3
"""One-off migration: reorganize clients/dotnet/<owner>/<repo>/* into
clients/<owner>/<repo>/dotnet/*, and clients/dotnet/_template,
clients/dotnet/_incidents into clients/_template, clients/_incidents.

Rationale: each source GitHub repo will eventually have multiple generated
client packages (.NET, npm, Python, ...) - grouping them under a shared
clients/<owner>/<repo>/ directory (with one subfolder per ecosystem) keeps all
of a repo's packages together, instead of splitting them across
clients/dotnet/, clients/typescript/, clients/python/.

Uses `git mv` so history is preserved. Safe to re-run: skips anything already
migrated. Never deletes anything - this is a pure move.
"""
from __future__ import annotations

import os
import subprocess
import sys

REPO_ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
CLIENTS_DIR = os.path.join(REPO_ROOT, "clients")
OLD_DOTNET_DIR = os.path.join(CLIENTS_DIR, "dotnet")


def git_mv(src: str, dst: str) -> None:
    os.makedirs(os.path.dirname(dst), exist_ok=True)
    print(f"git mv {os.path.relpath(src, REPO_ROOT)} -> {os.path.relpath(dst, REPO_ROOT)}", file=sys.stderr)
    subprocess.run(["git", "mv", src, dst], check=True, cwd=REPO_ROOT)


def main() -> int:
    if not os.path.isdir(OLD_DOTNET_DIR):
        print(f"ERROR: {OLD_DOTNET_DIR} does not exist - nothing to migrate", file=sys.stderr)
        return 1

    entries = sorted(os.listdir(OLD_DOTNET_DIR))
    owners = [e for e in entries if not e.startswith("_") and os.path.isdir(os.path.join(OLD_DOTNET_DIR, e))]

    moved = 0
    for owner in owners:
        owner_dir = os.path.join(OLD_DOTNET_DIR, owner)
        for repo in sorted(os.listdir(owner_dir)):
            repo_src = os.path.join(owner_dir, repo)
            if not os.path.isdir(repo_src):
                continue
            repo_dst = os.path.join(CLIENTS_DIR, owner, repo, "dotnet")
            if os.path.exists(repo_dst):
                print(f"SKIP (already migrated): {os.path.relpath(repo_dst, REPO_ROOT)}", file=sys.stderr)
                continue
            git_mv(repo_src, repo_dst)
            moved += 1
        # owner dir under clients/dotnet/ should now be empty of tracked files;
        # leftover untracked dirs (bin/obj) may remain - remove if empty.
        try:
            os.removedirs(owner_dir)
        except OSError:
            pass

    # Shared assets: _template and _incidents move up one level, out of dotnet/.
    for shared in ("_template", "_incidents"):
        src = os.path.join(OLD_DOTNET_DIR, shared)
        dst = os.path.join(CLIENTS_DIR, shared)
        if os.path.isdir(src) and not os.path.exists(dst):
            git_mv(src, dst)
            moved += 1

    # clients/dotnet/ itself should now be empty (or gone).
    if os.path.isdir(OLD_DOTNET_DIR) and not os.listdir(OLD_DOTNET_DIR):
        os.rmdir(OLD_DOTNET_DIR)
        print(f"Removed now-empty {os.path.relpath(OLD_DOTNET_DIR, REPO_ROOT)}", file=sys.stderr)

    print(f"Done: {moved} item(s) moved.", file=sys.stderr)
    return 0


if __name__ == "__main__":
    sys.exit(main())
