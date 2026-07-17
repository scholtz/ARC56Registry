# Generated code fails to compile: state_9aa83f49

- **Repo**: [algorandecosystem/algokit-core](https://github.com/algorandecosystem/algokit-core)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandecosystem/algokit-core/HEAD/crates/algokit_test_artifacts/contracts/state_contract/state.arc56.json](https://raw.githubusercontent.com/algorandecosystem/algokit-core/HEAD/crates/algokit_test_artifacts/contracts/state_contract/state.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandecosystem.algokit_core.state_9aa83f49`
- **Detected**: 2026-07-17T05:58:59.615283+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandecosystem.algokit_core.state_9aa83f49" \
  --url https://raw.githubusercontent.com/algorandecosystem/algokit-core/HEAD/crates/algokit_test_artifacts/contracts/state_contract/state.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\algorandecosystem\algokit-core\src\state_9aa83f49.cs(702,43): error CS0102: The type 'StateProxy' already contains a definition for 'Structs' [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\algorandecosystem\algokit-core\Arc56.Generated.algorandecosystem.algokit-core.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\algorandecosystem\algokit-core\src\state_9aa83f49.cs(702,43): error CS0102: The type 'StateProxy' already contains a definition for 'Structs' [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\algorandecosystem\algokit-core\Arc56.Generated.algorandecosystem.algokit-core.csproj]
```
