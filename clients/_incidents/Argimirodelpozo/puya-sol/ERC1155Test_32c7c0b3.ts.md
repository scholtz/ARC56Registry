# Generated code fails to compile: ERC1155Test_32c7c0b3 (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC1155Test/ERC1155Test.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC1155Test/ERC1155Test.arc56.json)
- **Detected**: 2026-07-19T19:02:53.990473+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC1155Test/ERC1155Test.arc56.json) -o client.generated.ts
```

## Error

```
src/ERC1155Test_32c7c0b3.ts(87,7): error TS1131: Property or signature expected.
src/ERC1155Test_32c7c0b3.ts(87,9): error TS1131: Property or signature expected.
src/ERC1155Test_32c7c0b3.ts(88,5): error TS1128: Declaration or statement expected.
src/ERC1155Test_32c7c0b3.ts(89,40): error TS1005: ';' expected.
src/ERC1155Test_32c7c0b3.ts(93,53): error TS1005: ';' expected.
src/ERC1155Test_32c7c0b3.ts(94,568): error TS1011: An element access expression should take an argument.
src/ERC1155Test_32c7c0b3.ts(95,25): error TS1011: An element access expression should take an argument.
src/ERC1155Test_32c7c0b3.ts(95,36): error TS1011: An element access expression should take an argument.
src/ERC1155Test_32c7c0b3.ts(97,42): error TS1005: ';' expected.
src/ERC1155Test_32c7c0b3.ts(101,44): error TS1005: ';' expected.
src/ERC1155Test_32c7c0b3.ts(105,67): error TS1005: ';' expected.
src/ERC1155Test_32c7c0b3.ts(112,76): error TS1005: ';' expected.
src/ERC1155Test_32c7c0b3.ts(115,25): error TS1011: An element access expression should take an argument.
src/ERC1155Test_32c7c0b3.ts(115,36): error TS1011: An element access expression should take an argument.
src/ERC1155Test_32c7c0b3.ts(116,28): error TS1011: An element access expression should take an argument.
src/ERC1155Test_32c7c0b3.ts(116,39): error TS1011: An element access expression should take an argument.
src/ERC1155Test_32c7c0b3.ts(119,3): error TS1128: Declaration or statement expected.
src/ERC1155Test_32c7c0b3.ts(124,40): error TS1005: ';' expected.
src/ERC1155Test_32c7c0b3.ts(124,45): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(124,57): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(124,81): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(125,40): error TS1005: ';' expected.
src/ERC1155Test_32c7c0b3.ts(125,47): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(125,59): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(125,83): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(126,37): error TS1005: ';' expected.
src/ERC1155Test_32c7c0b3.ts(126,51): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(127,25): error TS1005: ';' expected.
src/ERC1155Test_32c7c0b3.ts(127,28): error TS1137: Expression or comma expected.
src/ERC1155Test_32c7c0b3.ts(128,40): error TS1005: ';' expected.
src/ERC1155Test_32c7c0b3.ts(128,50): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(128,62): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(129,53): error TS1005: ';' expected.
src/ERC1155Test_32c7c0b3.ts(129,70): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(129,617): error TS1011: An element access expression should take an argument.
src/ERC1155Test_32c7c0b3.ts(129,629): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(129,638): error TS1011: An element access expression should take an argument.
src/ERC1155Test_32c7c0b3.ts(129,649): error TS1011: An element access expression should take an argument.
src/ERC1155Test_32c7c0b3.ts(130,42): error TS1005: ';' expected.
src/ERC1155Test_32c7c0b3.ts(130,53): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(130,71): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(131,44): error TS1005: ';' expected.
src/ERC1155Test_32c7c0b3.ts(131,54): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(131,72): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(132,67): error TS1005: ';' expected.
src/ERC1155Test_32c7c0b3.ts(132,74): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(132,86): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(132,98): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(132,122): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(132,145): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(133,76): error TS1005: ';' expected.
src/ERC1155Test_32c7c0b3.ts(133,83): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(133,95): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(133,114): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(133,123): error TS1011: An element access expression should take an argument.
src/ERC1155Test_32c7c0b3.ts(133,134): error TS1011: An element access expression should take an argument.
src/ERC1155Test_32c7c0b3.ts(133,149): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(133,158): error TS1011: An element access expression should take an argument.
src/ERC1155Test_32c7c0b3.ts(133,169): error TS1011: An element access expression should take an argument.
src/ERC1155Test_32c7c0b3.ts(133,176): error TS1005: ',' expected.
src/ERC1155Test_32c7c0b3.ts(135,1): error TS1128: Declaration or statement expected.
```
