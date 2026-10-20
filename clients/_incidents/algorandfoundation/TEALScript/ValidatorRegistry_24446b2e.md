# Generator crash: ValidatorRegistry_24446b2e

- **Repo**: [algorandfoundation/TEALScript](https://github.com/algorandfoundation/TEALScript)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/examples/reti/artifacts/ValidatorRegistry.arc56.json](https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/examples/reti/artifacts/ValidatorRegistry.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.TEALScript.ValidatorRegistry_24446b2e`
- **Detected**: 2026-10-20T11:05:24.788246+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:f7aaa620d62a7a766c9f2ae99d41d7ac7dc6f7d76fecd4ebd66d057e930a575d`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.TEALScript.ValidatorRegistry_24446b2e" \
  --url https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/examples/reti/artifacts/ValidatorRegistry.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/ValidatorRegistry_24446b2e.arc56.json
Namespace: Arc56.Generated.algorandfoundation.TEALScript.ValidatorRegistry_24446b2e

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: [. Path 'structs.ValidatorInfo[0].type', line 811, position 17.

```
