# Generated code fails to compile: RefugeeContract_92bbcaf9

- **Repo**: [Ananyaa-08/Refugee-Identity-System](https://github.com/Ananyaa-08/Refugee-Identity-System)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Ananyaa-08/Refugee-Identity-System/HEAD/projects/refugee-identity-system/Nexathon/blockchain/artifacts/refugee_contract/RefugeeContract.arc56.json](https://raw.githubusercontent.com/Ananyaa-08/Refugee-Identity-System/HEAD/projects/refugee-identity-system/Nexathon/blockchain/artifacts/refugee_contract/RefugeeContract.arc56.json)
- **Namespace used**: `Arc56.Generated.Ananyaa_08.Refugee_Identity_System.RefugeeContract_92bbcaf9`
- **Detected**: 2026-07-17T00:04:11.526942+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:e738b4d750aa1f25bbc94eec6a9322ce0e3d53dfeb06368c5806ae7475b201f7`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.Ananyaa_08.Refugee_Identity_System.RefugeeContract_92bbcaf9" \
  --url https://raw.githubusercontent.com/Ananyaa-08/Refugee-Identity-System/HEAD/projects/refugee-identity-system/Nexathon/blockchain/artifacts/refugee_contract/RefugeeContract.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\src\RefugeeContract_92bbcaf9.cs(84,40): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\Arc56.Generated.Ananyaa-08.Refugee-Identity-System.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\src\RefugeeContract_92bbcaf9.cs(85,42): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\Arc56.Generated.Ananyaa-08.Refugee-Identity-System.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\src\RefugeeContract_92bbcaf9.cs(86,41): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\Arc56.Generated.Ananyaa-08.Refugee-Identity-System.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\src\RefugeeContract_92bbcaf9.cs(101,40): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\Arc56.Generated.Ananyaa-08.Refugee-Identity-System.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\src\RefugeeContract_92bbcaf9.cs(102,42): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\Arc56.Generated.Ananyaa-08.Refugee-Identity-System.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\src\RefugeeContract_92bbcaf9.cs(103,41): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\Arc56.Generated.Ananyaa-08.Refugee-Identity-System.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\src\RefugeeContract_92bbcaf9.cs(84,40): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\Arc56.Generated.Ananyaa-08.Refugee-Identity-System.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\src\RefugeeContract_92bbcaf9.cs(85,42): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\Arc56.Generated.Ananyaa-08.Refugee-Identity-System.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\src\RefugeeContract_92bbcaf9.cs(86,41): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\Arc56.Generated.Ananyaa-08.Refugee-Identity-System.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\src\RefugeeContract_92bbcaf9.cs(101,40): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\Arc56.Generated.Ananyaa-08.Refugee-Identity-System.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\src\RefugeeContract_92bbcaf9.cs(102,42): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\Arc56.Generated.Ananyaa-08.Refugee-Identity-System.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\src\RefugeeContract_92bbcaf9.cs(103,41): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Ananyaa-08\Refugee-Identity-System\Arc56.Generated.Ananyaa-08.Refugee-Identity-System.csproj]
```
