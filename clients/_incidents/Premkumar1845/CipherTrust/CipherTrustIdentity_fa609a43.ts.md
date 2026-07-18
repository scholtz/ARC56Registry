# Generator crash: CipherTrustIdentity_fa609a43 (TypeScript)

- **Repo**: [Premkumar1845/CipherTrust](https://github.com/Premkumar1845/CipherTrust)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Premkumar1845/CipherTrust/HEAD/contracts/arc56/CipherTrustIdentity.arc56.json](https://raw.githubusercontent.com/Premkumar1845/CipherTrust/HEAD/contracts/arc56/CipherTrustIdentity.arc56.json)
- **Detected**: 2026-07-18T08:23:31.949275+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/Premkumar1845/CipherTrust/HEAD/contracts/arc56/CipherTrustIdentity.arc56.json) -o client.generated.ts
```

## Error

```
algokit-client-generator exited with code 1
--- stdout ---
Reading application.json file from path /home/runner/work/ARC56Registry/ARC56Registry/clients/Premkumar1845/CipherTrust/arc56/CipherTrustIdentity_fa609a43.arc56.json

--- stderr ---
file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2
    throw new Error(reason);
          ^

Error: Could not parse /home/runner/work/ARC56Registry/ARC56Registry/clients/Premkumar1845/CipherTrust/arc56/CipherTrustIdentity_fa609a43.arc56.json as ARC-56.
0: instance.compilerInfo.compiler is not one of enum values: algod,puya
1: instance.methods[0] requires property "actions"
2: instance.methods[1] requires property "actions"
3: instance.methods[2] requires property "actions"
4: instance.methods[3] requires property "actions"
5: instance.methods[4] requires property "actions"
6: instance.networks.testnet requires property "appID"
7: instance.networks.mainnet requires property "appID"
8: instance.sourceInfo.approval requires property "pcOffsetMethod"
9: instance.sourceInfo.clear requires property "pcOffsetMethod"
10: instance.state.keys.box.org_registry requires property "key"
11: instance.state requires property "maps"

    at boom (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2:11)
    at validateApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:38:9)
    at loadApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:19:12)
    at async generateClientCommand (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:57:18)
    at async Command.<anonymous> (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:24:9)

Node.js v20.20.2

```
