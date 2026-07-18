# Generator crash: vault_f0b47496 (TypeScript)

- **Repo**: [manuelmauro/algonaut](https://github.com/manuelmauro/algonaut)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/manuelmauro/algonaut/HEAD/tests/fixtures/vault.arc56.json](https://raw.githubusercontent.com/manuelmauro/algonaut/HEAD/tests/fixtures/vault.arc56.json)
- **Detected**: 2026-07-18T08:55:58.921899+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/manuelmauro/algonaut/HEAD/tests/fixtures/vault.arc56.json) -o client.generated.ts
```

## Error

```
algokit-client-generator exited with code 1
--- stdout ---
Reading application.json file from path /home/runner/work/ARC56Registry/ARC56Registry/clients/manuelmauro/algonaut/arc56/vault_f0b47496.arc56.json

--- stderr ---
file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2
    throw new Error(reason);
          ^

Error: Could not parse /home/runner/work/ARC56Registry/ARC56Registry/clients/manuelmauro/algonaut/arc56/vault_f0b47496.arc56.json as ARC-56.
0: instance.methods[0] requires property "actions"
1: instance.methods[1] requires property "actions"
2: instance.methods[2] requires property "actions"
3: instance.methods[3] requires property "actions"
4: instance.methods[4] requires property "actions"
5: instance.methods[6] requires property "actions"
6: instance.methods[7] requires property "actions"
7: instance.methods[8] requires property "actions"
8: instance.methods[9] requires property "actions"
9: instance.methods[10] requires property "actions"
10: instance.methods[11] requires property "actions"
11: instance.methods[12] requires property "actions"
12: instance.methods[13] requires property "actions"
13: instance requires property "bareActions"

    at boom (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2:11)
    at validateApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:38:9)
    at loadApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:19:12)
    at async generateClientCommand (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:57:18)
    at async Command.<anonymous> (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:24:9)

Node.js v20.20.2

```
