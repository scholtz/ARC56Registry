# Generator crash: C_cd67b9e6 (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/cleanup/dirty_calldata_dynamic_array/C.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/cleanup/dirty_calldata_dynamic_array/C.arc56.json)
- **Detected**: 2026-07-19T08:18:40.253392+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/cleanup/dirty_calldata_dynamic_array/C.arc56.json) -o client.generated.ts
```

## Error

```
algokit-client-generator exited with code 1
--- stdout ---
Reading application.json file from path /home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/arc56/C_cd67b9e6.arc56.json
Generating TS client for C
Writing TS client to /home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/npm/src/C_cd67b9e6.ts

--- stderr ---
file:///home/runner/.npm/_npx/7807033c42655689/node_modules/algosdk/dist/esm/abi/abi_type.js:91
        throw new Error(`cannot convert a string ${str} to an ABI type`);
              ^

Error: cannot convert a string int16 to an ABI type
    at ABIType.from (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/algosdk/dist/esm/abi/abi_type.js:91:15)
    at ABIType.from (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/algosdk/dist/esm/abi/abi_type.js:29:42)
    at file:///home/runner/.npm/_npx/7807033c42655689/node_modules/algosdk/dist/esm/abi/method.js:56:31
    at Array.map (<anonymous>)
    at new ABIMethod (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/algosdk/dist/esm/abi/method.js:47:33)
    at getCallConfigSummary (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/client/helpers/get-call-config-summary.mjs:19:37)
    at createGeneratorContext (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/client/generator-context.mjs:16:21)
    at generate (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/client/generate.mjs:66:17)
    at generate.next (<anonymous>)
    at writeDocumentPartsTo (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/output/writer.mjs:96:16)

Node.js v20.20.2

```
