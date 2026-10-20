# Generated code fails to compile: Sealed_v2_d3a92bb7

- **Repo**: [sealed-channel/sealed](https://github.com/sealed-channel/sealed)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/sealed-channel/sealed/HEAD/programs/sealed/src/__tests__/fixtures/Sealed.v2.arc56.json](https://raw.githubusercontent.com/sealed-channel/sealed/HEAD/programs/sealed/src/__tests__/fixtures/Sealed.v2.arc56.json)
- **Namespace used**: `Arc56.Generated.sealed_channel.sealed.Sealed_v2_d3a92bb7`
- **Detected**: 2026-10-20T11:27:30.372261+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:f7aaa620d62a7a766c9f2ae99d41d7ac7dc6f7d76fecd4ebd66d057e930a575d`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.sealed_channel.sealed.Sealed_v2_d3a92bb7" \
  --url https://raw.githubusercontent.com/sealed-channel/sealed/HEAD/programs/sealed/src/__tests__/fixtures/Sealed.v2.arc56.json
```

## Error

```
/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/src/Sealed_v2_d3a92bb7.cs(15,42): error CS1001: Identifier expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/Arc56.Generated.sealed-channel.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/src/Sealed_v2_d3a92bb7.cs(15,42): error CS1514: { expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/Arc56.Generated.sealed-channel.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/src/Sealed_v2_d3a92bb7.cs(15,42): error CS0116: A namespace cannot directly contain members such as fields, methods or statements [/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/Arc56.Generated.sealed-channel.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/src/Sealed_v2_d3a92bb7.cs(15,48): error CS1022: Type or namespace definition, or end-of-file expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/Arc56.Generated.sealed-channel.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/src/Sealed_v2_d3a92bb7.cs(15,67): error CS1001: Identifier expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/Arc56.Generated.sealed-channel.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/src/Sealed_v2_d3a92bb7.cs(16,2): error CS1513: } expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/Arc56.Generated.sealed-channel.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/src/Sealed_v2_d3a92bb7.cs(15,42): error CS1001: Identifier expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/Arc56.Generated.sealed-channel.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/src/Sealed_v2_d3a92bb7.cs(15,42): error CS1514: { expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/Arc56.Generated.sealed-channel.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/src/Sealed_v2_d3a92bb7.cs(15,42): error CS0116: A namespace cannot directly contain members such as fields, methods or statements [/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/Arc56.Generated.sealed-channel.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/src/Sealed_v2_d3a92bb7.cs(15,48): error CS1022: Type or namespace definition, or end-of-file expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/Arc56.Generated.sealed-channel.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/src/Sealed_v2_d3a92bb7.cs(15,67): error CS1001: Identifier expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/Arc56.Generated.sealed-channel.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/src/Sealed_v2_d3a92bb7.cs(16,2): error CS1513: } expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sealed-channel/sealed/dotnet/Arc56.Generated.sealed-channel.sealed.csproj]
```
