# Generated code fails to compile: ERC1155BurnableTest_cf3806c2 (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC1155BurnableTest/ERC1155BurnableTest.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC1155BurnableTest/ERC1155BurnableTest.arc56.json)
- **Detected**: 2026-07-18T08:15:09.516601+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC1155BurnableTest/ERC1155BurnableTest.arc56.json) -o client.generated.ts
```

## Error

```
src/ERC1155BurnableTest_cf3806c2.ts(92,7): error TS1131: Property or signature expected.
src/ERC1155BurnableTest_cf3806c2.ts(92,9): error TS1131: Property or signature expected.
src/ERC1155BurnableTest_cf3806c2.ts(93,5): error TS1128: Declaration or statement expected.
src/ERC1155BurnableTest_cf3806c2.ts(94,40): error TS1005: ';' expected.
src/ERC1155BurnableTest_cf3806c2.ts(98,53): error TS1005: ';' expected.
src/ERC1155BurnableTest_cf3806c2.ts(99,568): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(100,25): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(100,36): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(102,42): error TS1005: ';' expected.
src/ERC1155BurnableTest_cf3806c2.ts(106,44): error TS1005: ';' expected.
src/ERC1155BurnableTest_cf3806c2.ts(110,67): error TS1005: ';' expected.
src/ERC1155BurnableTest_cf3806c2.ts(117,76): error TS1005: ';' expected.
src/ERC1155BurnableTest_cf3806c2.ts(120,25): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(120,36): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(121,28): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(121,39): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(124,3): error TS1128: Declaration or statement expected.
src/ERC1155BurnableTest_cf3806c2.ts(129,40): error TS1005: ';' expected.
src/ERC1155BurnableTest_cf3806c2.ts(129,45): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(129,57): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(129,81): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(130,40): error TS1005: ';' expected.
src/ERC1155BurnableTest_cf3806c2.ts(130,50): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(130,62): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(130,86): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(131,49): error TS1005: ';' expected.
src/ERC1155BurnableTest_cf3806c2.ts(131,59): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(131,78): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(131,87): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(131,98): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(131,113): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(131,122): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(131,133): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(132,37): error TS1005: ';' expected.
src/ERC1155BurnableTest_cf3806c2.ts(132,51): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(133,25): error TS1005: ';' expected.
src/ERC1155BurnableTest_cf3806c2.ts(133,28): error TS1137: Expression or comma expected.
src/ERC1155BurnableTest_cf3806c2.ts(134,40): error TS1005: ';' expected.
src/ERC1155BurnableTest_cf3806c2.ts(134,50): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(134,62): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(135,53): error TS1005: ';' expected.
src/ERC1155BurnableTest_cf3806c2.ts(135,70): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(135,617): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(135,629): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(135,638): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(135,649): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(136,42): error TS1005: ';' expected.
src/ERC1155BurnableTest_cf3806c2.ts(136,53): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(136,71): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(137,44): error TS1005: ';' expected.
src/ERC1155BurnableTest_cf3806c2.ts(137,54): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(137,72): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(138,67): error TS1005: ';' expected.
src/ERC1155BurnableTest_cf3806c2.ts(138,74): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(138,86): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(138,98): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(138,122): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(138,145): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(139,76): error TS1005: ';' expected.
src/ERC1155BurnableTest_cf3806c2.ts(139,83): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(139,95): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(139,114): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(139,123): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(139,134): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(139,149): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(139,158): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(139,169): error TS1011: An element access expression should take an argument.
src/ERC1155BurnableTest_cf3806c2.ts(139,176): error TS1005: ',' expected.
src/ERC1155BurnableTest_cf3806c2.ts(141,1): error TS1128: Declaration or statement expected.
```
