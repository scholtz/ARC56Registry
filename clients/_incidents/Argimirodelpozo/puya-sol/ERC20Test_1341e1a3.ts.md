# Generated code fails to compile: ERC20Test_1341e1a3 (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC20Test/ERC20Test.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC20Test/ERC20Test.arc56.json)
- **Detected**: 2026-07-19T19:03:43.053858+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC20Test/ERC20Test.arc56.json) -o client.generated.ts
```

## Error

```
src/ERC20Test_1341e1a3.ts(301,10): error TS2699: Static property 'name' conflicts with built-in property 'Function.name' of constructor function 'Erc20TestParamsFactory'.
```
