# Generated code fails to compile: Multisig_0579f8cd (TypeScript)

- **Repo**: [algorandfoundation/arc55-encryption](https://github.com/algorandfoundation/arc55-encryption)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/arc55-encryption/HEAD/smart_contracts/artifacts/multisig/Multisig.arc56.json](https://raw.githubusercontent.com/algorandfoundation/arc55-encryption/HEAD/smart_contracts/artifacts/multisig/Multisig.arc56.json)
- **Detected**: 2026-07-17T20:02:41.739879+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/algorandfoundation/arc55-encryption/HEAD/smart_contracts/artifacts/multisig/Multisig.arc56.json) -o client.generated.ts
```

## Error

```
src/Multisig_0579f8cd.ts(761,5): error TS2740: Type 'AlgorandClientInterface' is missing the following properties from type 'AlgorandClient': _clientManager, _accountManager, _appManager, _appDeployer, and 14 more.
```
