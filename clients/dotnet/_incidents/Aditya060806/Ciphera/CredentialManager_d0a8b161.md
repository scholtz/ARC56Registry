# Generated code fails to compile: CredentialManager_d0a8b161

- **Repo**: [Aditya060806/Ciphera](https://github.com/Aditya060806/Ciphera)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Aditya060806/Ciphera/HEAD/Ciphera-kyc/projects/Ciphera-kyc/smart_contracts/artifacts/credential_manager/CredentialManager.arc56.json](https://raw.githubusercontent.com/Aditya060806/Ciphera/HEAD/Ciphera-kyc/projects/Ciphera-kyc/smart_contracts/artifacts/credential_manager/CredentialManager.arc56.json)
- **Namespace used**: `Arc56.Generated.Aditya060806.Ciphera.CredentialManager_d0a8b161`
- **Detected**: 2026-07-17T00:24:19.122990+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.Aditya060806.Ciphera.CredentialManager_d0a8b161" \
  --url https://raw.githubusercontent.com/Aditya060806/Ciphera/HEAD/Ciphera-kyc/projects/Ciphera-kyc/smart_contracts/artifacts/credential_manager/CredentialManager.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\src\CredentialManager_d0a8b161.cs(87,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\Arc56.Generated.Aditya060806.Ciphera.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\src\CredentialManager_d0a8b161.cs(102,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\Arc56.Generated.Aditya060806.Ciphera.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\src\CredentialManager_d0a8b161.cs(123,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\Arc56.Generated.Aditya060806.Ciphera.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\src\CredentialManager_d0a8b161.cs(138,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\Arc56.Generated.Aditya060806.Ciphera.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\src\CredentialManager_d0a8b161.cs(87,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\Arc56.Generated.Aditya060806.Ciphera.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\src\CredentialManager_d0a8b161.cs(102,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\Arc56.Generated.Aditya060806.Ciphera.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\src\CredentialManager_d0a8b161.cs(123,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\Arc56.Generated.Aditya060806.Ciphera.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\src\CredentialManager_d0a8b161.cs(138,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aditya060806\Ciphera\Arc56.Generated.Aditya060806.Ciphera.csproj]
```
