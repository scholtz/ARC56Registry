# Generated code fails to compile: NativeArraysAlgo_660ac19e

- **Repo**: [algorandfoundation/puya-ts](https://github.com/algorandfoundation/puya-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/o1/native-arrays/NativeArraysAlgo.arc56.json](https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/o1/native-arrays/NativeArraysAlgo.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.puya_ts.NativeArraysAlgo_660ac19e`
- **Detected**: 2026-07-17T07:36:41.959424+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.puya_ts.NativeArraysAlgo_660ac19e" \
  --url https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/o1/native-arrays/NativeArraysAlgo.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\algorandfoundation\puya-ts\src\NativeArraysAlgo_660ac19e.cs(446,45): error CS0102: The type 'NativeArraysAlgoProxy' already contains a definition for 'Structs' [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\algorandfoundation\puya-ts\Arc56.Generated.algorandfoundation.puya-ts.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\algorandfoundation\puya-ts\src\NativeArraysAlgo_660ac19e.cs(446,45): error CS0102: The type 'NativeArraysAlgoProxy' already contains a definition for 'Structs' [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\algorandfoundation\puya-ts\Arc56.Generated.algorandfoundation.puya-ts.csproj]
```
