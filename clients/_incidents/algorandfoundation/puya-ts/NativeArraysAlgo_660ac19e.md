# Generated code fails to compile: NativeArraysAlgo_660ac19e

- **Repo**: [algorandfoundation/puya-ts](https://github.com/algorandfoundation/puya-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/o1/native-arrays/NativeArraysAlgo.arc56.json](https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/o1/native-arrays/NativeArraysAlgo.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.puya_ts.NativeArraysAlgo_660ac19e`
- **Detected**: 2026-09-13T10:59:25.928840+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:373d3f7fe96a2c2c9e361a9c88d822321296511aadc0ad91910dd26077078f37`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.puya_ts.NativeArraysAlgo_660ac19e" \
  --url https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/o1/native-arrays/NativeArraysAlgo.arc56.json
```

## Error

```
/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/puya-ts/dotnet/src/NativeArraysAlgo_660ac19e.cs(446,45): error CS0102: The type 'NativeArraysAlgoProxy' already contains a definition for 'Structs' [/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/puya-ts/dotnet/Arc56.Generated.algorandfoundation.puya-ts.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/puya-ts/dotnet/src/NativeArraysAlgo_660ac19e.cs(446,45): error CS0102: The type 'NativeArraysAlgoProxy' already contains a definition for 'Structs' [/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/puya-ts/dotnet/Arc56.Generated.algorandfoundation.puya-ts.csproj]
```
