# Generated code fails to compile: AlgoZombiesContract_0b09c6f3

- **Repo**: [Aniketwarule/CryptoZombies_Algorand](https://github.com/Aniketwarule/CryptoZombies_Algorand)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Aniketwarule/CryptoZombies_Algorand/HEAD/projects/algoZombiesSetup-contracts/smart_contracts/artifacts/zombies_contract/AlgoZombiesContract.arc56.json](https://raw.githubusercontent.com/Aniketwarule/CryptoZombies_Algorand/HEAD/projects/algoZombiesSetup-contracts/smart_contracts/artifacts/zombies_contract/AlgoZombiesContract.arc56.json)
- **Namespace used**: `Arc56.Generated.Aniketwarule.CryptoZombies_Algorand.AlgoZombiesContract_0b09c6f3`
- **Detected**: 2026-07-17T00:05:08.999977+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:e738b4d750aa1f25bbc94eec6a9322ce0e3d53dfeb06368c5806ae7475b201f7`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.Aniketwarule.CryptoZombies_Algorand.AlgoZombiesContract_0b09c6f3" \
  --url https://raw.githubusercontent.com/Aniketwarule/CryptoZombies_Algorand/HEAD/projects/algoZombiesSetup-contracts/smart_contracts/artifacts/zombies_contract/AlgoZombiesContract.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aniketwarule\CryptoZombies_Algorand\src\AlgoZombiesContract_0b09c6f3.cs(434,31): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aniketwarule\CryptoZombies_Algorand\Arc56.Generated.Aniketwarule.CryptoZombies_Algorand.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aniketwarule\CryptoZombies_Algorand\src\AlgoZombiesContract_0b09c6f3.cs(455,31): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aniketwarule\CryptoZombies_Algorand\Arc56.Generated.Aniketwarule.CryptoZombies_Algorand.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aniketwarule\CryptoZombies_Algorand\src\AlgoZombiesContract_0b09c6f3.cs(596,34): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aniketwarule\CryptoZombies_Algorand\Arc56.Generated.Aniketwarule.CryptoZombies_Algorand.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aniketwarule\CryptoZombies_Algorand\src\AlgoZombiesContract_0b09c6f3.cs(617,34): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aniketwarule\CryptoZombies_Algorand\Arc56.Generated.Aniketwarule.CryptoZombies_Algorand.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aniketwarule\CryptoZombies_Algorand\src\AlgoZombiesContract_0b09c6f3.cs(434,31): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aniketwarule\CryptoZombies_Algorand\Arc56.Generated.Aniketwarule.CryptoZombies_Algorand.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aniketwarule\CryptoZombies_Algorand\src\AlgoZombiesContract_0b09c6f3.cs(455,31): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aniketwarule\CryptoZombies_Algorand\Arc56.Generated.Aniketwarule.CryptoZombies_Algorand.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aniketwarule\CryptoZombies_Algorand\src\AlgoZombiesContract_0b09c6f3.cs(596,34): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aniketwarule\CryptoZombies_Algorand\Arc56.Generated.Aniketwarule.CryptoZombies_Algorand.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aniketwarule\CryptoZombies_Algorand\src\AlgoZombiesContract_0b09c6f3.cs(617,34): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aniketwarule\CryptoZombies_Algorand\Arc56.Generated.Aniketwarule.CryptoZombies_Algorand.csproj]
```
