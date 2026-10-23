# Generator crash: nested_struct_223aa7f8

- **Repo**: [algorandfoundation/algokit-utils-py](https://github.com/algorandfoundation/algokit-utils-py)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/algokit-utils-py/HEAD/tests/artifacts/nested_struct/nested_struct.arc56.json](https://raw.githubusercontent.com/algorandfoundation/algokit-utils-py/HEAD/tests/artifacts/nested_struct/nested_struct.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.algokit_utils_py.nested_struct_223aa7f8`
- **Detected**: 2026-10-23T11:09:34.762287+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:4c7f0b02126c7a2565338efea6e3a214b086d319bc88c43d227a9fc55b907289`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.algokit_utils_py.nested_struct_223aa7f8" \
  --url https://raw.githubusercontent.com/algorandfoundation/algokit-utils-py/HEAD/tests/artifacts/nested_struct/nested_struct.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/nested_struct_223aa7f8.arc56.json
Namespace: Arc56.Generated.algorandfoundation.algokit_utils_py.nested_struct_223aa7f8

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: [. Path 'structs.Struct2[0].type', line 68, position 17.

```
