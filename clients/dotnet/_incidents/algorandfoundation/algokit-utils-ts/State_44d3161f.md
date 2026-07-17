# Generated code fails to compile: State_44d3161f

- **Repo**: [algorandfoundation/algokit-utils-ts](https://github.com/algorandfoundation/algokit-utils-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/algokit-utils-ts/HEAD/tests/example-contracts/state/State.arc56.json](https://raw.githubusercontent.com/algorandfoundation/algokit-utils-ts/HEAD/tests/example-contracts/state/State.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.algokit_utils_ts.State_44d3161f`
- **Detected**: 2026-07-17T06:27:39.024859+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.algokit_utils_ts.State_44d3161f" \
  --url https://raw.githubusercontent.com/algorandfoundation/algokit-utils-ts/HEAD/tests/example-contracts/state/State.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\algorandfoundation\algokit-utils-ts\src\State_44d3161f.cs(836,43): error CS0102: The type 'StateProxy' already contains a definition for 'Structs' [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\algorandfoundation\algokit-utils-ts\Arc56.Generated.algorandfoundation.algokit-utils-ts.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\algorandfoundation\algokit-utils-ts\src\State_44d3161f.cs(836,43): error CS0102: The type 'StateProxy' already contains a definition for 'Structs' [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\algorandfoundation\algokit-utils-ts\Arc56.Generated.algorandfoundation.algokit-utils-ts.csproj]
```
