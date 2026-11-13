# Generator crash: CompxGovernance_46f65b60

- **Repo**: [compx-labs/governance-contracts](https://github.com/compx-labs/governance-contracts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/compx-labs/governance-contracts/HEAD/projects/compx-governance/contracts/artifacts/CompxGovernance.arc56.json](https://raw.githubusercontent.com/compx-labs/governance-contracts/HEAD/projects/compx-governance/contracts/artifacts/CompxGovernance.arc56.json)
- **Namespace used**: `Arc56.Generated.compx_labs.governance_contracts.CompxGovernance_46f65b60`
- **Detected**: 2026-11-13T14:14:19.547394+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:23f962c15728699da4c86c52c95d65d4bca48d37e1e21665a2d9d2d181121ddf`

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
