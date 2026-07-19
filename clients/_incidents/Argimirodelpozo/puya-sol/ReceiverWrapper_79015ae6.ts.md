# Generated code fails to compile: ReceiverWrapper_79015ae6 (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/solady/out/ReceiverWrapper/ReceiverWrapper.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/solady/out/ReceiverWrapper/ReceiverWrapper.arc56.json)
- **Detected**: 2026-07-19T08:42:38.966339+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/solady/out/ReceiverWrapper/ReceiverWrapper.arc56.json) -o client.generated.ts
```

## Error

```
src/ReceiverWrapper_79015ae6.ts(293,5): error TS1136: Property assignment expected.
src/ReceiverWrapper_79015ae6.ts(293,7): error TS1136: Property assignment expected.
src/ReceiverWrapper_79015ae6.ts(293,14): error TS1005: ',' expected.
src/ReceiverWrapper_79015ae6.ts(293,152): error TS1005: ',' expected.
src/ReceiverWrapper_79015ae6.ts(293,166): error TS1005: ';' expected.
src/ReceiverWrapper_79015ae6.ts(293,169): error TS1068: Unexpected token. A constructor, method, accessor, or property was expected.
src/ReceiverWrapper_79015ae6.ts(295,6): error TS1128: Declaration or statement expected.
src/ReceiverWrapper_79015ae6.ts(297,3): error TS1128: Declaration or statement expected.
src/ReceiverWrapper_79015ae6.ts(302,3): error TS1128: Declaration or statement expected.
src/ReceiverWrapper_79015ae6.ts(333,5): error TS1136: Property assignment expected.
src/ReceiverWrapper_79015ae6.ts(333,7): error TS1136: Property assignment expected.
src/ReceiverWrapper_79015ae6.ts(333,14): error TS1005: ',' expected.
src/ReceiverWrapper_79015ae6.ts(333,152): error TS1005: ',' expected.
src/ReceiverWrapper_79015ae6.ts(333,166): error TS1005: ';' expected.
src/ReceiverWrapper_79015ae6.ts(335,6): error TS1128: Declaration or statement expected.
src/ReceiverWrapper_79015ae6.ts(337,3): error TS1128: Declaration or statement expected.
src/ReceiverWrapper_79015ae6.ts(342,3): error TS1128: Declaration or statement expected.
src/ReceiverWrapper_79015ae6.ts(374,5): error TS1136: Property assignment expected.
src/ReceiverWrapper_79015ae6.ts(374,185): error TS1005: '{' expected.
src/ReceiverWrapper_79015ae6.ts(374,188): error TS1136: Property assignment expected.
src/ReceiverWrapper_79015ae6.ts(377,6): error TS1128: Declaration or statement expected.
src/ReceiverWrapper_79015ae6.ts(379,3): error TS1128: Declaration or statement expected.
src/ReceiverWrapper_79015ae6.ts(387,3): error TS1128: Declaration or statement expected.
src/ReceiverWrapper_79015ae6.ts(387,22): error TS1005: ',' expected.
src/ReceiverWrapper_79015ae6.ts(387,46): error TS1005: ';' expected.
src/ReceiverWrapper_79015ae6.ts(399,3): error TS1434: Unexpected keyword or identifier.
src/ReceiverWrapper_79015ae6.ts(399,20): error TS1005: ',' expected.
src/ReceiverWrapper_79015ae6.ts(399,140): error TS1005: ';' expected.
src/ReceiverWrapper_79015ae6.ts(410,3): error TS1128: Declaration or statement expected.
src/ReceiverWrapper_79015ae6.ts(410,20): error TS1005: ';' expected.
src/ReceiverWrapper_79015ae6.ts(410,22): error TS1434: Unexpected keyword or identifier.
src/ReceiverWrapper_79015ae6.ts(427,7): error TS1136: Property assignment expected.
src/ReceiverWrapper_79015ae6.ts(427,14): error TS1005: ',' expected.
src/ReceiverWrapper_79015ae6.ts(427,153): error TS1005: ';' expected.
src/ReceiverWrapper_79015ae6.ts(431,8): error TS1128: Declaration or statement expected.
src/ReceiverWrapper_79015ae6.ts(435,24): error TS1005: ',' expected.
src/ReceiverWrapper_79015ae6.ts(435,51): error TS1005: ';' expected.
src/ReceiverWrapper_79015ae6.ts(438,8): error TS1128: Declaration or statement expected.
src/ReceiverWrapper_79015ae6.ts(439,25): error TS1005: ',' expected.
src/ReceiverWrapper_79015ae6.ts(439,47): error TS1109: Expression expected.
src/ReceiverWrapper_79015ae6.ts(439,68): error TS1005: ';' expected.
src/ReceiverWrapper_79015ae6.ts(442,8): error TS1128: Declaration or statement expected.
src/ReceiverWrapper_79015ae6.ts(443,7): error TS1434: Unexpected keyword or identifier.
src/ReceiverWrapper_79015ae6.ts(443,24): error TS1005: ';' expected.
src/ReceiverWrapper_79015ae6.ts(446,8): error TS1128: Declaration or statement expected.
src/ReceiverWrapper_79015ae6.ts(447,7): error TS1434: Unexpected keyword or identifier.
src/ReceiverWrapper_79015ae6.ts(447,30): error TS1109: Expression expected.
src/ReceiverWrapper_79015ae6.ts(447,49): error TS1005: ';' expected.
src/ReceiverWrapper_79015ae6.ts(454,8): error TS1128: Declaration or statement expected.
src/ReceiverWrapper_79015ae6.ts(455,7): error TS1434: Unexpected keyword or identifier.
src/ReceiverWrapper_79015ae6.ts(455,25): error TS1109: Expression expected.
src/ReceiverWrapper_79015ae6.ts(455,39): error TS1005: ';' expected.
src/ReceiverWrapper_79015ae6.ts(463,7): error TS1434: Unexpected keyword or identifier.
src/ReceiverWrapper_79015ae6.ts(464,3): error TS1128: Declaration or statement expected.
src/ReceiverWrapper_79015ae6.ts(465,1): error TS1128: Declaration or statement expected.
```
