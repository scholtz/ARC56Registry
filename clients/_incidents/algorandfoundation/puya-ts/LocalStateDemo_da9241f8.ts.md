# Generated code fails to compile: LocalStateDemo_da9241f8 (TypeScript)

- **Repo**: [algorandfoundation/puya-ts](https://github.com/algorandfoundation/puya-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/o2/local-state/LocalStateDemo.arc56.json](https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/o2/local-state/LocalStateDemo.arc56.json)
- **Detected**: 2026-09-13T11:13:06.955933+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/o2/local-state/LocalStateDemo.arc56.json) -o client.generated.ts
```

## Error

```
src/LocalStateDemo_da9241f8.ts(519,5): error TS1117: An object literal cannot have multiple properties with the same name.
src/LocalStateDemo_da9241f8.ts(607,5): error TS1117: An object literal cannot have multiple properties with the same name.
src/LocalStateDemo_da9241f8.ts(698,5): error TS1117: An object literal cannot have multiple properties with the same name.
src/LocalStateDemo_da9241f8.ts(830,7): error TS2300: Duplicate identifier 'clearState'.
src/LocalStateDemo_da9241f8.ts(863,7): error TS2300: Duplicate identifier 'clearState'.
src/LocalStateDemo_da9241f8.ts(864,68): error TS2345: Argument of type 'Promise<AppCallMethodCall>' is not assignable to parameter of type 'AppCallParams'.
src/LocalStateDemo_da9241f8.ts(864,93): error TS2345: Argument of type '{ signer?: TransactionSigner | TransactionSignerAccount; rekeyTo?: string | Address; note?: string | Uint8Array<ArrayBufferLike>; ... 14 more ...; sender?: string | Address; }' is not assignable to parameter of type '{ signer?: TransactionSigner | TransactionSignerAccount; rekeyTo?: string | Address; note?: string | Uint8Array<ArrayBufferLike>; ... 14 more ...; args: { ...; } | []; } & { ...; }'.
```
