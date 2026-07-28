# Generated code fails to compile: GeneralTest_4f8027d2

- **Repo**: [algorandfoundation/TEALScript](https://github.com/algorandfoundation/TEALScript)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/GeneralTest.arc56.json](https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/GeneralTest.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.TEALScript.GeneralTest_4f8027d2`
- **Detected**: 2026-07-28T08:19:09.153541+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:0093cb1562e2d8125477e45e9b2045a81c983a91f38f1a2f9b738be110520613`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.TEALScript.GeneralTest_4f8027d2" \
  --url https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/GeneralTest.arc56.json
```

## Error

```
/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/TEALScript/dotnet/src/GeneralTest_4f8027d2.cs(486,27): error CS0102: The type 'GeneralTestProxy' already contains a definition for 'Events' [/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/TEALScript/dotnet/Arc56.Generated.algorandfoundation.TEALScript.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/TEALScript/dotnet/src/GeneralTest_4f8027d2.cs(486,27): error CS0102: The type 'GeneralTestProxy' already contains a definition for 'Events' [/home/runner/work/ARC56Registry/ARC56Registry/clients/algorandfoundation/TEALScript/dotnet/Arc56.Generated.algorandfoundation.TEALScript.csproj]
```
