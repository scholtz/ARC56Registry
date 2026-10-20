# Generator crash: AgentEscrowVault_ce7b1e31

- **Repo**: [devndesigner6/unsubly](https://github.com/devndesigner6/unsubly)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/devndesigner6/unsubly/HEAD/smart_contracts/artifacts/AgentEscrowVault/AgentEscrowVault.arc56.json](https://raw.githubusercontent.com/devndesigner6/unsubly/HEAD/smart_contracts/artifacts/AgentEscrowVault/AgentEscrowVault.arc56.json)
- **Namespace used**: `Arc56.Generated.devndesigner6.unsubly.AgentEscrowVault_ce7b1e31`
- **Detected**: 2026-10-20T11:14:52.150926+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:f7aaa620d62a7a766c9f2ae99d41d7ac7dc6f7d76fecd4ebd66d057e930a575d`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.devndesigner6.unsubly.AgentEscrowVault_ce7b1e31" \
  --url https://raw.githubusercontent.com/devndesigner6/unsubly/HEAD/smart_contracts/artifacts/AgentEscrowVault/AgentEscrowVault.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/AgentEscrowVault_ce7b1e31.arc56.json
Namespace: Arc56.Generated.devndesigner6.unsubly.AgentEscrowVault_ce7b1e31

--- stderr ---
Error: could not generate a client from the spec: Cannot deserialize the current JSON array (e.g. [1,2,3]) into type 'System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.List`1[AVM.ClientGenerator.ABI.ARC56.StructField]]' because the type requires a JSON object (e.g. {"name":"value"}) to deserialize correctly.
To fix this error either change the JSON to a JSON object (e.g. {"name":"value"}) or change the deserialized type to an array or a type that implements a collection interface (e.g. ICollection, IList) like List<T> that can be deserialized from a JSON array. JsonArrayAttribute can also be added to the type to force it to deserialize from a JSON array.
Path 'structs', line 5, position 14.

```
