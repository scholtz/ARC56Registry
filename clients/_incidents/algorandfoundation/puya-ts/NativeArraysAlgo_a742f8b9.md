# Generated code fails to compile: NativeArraysAlgo_a742f8b9

- **Repo**: [algorandfoundation/puya-ts](https://github.com/algorandfoundation/puya-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/unoptimized/native-arrays/NativeArraysAlgo.arc56.json](https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/unoptimized/native-arrays/NativeArraysAlgo.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.puya_ts.NativeArraysAlgo_a742f8b9`
- **Detected**: 2026-07-27T09:37:06.888704+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:0093cb1562e2d8125477e45e9b2045a81c983a91f38f1a2f9b738be110520613`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.puya_ts.NativeArraysAlgo_a742f8b9" \
  --url https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/unoptimized/native-arrays/NativeArraysAlgo.arc56.json
```

## Error

```
/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/puya-ts/dotnet/src/NativeArraysAlgo_a742f8b9.cs(446,45): error CS0102: The type 'NativeArraysAlgoProxy' already contains a definition for 'Structs' [/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/puya-ts/dotnet/Arc56.Generated.algorandfoundation.puya-ts.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/puya-ts/dotnet/src/NativeArraysAlgo_a742f8b9.cs(446,45): error CS0102: The type 'NativeArraysAlgoProxy' already contains a definition for 'Structs' [/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/puya-ts/dotnet/Arc56.Generated.algorandfoundation.puya-ts.csproj]
```
