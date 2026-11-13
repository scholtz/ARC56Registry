# Generator crash: full_5eb64ee7

- **Repo**: [manuelmauro/algonaut](https://github.com/manuelmauro/algonaut)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/manuelmauro/algonaut/HEAD/algonaut_abi_model/tests/fixtures/full.arc56.json](https://raw.githubusercontent.com/manuelmauro/algonaut/HEAD/algonaut_abi_model/tests/fixtures/full.arc56.json)
- **Namespace used**: `Arc56.Generated.manuelmauro.algonaut.full_5eb64ee7`
- **Detected**: 2026-11-13T14:21:54.845615+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:23f962c15728699da4c86c52c95d65d4bca48d37e1e21665a2d9d2d181121ddf`

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
