# Generated code fails to compile: Wetrust_1233a2c7

- **Repo**: [Algorand-Developer-Retreat/WeTrust](https://github.com/Algorand-Developer-Retreat/WeTrust)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Algorand-Developer-Retreat/WeTrust/HEAD/projects/WeTrust/smart_contracts/artifacts/wetrust/Wetrust.arc56.json](https://raw.githubusercontent.com/Algorand-Developer-Retreat/WeTrust/HEAD/projects/WeTrust/smart_contracts/artifacts/wetrust/Wetrust.arc56.json)
- **Namespace used**: `Arc56.Generated.Algorand_Developer_Retreat.WeTrust.Wetrust_1233a2c7`
- **Detected**: 2026-07-17T00:01:57.287057+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:e738b4d750aa1f25bbc94eec6a9322ce0e3d53dfeb06368c5806ae7475b201f7`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.Algorand_Developer_Retreat.WeTrust.Wetrust_1233a2c7" \
  --url https://raw.githubusercontent.com/Algorand-Developer-Retreat/WeTrust/HEAD/projects/WeTrust/smart_contracts/artifacts/wetrust/Wetrust.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\WeTrust\src\Wetrust_1233a2c7.cs(162,38): error CS1729: 'VariableArray<UInt64>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\WeTrust\Arc56.Generated.Algorand-Developer-Retreat.WeTrust.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\WeTrust\src\Wetrust_1233a2c7.cs(206,38): error CS1729: 'VariableArray<UInt64>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\WeTrust\Arc56.Generated.Algorand-Developer-Retreat.WeTrust.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\WeTrust\src\Wetrust_1233a2c7.cs(162,38): error CS1729: 'VariableArray<UInt64>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\WeTrust\Arc56.Generated.Algorand-Developer-Retreat.WeTrust.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\WeTrust\src\Wetrust_1233a2c7.cs(206,38): error CS1729: 'VariableArray<UInt64>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Algorand-Developer-Retreat\WeTrust\Arc56.Generated.Algorand-Developer-Retreat.WeTrust.csproj]
```
