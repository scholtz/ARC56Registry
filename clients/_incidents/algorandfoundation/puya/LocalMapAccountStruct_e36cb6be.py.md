# Generated code fails to compile: LocalMapAccountStruct_e36cb6be (Python)

- **Repo**: [algorandfoundation/puya](https://github.com/algorandfoundation/puya)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/local_map/out/LocalMapAccountStruct.arc56.json](https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/local_map/out/LocalMapAccountStruct.arc56.json)
- **Detected**: 2026-07-18T15:54:17.011392+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/local_map/out/LocalMapAccountStruct.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/puya/python/src/arc56_generated_algorandfoundation_puya/LocalMapAccountStruct_e36cb6be.py", line 203
    def in(
        ^^
SyntaxError: invalid syntax

```
