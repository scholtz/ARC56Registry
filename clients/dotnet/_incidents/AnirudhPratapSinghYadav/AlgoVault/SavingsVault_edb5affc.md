# Generated code fails to compile: SavingsVault_edb5affc

- **Repo**: [AnirudhPratapSinghYadav/AlgoVault](https://github.com/AnirudhPratapSinghYadav/AlgoVault)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/AnirudhPratapSinghYadav/AlgoVault/HEAD/savings_vault/projects/savings_vault/smart_contracts/artifacts/savings_vault/SavingsVault.arc56.json](https://raw.githubusercontent.com/AnirudhPratapSinghYadav/AlgoVault/HEAD/savings_vault/projects/savings_vault/smart_contracts/artifacts/savings_vault/SavingsVault.arc56.json)
- **Namespace used**: `Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.SavingsVault_edb5affc`
- **Detected**: 2026-07-17T00:06:42.691657+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:e738b4d750aa1f25bbc94eec6a9322ce0e3d53dfeb06368c5806ae7475b201f7`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.SavingsVault_edb5affc" \
  --url https://raw.githubusercontent.com/AnirudhPratapSinghYadav/AlgoVault/HEAD/savings_vault/projects/savings_vault/smart_contracts/artifacts/savings_vault/SavingsVault.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\SavingsVault_edb5affc.cs(699,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\SavingsVault_edb5affc.cs(700,38): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\SavingsVault_edb5affc.cs(714,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\SavingsVault_edb5affc.cs(715,38): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\SavingsVault_edb5affc.cs(699,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\SavingsVault_edb5affc.cs(700,38): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\SavingsVault_edb5affc.cs(714,36): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\SavingsVault_edb5affc.cs(715,38): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
```
