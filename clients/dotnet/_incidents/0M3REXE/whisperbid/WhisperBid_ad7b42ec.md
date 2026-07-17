# Generated code fails to compile: WhisperBid_ad7b42ec

- **Repo**: [0M3REXE/whisperbid](https://github.com/0M3REXE/whisperbid)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/0M3REXE/whisperbid/HEAD/projects/whisperbid-contracts/smart_contracts/artifacts/whisper_bid/WhisperBid.arc56.json](https://raw.githubusercontent.com/0M3REXE/whisperbid/HEAD/projects/whisperbid-contracts/smart_contracts/artifacts/whisper_bid/WhisperBid.arc56.json)
- **Namespace used**: `Arc56.Generated._0M3REXE.whisperbid.WhisperBid_ad7b42ec`
- **Detected**: 2026-07-17T00:15:09.817273+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated._0M3REXE.whisperbid.WhisperBid_ad7b42ec" \
  --url https://raw.githubusercontent.com/0M3REXE/whisperbid/HEAD/projects/whisperbid-contracts/smart_contracts/artifacts/whisper_bid/WhisperBid.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0M3REXE\whisperbid\src\WhisperBid_ad7b42ec.cs(118,41): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0M3REXE\whisperbid\Arc56.Generated.0M3REXE.whisperbid.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0M3REXE\whisperbid\src\WhisperBid_ad7b42ec.cs(132,41): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0M3REXE\whisperbid\Arc56.Generated.0M3REXE.whisperbid.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0M3REXE\whisperbid\src\WhisperBid_ad7b42ec.cs(152,31): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0M3REXE\whisperbid\Arc56.Generated.0M3REXE.whisperbid.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0M3REXE\whisperbid\src\WhisperBid_ad7b42ec.cs(167,31): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0M3REXE\whisperbid\Arc56.Generated.0M3REXE.whisperbid.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0M3REXE\whisperbid\src\WhisperBid_ad7b42ec.cs(118,41): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0M3REXE\whisperbid\Arc56.Generated.0M3REXE.whisperbid.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0M3REXE\whisperbid\src\WhisperBid_ad7b42ec.cs(132,41): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0M3REXE\whisperbid\Arc56.Generated.0M3REXE.whisperbid.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0M3REXE\whisperbid\src\WhisperBid_ad7b42ec.cs(152,31): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0M3REXE\whisperbid\Arc56.Generated.0M3REXE.whisperbid.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0M3REXE\whisperbid\src\WhisperBid_ad7b42ec.cs(167,31): error CS1729: 'VariableArray<Byte>' does not contain a constructor that takes 1 arguments [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\0M3REXE\whisperbid\Arc56.Generated.0M3REXE.whisperbid.csproj]
```
