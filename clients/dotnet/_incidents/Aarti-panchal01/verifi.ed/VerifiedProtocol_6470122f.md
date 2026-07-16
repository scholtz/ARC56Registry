# Generated code fails to compile: VerifiedProtocol_6470122f

- **Repo**: [Aarti-panchal01/verifi.ed](https://github.com/Aarti-panchal01/verifi.ed)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Aarti-panchal01/verifi.ed/HEAD/smart_contracts/artifacts/verified_protocol/VerifiedProtocol.arc56.json](https://raw.githubusercontent.com/Aarti-panchal01/verifi.ed/HEAD/smart_contracts/artifacts/verified_protocol/VerifiedProtocol.arc56.json)
- **Namespace used**: `Arc56.Generated.Aarti_panchal01.verifi_ed.VerifiedProtocol_6470122f`
- **Detected**: 2026-07-16T23:47:46.393744+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:e738b4d750aa1f25bbc94eec6a9322ce0e3d53dfeb06368c5806ae7475b201f7`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.Aarti_panchal01.verifi_ed.VerifiedProtocol_6470122f" \
  --url https://raw.githubusercontent.com/Aarti-panchal01/verifi.ed/HEAD/smart_contracts/artifacts/verified_protocol/VerifiedProtocol.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aarti-panchal01\verifi.ed\src\VerifiedProtocol_6470122f.cs(112,38): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aarti-panchal01\verifi.ed\Arc56.Generated.Aarti-panchal01.verifi.ed.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aarti-panchal01\verifi.ed\src\VerifiedProtocol_6470122f.cs(112,38): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\Aarti-panchal01\verifi.ed\Arc56.Generated.Aarti-panchal01.verifi.ed.csproj]
```
