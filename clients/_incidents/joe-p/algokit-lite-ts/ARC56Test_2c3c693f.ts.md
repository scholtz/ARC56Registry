# Generator crash: ARC56Test_2c3c693f (TypeScript)

- **Repo**: [joe-p/algokit-lite-ts](https://github.com/joe-p/algokit-lite-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/joe-p/algokit-lite-ts/HEAD/__test__/fixtures/ARC56Test.arc56.json](https://raw.githubusercontent.com/joe-p/algokit-lite-ts/HEAD/__test__/fixtures/ARC56Test.arc56.json)
- **Detected**: 2026-09-07T11:39:18.054102+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/joe-p/algokit-lite-ts/HEAD/__test__/fixtures/ARC56Test.arc56.json) -o client.generated.ts
```

## Error

```
algokit-client-generator exited with code 1
--- stdout ---
Reading application.json file from path /home/runner/work/ARC56Registry/ARC56Registry/clients/joe-p/algokit-lite-ts/arc56/ARC56Test_2c3c693f.arc56.json

--- stderr ---
file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2
    throw new Error(reason);
          ^

Error: Could not parse /home/runner/work/ARC56Registry/ARC56Registry/clients/joe-p/algokit-lite-ts/arc56/ARC56Test_2c3c693f.arc56.json as ARC-56.
0: instance.sourceInfo is not of a type(s) object
1: instance.structs["{ foo: uint16; bar: uint16 }"] is not of a type(s) array
2: instance.structs.Outputs is not of a type(s) array
3: instance.structs.Inputs is not of a type(s) array

    at boom (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2:11)
    at validateApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:38:9)
    at loadApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:19:12)
    at async generateClientCommand (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:57:18)
    at async Command.<anonymous> (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:24:9)

Node.js v20.20.2

```
