# Generated code fails to compile: BinaryTest_1535f562 (Python)

- **Repo**: [algorandfoundation/TEALScript](https://github.com/algorandfoundation/TEALScript)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/BinaryTest.arc56.json](https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/BinaryTest.arc56.json)
- **Detected**: 2026-07-18T17:41:39.072574+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/BinaryTest.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/TEALScript/python/src/arc56_generated_algor_4ad3bfc9/BinaryTest_1535f562.py", line 192
    def and(
        ^^^
SyntaxError: invalid syntax

```
