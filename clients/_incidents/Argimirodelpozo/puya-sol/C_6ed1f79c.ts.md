# Generator crash: C_6ed1f79c (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/builtinFunctions/erc7201_equivalent_solidity_spec_comptime/C.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/builtinFunctions/erc7201_equivalent_solidity_spec_comptime/C.arc56.json)
- **Detected**: 2026-07-19T08:17:51.728178+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/builtinFunctions/erc7201_equivalent_solidity_spec_comptime/C.arc56.json) -o client.generated.ts
```

## Error

```
algokit-client-generator exited with code 1
--- stdout ---
Reading application.json file from path /home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/arc56/C_6ed1f79c.arc56.json
Generating TS client for C
Writing TS client to /home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/npm/src/C_6ed1f79c.ts

--- stderr ---
file:///home/runner/.npm/_npx/7807033c42655689/node_modules/algosdk/dist/esm/abi/abi_type.js:42
                throw new Error(`array length exceeds limit ${MAX_LEN}`);
                      ^

Error: array length exceeds limit 65535
    at ABIType.from (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/algosdk/dist/esm/abi/abi_type.js:42:23)
    at getEquivalentType (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/client/helpers/get-equivalent-type.mjs:31:29)
    at keysAndMaps (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/client/app-types.mjs:228:82)
    at keysAndMaps.next (<anonymous>)
    at appState (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/client/app-types.mjs:273:20)
    at appState.next (<anonymous>)
    at appTypes (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/client/app-types.mjs:106:12)
    at appTypes.next (<anonymous>)
    at generate (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/client/generate.mjs:81:12)
    at generate.next (<anonymous>)

Node.js v20.20.2

```
