# Generated code fails to compile: AccessManagerEnumerable__chunk_3_48eb32f9

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/AccessManagerEnumerable/__uros_split/chunk_3/AccessManagerEnumerable__chunk_3.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/AccessManagerEnumerable/__uros_split/chunk_3/AccessManagerEnumerable__chunk_3.arc56.json)
- **Namespace used**: `Arc56.Generated.Argimirodelpozo.puya_sol.AccessManagerEnumerable__chunk_3_48eb32f9`
- **Detected**: 2026-07-17T04:58:45.321241+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.Argimirodelpozo.puya_sol.AccessManagerEnumerable__chunk_3_48eb32f9" \
  --url https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/AccessManagerEnumerable/__uros_split/chunk_3/AccessManagerEnumerable__chunk_3.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\AccessManagerEnumerable__chunk_3_48eb32f9.cs(1117,31): error CS0102: The type 'AccessManagerEnumerable__chunk_3Proxy.Events.TargetFunctionRoleUpdatedEvent' already contains a definition for 'Selector' [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\AccessManagerEnumerable__chunk_3_48eb32f9.cs(1117,31): error CS0102: The type 'AccessManagerEnumerable__chunk_3Proxy.Events.TargetFunctionRoleUpdatedEvent' already contains a definition for 'Selector' [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
```
