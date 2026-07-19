# Generated code fails to compile: GlobalMapContract_55f26931 (TypeScript)

- **Repo**: [algorandfoundation/algorand-python-testing](https://github.com/algorandfoundation/algorand-python-testing)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/algorand-python-testing/HEAD/tests/artifacts/StateOps/data/GlobalMapContract.arc56.json](https://raw.githubusercontent.com/algorandfoundation/algorand-python-testing/HEAD/tests/artifacts/StateOps/data/GlobalMapContract.arc56.json)
- **Detected**: 2026-07-19T08:46:32.059982+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/algorandfoundation/algorand-python-testing/HEAD/tests/artifacts/StateOps/data/GlobalMapContract.arc56.json) -o client.generated.ts
```

## Error

```
src/GlobalMapContract_55f26931.ts(187,87): error TS1110: Type expected.
src/GlobalMapContract_55f26931.ts(187,111): error TS1005: ';' expected.
```
