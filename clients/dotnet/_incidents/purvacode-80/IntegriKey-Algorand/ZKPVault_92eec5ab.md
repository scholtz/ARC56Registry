# Generated code fails to compile: ZKPVault_92eec5ab

- **Repo**: [purvacode-80/IntegriKey-Algorand](https://github.com/purvacode-80/IntegriKey-Algorand)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/purvacode-80/IntegriKey-Algorand/HEAD/projects/zkp_vault-contracts/smart_contracts/artifacts/zkp_vault/ZKPVault.arc56.json](https://raw.githubusercontent.com/purvacode-80/IntegriKey-Algorand/HEAD/projects/zkp_vault-contracts/smart_contracts/artifacts/zkp_vault/ZKPVault.arc56.json)
- **Namespace used**: `Arc56.Generated.purvacode_80.IntegriKey_Algorand.ZKPVault_92eec5ab`
- **Detected**: 2026-07-17T08:42:12.989544+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.purvacode_80.IntegriKey_Algorand.ZKPVault_92eec5ab" \
  --url https://raw.githubusercontent.com/purvacode-80/IntegriKey-Algorand/HEAD/projects/zkp_vault-contracts/smart_contracts/artifacts/zkp_vault/ZKPVault.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\purvacode-80\IntegriKey-Algorand\src\ZKPVault_92eec5ab.cs(374,27): error CS0111: Type 'ZKPVaultProxy' already defines a member called 'CreateApplication' with the same parameter types [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\purvacode-80\IntegriKey-Algorand\Arc56.Generated.purvacode-80.IntegriKey-Algorand.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\purvacode-80\IntegriKey-Algorand\src\ZKPVault_92eec5ab.cs(387,46): error CS0111: Type 'ZKPVaultProxy' already defines a member called 'CreateApplication_Transactions' with the same parameter types [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\purvacode-80\IntegriKey-Algorand\Arc56.Generated.purvacode-80.IntegriKey-Algorand.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\purvacode-80\IntegriKey-Algorand\src\ZKPVault_92eec5ab.cs(374,27): error CS0111: Type 'ZKPVaultProxy' already defines a member called 'CreateApplication' with the same parameter types [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\purvacode-80\IntegriKey-Algorand\Arc56.Generated.purvacode-80.IntegriKey-Algorand.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\purvacode-80\IntegriKey-Algorand\src\ZKPVault_92eec5ab.cs(387,46): error CS0111: Type 'ZKPVaultProxy' already defines a member called 'CreateApplication_Transactions' with the same parameter types [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\purvacode-80\IntegriKey-Algorand\Arc56.Generated.purvacode-80.IntegriKey-Algorand.csproj]
```
