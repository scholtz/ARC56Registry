# Generator crash: CadenciaEscrow_08254c5a (TypeScript)

- **Repo**: [AdityaWagh19/Cadencia-A2A-Platform](https://github.com/AdityaWagh19/Cadencia-A2A-Platform)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/AdityaWagh19/Cadencia-A2A-Platform/HEAD/backend/artifacts/CadenciaEscrow.arc56.json](https://raw.githubusercontent.com/AdityaWagh19/Cadencia-A2A-Platform/HEAD/backend/artifacts/CadenciaEscrow.arc56.json)
- **Detected**: 2026-07-17T21:29:57.057653+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/AdityaWagh19/Cadencia-A2A-Platform/HEAD/backend/artifacts/CadenciaEscrow.arc56.json) -o client.generated.ts
```

## Error

```
algokit-client-generator exited with code 1
--- stdout ---
Reading application.json file from path /home/runner/work/ARC56Registry/ARC56Registry/clients/AdityaWagh19/Cadencia-A2A-Platform/arc56/CadenciaEscrow_08254c5a.arc56.json

--- stderr ---
file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2
    throw new Error(reason);
          ^

Error: Could not parse /home/runner/work/ARC56Registry/ARC56Registry/clients/AdityaWagh19/Cadencia-A2A-Platform/arc56/CadenciaEscrow_08254c5a.arc56.json as ARC-56.
0: instance.methods[0].actions.create[0] is not one of enum values: DeleteApplication,NoOp,OptIn
1: instance.methods[1].actions.call[0] is not one of enum values: ClearState,CloseOut,DeleteApplication,NoOp,OptIn,UpdateApplication
2: instance.methods[2].actions.call[0] is not one of enum values: ClearState,CloseOut,DeleteApplication,NoOp,OptIn,UpdateApplication
3: instance.methods[3].actions.call[0] is not one of enum values: ClearState,CloseOut,DeleteApplication,NoOp,OptIn,UpdateApplication
4: instance.methods[4].actions.call[0] is not one of enum values: ClearState,CloseOut,DeleteApplication,NoOp,OptIn,UpdateApplication
5: instance.methods[5].actions.call[0] is not one of enum values: ClearState,CloseOut,DeleteApplication,NoOp,OptIn,UpdateApplication

    at boom (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2:11)
    at validateApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:38:9)
    at loadApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:19:12)
    at async generateClientCommand (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:57:18)
    at async Command.<anonymous> (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:24:9)

Node.js v20.20.2

```
