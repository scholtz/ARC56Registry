# Generated code fails to compile: Petition_f12fa825

- **Repo**: [atsoc1993/On-Chain-Petitions-V2](https://github.com/atsoc1993/On-Chain-Petitions-V2)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/atsoc1993/On-Chain-Petitions-V2/HEAD/python_implementations/contract/contract_files/Petition.arc56.json](https://raw.githubusercontent.com/atsoc1993/On-Chain-Petitions-V2/HEAD/python_implementations/contract/contract_files/Petition.arc56.json)
- **Namespace used**: `Arc56.Generated.atsoc1993.On_Chain_Petitions_V2.Petition_f12fa825`
- **Detected**: 2026-07-17T07:50:01.271010+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.atsoc1993.On_Chain_Petitions_V2.Petition_f12fa825" \
  --url https://raw.githubusercontent.com/atsoc1993/On-Chain-Petitions-V2/HEAD/python_implementations/contract/contract_files/Petition.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\atsoc1993\On-Chain-Petitions-V2\src\Petition_f12fa825.cs(110,31): error CS0542: 'Comment': member names cannot be the same as their enclosing type [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\atsoc1993\On-Chain-Petitions-V2\Arc56.Generated.atsoc1993.On-Chain-Petitions-V2.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\atsoc1993\On-Chain-Petitions-V2\src\Petition_f12fa825.cs(252,30): error CS0542: 'TimeSigned': member names cannot be the same as their enclosing type [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\atsoc1993\On-Chain-Petitions-V2\Arc56.Generated.atsoc1993.On-Chain-Petitions-V2.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\atsoc1993\On-Chain-Petitions-V2\src\Petition_f12fa825.cs(110,31): error CS0542: 'Comment': member names cannot be the same as their enclosing type [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\atsoc1993\On-Chain-Petitions-V2\Arc56.Generated.atsoc1993.On-Chain-Petitions-V2.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\atsoc1993\On-Chain-Petitions-V2\src\Petition_f12fa825.cs(252,30): error CS0542: 'TimeSigned': member names cannot be the same as their enclosing type [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\atsoc1993\On-Chain-Petitions-V2\Arc56.Generated.atsoc1993.On-Chain-Petitions-V2.csproj]
```
