# Generated code fails to compile: State_77bbdb76

- **Repo**: [joe-p/algokit-monorepo-ts](https://github.com/joe-p/algokit-monorepo-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/joe-p/algokit-monorepo-ts/HEAD/algokit-utils-ts/tests/example-contracts/state/State.arc56.json](https://raw.githubusercontent.com/joe-p/algokit-monorepo-ts/HEAD/algokit-utils-ts/tests/example-contracts/state/State.arc56.json)
- **Namespace used**: `Arc56.Generated.joe_p.algokit_monorepo_ts.State_77bbdb76`
- **Detected**: 2026-10-16T10:24:50.356288+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:88c68c0274a5913ccebbf6dccbb503ed2caada80abbd41dbe4ecb7d267aa84c5`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.joe_p.algokit_monorepo_ts.State_77bbdb76" \
  --url https://raw.githubusercontent.com/joe-p/algokit-monorepo-ts/HEAD/algokit-utils-ts/tests/example-contracts/state/State.arc56.json
```

## Error

```
/home/runner/work/ARC56Registry/ARC56Registry/clients/joe-p/algokit-monorepo-ts/dotnet/src/State_77bbdb76.cs(836,43): error CS0102: The type 'StateProxy' already contains a definition for 'Structs' [/home/runner/work/ARC56Registry/ARC56Registry/clients/joe-p/algokit-monorepo-ts/dotnet/Arc56.Generated.joe-p.algokit-monorepo-ts.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/joe-p/algokit-monorepo-ts/dotnet/src/State_77bbdb76.cs(836,43): error CS0102: The type 'StateProxy' already contains a definition for 'Structs' [/home/runner/work/ARC56Registry/ARC56Registry/clients/joe-p/algokit-monorepo-ts/dotnet/Arc56.Generated.joe-p.algokit-monorepo-ts.csproj]
```
