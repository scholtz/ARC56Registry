# Generated code fails to compile: State_af18f32b

- **Repo**: [algorandfoundation/algokit-client-generator-py](https://github.com/algorandfoundation/algokit-client-generator-py)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/algokit-client-generator-py/HEAD/examples/smart_contracts/artifacts/state/State.arc56.json](https://raw.githubusercontent.com/algorandfoundation/algokit-client-generator-py/HEAD/examples/smart_contracts/artifacts/state/State.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.algokit_client_generator_py.State_af18f32b`
- **Detected**: 2026-07-17T06:24:01.918021+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.algokit_client_generator_py.State_af18f32b" \
  --url https://raw.githubusercontent.com/algorandfoundation/algokit-client-generator-py/HEAD/examples/smart_contracts/artifacts/state/State.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\algorandfoundation\algokit-client-generator-py\src\State_af18f32b.cs(684,43): error CS0102: The type 'StateProxy' already contains a definition for 'Structs' [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\algorandfoundation\algokit-client-generator-py\Arc56.Generated.algorandfoundation.algokit-client-generator-py.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\algorandfoundation\algokit-client-generator-py\src\State_af18f32b.cs(684,43): error CS0102: The type 'StateProxy' already contains a definition for 'Structs' [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\algorandfoundation\algokit-client-generator-py\Arc56.Generated.algorandfoundation.algokit-client-generator-py.csproj]
```
