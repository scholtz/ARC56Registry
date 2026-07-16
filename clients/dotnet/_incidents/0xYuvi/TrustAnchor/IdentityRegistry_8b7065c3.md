# Generated code fails to compile: IdentityRegistry_8b7065c3

- **Repo**: [0xYuvi/TrustAnchor](https://github.com/0xYuvi/TrustAnchor)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/0xYuvi/TrustAnchor/HEAD/projects/TrustAnchor-contracts/smart_contracts/artifacts/identity_registry/IdentityRegistry.arc56.json](https://raw.githubusercontent.com/0xYuvi/TrustAnchor/HEAD/projects/TrustAnchor-contracts/smart_contracts/artifacts/identity_registry/IdentityRegistry.arc56.json)
- **Namespace used**: `Arc56.Generated._0xYuvi.TrustAnchor.IdentityRegistry_8b7065c3`
- **Detected**: 2026-07-16T23:47:30.356387+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:e738b4d750aa1f25bbc94eec6a9322ce0e3d53dfeb06368c5806ae7475b201f7`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated._0xYuvi.TrustAnchor.IdentityRegistry_8b7065c3" \
  --url https://raw.githubusercontent.com/0xYuvi/TrustAnchor/HEAD/projects/TrustAnchor-contracts/smart_contracts/artifacts/identity_registry/IdentityRegistry.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\IdentityRegistry_8b7065c3.cs(185,37): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\IdentityRegistry_8b7065c3.cs(202,37): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\IdentityRegistry_8b7065c3.cs(185,37): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\IdentityRegistry_8b7065c3.cs(202,37): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
```
