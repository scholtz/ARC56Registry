# Generator crash: ByteArrays_8be2968f

- **Repo**: [algorandfoundation/algokit-utils-ts](https://github.com/algorandfoundation/algokit-utils-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/algokit-utils-ts/HEAD/tests/example-contracts/byte_arrays/artifacts/ByteArrays.arc56.json](https://raw.githubusercontent.com/algorandfoundation/algokit-utils-ts/HEAD/tests/example-contracts/byte_arrays/artifacts/ByteArrays.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.algokit_utils_ts.ByteArrays_8be2968f`
- **Detected**: 2026-10-23T11:09:39.933214+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:4c7f0b02126c7a2565338efea6e3a214b086d319bc88c43d227a9fc55b907289`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.algokit_utils_ts.ByteArrays_8be2968f" \
  --url https://raw.githubusercontent.com/algorandfoundation/algokit-utils-ts/HEAD/tests/example-contracts/byte_arrays/artifacts/ByteArrays.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/ByteArrays_8be2968f.arc56.json
Namespace: Arc56.Generated.algorandfoundation.algokit_utils_ts.ByteArrays_8be2968f

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: [. Path 'structs.ByteArraysInStruct[2].type', line 102, position 17.

```
