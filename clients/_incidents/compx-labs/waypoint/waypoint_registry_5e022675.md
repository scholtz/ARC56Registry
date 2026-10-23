# Generator crash: waypoint_registry_5e022675

- **Repo**: [compx-labs/waypoint](https://github.com/compx-labs/waypoint)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/compx-labs/waypoint/HEAD/contracts/algorand/projects/algorand/smart_contracts/artifacts/waypoint_registry/waypoint-registry.arc56.json](https://raw.githubusercontent.com/compx-labs/waypoint/HEAD/contracts/algorand/projects/algorand/smart_contracts/artifacts/waypoint_registry/waypoint-registry.arc56.json)
- **Namespace used**: `Arc56.Generated.compx_labs.waypoint.waypoint_registry_5e022675`
- **Detected**: 2026-10-23T11:22:52.865285+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:4c7f0b02126c7a2565338efea6e3a214b086d319bc88c43d227a9fc55b907289`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.compx_labs.waypoint.waypoint_registry_5e022675" \
  --url https://raw.githubusercontent.com/compx-labs/waypoint/HEAD/contracts/algorand/projects/algorand/smart_contracts/artifacts/waypoint_registry/waypoint-registry.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/waypoint_registry_5e022675.arc56.json
Namespace: Arc56.Generated.compx_labs.waypoint.waypoint_registry_5e022675

--- stderr ---
Error: the contract spec was rejected: The contract name "waypoint-registry" is not a plain identifier ([A-Za-z_][A-Za-z0-9_]*) and cannot be used to generate code.

```
