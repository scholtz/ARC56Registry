# Generated code fails to compile: A_d7a5b6c2

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/immutable/read_in_ctor/A.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/immutable/read_in_ctor/A.arc56.json)
- **Namespace used**: `Arc56.Generated.Argimirodelpozo.puya_sol.A_d7a5b6c2`
- **Detected**: 2026-07-21T08:12:18.269192+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:0093cb1562e2d8125477e45e9b2045a81c983a91f38f1a2f9b738be110520613`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.Argimirodelpozo.puya_sol.A_d7a5b6c2" \
  --url https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/immutable/read_in_ctor/A.arc56.json
```

## Error

```
/home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/dotnet/src/A_d7a5b6c2.cs(98,39): error CS8103: Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string literals or try the EXPERIMENTAL feature flag 'experimental-data-section-string-literals'. [/home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/dotnet/Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/dotnet/src/A_d7a5b6c2.cs(98,39): error CS8103: Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string literals or try the EXPERIMENTAL feature flag 'experimental-data-section-string-literals'. [/home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/dotnet/Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
```
