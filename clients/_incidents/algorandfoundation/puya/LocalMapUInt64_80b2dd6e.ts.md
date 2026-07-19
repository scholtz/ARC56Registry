# Generated code fails to compile: LocalMapUInt64_80b2dd6e (TypeScript)

- **Repo**: [algorandfoundation/puya](https://github.com/algorandfoundation/puya)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/local_map/out/LocalMapUInt64.arc56.json](https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/local_map/out/LocalMapUInt64.arc56.json)
- **Detected**: 2026-07-19T08:48:22.487108+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/local_map/out/LocalMapUInt64.arc56.json) -o client.generated.ts
```

## Error

```
src/LocalMapUInt64_80b2dd6e.ts(112,94): error TS1110: Type expected.
src/LocalMapUInt64_80b2dd6e.ts(112,118): error TS1005: ';' expected.
```
