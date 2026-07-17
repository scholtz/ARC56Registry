# Generated code fails to compile: CredentialManager_25f86a34

- **Repo**: [Aditya060806/Ciphera](https://github.com/Aditya060806/Ciphera)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Aditya060806/Ciphera/HEAD/Ciphera-kyc/projects/Ciphera-kyc/smart_contracts/credential_manager/smart_contracts/artifacts/credential_manager/CredentialManager.arc56.json](https://raw.githubusercontent.com/Aditya060806/Ciphera/HEAD/Ciphera-kyc/projects/Ciphera-kyc/smart_contracts/credential_manager/smart_contracts/artifacts/credential_manager/CredentialManager.arc56.json)
- **Namespace used**: `Arc56.Generated.Aditya060806.Ciphera.CredentialManager_25f86a34`
- **Detected**: 2026-07-16T23:59:54.414126+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:e738b4d750aa1f25bbc94eec6a9322ce0e3d53dfeb06368c5806ae7475b201f7`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.Aditya060806.Ciphera.CredentialManager_25f86a34" \
  --url https://raw.githubusercontent.com/Aditya060806/Ciphera/HEAD/Ciphera-kyc/projects/Ciphera-kyc/smart_contracts/credential_manager/smart_contracts/artifacts/credential_manager/CredentialManager.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\src\CredentialManager_25f86a34.cs(115,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\Arc56.Generated.Aditya060806.Ciphera.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\src\CredentialManager_25f86a34.cs(130,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\Arc56.Generated.Aditya060806.Ciphera.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\src\CredentialManager_25f86a34.cs(150,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\Arc56.Generated.Aditya060806.Ciphera.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\src\CredentialManager_25f86a34.cs(165,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\Arc56.Generated.Aditya060806.Ciphera.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\src\CredentialManager_25f86a34.cs(115,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\Arc56.Generated.Aditya060806.Ciphera.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\src\CredentialManager_25f86a34.cs(130,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\Arc56.Generated.Aditya060806.Ciphera.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\src\CredentialManager_25f86a34.cs(150,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\Arc56.Generated.Aditya060806.Ciphera.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\src\CredentialManager_25f86a34.cs(165,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\Arc56.Generated.Aditya060806.Ciphera.csproj]
```
