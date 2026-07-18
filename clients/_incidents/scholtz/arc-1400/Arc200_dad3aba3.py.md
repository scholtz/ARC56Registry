# Generated code fails to compile: Arc200_dad3aba3 (Python)

- **Repo**: [scholtz/arc-1400](https://github.com/scholtz/arc-1400)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/scholtz/arc-1400/HEAD/projects/arc-1400/smart_contracts/artifacts/security_token/Arc200.arc56.json](https://raw.githubusercontent.com/scholtz/arc-1400/HEAD/projects/arc-1400/smart_contracts/artifacts/security_token/Arc200.arc56.json)
- **Detected**: 2026-07-18T17:53:35.709848+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/scholtz/arc-1400/HEAD/projects/arc-1400/smart_contracts/artifacts/security_token/Arc200.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/scholtz/arc-1400/python/src/arc56_generated_schol_1f74bf10/Arc200_dad3aba3.py", line 109
    from: str
        ^
SyntaxError: invalid syntax

```
