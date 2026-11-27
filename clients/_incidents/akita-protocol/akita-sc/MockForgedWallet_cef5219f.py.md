# Generated code fails to compile: MockForgedWallet_cef5219f (Python)

- **Repo**: [akita-protocol/akita-sc](https://github.com/akita-protocol/akita-sc)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/mocks/forged-wallet/MockForgedWallet.arc56.json](https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/mocks/forged-wallet/MockForgedWallet.arc56.json)
- **Detected**: 2026-11-27T17:23:26.594399+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/mocks/forged-wallet/MockForgedWallet.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/python/src/arc56_generated_akita_5cada353/MockForgedWallet_cef5219f.py", line 189
    def del(
        ^^^
SyntaxError: invalid syntax

```
