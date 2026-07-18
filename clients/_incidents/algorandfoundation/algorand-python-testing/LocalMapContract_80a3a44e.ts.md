# Generated code fails to compile: LocalMapContract_80a3a44e (TypeScript)

- **Repo**: [algorandfoundation/algorand-python-testing](https://github.com/algorandfoundation/algorand-python-testing)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/algorand-python-testing/HEAD/tests/artifacts/StateOps/data/LocalMapContract.arc56.json](https://raw.githubusercontent.com/algorandfoundation/algorand-python-testing/HEAD/tests/artifacts/StateOps/data/LocalMapContract.arc56.json)
- **Detected**: 2026-07-18T08:35:42.701702+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/algorandfoundation/algorand-python-testing/HEAD/tests/artifacts/StateOps/data/LocalMapContract.arc56.json) -o client.generated.ts
```

## Error

```
src/LocalMapContract_80a3a44e.ts(215,106): error TS1110: Type expected.
src/LocalMapContract_80a3a44e.ts(215,130): error TS1005: ';' expected.
```
