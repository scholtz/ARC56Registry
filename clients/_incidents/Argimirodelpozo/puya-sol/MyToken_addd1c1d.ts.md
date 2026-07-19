# Generated code fails to compile: MyToken_addd1c1d (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/MyToken/MyToken.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/MyToken/MyToken.arc56.json)
- **Detected**: 2026-07-19T19:03:43.056700+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/MyToken/MyToken.arc56.json) -o client.generated.ts
```

## Error

```
src/MyToken_addd1c1d.ts(299,10): error TS2699: Static property 'name' conflicts with built-in property 'Function.name' of constructor function 'MyTokenParamsFactory'.
```
