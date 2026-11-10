# Generated code fails to compile: State_330b6e2b

- **Repo**: [joe-p/algokit-py](https://github.com/joe-p/algokit-py)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/joe-p/algokit-py/HEAD/algokit-utils-py/tests/artifacts/state_contract/State.arc56.json](https://raw.githubusercontent.com/joe-p/algokit-py/HEAD/algokit-utils-py/tests/artifacts/state_contract/State.arc56.json)
- **Namespace used**: `Arc56.Generated.joe_p.algokit_py.State_330b6e2b`
- **Detected**: 2026-11-10T14:00:40.574266+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:4c7f0b02126c7a2565338efea6e3a214b086d319bc88c43d227a9fc55b907289`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.joe_p.algokit_py.State_330b6e2b" \
  --url https://raw.githubusercontent.com/joe-p/algokit-py/HEAD/algokit-utils-py/tests/artifacts/state_contract/State.arc56.json
```

## Error

```
/home/runner/work/ARC56Registry/ARC56Registry/clients/joe-p/algokit-py/dotnet/src/State_330b6e2b.cs(702,43): error CS0102: The type 'StateProxy' already contains a definition for 'Structs' [/home/runner/work/ARC56Registry/ARC56Registry/clients/joe-p/algokit-py/dotnet/Arc56.Generated.joe-p.algokit-py.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/joe-p/algokit-py/dotnet/src/State_330b6e2b.cs(702,43): error CS0102: The type 'StateProxy' already contains a definition for 'Structs' [/home/runner/work/ARC56Registry/ARC56Registry/clients/joe-p/algokit-py/dotnet/Arc56.Generated.joe-p.algokit-py.csproj]
```
