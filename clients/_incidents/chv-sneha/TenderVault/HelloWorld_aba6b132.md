# Generated code fails to compile: HelloWorld_aba6b132

- **Repo**: [chv-sneha/TenderVault](https://github.com/chv-sneha/TenderVault)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/chv-sneha/TenderVault/HEAD/tender-contract/projects/tender-contract/smart_contracts/hello_world/smart_contracts/artifacts/hello_world/HelloWorld.arc56.json](https://raw.githubusercontent.com/chv-sneha/TenderVault/HEAD/tender-contract/projects/tender-contract/smart_contracts/hello_world/smart_contracts/artifacts/hello_world/HelloWorld.arc56.json)
- **Namespace used**: `Arc56.Generated.chv_sneha.TenderVault.HelloWorld_aba6b132`
- **Detected**: 2026-07-17T07:55:28.598182+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.chv_sneha.TenderVault.HelloWorld_aba6b132" \
  --url https://raw.githubusercontent.com/chv-sneha/TenderVault/HEAD/tender-contract/projects/tender-contract/smart_contracts/hello_world/smart_contracts/artifacts/hello_world/HelloWorld.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\chv-sneha\TenderVault\src\HelloWorld_aba6b132.cs(233,27): error CS0111: Type 'HelloWorldProxy' already defines a member called 'CreateApplication' with the same parameter types [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\chv-sneha\TenderVault\Arc56.Generated.chv-sneha.TenderVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\chv-sneha\TenderVault\src\HelloWorld_aba6b132.cs(246,46): error CS0111: Type 'HelloWorldProxy' already defines a member called 'CreateApplication_Transactions' with the same parameter types [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\chv-sneha\TenderVault\Arc56.Generated.chv-sneha.TenderVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\chv-sneha\TenderVault\src\HelloWorld_aba6b132.cs(233,27): error CS0111: Type 'HelloWorldProxy' already defines a member called 'CreateApplication' with the same parameter types [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\chv-sneha\TenderVault\Arc56.Generated.chv-sneha.TenderVault.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\chv-sneha\TenderVault\src\HelloWorld_aba6b132.cs(246,46): error CS0111: Type 'HelloWorldProxy' already defines a member called 'CreateApplication_Transactions' with the same parameter types [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\chv-sneha\TenderVault\Arc56.Generated.chv-sneha.TenderVault.csproj]
```
