# Generated code fails to compile: PoolManager__Helper25_f05a8a8d

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/uniswap-v4/out/PoolManager/PoolManager__Helper25.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/uniswap-v4/out/PoolManager/PoolManager__Helper25.arc56.json)
- **Namespace used**: `Arc56.Generated.Argimirodelpozo.puya_sol.PoolManager__Helper25_f05a8a8d`
- **Detected**: 2026-07-17T04:59:57.630501+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.Argimirodelpozo.puya_sol.PoolManager__Helper25_f05a8a8d" \
  --url https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/uniswap-v4/out/PoolManager/PoolManager__Helper25.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\PoolManager__Helper25_f05a8a8d.cs(331,39): error CS8103: Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string literals or try the EXPERIMENTAL feature flag 'experimental-data-section-string-literals'. [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\PoolManager__Helper25_f05a8a8d.cs(167,147): error CS0841: Cannot use local variable 'result' before it is declared [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\PoolManager__Helper25_f05a8a8d.cs(169,17): error CS0136: A local or parameter named 'result' cannot be declared in this scope because that name is used in an enclosing local scope to define a local or parameter [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\PoolManager__Helper25_f05a8a8d.cs(331,39): error CS8103: Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string literals or try the EXPERIMENTAL feature flag 'experimental-data-section-string-literals'. [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\PoolManager__Helper25_f05a8a8d.cs(167,147): error CS0841: Cannot use local variable 'result' before it is declared [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\src\PoolManager__Helper25_f05a8a8d.cs(169,17): error CS0136: A local or parameter named 'result' cannot be declared in this scope because that name is used in an enclosing local scope to define a local or parameter [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Argimirodelpozo\puya-sol\Arc56.Generated.Argimirodelpozo.puya-sol.csproj]
```
