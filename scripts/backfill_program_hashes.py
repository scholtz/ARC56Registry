#!/usr/bin/env python3
"""One-time backfill: add approval_program_sha256 / clear_program_sha256 to every entry
in clients/*/*/arc56/state.json, computed from the already-downloaded local spec copy
(clients/<owner>/<repo>/arc56/<file_slug>_<hash8>.arc56.json). No network access.

Idempotent; never removes entries or files. New downloads get these fields from
scripts/download_arc56_specs.py directly.
"""
from __future__ import annotations

import glob
import os
import sys
from datetime import datetime, timezone

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from download_arc56_specs import CLIENTS_DIR, load_state, program_hashes, save_state  # noqa: E402


def log(message: str) -> None:
    print(f"{datetime.now(timezone.utc).isoformat()} {message}", file=sys.stderr)


def main() -> int:
    files = changed_entries = missing = 0
    for state_path in sorted(glob.glob(os.path.join(CLIENTS_DIR, "*", "*", "arc56", "state.json"))):
        arc56_dir = os.path.dirname(state_path)
        state = load_state(state_path)
        dirty = False
        for url, entry in state.get("contracts", {}).items():
            spec_path = os.path.join(arc56_dir, f"{entry.get('file_slug')}_{entry.get('hash8')}.arc56.json")
            if not os.path.isfile(spec_path):
                missing += 1
                continue
            with open(spec_path, "rb") as f:
                hashes = program_hashes(f.read())
            if any(entry.get(k) != v for k, v in hashes.items()):
                entry.update(hashes)
                dirty = True
                changed_entries += 1
        if dirty:
            save_state(state_path, state)
            files += 1
    log(f"Updated {changed_entries} entries in {files} state.json files; {missing} entries had no local spec")
    return 0


if __name__ == "__main__":
    sys.exit(main())
