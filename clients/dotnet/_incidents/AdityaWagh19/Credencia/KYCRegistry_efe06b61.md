# Generated code fails to compile: KYCRegistry_efe06b61

- **Repo**: [AdityaWagh19/Credencia](https://github.com/AdityaWagh19/Credencia)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/AdityaWagh19/Credencia/HEAD/backend/contracts/cadencia/KYCRegistry/KYCRegistry.arc56.json](https://raw.githubusercontent.com/AdityaWagh19/Credencia/HEAD/backend/contracts/cadencia/KYCRegistry/KYCRegistry.arc56.json)
- **Namespace used**: `Arc56.Generated.AdityaWagh19.Credencia.KYCRegistry_efe06b61`
- **Detected**: 2026-07-16T23:50:39.979362+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:e738b4d750aa1f25bbc94eec6a9322ce0e3d53dfeb06368c5806ae7475b201f7`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.AdityaWagh19.Credencia.KYCRegistry_efe06b61" \
  --url https://raw.githubusercontent.com/AdityaWagh19/Credencia/HEAD/backend/contracts/cadencia/KYCRegistry/KYCRegistry.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AdityaWagh19\Credencia\src\KYCRegistry_efe06b61.cs(188,35): error CS1729: 'FixedArray<Byte>' does not contain a constructor that takes 2 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AdityaWagh19\Credencia\Arc56.Generated.AdityaWagh19.Credencia.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AdityaWagh19\Credencia\src\KYCRegistry_efe06b61.cs(204,35): error CS1729: 'FixedArray<Byte>' does not contain a constructor that takes 2 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AdityaWagh19\Credencia\Arc56.Generated.AdityaWagh19.Credencia.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AdityaWagh19\Credencia\src\KYCRegistry_efe06b61.cs(188,35): error CS1729: 'FixedArray<Byte>' does not contain a constructor that takes 2 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AdityaWagh19\Credencia\Arc56.Generated.AdityaWagh19.Credencia.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AdityaWagh19\Credencia\src\KYCRegistry_efe06b61.cs(204,35): error CS1729: 'FixedArray<Byte>' does not contain a constructor that takes 2 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AdityaWagh19\Credencia\Arc56.Generated.AdityaWagh19.Credencia.csproj]
```
