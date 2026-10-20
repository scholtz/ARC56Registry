# Generator crash: DeChametz_9d6f0a48

- **Repo**: [SilentRhetoric/DeChametzMe](https://github.com/SilentRhetoric/DeChametzMe)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/SilentRhetoric/DeChametzMe/HEAD/projects/deChametzMe-contracts/smart_contracts/artifacts/de_chametz/DeChametz.arc56.json](https://raw.githubusercontent.com/SilentRhetoric/DeChametzMe/HEAD/projects/deChametzMe-contracts/smart_contracts/artifacts/de_chametz/DeChametz.arc56.json)
- **Namespace used**: `Arc56.Generated.SilentRhetoric.DeChametzMe.DeChametz_9d6f0a48`
- **Detected**: 2026-10-20T11:28:13.557620+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:f7aaa620d62a7a766c9f2ae99d41d7ac7dc6f7d76fecd4ebd66d057e930a575d`

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
