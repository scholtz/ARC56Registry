# Generated code fails to compile: LocalMapAccountStruct_e36cb6be (TypeScript)

- **Repo**: [algorandfoundation/puya](https://github.com/algorandfoundation/puya)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/local_map/out/LocalMapAccountStruct.arc56.json](https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/local_map/out/LocalMapAccountStruct.arc56.json)
- **Detected**: 2026-07-19T08:48:22.486901+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/local_map/out/LocalMapAccountStruct.arc56.json) -o client.generated.ts
```

## Error

```
src/LocalMapAccountStruct_e36cb6be.ts(127,106): error TS1110: Type expected.
src/LocalMapAccountStruct_e36cb6be.ts(127,119): error TS1005: ';' expected.
```
