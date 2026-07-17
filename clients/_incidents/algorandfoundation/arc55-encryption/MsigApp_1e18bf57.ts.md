# Generated code fails to compile: MsigApp_1e18bf57 (TypeScript)

- **Repo**: [algorandfoundation/arc55-encryption](https://github.com/algorandfoundation/arc55-encryption)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/arc55-encryption/HEAD/smart_contracts/artifacts/multisig/MsigApp.arc56.json](https://raw.githubusercontent.com/algorandfoundation/arc55-encryption/HEAD/smart_contracts/artifacts/multisig/MsigApp.arc56.json)
- **Detected**: 2026-07-17T20:02:41.741081+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/algorandfoundation/arc55-encryption/HEAD/smart_contracts/artifacts/multisig/MsigApp.arc56.json) -o client.generated.ts
```

## Error

```
src/MsigApp_1e18bf57.ts(232,5): error TS2740: Type 'AlgorandClientInterface' is missing the following properties from type 'AlgorandClient': _clientManager, _accountManager, _appManager, _appDeployer, and 14 more.
```
