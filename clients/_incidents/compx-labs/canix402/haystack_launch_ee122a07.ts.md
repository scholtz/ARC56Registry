# Generator crash: haystack_launch_ee122a07 (TypeScript)

- **Repo**: [compx-labs/canix402](https://github.com/compx-labs/canix402)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/compx-labs/canix402/HEAD/protocol/src/haystack-launch.arc56.json](https://raw.githubusercontent.com/compx-labs/canix402/HEAD/protocol/src/haystack-launch.arc56.json)
- **Detected**: 2026-10-06T12:48:02.500873+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/compx-labs/canix402/HEAD/protocol/src/haystack-launch.arc56.json) -o client.generated.ts
```

## Error

```
algokit-client-generator exited with code 1
--- stdout ---
Reading application.json file from path /home/runner/work/ARC56Registry/ARC56Registry/clients/compx-labs/canix402/arc56/haystack_launch_ee122a07.arc56.json

--- stderr ---
file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2
    throw new Error(reason);
          ^

Error: Could not parse /home/runner/work/ARC56Registry/ARC56Registry/clients/compx-labs/canix402/arc56/haystack_launch_ee122a07.arc56.json as ARC-56.
0: instance requires property "arcs"
1: instance requires property "state"
2: instance requires property "bareActions"

    at boom (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2:11)
    at validateApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:38:9)
    at loadApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:19:12)
    at async generateClientCommand (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:57:18)
    at async Command.<anonymous> (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:24:9)

Node.js v20.20.2

```
