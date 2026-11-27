# Generated code fails to compile: MockSmartAsa_eb679860 (Python)

- **Repo**: [akita-protocol/akita-sc](https://github.com/akita-protocol/akita-sc)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/mocks/collectible-variations/MockSmartAsa.arc56.json](https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/mocks/collectible-variations/MockSmartAsa.arc56.json)
- **Detected**: 2026-11-27T17:23:26.043156+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/mocks/collectible-variations/MockSmartAsa.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/python/src/arc56_generated_akita_5cada353/MockSmartAsa_eb679860.py", line 90
    from: str
        ^
SyntaxError: invalid syntax

```
