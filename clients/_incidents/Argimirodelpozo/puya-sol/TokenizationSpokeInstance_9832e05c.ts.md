# Generated code fails to compile: TokenizationSpokeInstance_9832e05c (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/TokenizationSpokeInstance/TokenizationSpokeInstance.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/TokenizationSpokeInstance/TokenizationSpokeInstance.arc56.json)
- **Detected**: 2026-07-19T19:03:43.053189+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/TokenizationSpokeInstance/TokenizationSpokeInstance.arc56.json) -o client.generated.ts
```

## Error

```
src/TokenizationSpokeInstance_9832e05c.ts(1330,10): error TS2699: Static property 'name' conflicts with built-in property 'Function.name' of constructor function 'TokenizationSpokeInstanceParamsFactory'.
```
