# Generated code fails to compile: DisasterVault_32b608a7

- **Repo**: [AnirudhPratapSinghYadav/AlgoVault](https://github.com/AnirudhPratapSinghYadav/AlgoVault)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/AnirudhPratapSinghYadav/AlgoVault/HEAD/src/contracts/DisasterVault.arc56.json](https://raw.githubusercontent.com/AnirudhPratapSinghYadav/AlgoVault/HEAD/src/contracts/DisasterVault.arc56.json)
- **Namespace used**: `Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.DisasterVault_32b608a7`
- **Detected**: 2026-07-17T00:06:42.692710+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:e738b4d750aa1f25bbc94eec6a9322ce0e3d53dfeb06368c5806ae7475b201f7`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.DisasterVault_32b608a7" \
  --url https://raw.githubusercontent.com/AnirudhPratapSinghYadav/AlgoVault/HEAD/src/contracts/DisasterVault.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\DisasterVault_32b608a7.cs(233,36): error CS1729: 'VariableArray<Address>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\DisasterVault_32b608a7.cs(259,36): error CS1729: 'VariableArray<Address>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\DisasterVault_32b608a7.cs(350,40): error CS1729: 'VariableArray<Address>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\DisasterVault_32b608a7.cs(351,34): error CS1729: 'VariableArray<UInt64>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\DisasterVault_32b608a7.cs(366,40): error CS1729: 'VariableArray<Address>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\DisasterVault_32b608a7.cs(367,34): error CS1729: 'VariableArray<UInt64>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\DisasterVault_32b608a7.cs(233,36): error CS1729: 'VariableArray<Address>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\DisasterVault_32b608a7.cs(259,36): error CS1729: 'VariableArray<Address>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\DisasterVault_32b608a7.cs(350,40): error CS1729: 'VariableArray<Address>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\DisasterVault_32b608a7.cs(351,34): error CS1729: 'VariableArray<UInt64>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\DisasterVault_32b608a7.cs(366,40): error CS1729: 'VariableArray<Address>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\src\DisasterVault_32b608a7.cs(367,34): error CS1729: 'VariableArray<UInt64>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnirudhPratapSinghYadav\AlgoVault\Arc56.Generated.AnirudhPratapSinghYadav.AlgoVault.csproj]
```
