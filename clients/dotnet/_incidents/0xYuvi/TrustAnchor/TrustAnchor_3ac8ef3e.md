# Generated code fails to compile: TrustAnchor_3ac8ef3e

- **Repo**: [0xYuvi/TrustAnchor](https://github.com/0xYuvi/TrustAnchor)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/0xYuvi/TrustAnchor/HEAD/projects/TrustAnchor-contracts/smart_contracts/artifacts/trust_anchor/TrustAnchor.arc56.json](https://raw.githubusercontent.com/0xYuvi/TrustAnchor/HEAD/projects/TrustAnchor-contracts/smart_contracts/artifacts/trust_anchor/TrustAnchor.arc56.json)
- **Namespace used**: `Arc56.Generated._0xYuvi.TrustAnchor.TrustAnchor_3ac8ef3e`
- **Detected**: 2026-07-17T00:22:17.421601+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated._0xYuvi.TrustAnchor.TrustAnchor_3ac8ef3e" \
  --url https://raw.githubusercontent.com/0xYuvi/TrustAnchor/HEAD/projects/TrustAnchor-contracts/smart_contracts/artifacts/trust_anchor/TrustAnchor.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(46,35): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(47,37): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(67,35): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(68,37): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(86,39): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(92,38): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(106,39): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(126,37): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(147,37): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(46,35): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(47,37): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(67,35): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(68,37): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(86,39): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(92,38): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(106,39): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(126,37): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\src\TrustAnchor_3ac8ef3e.cs(147,37): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0xYuvi\TrustAnchor\Arc56.Generated.0xYuvi.TrustAnchor.csproj]
```
