# Generated code fails to compile: GlobalMapAccountStruct_cdb51e65 (TypeScript)

- **Repo**: [algorandfoundation/puya](https://github.com/algorandfoundation/puya)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/global_map/out/GlobalMapAccountStruct.arc56.json](https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/global_map/out/GlobalMapAccountStruct.arc56.json)
- **Detected**: 2026-07-18T08:38:27.955376+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/global_map/out/GlobalMapAccountStruct.arc56.json) -o client.generated.ts
```

## Error

```
src/GlobalMapAccountStruct_cdb51e65.ts(118,81): error TS1110: Type expected.
src/GlobalMapAccountStruct_cdb51e65.ts(118,94): error TS1005: ';' expected.
```
