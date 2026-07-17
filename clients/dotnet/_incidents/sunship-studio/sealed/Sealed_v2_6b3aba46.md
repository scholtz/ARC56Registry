# Generated code fails to compile: Sealed_v2_6b3aba46

- **Repo**: [sunship-studio/sealed](https://github.com/sunship-studio/sealed)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/sunship-studio/sealed/HEAD/programs/sealed/src/__tests__/fixtures/Sealed.v2.arc56.json](https://raw.githubusercontent.com/sunship-studio/sealed/HEAD/programs/sealed/src/__tests__/fixtures/Sealed.v2.arc56.json)
- **Namespace used**: `Arc56.Generated.sunship_studio.sealed.Sealed_v2_6b3aba46`
- **Detected**: 2026-07-17T08:53:13.261853+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.sunship_studio.sealed.Sealed_v2_6b3aba46" \
  --url https://raw.githubusercontent.com/sunship-studio/sealed/HEAD/programs/sealed/src/__tests__/fixtures/Sealed.v2.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\src\Sealed_v2_6b3aba46.cs(15,42): error CS1001: Identifier expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\Arc56.Generated.sunship-studio.sealed.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\src\Sealed_v2_6b3aba46.cs(15,42): error CS1514: { expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\Arc56.Generated.sunship-studio.sealed.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\src\Sealed_v2_6b3aba46.cs(15,42): error CS0116: A namespace cannot directly contain members such as fields, methods or statements [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\Arc56.Generated.sunship-studio.sealed.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\src\Sealed_v2_6b3aba46.cs(15,48): error CS1022: Type or namespace definition, or end-of-file expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\Arc56.Generated.sunship-studio.sealed.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\src\Sealed_v2_6b3aba46.cs(15,67): error CS1001: Identifier expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\Arc56.Generated.sunship-studio.sealed.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\src\Sealed_v2_6b3aba46.cs(16,2): error CS1513: } expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\Arc56.Generated.sunship-studio.sealed.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\src\Sealed_v2_6b3aba46.cs(15,42): error CS1001: Identifier expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\Arc56.Generated.sunship-studio.sealed.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\src\Sealed_v2_6b3aba46.cs(15,42): error CS1514: { expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\Arc56.Generated.sunship-studio.sealed.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\src\Sealed_v2_6b3aba46.cs(15,42): error CS0116: A namespace cannot directly contain members such as fields, methods or statements [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\Arc56.Generated.sunship-studio.sealed.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\src\Sealed_v2_6b3aba46.cs(15,48): error CS1022: Type or namespace definition, or end-of-file expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\Arc56.Generated.sunship-studio.sealed.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\src\Sealed_v2_6b3aba46.cs(15,67): error CS1001: Identifier expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\Arc56.Generated.sunship-studio.sealed.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\src\Sealed_v2_6b3aba46.cs(16,2): error CS1513: } expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\sunship-studio\sealed\Arc56.Generated.sunship-studio.sealed.csproj]
```
