# Generator crash: Arc56Test_9d89aae1

- **Repo**: [algorandfoundation/algokit-ts](https://github.com/algorandfoundation/algokit-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/algokit-ts/HEAD/algokit-client-generator-ts/examples/smart_contracts/artifacts/arc56_test/Arc56Test.arc56.json](https://raw.githubusercontent.com/algorandfoundation/algokit-ts/HEAD/algokit-client-generator-ts/examples/smart_contracts/artifacts/arc56_test/Arc56Test.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.algokit_ts.Arc56Test_9d89aae1`
- **Detected**: 2026-10-30T11:54:56.147203+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:4c7f0b02126c7a2565338efea6e3a214b086d319bc88c43d227a9fc55b907289`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.algokit_ts.Arc56Test_9d89aae1" \
  --url https://raw.githubusercontent.com/algorandfoundation/algokit-ts/HEAD/algokit-client-generator-ts/examples/smart_contracts/artifacts/arc56_test/Arc56Test.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/Arc56Test_9d89aae1.arc56.json
Namespace: Arc56.Generated.algorandfoundation.algokit_ts.Arc56Test_9d89aae1

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: [. Path 'structs.Inputs[0].type', line 80, position 25.

```
