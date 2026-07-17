# Generated code fails to compile: State_aa78165e

- **Repo**: [mrcointreau/algokit-utils-luca-py](https://github.com/mrcointreau/algokit-utils-luca-py)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/mrcointreau/algokit-utils-luca-py/HEAD/tests/artifacts/state_contract/State.arc56.json](https://raw.githubusercontent.com/mrcointreau/algokit-utils-luca-py/HEAD/tests/artifacts/state_contract/State.arc56.json)
- **Namespace used**: `Arc56.Generated.mrcointreau.algokit_utils_luca_py.State_aa78165e`
- **Detected**: 2026-07-17T08:30:09.292450+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.mrcointreau.algokit_utils_luca_py.State_aa78165e" \
  --url https://raw.githubusercontent.com/mrcointreau/algokit-utils-luca-py/HEAD/tests/artifacts/state_contract/State.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\mrcointreau\algokit-utils-luca-py\src\State_aa78165e.cs(702,43): error CS0102: The type 'StateProxy' already contains a definition for 'Structs' [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\mrcointreau\algokit-utils-luca-py\Arc56.Generated.mrcointreau.algokit-utils-luca-py.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\mrcointreau\algokit-utils-luca-py\src\State_aa78165e.cs(702,43): error CS0102: The type 'StateProxy' already contains a definition for 'Structs' [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\mrcointreau\algokit-utils-luca-py\Arc56.Generated.mrcointreau.algokit-utils-luca-py.csproj]
```
