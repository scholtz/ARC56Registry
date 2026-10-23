# Generator crash: PaymentApp_f0e3c66a

- **Repo**: [ghoshvidip26/VoiceVaultAlgorand](https://github.com/ghoshvidip26/VoiceVaultAlgorand)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/ghoshvidip26/VoiceVaultAlgorand/HEAD/frontend/src/contracts/PaymentApp.arc56.json](https://raw.githubusercontent.com/ghoshvidip26/VoiceVaultAlgorand/HEAD/frontend/src/contracts/PaymentApp.arc56.json)
- **Namespace used**: `Arc56.Generated.ghoshvidip26.VoiceVaultAlgorand.PaymentApp_f0e3c66a`
- **Detected**: 2026-10-23T11:26:48.999878+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:4c7f0b02126c7a2565338efea6e3a214b086d319bc88c43d227a9fc55b907289`

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
