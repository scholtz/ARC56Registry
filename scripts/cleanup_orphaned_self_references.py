#!/usr/bin/env python3
"""One-time remediation for the self-referencing hash-winner bug fixed in
generate_hash_registry.py (see docs/hash-registry.md and that script's own
module docstring for the full explanation of the bug).

Before the fix, find_arc56_files() globbed the whole repo, so a byte-for-byte
approval-programs/clear-programs winner copy from a previous run could
out-rank its own true clients/<owner>/<repo>/arc56/ source and permanently
self-reference this registry's own mirror commit in <hash>.txt. The fix
(restricting that glob to clients/**) stops this from happening *going
forward* for any hash whose true source is still present in clients/ - but
it can only repoint hashes that are still candidates this run. Some hashes
got stuck self-referencing, and their original clients/ source has *since
disappeared entirely* (the source repo was deleted, renamed, or blacklisted
sometime between whenever the bug first mis-attributed that hash and now) -
there is no current candidate for these hashes at all, so the regular
pipeline can never re-resolve or even warn about them; they would otherwise
sit self-referencing forever.

This script finds exactly that narrow case - self-referencing AND currently
orphaned (no clients/** file produces that hash any more) - and deletes
those hash directories' files. This is a deliberate, one-time exception to
this repo's usual "never delete" convention, which exists to protect
*legitimate* historical records: these were never one. They only exist
because of a bug, and a wallet resolving one today would be silently
misdirected to this registry's own commit with no way to reach a real
source - worse than having no entry at all. A hash directory that
legitimately points at a real (possibly now-vanished) external repo is left
untouched forever, exactly as before; this script only ever touches a hash
whose .txt content matches the self-referencing URL pattern.

Not part of the scheduled pipeline (not wired into any GitHub Actions
workflow) - the bug it cleans up after can't recur post-fix, so this is
meant to be run once, by hand, to clear the backlog the bug already created.
"""
from __future__ import annotations

import argparse
import os
import re
import sys

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import generate_hash_registry as ghr  # noqa: E402

SELF_REF_RE = re.compile(
    r"^https://raw\.githubusercontent\.com/scholtz/ARC56Registry/[0-9a-f]+/"
    r"(approval|clear)-programs/"
)


def find_orphaned_self_references(out_dir: str, current_digests: set[str]) -> list[str]:
    orphans = []
    for root, _dirs, files in os.walk(out_dir):
        for filename in files:
            if not filename.endswith(".txt"):
                continue
            digest = filename[: -len(".txt")]
            if digest in current_digests:
                continue
            with open(os.path.join(root, filename), encoding="utf-8") as f:
                content = f.read().strip()
            if SELF_REF_RE.match(content):
                orphans.append(digest)
    return orphans


def remove_hash_files(out_dir: str, digest: str, dry_run: bool) -> None:
    out_subdir = os.path.join(out_dir, digest[:3])
    for suffix in (".txt", ".arc56.json", ".owners.json"):
        path = os.path.join(out_subdir, f"{digest}{suffix}")
        if not os.path.exists(path):
            continue
        if dry_run:
            print(f"would remove {os.path.relpath(path, ghr.REPO_ROOT)}")
            continue
        os.remove(path)
    if not dry_run and os.path.isdir(out_subdir) and not os.listdir(out_subdir):
        os.rmdir(out_subdir)


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    parser.add_argument("--dry-run", action="store_true")
    args = parser.parse_args()

    arc56_files = ghr.find_arc56_files()
    specs: dict[str, dict] = {}
    for rel_path in arc56_files:
        spec = ghr.load_spec(rel_path)
        if spec is not None:
            specs[rel_path] = spec

    for field, out_dir in ghr.PROGRAMS.items():
        current_digests = set(ghr.compute_field_digests(field, specs).values())
        orphans = find_orphaned_self_references(out_dir, current_digests)
        print(f"[{field}] {len(orphans)} orphaned self-referencing hash(es)", file=sys.stderr)
        for digest in sorted(orphans):
            remove_hash_files(out_dir, digest, args.dry_run)

    return 0


if __name__ == "__main__":
    raise SystemExit(main())
