# Generator crash: waypoint_registry_5e022675

- **Repo**: [compx-labs/waypoint](https://github.com/compx-labs/waypoint)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/compx-labs/waypoint/HEAD/contracts/algorand/projects/algorand/smart_contracts/artifacts/waypoint_registry/waypoint-registry.arc56.json](https://raw.githubusercontent.com/compx-labs/waypoint/HEAD/contracts/algorand/projects/algorand/smart_contracts/artifacts/waypoint_registry/waypoint-registry.arc56.json)
- **Namespace used**: `Arc56.Generated.compx_labs.waypoint.waypoint_registry_5e022675`
- **Detected**: 2026-11-13T14:14:26.772942+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:23f962c15728699da4c86c52c95d65d4bca48d37e1e21665a2d9d2d181121ddf`

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
