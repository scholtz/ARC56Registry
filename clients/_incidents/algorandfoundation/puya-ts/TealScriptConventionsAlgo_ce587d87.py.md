# Generated code fails to compile: TealScriptConventionsAlgo_ce587d87 (Python)

- **Repo**: [algorandfoundation/puya-ts](https://github.com/algorandfoundation/puya-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/o1/teal-script-conventions/TealScriptConventionsAlgo.arc56.json](https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/o1/teal-script-conventions/TealScriptConventionsAlgo.arc56.json)
- **Detected**: 2026-07-18T15:55:11.219320+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/o1/teal-script-conventions/TealScriptConventionsAlgo.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/puya-ts/python/src/arc56_generated_algorandfoundation_puya_ts/TealScriptConventionsAlgo_ce587d87.py", line 316
    global: bytes
          ^
SyntaxError: invalid syntax

```
