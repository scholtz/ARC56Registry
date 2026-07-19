# Generated code fails to compile: EnumerableSetTest_28df91b8 (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/EnumerableSetTest/EnumerableSetTest.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/EnumerableSetTest/EnumerableSetTest.arc56.json)
- **Detected**: 2026-07-19T19:03:43.056499+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/EnumerableSetTest/EnumerableSetTest.arc56.json) -o client.generated.ts
```

## Error

```
src/EnumerableSetTest_28df91b8.ts(240,10): error TS2699: Static property 'length' conflicts with built-in property 'Function.length' of constructor function 'EnumerableSetTestParamsFactory'.
```
