# Generator crash: SpokeInstance__chunk_5_33245221 (TypeScript)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/SpokeInstance/__uros_split/chunk_5/SpokeInstance__chunk_5.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/SpokeInstance/__uros_split/chunk_5/SpokeInstance__chunk_5.arc56.json)
- **Detected**: 2026-07-18T08:07:52.281023+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/SpokeInstance/__uros_split/chunk_5/SpokeInstance__chunk_5.arc56.json) -o client.generated.ts
```

## Error

```
algokit-client-generator exited with code 1
--- stdout ---
Reading application.json file from path /home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/arc56/SpokeInstance__chunk_5_33245221.arc56.json
Generating TS client for SpokeInstance__chunk_5
Writing TS client to /home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/npm/src/SpokeInstance__chunk_5_33245221.ts

--- stderr ---
file:///home/runner/.npm/_npx/7807033c42655689/node_modules/algosdk/dist/esm/abi/abi_type.js:91
        throw new Error(`cannot convert a string ${str} to an ABI type`);
              ^

Error: cannot convert a string int200 to an ABI type
    at ABIType.from (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/algosdk/dist/esm/abi/abi_type.js:91:15)
    at ABIType.from (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/algosdk/dist/esm/abi/abi_type.js:86:36)
    at new ABIMethod (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/algosdk/dist/esm/abi/method.js:64:27)
    at getCallConfigSummary (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/client/helpers/get-call-config-summary.mjs:19:37)
    at createGeneratorContext (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/client/generator-context.mjs:16:21)
    at generate (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/client/generate.mjs:66:17)
    at generate.next (<anonymous>)
    at writeDocumentPartsTo (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/output/writer.mjs:96:16)
    at writeDocumentPartsToStream (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/output/writer.mjs:20:5)
    at generateClientCommand (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:66:5)

Node.js v20.20.2

```
