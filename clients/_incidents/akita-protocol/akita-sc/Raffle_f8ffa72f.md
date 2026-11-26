# Generated code fails to compile: Raffle_f8ffa72f

- **Repo**: [akita-protocol/akita-sc](https://github.com/akita-protocol/akita-sc)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/raffle/Raffle.arc56.json](https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/raffle/Raffle.arc56.json)
- **Namespace used**: `Arc56.Generated.akita_protocol.akita_sc.Raffle_f8ffa72f`
- **Detected**: 2026-11-26T16:07:33.565767+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:23f962c15728699da4c86c52c95d65d4bca48d37e1e21665a2d9d2d181121ddf`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.akita_protocol.akita_sc.Raffle_f8ffa72f" \
  --url https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/raffle/Raffle.arc56.json
```

## Error

```
/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/dotnet/src/Raffle_f8ffa72f.cs(1712,39): error CS8103: Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string literals or try the EXPERIMENTAL feature flag 'experimental-data-section-string-literals'. [/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/dotnet/Arc56.Generated.akita-protocol.akita-sc.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/dotnet/src/Raffle_f8ffa72f.cs(1712,39): error CS8103: Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string literals or try the EXPERIMENTAL feature flag 'experimental-data-section-string-literals'. [/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/dotnet/Arc56.Generated.akita-protocol.akita-sc.csproj]
```
