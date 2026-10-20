# Generator crash: Voice_a495d572

- **Repo**: [ghoshvidip26/VoiceVaultAlgorand](https://github.com/ghoshvidip26/VoiceVaultAlgorand)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/ghoshvidip26/VoiceVaultAlgorand/HEAD/frontend/src/contracts/Voice.arc56.json](https://raw.githubusercontent.com/ghoshvidip26/VoiceVaultAlgorand/HEAD/frontend/src/contracts/Voice.arc56.json)
- **Namespace used**: `Arc56.Generated.ghoshvidip26.VoiceVaultAlgorand.Voice_a495d572`
- **Detected**: 2026-10-20T11:16:44.632354+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:f7aaa620d62a7a766c9f2ae99d41d7ac7dc6f7d76fecd4ebd66d057e930a575d`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.ghoshvidip26.VoiceVaultAlgorand.Voice_a495d572" \
  --url https://raw.githubusercontent.com/ghoshvidip26/VoiceVaultAlgorand/HEAD/frontend/src/contracts/Voice.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/Voice_a495d572.arc56.json
Namespace: Arc56.Generated.ghoshvidip26.VoiceVaultAlgorand.Voice_a495d572

--- stderr ---
Error: the contract spec was rejected: The contract name is missing; it must be a plain identifier ([A-Za-z_][A-Za-z0-9_]*).

```
