# Generated code fails to compile: SocialFollowerIndexGate_a3f060c1

- **Repo**: [akita-protocol/akita-sc](https://github.com/akita-protocol/akita-sc)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/gates/sub-gates/social-follower-index/SocialFollowerIndexGate.arc56.json](https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/gates/sub-gates/social-follower-index/SocialFollowerIndexGate.arc56.json)
- **Namespace used**: `Arc56.Generated.akita_protocol.akita_sc.SocialFollowerIndexGate_a3f060c1`
- **Detected**: 2026-11-26T16:07:33.612854+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:23f962c15728699da4c86c52c95d65d4bca48d37e1e21665a2d9d2d181121ddf`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.akita_protocol.akita_sc.SocialFollowerIndexGate_a3f060c1" \
  --url https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/gates/sub-gates/social-follower-index/SocialFollowerIndexGate.arc56.json
```

## Error

```
/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/dotnet/src/SocialFollowerIndexGate_a3f060c1.cs(436,39): error CS8103: Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string literals or try the EXPERIMENTAL feature flag 'experimental-data-section-string-literals'. [/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/dotnet/Arc56.Generated.akita-protocol.akita-sc.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/dotnet/src/SocialFollowerIndexGate_a3f060c1.cs(436,39): error CS8103: Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string literals or try the EXPERIMENTAL feature flag 'experimental-data-section-string-literals'. [/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/dotnet/Arc56.Generated.akita-protocol.akita-sc.csproj]
```
