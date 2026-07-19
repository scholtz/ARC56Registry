# Generated code fails to compile: MinHeapWrapper_d0d49290 (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/solady/out/MinHeapWrapper/MinHeapWrapper.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/solady/out/MinHeapWrapper/MinHeapWrapper.arc56.json)
- **Detected**: 2026-07-19T19:03:43.050369+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/solady/out/MinHeapWrapper/MinHeapWrapper.arc56.json) -o client.generated.ts
```

## Error

```
src/MinHeapWrapper_d0d49290.ts(239,10): error TS2699: Static property 'length' conflicts with built-in property 'Function.length' of constructor function 'MinHeapWrapperParamsFactory'.
```
