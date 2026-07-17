# Generated code fails to compile: NFTPromptRegistry_a25c5376

- **Repo**: [DedMoroz38/AI-assisted-NFT-deployment](https://github.com/DedMoroz38/AI-assisted-NFT-deployment)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/DedMoroz38/AI-assisted-NFT-deployment/HEAD/smar-contract/smart_contracts/nft_prompt_registry/NFTPromptRegistry.arc56.json](https://raw.githubusercontent.com/DedMoroz38/AI-assisted-NFT-deployment/HEAD/smar-contract/smart_contracts/nft_prompt_registry/NFTPromptRegistry.arc56.json)
- **Namespace used**: `Arc56.Generated.DedMoroz38.AI_assisted_NFT_deployment.NFTPromptRegistry_a25c5376`
- **Detected**: 2026-07-17T05:08:14.570798+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.DedMoroz38.AI_assisted_NFT_deployment.NFTPromptRegistry_a25c5376" \
  --url https://raw.githubusercontent.com/DedMoroz38/AI-assisted-NFT-deployment/HEAD/smar-contract/smart_contracts/nft_prompt_registry/NFTPromptRegistry.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\DedMoroz38\AI-assisted-NFT-deployment\src\NFTPromptRegistry_a25c5376.cs(205,27): error CS0111: Type 'NFTPromptRegistryProxy' already defines a member called 'CreateApplication' with the same parameter types [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\DedMoroz38\AI-assisted-NFT-deployment\Arc56.Generated.DedMoroz38.AI-assisted-NFT-deployment.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\DedMoroz38\AI-assisted-NFT-deployment\src\NFTPromptRegistry_a25c5376.cs(218,46): error CS0111: Type 'NFTPromptRegistryProxy' already defines a member called 'CreateApplication_Transactions' with the same parameter types [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\DedMoroz38\AI-assisted-NFT-deployment\Arc56.Generated.DedMoroz38.AI-assisted-NFT-deployment.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\DedMoroz38\AI-assisted-NFT-deployment\src\NFTPromptRegistry_a25c5376.cs(205,27): error CS0111: Type 'NFTPromptRegistryProxy' already defines a member called 'CreateApplication' with the same parameter types [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\DedMoroz38\AI-assisted-NFT-deployment\Arc56.Generated.DedMoroz38.AI-assisted-NFT-deployment.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\DedMoroz38\AI-assisted-NFT-deployment\src\NFTPromptRegistry_a25c5376.cs(218,46): error CS0111: Type 'NFTPromptRegistryProxy' already defines a member called 'CreateApplication_Transactions' with the same parameter types [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\DedMoroz38\AI-assisted-NFT-deployment\Arc56.Generated.DedMoroz38.AI-assisted-NFT-deployment.csproj]
```
