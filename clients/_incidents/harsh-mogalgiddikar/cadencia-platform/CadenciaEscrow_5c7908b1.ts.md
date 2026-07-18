# Generator crash: CadenciaEscrow_5c7908b1 (TypeScript)

- **Repo**: [harsh-mogalgiddikar/cadencia-platform](https://github.com/harsh-mogalgiddikar/cadencia-platform)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/harsh-mogalgiddikar/cadencia-platform/HEAD/cadencia-a2a-phases/artifacts/CadenciaEscrow.arc56.json](https://raw.githubusercontent.com/harsh-mogalgiddikar/cadencia-platform/HEAD/cadencia-a2a-phases/artifacts/CadenciaEscrow.arc56.json)
- **Detected**: 2026-07-18T08:51:58.873987+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/harsh-mogalgiddikar/cadencia-platform/HEAD/cadencia-a2a-phases/artifacts/CadenciaEscrow.arc56.json) -o client.generated.ts
```

## Error

```
algokit-client-generator exited with code 1
--- stdout ---
Reading application.json file from path /home/runner/work/ARC56Registry/ARC56Registry/clients/harsh-mogalgiddikar/cadencia-platform/arc56/CadenciaEscrow_5c7908b1.arc56.json

--- stderr ---
file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2
    throw new Error(reason);
          ^

Error: Could not parse /home/runner/work/ARC56Registry/ARC56Registry/clients/harsh-mogalgiddikar/cadencia-platform/arc56/CadenciaEscrow_5c7908b1.arc56.json as ARC-56.
0: instance.methods[0].actions.create[0] is not one of enum values: DeleteApplication,NoOp,OptIn
1: instance.methods[1].actions.call[0] is not one of enum values: ClearState,CloseOut,DeleteApplication,NoOp,OptIn,UpdateApplication
2: instance.methods[2].actions.call[0] is not one of enum values: ClearState,CloseOut,DeleteApplication,NoOp,OptIn,UpdateApplication
3: instance.methods[3].actions.call[0] is not one of enum values: ClearState,CloseOut,DeleteApplication,NoOp,OptIn,UpdateApplication
4: instance.methods[4].actions.call[0] is not one of enum values: ClearState,CloseOut,DeleteApplication,NoOp,OptIn,UpdateApplication
5: instance.methods[5].actions.call[0] is not one of enum values: ClearState,CloseOut,DeleteApplication,NoOp,OptIn,UpdateApplication
6: instance.sourceInfo.approval requires property "sourceInfo"
7: instance.sourceInfo.clear requires property "sourceInfo"
8: instance requires property "structs"

    at boom (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2:11)
    at validateApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:38:9)
    at loadApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:19:12)
    at async generateClientCommand (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:57:18)
    at async Command.<anonymous> (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:24:9)

Node.js v20.20.2

```
