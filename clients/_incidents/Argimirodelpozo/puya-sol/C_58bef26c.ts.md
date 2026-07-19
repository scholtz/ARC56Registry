# Generated code fails to compile: C_58bef26c (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/smoke/constructor/C.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/smoke/constructor/C.arc56.json)
- **Detected**: 2026-07-19T19:03:43.054848+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/smoke/constructor/C.arc56.json) -o client.generated.ts
```

## Error

```
src/C_58bef26c.ts(469,3): error TS2300: Duplicate identifier 'state'.
src/C_58bef26c.ts(469,3): error TS2687: All declarations of 'state' must have identical modifiers.
src/C_58bef26c.ts(469,3): error TS2717: Subsequent property declarations must have the same type.  Property 'state' must be of type '(params?: { sender?: string | Address; signer?: TransactionSigner | TransactionSignerAccount; rekeyTo?: string | Address; ... 14 more ...; args: [] | { ...; }; }) => Promise<...>', but here has type '{ global: { getAll: () => Promise<Partial<{ state: BinaryState; }>>; state: () => Promise<BinaryState>; }; }'.
```
