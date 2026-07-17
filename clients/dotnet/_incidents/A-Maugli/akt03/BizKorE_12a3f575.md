# Generated code fails to compile: BizKorE_12a3f575

- **Repo**: [A-Maugli/akt03](https://github.com/A-Maugli/akt03)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/A-Maugli/akt03/HEAD/biz_kor/projects/biz_kor-contracts/smart_contracts/artifacts/biz_kor/BizKorE.arc56.json](https://raw.githubusercontent.com/A-Maugli/akt03/HEAD/biz_kor/projects/biz_kor-contracts/smart_contracts/artifacts/biz_kor/BizKorE.arc56.json)
- **Namespace used**: `Arc56.Generated.A_Maugli.akt03.BizKorE_12a3f575`
- **Detected**: 2026-07-16T23:57:59.568131+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:e738b4d750aa1f25bbc94eec6a9322ce0e3d53dfeb06368c5806ae7475b201f7`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.A_Maugli.akt03.BizKorE_12a3f575" \
  --url https://raw.githubusercontent.com/A-Maugli/akt03/HEAD/biz_kor/projects/biz_kor-contracts/smart_contracts/artifacts/biz_kor/BizKorE.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\A-Maugli\akt03\src\BizKorE_12a3f575.cs(119,38): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\A-Maugli\akt03\Arc56.Generated.A-Maugli.akt03.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\A-Maugli\akt03\src\BizKorE_12a3f575.cs(119,38): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\A-Maugli\akt03\Arc56.Generated.A-Maugli.akt03.csproj]
```
