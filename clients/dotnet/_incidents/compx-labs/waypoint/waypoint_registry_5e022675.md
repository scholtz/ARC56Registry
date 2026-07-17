# Generated code fails to compile: waypoint_registry_5e022675

- **Repo**: [compx-labs/waypoint](https://github.com/compx-labs/waypoint)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/compx-labs/waypoint/HEAD/contracts/algorand/projects/algorand/smart_contracts/artifacts/waypoint_registry/waypoint-registry.arc56.json](https://raw.githubusercontent.com/compx-labs/waypoint/HEAD/contracts/algorand/projects/algorand/smart_contracts/artifacts/waypoint_registry/waypoint-registry.arc56.json)
- **Namespace used**: `Arc56.Generated.compx_labs.waypoint.waypoint_registry_5e022675`
- **Detected**: 2026-07-17T07:56:48.516655+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.compx_labs.waypoint.waypoint_registry_5e022675" \
  --url https://raw.githubusercontent.com/compx-labs/waypoint/HEAD/contracts/algorand/projects/algorand/smart_contracts/artifacts/waypoint_registry/waypoint-registry.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(19,26): error CS1514: { expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(19,26): error CS1513: } expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(19,26): error CS1022: Type or namespace definition, or end-of-file expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(19,27): error CS0116: A namespace cannot directly contain members such as fields, methods or statements [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(19,41): error CS1022: Type or namespace definition, or end-of-file expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(19,52): error CS1001: Identifier expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(20,3): error CS1513: } expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(23,12): error CS0116: A namespace cannot directly contain members such as fields, methods or statements [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(23,20): error CS1022: Type or namespace definition, or end-of-file expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(267,3): error CS1519: Invalid token '}' in a member declaration [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(19,26): error CS1514: { expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(19,26): error CS1513: } expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(19,26): error CS1022: Type or namespace definition, or end-of-file expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(19,27): error CS0116: A namespace cannot directly contain members such as fields, methods or statements [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(19,41): error CS1022: Type or namespace definition, or end-of-file expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(19,52): error CS1001: Identifier expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(20,3): error CS1513: } expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(23,12): error CS0116: A namespace cannot directly contain members such as fields, methods or statements [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(23,20): error CS1022: Type or namespace definition, or end-of-file expected [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\src\waypoint_registry_5e022675.cs(267,3): error CS1519: Invalid token '}' in a member declaration [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\compx-labs\waypoint\Arc56.Generated.compx-labs.waypoint.csproj]
```
