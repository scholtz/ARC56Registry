# Generated code fails to compile: BountyEscrowContract_0ac88497

- **Repo**: [AnuragAJ25/BaseCase-Web3-Algorand](https://github.com/AnuragAJ25/BaseCase-Web3-Algorand)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/AnuragAJ25/BaseCase-Web3-Algorand/HEAD/contracts/bounty_escrow/backend/contract_artifacts/BountyEscrowContract.arc56.json](https://raw.githubusercontent.com/AnuragAJ25/BaseCase-Web3-Algorand/HEAD/contracts/bounty_escrow/backend/contract_artifacts/BountyEscrowContract.arc56.json)
- **Namespace used**: `Arc56.Generated.AnuragAJ25.BaseCase_Web3_Algorand.BountyEscrowContract_0ac88497`
- **Detected**: 2026-07-17T00:07:25.785758+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:e738b4d750aa1f25bbc94eec6a9322ce0e3d53dfeb06368c5806ae7475b201f7`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.AnuragAJ25.BaseCase_Web3_Algorand.BountyEscrowContract_0ac88497" \
  --url https://raw.githubusercontent.com/AnuragAJ25/BaseCase-Web3-Algorand/HEAD/contracts/bounty_escrow/backend/contract_artifacts/BountyEscrowContract.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnuragAJ25\BaseCase-Web3-Algorand\src\BountyEscrowContract_0ac88497.cs(158,37): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnuragAJ25\BaseCase-Web3-Algorand\Arc56.Generated.AnuragAJ25.BaseCase-Web3-Algorand.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnuragAJ25\BaseCase-Web3-Algorand\src\BountyEscrowContract_0ac88497.cs(172,37): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnuragAJ25\BaseCase-Web3-Algorand\Arc56.Generated.AnuragAJ25.BaseCase-Web3-Algorand.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnuragAJ25\BaseCase-Web3-Algorand\src\BountyEscrowContract_0ac88497.cs(313,38): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnuragAJ25\BaseCase-Web3-Algorand\Arc56.Generated.AnuragAJ25.BaseCase-Web3-Algorand.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnuragAJ25\BaseCase-Web3-Algorand\src\BountyEscrowContract_0ac88497.cs(423,38): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnuragAJ25\BaseCase-Web3-Algorand\Arc56.Generated.AnuragAJ25.BaseCase-Web3-Algorand.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnuragAJ25\BaseCase-Web3-Algorand\src\BountyEscrowContract_0ac88497.cs(158,37): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnuragAJ25\BaseCase-Web3-Algorand\Arc56.Generated.AnuragAJ25.BaseCase-Web3-Algorand.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnuragAJ25\BaseCase-Web3-Algorand\src\BountyEscrowContract_0ac88497.cs(172,37): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnuragAJ25\BaseCase-Web3-Algorand\Arc56.Generated.AnuragAJ25.BaseCase-Web3-Algorand.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnuragAJ25\BaseCase-Web3-Algorand\src\BountyEscrowContract_0ac88497.cs(313,38): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnuragAJ25\BaseCase-Web3-Algorand\Arc56.Generated.AnuragAJ25.BaseCase-Web3-Algorand.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnuragAJ25\BaseCase-Web3-Algorand\src\BountyEscrowContract_0ac88497.cs(423,38): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnuragAJ25\BaseCase-Web3-Algorand\Arc56.Generated.AnuragAJ25.BaseCase-Web3-Algorand.csproj]
```
