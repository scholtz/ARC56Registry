# Generator crash: Arc56Test_ab61f4ea

- **Repo**: [algorandfoundation/algokit-client-generator-ts](https://github.com/algorandfoundation/algokit-client-generator-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/algokit-client-generator-ts/HEAD/examples/smart_contracts/artifacts/arc56_test/Arc56Test.arc56.json](https://raw.githubusercontent.com/algorandfoundation/algokit-client-generator-ts/HEAD/examples/smart_contracts/artifacts/arc56_test/Arc56Test.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.algokit_client_generator_ts.Arc56Test_ab61f4ea`
- **Detected**: 2026-10-20T11:02:13.368173+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:f7aaa620d62a7a766c9f2ae99d41d7ac7dc6f7d76fecd4ebd66d057e930a575d`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.algokit_client_generator_ts.Arc56Test_ab61f4ea" \
  --url https://raw.githubusercontent.com/algorandfoundation/algokit-client-generator-ts/HEAD/examples/smart_contracts/artifacts/arc56_test/Arc56Test.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/Arc56Test_ab61f4ea.arc56.json
Namespace: Arc56.Generated.algorandfoundation.algokit_client_generator_ts.Arc56Test_ab61f4ea

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: [. Path 'structs.Inputs[0].type', line 80, position 25.

```
