# Generated code fails to compile: TealScriptConventionsAlgo_b71037e4 (Python)

- **Repo**: [algorandfoundation/puya-ts](https://github.com/algorandfoundation/puya-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/unoptimized/teal-script-conventions/TealScriptConventionsAlgo.arc56.json](https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/unoptimized/teal-script-conventions/TealScriptConventionsAlgo.arc56.json)
- **Detected**: 2026-07-18T17:45:45.685997+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/unoptimized/teal-script-conventions/TealScriptConventionsAlgo.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/puya-ts/python/src/arc56_generated_algor_98bbbad3/TealScriptConventionsAlgo_b71037e4.py", line 316
    global: bytes
          ^
SyntaxError: invalid syntax

```
