# Generator crash: flux_gate_9fada13f

- **Repo**: [compx-labs/flux-access-controls](https://github.com/compx-labs/flux-access-controls)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/compx-labs/flux-access-controls/HEAD/projects/flux-access-controls/smart_contracts/artifacts/flux_gate/flux-gate.arc56.json](https://raw.githubusercontent.com/compx-labs/flux-access-controls/HEAD/projects/flux-access-controls/smart_contracts/artifacts/flux_gate/flux-gate.arc56.json)
- **Namespace used**: `Arc56.Generated.compx_labs.flux_access_controls.flux_gate_9fada13f`
- **Detected**: 2026-10-23T11:22:43.370319+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:4c7f0b02126c7a2565338efea6e3a214b086d319bc88c43d227a9fc55b907289`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.compx_labs.flux_access_controls.flux_gate_9fada13f" \
  --url https://raw.githubusercontent.com/compx-labs/flux-access-controls/HEAD/projects/flux-access-controls/smart_contracts/artifacts/flux_gate/flux-gate.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/flux_gate_9fada13f.arc56.json
Namespace: Arc56.Generated.compx_labs.flux_access_controls.flux_gate_9fada13f

--- stderr ---
Error: the contract spec was rejected: The contract name "flux-gate" is not a plain identifier ([A-Za-z_][A-Za-z0-9_]*) and cannot be used to generate code.

```
