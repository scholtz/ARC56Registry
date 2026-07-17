# Generated code fails to compile: HeadsOrTails_b08111df

- **Repo**: [Algorand-Developer-Retreat/wasm-vrf-example](https://github.com/Algorand-Developer-Retreat/wasm-vrf-example)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Algorand-Developer-Retreat/wasm-vrf-example/HEAD/projects/wasm-vrf-contracts/contracts/artifacts/HeadsOrTails.arc56.json](https://raw.githubusercontent.com/Algorand-Developer-Retreat/wasm-vrf-example/HEAD/projects/wasm-vrf-contracts/contracts/artifacts/HeadsOrTails.arc56.json)
- **Namespace used**: `Arc56.Generated.Algorand_Developer_Retreat.wasm_vrf_example.HeadsOrTails_b08111df`
- **Detected**: 2026-07-17T00:03:22.235254+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:e738b4d750aa1f25bbc94eec6a9322ce0e3d53dfeb06368c5806ae7475b201f7`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.Algorand_Developer_Retreat.wasm_vrf_example.HeadsOrTails_b08111df" \
  --url https://raw.githubusercontent.com/Algorand-Developer-Retreat/wasm-vrf-example/HEAD/projects/wasm-vrf-contracts/contracts/artifacts/HeadsOrTails.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\wasm-vrf-example\src\HeadsOrTails_b08111df.cs(131,29): error CS1729: 'FixedArray<Byte>' does not contain a constructor that takes 2 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\wasm-vrf-example\Arc56.Generated.Algorand-Developer-Retreat.wasm-vrf-example.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\wasm-vrf-example\src\HeadsOrTails_b08111df.cs(153,29): error CS1729: 'FixedArray<Byte>' does not contain a constructor that takes 2 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\wasm-vrf-example\Arc56.Generated.Algorand-Developer-Retreat.wasm-vrf-example.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\wasm-vrf-example\src\HeadsOrTails_b08111df.cs(172,32): error CS1729: 'FixedArray<Byte>' does not contain a constructor that takes 2 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\wasm-vrf-example\Arc56.Generated.Algorand-Developer-Retreat.wasm-vrf-example.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\wasm-vrf-example\src\HeadsOrTails_b08111df.cs(192,32): error CS1729: 'FixedArray<Byte>' does not contain a constructor that takes 2 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\wasm-vrf-example\Arc56.Generated.Algorand-Developer-Retreat.wasm-vrf-example.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\wasm-vrf-example\src\HeadsOrTails_b08111df.cs(131,29): error CS1729: 'FixedArray<Byte>' does not contain a constructor that takes 2 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\wasm-vrf-example\Arc56.Generated.Algorand-Developer-Retreat.wasm-vrf-example.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\wasm-vrf-example\src\HeadsOrTails_b08111df.cs(153,29): error CS1729: 'FixedArray<Byte>' does not contain a constructor that takes 2 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\wasm-vrf-example\Arc56.Generated.Algorand-Developer-Retreat.wasm-vrf-example.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\wasm-vrf-example\src\HeadsOrTails_b08111df.cs(172,32): error CS1729: 'FixedArray<Byte>' does not contain a constructor that takes 2 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\wasm-vrf-example\Arc56.Generated.Algorand-Developer-Retreat.wasm-vrf-example.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\wasm-vrf-example\src\HeadsOrTails_b08111df.cs(192,32): error CS1729: 'FixedArray<Byte>' does not contain a constructor that takes 2 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\wasm-vrf-example\Arc56.Generated.Algorand-Developer-Retreat.wasm-vrf-example.csproj]
```
