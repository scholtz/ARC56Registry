# Generator crash: CancellationInsurance_4f7185f4 (TypeScript)

- **Repo**: [devndesigner6/unsubly](https://github.com/devndesigner6/unsubly)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/devndesigner6/unsubly/HEAD/smart_contracts/artifacts/CancellationInsurance/CancellationInsurance.arc56.json](https://raw.githubusercontent.com/devndesigner6/unsubly/HEAD/smart_contracts/artifacts/CancellationInsurance/CancellationInsurance.arc56.json)
- **Detected**: 2026-07-18T08:49:01.155284+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/devndesigner6/unsubly/HEAD/smart_contracts/artifacts/CancellationInsurance/CancellationInsurance.arc56.json) -o client.generated.ts
```

## Error

```
algokit-client-generator exited with code 1
--- stdout ---
Reading application.json file from path /home/runner/work/ARC56Registry/ARC56Registry/clients/devndesigner6/unsubly/arc56/CancellationInsurance_4f7185f4.arc56.json

--- stderr ---
file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2
    throw new Error(reason);
          ^

Error: Could not parse /home/runner/work/ARC56Registry/ARC56Registry/clients/devndesigner6/unsubly/arc56/CancellationInsurance_4f7185f4.arc56.json as ARC-56.
0: instance.methods[1] requires property "actions"
1: instance.methods[2] requires property "actions"
2: instance.methods[3] requires property "actions"
3: instance.methods[4] requires property "actions"
4: instance.methods[5] requires property "actions"
5: instance.state.keys.global.creator requires property "key"
6: instance.state.keys.global.creator requires property "keyType"
7: instance.state.keys.global.creator requires property "valueType"
8: instance.state.keys.global.recipient requires property "key"
9: instance.state.keys.global.recipient requires property "keyType"
10: instance.state.keys.global.recipient requires property "valueType"
11: instance.state.keys.global.agent requires property "key"
12: instance.state.keys.global.agent requires property "keyType"
13: instance.state.keys.global.agent requires property "valueType"
14: instance.state.keys.global.billing_date requires property "key"
15: instance.state.keys.global.billing_date requires property "keyType"
16: instance.state.keys.global.billing_date requires property "valueType"
17: instance.state.keys.global.proof_hash requires property "key"
18: instance.state.keys.global.proof_hash requires property "keyType"
19: instance.state.keys.global.proof_hash requires property "valueType"
20: instance.state.keys.global.status requires property "key"
21: instance.state.keys.global.status requires property "keyType"
22: instance.state.keys.global.status requires property "valueType"
23: instance.state.keys requires property "box"
24: instance.state.keys requires property "local"
25: instance.state requires property "maps"
26: instance requires property "arcs"
27: instance requires property "bareActions"

    at boom (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2:11)
    at validateApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:38:9)
    at loadApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:19:12)
    at async generateClientCommand (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:57:18)
    at async Command.<anonymous> (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:24:9)

Node.js v20.20.2

```
