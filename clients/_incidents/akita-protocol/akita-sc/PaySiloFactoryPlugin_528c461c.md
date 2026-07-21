# Generated code fails to compile: PaySiloFactoryPlugin_528c461c

- **Repo**: [akita-protocol/akita-sc](https://github.com/akita-protocol/akita-sc)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/arc58/plugins/pay-silo/PaySiloFactoryPlugin.arc56.json](https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/arc58/plugins/pay-silo/PaySiloFactoryPlugin.arc56.json)
- **Namespace used**: `Arc56.Generated.akita_protocol.akita_sc.PaySiloFactoryPlugin_528c461c`
- **Detected**: 2026-07-21T08:15:11.504572+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:0093cb1562e2d8125477e45e9b2045a81c983a91f38f1a2f9b738be110520613`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.akita_protocol.akita_sc.PaySiloFactoryPlugin_528c461c" \
  --url https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/arc58/plugins/pay-silo/PaySiloFactoryPlugin.arc56.json
```

## Error

```
/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/dotnet/src/PaySiloFactoryPlugin_528c461c.cs(107,39): error CS8103: Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string literals or try the EXPERIMENTAL feature flag 'experimental-data-section-string-literals'. [/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/dotnet/Arc56.Generated.akita-protocol.akita-sc.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/dotnet/src/PaySiloFactoryPlugin_528c461c.cs(107,39): error CS8103: Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string literals or try the EXPERIMENTAL feature flag 'experimental-data-section-string-literals'. [/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/dotnet/Arc56.Generated.akita-protocol.akita-sc.csproj]
```
