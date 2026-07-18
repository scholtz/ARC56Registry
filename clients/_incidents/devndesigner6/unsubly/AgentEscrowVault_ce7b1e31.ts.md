# Generator crash: AgentEscrowVault_ce7b1e31 (TypeScript)

- **Repo**: [devndesigner6/unsubly](https://github.com/devndesigner6/unsubly)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/devndesigner6/unsubly/HEAD/smart_contracts/artifacts/AgentEscrowVault/AgentEscrowVault.arc56.json](https://raw.githubusercontent.com/devndesigner6/unsubly/HEAD/smart_contracts/artifacts/AgentEscrowVault/AgentEscrowVault.arc56.json)
- **Detected**: 2026-07-18T08:48:59.047808+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/devndesigner6/unsubly/HEAD/smart_contracts/artifacts/AgentEscrowVault/AgentEscrowVault.arc56.json) -o client.generated.ts
```

## Error

```
algokit-client-generator exited with code 1
--- stdout ---
Reading application.json file from path /home/runner/work/ARC56Registry/ARC56Registry/clients/devndesigner6/unsubly/arc56/AgentEscrowVault_ce7b1e31.arc56.json

--- stderr ---
file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2
    throw new Error(reason);
          ^

Error: Could not parse /home/runner/work/ARC56Registry/ARC56Registry/clients/devndesigner6/unsubly/arc56/AgentEscrowVault_ce7b1e31.arc56.json as ARC-56.
0: instance.compilerInfo.compiler is not one of enum values: algod,puya
1: instance.compilerInfo.compilerVersion is not of a type(s) object
2: instance.methods[0] requires property "actions"
3: instance.methods[1] requires property "actions"
4: instance.methods[2] requires property "actions"
5: instance.methods[3] requires property "actions"
6: instance.structs is not of a type(s) object

    at boom (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2:11)
    at validateApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:38:9)
    at loadApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:19:12)
    at async generateClientCommand (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:57:18)
    at async Command.<anonymous> (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:24:9)

Node.js v20.20.2

```
