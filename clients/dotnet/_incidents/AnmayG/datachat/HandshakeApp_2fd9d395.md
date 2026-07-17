# Generated code fails to compile: HandshakeApp_2fd9d395

- **Repo**: [AnmayG/datachat](https://github.com/AnmayG/datachat)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/AnmayG/datachat/HEAD/src/smartcontract/HandshakeApp.arc56.json](https://raw.githubusercontent.com/AnmayG/datachat/HEAD/src/smartcontract/HandshakeApp.arc56.json)
- **Namespace used**: `Arc56.Generated.AnmayG.datachat.HandshakeApp_2fd9d395`
- **Detected**: 2026-07-17T00:07:11.261111+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:e738b4d750aa1f25bbc94eec6a9322ce0e3d53dfeb06368c5806ae7475b201f7`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.AnmayG.datachat.HandshakeApp_2fd9d395" \
  --url https://raw.githubusercontent.com/AnmayG/datachat/HEAD/src/smartcontract/HandshakeApp.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnmayG\datachat\src\HandshakeApp_2fd9d395.cs(137,35): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnmayG\datachat\Arc56.Generated.AnmayG.datachat.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnmayG\datachat\src\HandshakeApp_2fd9d395.cs(158,35): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnmayG\datachat\Arc56.Generated.AnmayG.datachat.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnmayG\datachat\src\HandshakeApp_2fd9d395.cs(137,35): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnmayG\datachat\Arc56.Generated.AnmayG.datachat.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnmayG\datachat\src\HandshakeApp_2fd9d395.cs(158,35): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\AnmayG\datachat\Arc56.Generated.AnmayG.datachat.csproj]
```
