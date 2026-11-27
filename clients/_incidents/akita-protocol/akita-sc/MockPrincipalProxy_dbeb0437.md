# Generated code fails to compile: MockPrincipalProxy_dbeb0437

- **Repo**: [akita-protocol/akita-sc](https://github.com/akita-protocol/akita-sc)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/mocks/principal-proxy/MockPrincipalProxy.arc56.json](https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/mocks/principal-proxy/MockPrincipalProxy.arc56.json)
- **Namespace used**: `Arc56.Generated.akita_protocol.akita_sc.MockPrincipalProxy_dbeb0437`
- **Detected**: 2026-11-27T15:56:25.737426+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:23f962c15728699da4c86c52c95d65d4bca48d37e1e21665a2d9d2d181121ddf`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.akita_protocol.akita_sc.MockPrincipalProxy_dbeb0437" \
  --url https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/mocks/principal-proxy/MockPrincipalProxy.arc56.json
```

## Error

```
/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/dotnet/src/MockPrincipalProxy_dbeb0437.cs(42,41): error CS0542: 'Principal': member names cannot be the same as their enclosing type [/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/dotnet/Arc56.Generated.akita-protocol.akita-sc.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/dotnet/src/MockPrincipalProxy_dbeb0437.cs(42,41): error CS0542: 'Principal': member names cannot be the same as their enclosing type [/home/runner/work/ARC56Registry/ARC56Registry/clients/akita-protocol/akita-sc/dotnet/Arc56.Generated.akita-protocol.akita-sc.csproj]
```
