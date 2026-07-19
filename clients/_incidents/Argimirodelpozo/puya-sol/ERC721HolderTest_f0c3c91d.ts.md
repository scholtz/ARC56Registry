# Generated code fails to compile: ERC721HolderTest_f0c3c91d (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC721HolderTest/ERC721HolderTest.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC721HolderTest/ERC721HolderTest.arc56.json)
- **Detected**: 2026-07-19T08:42:38.965641+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC721HolderTest/ERC721HolderTest.arc56.json) -o client.generated.ts
```

## Error

```
src/ERC721HolderTest_f0c3c91d.ts(83,7): error TS1131: Property or signature expected.
src/ERC721HolderTest_f0c3c91d.ts(85,7): error TS1131: Property or signature expected.
src/ERC721HolderTest_f0c3c91d.ts(85,9): error TS1131: Property or signature expected.
src/ERC721HolderTest_f0c3c91d.ts(86,7): error TS1128: Declaration or statement expected.
src/ERC721HolderTest_f0c3c91d.ts(87,5): error TS1128: Declaration or statement expected.
src/ERC721HolderTest_f0c3c91d.ts(88,3): error TS1128: Declaration or statement expected.
src/ERC721HolderTest_f0c3c91d.ts(93,37): error TS1005: ';' expected.
src/ERC721HolderTest_f0c3c91d.ts(93,51): error TS1005: ',' expected.
src/ERC721HolderTest_f0c3c91d.ts(94,66): error TS1005: ';' expected.
src/ERC721HolderTest_f0c3c91d.ts(94,77): error TS1005: ',' expected.
src/ERC721HolderTest_f0c3c91d.ts(94,91): error TS1005: ',' expected.
src/ERC721HolderTest_f0c3c91d.ts(94,108): error TS1005: ',' expected.
src/ERC721HolderTest_f0c3c91d.ts(94,131): error TS1005: ',' expected.
src/ERC721HolderTest_f0c3c91d.ts(95,62): error TS1005: ';' expected.
src/ERC721HolderTest_f0c3c91d.ts(95,65): error TS1137: Expression or comma expected.
src/ERC721HolderTest_f0c3c91d.ts(95,75): error TS1137: Expression or comma expected.
src/ERC721HolderTest_f0c3c91d.ts(95,85): error TS1137: Expression or comma expected.
src/ERC721HolderTest_f0c3c91d.ts(95,104): error TS1137: Expression or comma expected.
src/ERC721HolderTest_f0c3c91d.ts(97,1): error TS1128: Declaration or statement expected.
```
