# Generated code fails to compile: State_c2455e02

- **Repo**: [algorandfoundation/algokit-ts](https://github.com/algorandfoundation/algokit-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/algokit-ts/HEAD/algokit-utils-ts/tests/example-contracts/state/State.arc56.json](https://raw.githubusercontent.com/algorandfoundation/algokit-ts/HEAD/algokit-utils-ts/tests/example-contracts/state/State.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.algokit_ts.State_c2455e02`
- **Detected**: 2026-10-30T11:55:23.673236+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:4c7f0b02126c7a2565338efea6e3a214b086d319bc88c43d227a9fc55b907289`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.algokit_ts.State_c2455e02" \
  --url https://raw.githubusercontent.com/algorandfoundation/algokit-ts/HEAD/algokit-utils-ts/tests/example-contracts/state/State.arc56.json
```

## Error

```
/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/algokit-ts/dotnet/src/State_c2455e02.cs(836,43): error CS0102: The type 'StateProxy' already contains a definition for 'Structs' [/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/algokit-ts/dotnet/Arc56.Generated.algorandfoundation.algokit-ts.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/algokit-ts/dotnet/src/State_c2455e02.cs(836,43): error CS0102: The type 'StateProxy' already contains a definition for 'Structs' [/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/algokit-ts/dotnet/Arc56.Generated.algorandfoundation.algokit-ts.csproj]
```
