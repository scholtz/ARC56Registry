# Generated code fails to compile: ERC1155PausableTest_39e59af3 (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC1155PausableTest/ERC1155PausableTest.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC1155PausableTest/ERC1155PausableTest.arc56.json)
- **Detected**: 2026-07-19T19:02:53.990766+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC1155PausableTest/ERC1155PausableTest.arc56.json) -o client.generated.ts
```

## Error

```
src/ERC1155PausableTest_39e59af3.ts(90,7): error TS1131: Property or signature expected.
src/ERC1155PausableTest_39e59af3.ts(90,9): error TS1131: Property or signature expected.
src/ERC1155PausableTest_39e59af3.ts(91,5): error TS1128: Declaration or statement expected.
src/ERC1155PausableTest_39e59af3.ts(92,40): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(96,53): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(97,568): error TS1011: An element access expression should take an argument.
src/ERC1155PausableTest_39e59af3.ts(98,25): error TS1011: An element access expression should take an argument.
src/ERC1155PausableTest_39e59af3.ts(98,36): error TS1011: An element access expression should take an argument.
src/ERC1155PausableTest_39e59af3.ts(100,42): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(104,44): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(108,67): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(115,76): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(118,25): error TS1011: An element access expression should take an argument.
src/ERC1155PausableTest_39e59af3.ts(118,36): error TS1011: An element access expression should take an argument.
src/ERC1155PausableTest_39e59af3.ts(119,28): error TS1011: An element access expression should take an argument.
src/ERC1155PausableTest_39e59af3.ts(119,39): error TS1011: An element access expression should take an argument.
src/ERC1155PausableTest_39e59af3.ts(122,3): error TS1128: Declaration or statement expected.
src/ERC1155PausableTest_39e59af3.ts(127,40): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(127,45): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(127,57): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(127,81): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(128,40): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(128,47): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(128,59): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(128,83): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(129,18): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(130,20): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(131,19): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(132,37): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(132,51): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(133,25): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(133,28): error TS1137: Expression or comma expected.
src/ERC1155PausableTest_39e59af3.ts(134,40): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(134,50): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(134,62): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(135,53): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(135,70): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(135,617): error TS1011: An element access expression should take an argument.
src/ERC1155PausableTest_39e59af3.ts(135,629): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(135,638): error TS1011: An element access expression should take an argument.
src/ERC1155PausableTest_39e59af3.ts(135,649): error TS1011: An element access expression should take an argument.
src/ERC1155PausableTest_39e59af3.ts(136,42): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(136,53): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(136,71): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(137,44): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(137,54): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(137,72): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(138,67): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(138,74): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(138,86): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(138,98): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(138,122): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(138,145): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(139,76): error TS1005: ';' expected.
src/ERC1155PausableTest_39e59af3.ts(139,83): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(139,95): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(139,114): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(139,123): error TS1011: An element access expression should take an argument.
src/ERC1155PausableTest_39e59af3.ts(139,134): error TS1011: An element access expression should take an argument.
src/ERC1155PausableTest_39e59af3.ts(139,149): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(139,158): error TS1011: An element access expression should take an argument.
src/ERC1155PausableTest_39e59af3.ts(139,169): error TS1011: An element access expression should take an argument.
src/ERC1155PausableTest_39e59af3.ts(139,176): error TS1005: ',' expected.
src/ERC1155PausableTest_39e59af3.ts(141,1): error TS1128: Declaration or statement expected.
```
