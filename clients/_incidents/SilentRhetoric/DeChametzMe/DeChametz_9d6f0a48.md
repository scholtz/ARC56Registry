# Generator crash: DeChametz_9d6f0a48

- **Repo**: [SilentRhetoric/DeChametzMe](https://github.com/SilentRhetoric/DeChametzMe)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/SilentRhetoric/DeChametzMe/HEAD/projects/deChametzMe-contracts/smart_contracts/artifacts/de_chametz/DeChametz.arc56.json](https://raw.githubusercontent.com/SilentRhetoric/DeChametzMe/HEAD/projects/deChametzMe-contracts/smart_contracts/artifacts/de_chametz/DeChametz.arc56.json)
- **Namespace used**: `Arc56.Generated.SilentRhetoric.DeChametzMe.DeChametz_9d6f0a48`
- **Detected**: 2026-10-23T11:40:33.086085+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:4c7f0b02126c7a2565338efea6e3a214b086d319bc88c43d227a9fc55b907289`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.SilentRhetoric.DeChametzMe.DeChametz_9d6f0a48" \
  --url https://raw.githubusercontent.com/SilentRhetoric/DeChametzMe/HEAD/projects/deChametzMe-contracts/smart_contracts/artifacts/de_chametz/DeChametz.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/DeChametz_9d6f0a48.arc56.json
Namespace: Arc56.Generated.SilentRhetoric.DeChametzMe.DeChametz_9d6f0a48

--- stderr ---
Error: the contract spec was rejected: The method name "Bootstrap contract" is not a plain identifier ([A-Za-z_][A-Za-z0-9_]*) and cannot be used to generate code.

```
