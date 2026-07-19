# Generated code fails to compile: GlobalMapBytes_66a90561 (TypeScript)

- **Repo**: [algorandfoundation/puya](https://github.com/algorandfoundation/puya)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/global_map/out/GlobalMapBytes.arc56.json](https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/global_map/out/GlobalMapBytes.arc56.json)
- **Detected**: 2026-07-19T08:48:22.487308+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/global_map/out/GlobalMapBytes.arc56.json) -o client.generated.ts
```

## Error

```
src/GlobalMapBytes_66a90561.ts(103,64): error TS1110: Type expected.
src/GlobalMapBytes_66a90561.ts(103,83): error TS1005: ';' expected.
```
