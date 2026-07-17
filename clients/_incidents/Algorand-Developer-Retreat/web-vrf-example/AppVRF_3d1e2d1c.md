# Generated code fails to compile: AppVRF_3d1e2d1c

- **Repo**: [Algorand-Developer-Retreat/web-vrf-example](https://github.com/Algorand-Developer-Retreat/web-vrf-example)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Algorand-Developer-Retreat/web-vrf-example/HEAD/src/artifacts/AppVRF.arc56.json](https://raw.githubusercontent.com/Algorand-Developer-Retreat/web-vrf-example/HEAD/src/artifacts/AppVRF.arc56.json)
- **Namespace used**: `Arc56.Generated.Algorand_Developer_Retreat.web_vrf_example.AppVRF_3d1e2d1c`
- **Detected**: 2026-07-17T00:28:16.534263+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.Algorand_Developer_Retreat.web_vrf_example.AppVRF_3d1e2d1c" \
  --url https://raw.githubusercontent.com/Algorand-Developer-Retreat/web-vrf-example/HEAD/src/artifacts/AppVRF.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\web-vrf-example\src\AppVRF_3d1e2d1c.cs(128,34): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\web-vrf-example\Arc56.Generated.Algorand-Developer-Retreat.web-vrf-example.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\web-vrf-example\src\AppVRF_3d1e2d1c.cs(129,32): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\web-vrf-example\Arc56.Generated.Algorand-Developer-Retreat.web-vrf-example.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\web-vrf-example\src\AppVRF_3d1e2d1c.cs(147,34): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\web-vrf-example\Arc56.Generated.Algorand-Developer-Retreat.web-vrf-example.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\web-vrf-example\src\AppVRF_3d1e2d1c.cs(148,32): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\web-vrf-example\Arc56.Generated.Algorand-Developer-Retreat.web-vrf-example.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\web-vrf-example\src\AppVRF_3d1e2d1c.cs(128,34): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\web-vrf-example\Arc56.Generated.Algorand-Developer-Retreat.web-vrf-example.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\web-vrf-example\src\AppVRF_3d1e2d1c.cs(129,32): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\web-vrf-example\Arc56.Generated.Algorand-Developer-Retreat.web-vrf-example.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\web-vrf-example\src\AppVRF_3d1e2d1c.cs(147,34): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\web-vrf-example\Arc56.Generated.Algorand-Developer-Retreat.web-vrf-example.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\web-vrf-example\src\AppVRF_3d1e2d1c.cs(148,32): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\web-vrf-example\Arc56.Generated.Algorand-Developer-Retreat.web-vrf-example.csproj]
```
