# Generated code fails to compile: LocalMapBytes_e3447b02 (TypeScript)

- **Repo**: [algorandfoundation/puya](https://github.com/algorandfoundation/puya)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/local_map/out/LocalMapBytes.arc56.json](https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/local_map/out/LocalMapBytes.arc56.json)
- **Detected**: 2026-07-18T08:38:27.955514+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/local_map/out/LocalMapBytes.arc56.json) -o client.generated.ts
```

## Error

```
src/LocalMapBytes_e3447b02.ts(112,89): error TS1110: Type expected.
src/LocalMapBytes_e3447b02.ts(112,108): error TS1005: ';' expected.
```
