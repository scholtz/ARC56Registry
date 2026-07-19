# Generated code fails to compile: ERC721RoyaltyTest_4a549697 (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC721RoyaltyTest/ERC721RoyaltyTest.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC721RoyaltyTest/ERC721RoyaltyTest.arc56.json)
- **Detected**: 2026-07-19T19:03:43.054669+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC721RoyaltyTest/ERC721RoyaltyTest.arc56.json) -o client.generated.ts
```

## Error

```
src/ERC721RoyaltyTest_4a549697.ts(466,10): error TS2699: Static property 'name' conflicts with built-in property 'Function.name' of constructor function 'Erc721RoyaltyTestParamsFactory'.
```
