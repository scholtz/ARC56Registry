# Generator crash: CompxGovernance_46f65b60

- **Repo**: [compx-labs/governance-contracts](https://github.com/compx-labs/governance-contracts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/compx-labs/governance-contracts/HEAD/projects/compx-governance/contracts/artifacts/CompxGovernance.arc56.json](https://raw.githubusercontent.com/compx-labs/governance-contracts/HEAD/projects/compx-governance/contracts/artifacts/CompxGovernance.arc56.json)
- **Namespace used**: `Arc56.Generated.compx_labs.governance_contracts.CompxGovernance_46f65b60`
- **Detected**: 2026-10-23T11:22:44.203251+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:4c7f0b02126c7a2565338efea6e3a214b086d319bc88c43d227a9fc55b907289`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.compx_labs.governance_contracts.CompxGovernance_46f65b60" \
  --url https://raw.githubusercontent.com/compx-labs/governance-contracts/HEAD/projects/compx-governance/contracts/artifacts/CompxGovernance.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/CompxGovernance_46f65b60.arc56.json
Namespace: Arc56.Generated.compx_labs.governance_contracts.CompxGovernance_46f65b60

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: [. Path 'structs.ProposalVoteIdType[0].type', line 256, position 17.

```
