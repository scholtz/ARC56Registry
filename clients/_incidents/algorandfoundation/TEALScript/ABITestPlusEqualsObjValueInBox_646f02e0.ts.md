# Generated code fails to compile: ABITestPlusEqualsObjValueInBox_646f02e0 (TypeScript)

- **Repo**: [algorandfoundation/TEALScript](https://github.com/algorandfoundation/TEALScript)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ABITestPlusEqualsObjValueInBox.arc56.json](https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ABITestPlusEqualsObjValueInBox.arc56.json)
- **Detected**: 2026-07-19T08:45:55.585116+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ABITestPlusEqualsObjValueInBox.arc56.json) -o client.generated.ts
```

## Error

```
src/ABITestPlusEqualsObjValueInBox_646f02e0.ts(67,13): error TS2300: Duplicate identifier 'FooUint64BarUint64'.
src/ABITestPlusEqualsObjValueInBox_646f02e0.ts(76,17): error TS2323: Cannot redeclare exported variable 'FooUint64BarUint64FromTuple'.
src/ABITestPlusEqualsObjValueInBox_646f02e0.ts(76,17): error TS2393: Duplicate function implementation.
src/ABITestPlusEqualsObjValueInBox_646f02e0.ts(80,13): error TS2300: Duplicate identifier 'FooUint64BarUint64'.
src/ABITestPlusEqualsObjValueInBox_646f02e0.ts(89,17): error TS2323: Cannot redeclare exported variable 'FooUint64BarUint64FromTuple'.
src/ABITestPlusEqualsObjValueInBox_646f02e0.ts(89,17): error TS2393: Duplicate function implementation.
```
