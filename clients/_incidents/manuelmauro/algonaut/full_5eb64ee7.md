# Generator crash: full_5eb64ee7

- **Repo**: [manuelmauro/algonaut](https://github.com/manuelmauro/algonaut)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/manuelmauro/algonaut/HEAD/algonaut_abi_model/tests/fixtures/full.arc56.json](https://raw.githubusercontent.com/manuelmauro/algonaut/HEAD/algonaut_abi_model/tests/fixtures/full.arc56.json)
- **Namespace used**: `Arc56.Generated.manuelmauro.algonaut.full_5eb64ee7`
- **Detected**: 2026-10-20T11:20:55.044992+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:f7aaa620d62a7a766c9f2ae99d41d7ac7dc6f7d76fecd4ebd66d057e930a575d`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.manuelmauro.algonaut.full_5eb64ee7" \
  --url https://raw.githubusercontent.com/manuelmauro/algonaut/HEAD/algonaut_abi_model/tests/fixtures/full.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/full_5eb64ee7.arc56.json
Namespace: Arc56.Generated.manuelmauro.algonaut.full_5eb64ee7

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: [. Path 'structs.Outer[0].type', line 14, position 42.

```
