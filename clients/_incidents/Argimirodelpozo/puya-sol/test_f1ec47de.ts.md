# Generated code fails to compile: test_f1ec47de (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/functionCall/member_accessors/test.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/functionCall/member_accessors/test.arc56.json)
- **Detected**: 2026-07-19T19:03:43.056863+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/functionCall/member_accessors/test.arc56.json) -o client.generated.ts
```

## Error

```
src/test_f1ec47de.ts(201,10): error TS2699: Static property 'name' conflicts with built-in property 'Function.name' of constructor function 'TestParamsFactory'.
```
