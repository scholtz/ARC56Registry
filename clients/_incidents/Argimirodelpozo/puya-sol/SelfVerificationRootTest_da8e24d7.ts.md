# Generated code fails to compile: SelfVerificationRootTest_da8e24d7 (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/self_features/out/SelfVerificationRootTest/SelfVerificationRootTest.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/self_features/out/SelfVerificationRootTest/SelfVerificationRootTest.arc56.json)
- **Detected**: 2026-07-19T08:42:38.965401+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/self_features/out/SelfVerificationRootTest/SelfVerificationRootTest.arc56.json) -o client.generated.ts
```

## Error

```
src/SelfVerificationRootTest_da8e24d7.ts(76,7): error TS1131: Property or signature expected.
src/SelfVerificationRootTest_da8e24d7.ts(120,115): error TS1110: Type expected.
```
