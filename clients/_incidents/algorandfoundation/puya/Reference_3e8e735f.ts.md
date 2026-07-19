# Generator crash: Reference_3e8e735f (TypeScript)

- **Repo**: [algorandfoundation/puya](https://github.com/algorandfoundation/puya)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/abi_routing/out/Reference.arc56.json](https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/abi_routing/out/Reference.arc56.json)
- **Detected**: 2026-07-19T19:19:11.474207+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/abi_routing/out/Reference.arc56.json) -o client.generated.ts
```

## Error

```
algokit-client-generator exited with code 1
--- stdout ---
Reading application.json file from path /home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/puya/arc56/Reference_3e8e735f.arc56.json

--- stderr ---
file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2
    throw new Error(reason);
          ^

Error: Could not parse /home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/puya/arc56/Reference_3e8e735f.arc56.json as ARC-56.
0: instance.methods[11].args[1].defaultValue.source is not one of enum values: box,global,literal,local
1: instance.methods[11].args[3].defaultValue.source is not one of enum values: box,global,literal,local
2: instance.methods[11].args[5].defaultValue.source is not one of enum values: box,global,literal,local
3: instance.methods[11].args[8].defaultValue.source is not one of enum values: box,global,literal,local

    at boom (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2:11)
    at validateApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:38:9)
    at loadApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:19:12)
    at async generateClientCommand (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:57:18)
    at async Command.<anonymous> (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:24:9)

Node.js v20.20.2

```
