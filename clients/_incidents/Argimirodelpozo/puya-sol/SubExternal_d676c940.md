# Generated code fails to compile: SubExternal_d676c940

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/externalSource/source_import_subdir/SubExternal.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/externalSource/source_import_subdir/SubExternal.arc56.json)
- **Namespace used**: `Arc56.Generated.Argimirodelpozo.puya_sol.SubExternal_d676c940`
- **Detected**: 2026-07-17T04:59:25.403831+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.Argimirodelpozo.puya_sol.SubExternal_d676c940" \
  --url https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/externalSource/source_import_subdir/SubExternal.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\SubExternal_d676c940.cs(63,39): error CS8103: Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string literals or try the EXPERIMENTAL feature flag 'experimental-data-section-string-literals'. [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\SubExternal_d676c940.cs(63,39): error CS8103: Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string literals or try the EXPERIMENTAL feature flag 'experimental-data-section-string-literals'. [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
```
