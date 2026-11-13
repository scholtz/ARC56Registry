# Generator crash: PaymentApp_f0e3c66a

- **Repo**: [ghoshvidip26/VoiceVaultAlgorand](https://github.com/ghoshvidip26/VoiceVaultAlgorand)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/ghoshvidip26/VoiceVaultAlgorand/HEAD/frontend/src/contracts/PaymentApp.arc56.json](https://raw.githubusercontent.com/ghoshvidip26/VoiceVaultAlgorand/HEAD/frontend/src/contracts/PaymentApp.arc56.json)
- **Namespace used**: `Arc56.Generated.ghoshvidip26.VoiceVaultAlgorand.PaymentApp_f0e3c66a`
- **Detected**: 2026-11-13T14:17:42.349931+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:23f962c15728699da4c86c52c95d65d4bca48d37e1e21665a2d9d2d181121ddf`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.ghoshvidip26.VoiceVaultAlgorand.PaymentApp_f0e3c66a" \
  --url https://raw.githubusercontent.com/ghoshvidip26/VoiceVaultAlgorand/HEAD/frontend/src/contracts/PaymentApp.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/PaymentApp_f0e3c66a.arc56.json
Namespace: Arc56.Generated.ghoshvidip26.VoiceVaultAlgorand.PaymentApp_f0e3c66a

--- stderr ---
Error: the contract spec was rejected: The contract name is missing; it must be a plain identifier ([A-Za-z_][A-Za-z0-9_]*).

```
