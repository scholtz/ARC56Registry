# Generated code fails to compile: SavingsVault_0ac1d6f6 (TypeScript)

- **Repo**: [charmi-reddy/Fortuna](https://github.com/charmi-reddy/Fortuna)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/charmi-reddy/Fortuna/HEAD/backend/savings_vault/smart_contracts/artifacts/savings_vault/SavingsVault.arc56.json](https://raw.githubusercontent.com/charmi-reddy/Fortuna/HEAD/backend/savings_vault/smart_contracts/artifacts/savings_vault/SavingsVault.arc56.json)
- **Detected**: 2026-07-19T08:53:03.949076+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/charmi-reddy/Fortuna/HEAD/backend/savings_vault/smart_contracts/artifacts/savings_vault/SavingsVault.arc56.json) -o client.generated.ts
```

## Error

```
src/SavingsVault_0ac1d6f6.ts(182,14): error TS2300: Duplicate identifier 'optIn'.
src/SavingsVault_0ac1d6f6.ts(206,10): error TS2300: Duplicate identifier 'optIn'.
src/SavingsVault_0ac1d6f6.ts(365,5): error TS1117: An object literal cannot have multiple properties with the same name.
src/SavingsVault_0ac1d6f6.ts(366,67): error TS2349: This expression is not callable.
src/SavingsVault_0ac1d6f6.ts(437,5): error TS1117: An object literal cannot have multiple properties with the same name.
src/SavingsVault_0ac1d6f6.ts(438,78): error TS2349: This expression is not callable.
src/SavingsVault_0ac1d6f6.ts(510,5): error TS1117: An object literal cannot have multiple properties with the same name.
src/SavingsVault_0ac1d6f6.ts(511,79): error TS2349: This expression is not callable.
src/SavingsVault_0ac1d6f6.ts(601,7): error TS2300: Duplicate identifier 'optIn'.
src/SavingsVault_0ac1d6f6.ts(630,11): error TS1119: An object literal cannot have property and accessor with the same name.
src/SavingsVault_0ac1d6f6.ts(630,11): error TS2300: Duplicate identifier 'optIn'.
src/SavingsVault_0ac1d6f6.ts(633,114): error TS2339: Property 'optIn' does not exist on type '(params?: { sender?: string | Address; signer?: TransactionSigner | TransactionSignerAccount; rekeyTo?: string | Address; ... 14 more ...; args: [] | { ...; }; } & { ...; }) => Promise<...>'.
src/SavingsVault_0ac1d6f6.ts(713,12): error TS2687: All declarations of 'optIn' must have identical modifiers.
src/SavingsVault_0ac1d6f6.ts(713,12): error TS2717: Subsequent property declarations must have the same type.  Property 'optIn' must be of type '(params?: { sender?: string | Address; signer?: TransactionSigner | TransactionSignerAccount; rekeyTo?: string | Address; ... 14 more ...; args: [] | { ...; }; }) => SavingsVaultComposer<...>', but here has type '{ optIn(params?: { sender?: string | Address; signer?: TransactionSigner | TransactionSignerAccount; rekeyTo?: string | Address; ... 14 more ...; args: [] | { ...; }; }): SavingsVaultComposer<...>; }'.
```
