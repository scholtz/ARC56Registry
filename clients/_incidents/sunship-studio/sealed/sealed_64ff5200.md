# Generated code fails to compile: sealed_64ff5200

- **Repo**: [sunship-studio/sealed](https://github.com/sunship-studio/sealed)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/sunship-studio/sealed/HEAD/sealed-indexer/src/notifications/sealed.arc56.json](https://raw.githubusercontent.com/sunship-studio/sealed/HEAD/sealed-indexer/src/notifications/sealed.arc56.json)
- **Namespace used**: `Arc56.Generated.sunship_studio.sealed.sealed_64ff5200`
- **Detected**: 2026-10-20T11:29:10.996664+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:f7aaa620d62a7a766c9f2ae99d41d7ac7dc6f7d76fecd4ebd66d057e930a575d`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.sunship_studio.sealed.sealed_64ff5200" \
  --url https://raw.githubusercontent.com/sunship-studio/sealed/HEAD/sealed-indexer/src/notifications/sealed.arc56.json
```

## Error

```
/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/src/sealed_64ff5200.cs(15,42): error CS1001: Identifier expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/Arc56.Generated.sunship-studio.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/src/sealed_64ff5200.cs(15,42): error CS1514: { expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/Arc56.Generated.sunship-studio.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/src/sealed_64ff5200.cs(15,42): error CS0116: A namespace cannot directly contain members such as fields, methods or statements [/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/Arc56.Generated.sunship-studio.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/src/sealed_64ff5200.cs(15,48): error CS1022: Type or namespace definition, or end-of-file expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/Arc56.Generated.sunship-studio.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/src/sealed_64ff5200.cs(15,64): error CS1001: Identifier expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/Arc56.Generated.sunship-studio.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/src/sealed_64ff5200.cs(16,2): error CS1513: } expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/Arc56.Generated.sunship-studio.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/src/sealed_64ff5200.cs(15,42): error CS1001: Identifier expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/Arc56.Generated.sunship-studio.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/src/sealed_64ff5200.cs(15,42): error CS1514: { expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/Arc56.Generated.sunship-studio.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/src/sealed_64ff5200.cs(15,42): error CS0116: A namespace cannot directly contain members such as fields, methods or statements [/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/Arc56.Generated.sunship-studio.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/src/sealed_64ff5200.cs(15,48): error CS1022: Type or namespace definition, or end-of-file expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/Arc56.Generated.sunship-studio.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/src/sealed_64ff5200.cs(15,64): error CS1001: Identifier expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/Arc56.Generated.sunship-studio.sealed.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/src/sealed_64ff5200.cs(16,2): error CS1513: } expected [/home/runner/work/ARC56Registry/ARC56Registry/clients/sunship-studio/sealed/dotnet/Arc56.Generated.sunship-studio.sealed.csproj]
```
