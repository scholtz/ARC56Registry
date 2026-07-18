# Generated code fails to compile: GlobalMapAccountStruct_cdb51e65 (Python)

- **Repo**: [algorandfoundation/puya](https://github.com/algorandfoundation/puya)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/global_map/out/GlobalMapAccountStruct.arc56.json](https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/global_map/out/GlobalMapAccountStruct.arc56.json)
- **Detected**: 2026-07-18T17:43:14.503185+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/global_map/out/GlobalMapAccountStruct.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/puya/python/src/arc56_generated_algor_ae3945ab/GlobalMapAccountStruct_cdb51e65.py", line 196
    def in(
        ^^
SyntaxError: invalid syntax

```
