# Generated code fails to compile: State_af18f32b

- **Repo**: [algorandfoundation/algokit-client-generator-py](https://github.com/algorandfoundation/algokit-client-generator-py)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/algokit-client-generator-py/HEAD/examples/smart_contracts/artifacts/state/State.arc56.json](https://raw.githubusercontent.com/algorandfoundation/algokit-client-generator-py/HEAD/examples/smart_contracts/artifacts/state/State.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.algokit_client_generator_py.State_af18f32b`
- **Detected**: 2026-08-07T07:02:31.401139+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:508821bfbb37c3c0d4d6f2867be89c794b766971b607e9ee5b39cde816fbb352`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.algokit_client_generator_py.State_af18f32b" \
  --url https://raw.githubusercontent.com/algorandfoundation/algokit-client-generator-py/HEAD/examples/smart_contracts/artifacts/state/State.arc56.json
```

## Error

```
/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/algokit-client-generator-py/dotnet/src/State_af18f32b.cs(702,43): error CS0102: The type 'StateProxy' already contains a definition for 'Structs' [/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/algokit-client-generator-py/dotnet/Arc56.Generated.algorandfoundation.algokit-client-generator-py.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/algokit-client-generator-py/dotnet/src/State_af18f32b.cs(702,43): error CS0102: The type 'StateProxy' already contains a definition for 'Structs' [/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/algokit-client-generator-py/dotnet/Arc56.Generated.algorandfoundation.algokit-client-generator-py.csproj]
```
