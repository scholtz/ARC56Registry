# Generator crash: application_4e04370a (TypeScript)

- **Repo**: [algorandecosystem/algokit-core](https://github.com/algorandecosystem/algokit-core)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandecosystem/algokit-core/HEAD/crates/algokit_test_artifacts/contracts/testing_app/application.arc56.json](https://raw.githubusercontent.com/algorandecosystem/algokit-core/HEAD/crates/algokit_test_artifacts/contracts/testing_app/application.arc56.json)
- **Detected**: 2026-07-18T08:31:29.038803+00:00
- **Generator package**: `@algorandfoundation/algokit-client-generator@6.0.1`

## Reproduce

```bash
npx --yes @algorandfoundation/algokit-client-generator generate \
  -a <(curl -sL https://raw.githubusercontent.com/algorandecosystem/algokit-core/HEAD/crates/algokit_test_artifacts/contracts/testing_app/application.arc56.json) -o client.generated.ts
```

## Error

```
algokit-client-generator exited with code 1
--- stdout ---
Reading application.json file from path /home/runner/work/ARC56Registry/ARC56Registry/clients/algorandecosystem/algokit-core/arc56/application_4e04370a.arc56.json

--- stderr ---
file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2
    throw new Error(reason);
          ^

Error: Could not parse /home/runner/work/ARC56Registry/ARC56Registry/clients/algorandecosystem/algokit-core/arc56/application_4e04370a.arc56.json as ARC-56.
0: instance.methods[12].args[0].defaultValue.source is not one of enum values: box,global,literal,local

    at boom (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/util/boom.mjs:2:11)
    at validateApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:38:9)
    at loadApplicationJson (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/schema/load.mjs:19:12)
    at async generateClientCommand (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:57:18)
    at async Command.<anonymous> (file:///home/runner/.npm/_npx/7807033c42655689/node_modules/@algorandfoundation/algokit-client-generator/cli.mjs:24:9)

Node.js v20.20.2

```
