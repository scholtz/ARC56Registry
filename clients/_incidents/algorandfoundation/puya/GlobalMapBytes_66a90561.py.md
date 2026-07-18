# Generated code fails to compile: GlobalMapBytes_66a90561 (Python)

- **Repo**: [algorandfoundation/puya](https://github.com/algorandfoundation/puya)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/global_map/out/GlobalMapBytes.arc56.json](https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/global_map/out/GlobalMapBytes.arc56.json)
- **Detected**: 2026-07-18T17:43:14.859011+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/global_map/out/GlobalMapBytes.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/puya/python/src/arc56_generated_algor_ae3945ab/GlobalMapBytes_66a90561.py", line 189
    def in(
        ^^
SyntaxError: invalid syntax

```
