# Generated code fails to compile: C_47a6caa5

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/abiEncoderV2/calldata_three_dimensional_dynamic_array_index_access/C.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/abiEncoderV2/calldata_three_dimensional_dynamic_array_index_access/C.arc56.json)
- **Namespace used**: `Arc56.Generated.Argimirodelpozo.puya_sol.C_47a6caa5`
- **Detected**: 2026-07-17T04:58:44.559404+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.Argimirodelpozo.puya_sol.C_47a6caa5" \
  --url https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/abiEncoderV2/calldata_three_dimensional_dynamic_array_index_access/C.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\C_47a6caa5.cs(159,37): error CS0246: The type or namespace name 'KArgS' could not be found (are you missing a using directive or an assembly reference?) [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\C_47a6caa5.cs(179,61): error CS0246: The type or namespace name 'KArgS' could not be found (are you missing a using directive or an assembly reference?) [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\C_47a6caa5.cs(199,37): error CS0246: The type or namespace name 'LArgS' could not be found (are you missing a using directive or an assembly reference?) [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\C_47a6caa5.cs(219,61): error CS0246: The type or namespace name 'LArgS' could not be found (are you missing a using directive or an assembly reference?) [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\C_47a6caa5.cs(159,37): error CS0246: The type or namespace name 'KArgS' could not be found (are you missing a using directive or an assembly reference?) [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\C_47a6caa5.cs(179,61): error CS0246: The type or namespace name 'KArgS' could not be found (are you missing a using directive or an assembly reference?) [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\C_47a6caa5.cs(199,37): error CS0246: The type or namespace name 'LArgS' could not be found (are you missing a using directive or an assembly reference?) [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\C_47a6caa5.cs(219,61): error CS0246: The type or namespace name 'LArgS' could not be found (are you missing a using directive or an assembly reference?) [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
```
