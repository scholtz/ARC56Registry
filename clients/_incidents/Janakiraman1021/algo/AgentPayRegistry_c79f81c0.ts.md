# Generator crash: AgentPayRegistry_c79f81c0 (TypeScript)

- **Repo**: [Janakiraman1021/algo](https://github.com/Janakiraman1021/algo)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Janakiraman1021/algo/HEAD/smart-contract/artifacts/AgentPayRegistry.arc56.json](https://raw.githubusercontent.com/Janakiraman1021/algo/HEAD/smart-contract/artifacts/AgentPayRegistry.arc56.json)
- **Detected**: 2026-08-24T06:56:01.416959+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Janakiraman1021/algo/HEAD/smart-contract/artifacts/AgentPayRegistry.arc56.json) -o client.generated.ts
```

## Error

```
algokit-client-generator exited with code 1
--- stdout ---
Reading application.json file from path /home/runner/work/ARC56Registry/ARC56Registry/clients/Janakiraman1021/algo/arc56/AgentPayRegistry_c79f81c0.arc56.json

--- stderr ---
file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2
    throw new Error(reason);
          ^

Error: Could not parse /home/runner/work/ARC56Registry/ARC56Registry/clients/Janakiraman1021/algo/arc56/AgentPayRegistry_c79f81c0.arc56.json as ARC-56.
0: instance.methods[0] requires property "actions"
1: instance.methods[1] requires property "actions"
2: instance.methods[2] requires property "actions"
3: instance.methods[3] requires property "actions"
4: instance.methods[4] requires property "actions"
5: instance.methods[5] requires property "actions"
6: instance.state requires property "keys"
7: instance.state requires property "maps"
8: instance.state requires property "schema"
9: instance requires property "arcs"
10: instance requires property "structs"
11: instance requires property "bareActions"

    at boom (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2:11)
    at validateApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:38:9)
    at loadApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:19:12)
    at async generateClientCommand (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:57:18)
    at async Command.<anonymous> (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:24:9)

Node.js v20.20.2

```
