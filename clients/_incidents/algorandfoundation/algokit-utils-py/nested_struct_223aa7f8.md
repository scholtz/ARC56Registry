# Generator crash: nested_struct_223aa7f8

- **Repo**: [algorandfoundation/algokit-utils-py](https://github.com/algorandfoundation/algokit-utils-py)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/algokit-utils-py/HEAD/tests/artifacts/nested_struct/nested_struct.arc56.json](https://raw.githubusercontent.com/algorandfoundation/algokit-utils-py/HEAD/tests/artifacts/nested_struct/nested_struct.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.algokit_utils_py.nested_struct_223aa7f8`
- **Detected**: 2026-10-20T11:02:32.507689+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:f7aaa620d62a7a766c9f2ae99d41d7ac7dc6f7d76fecd4ebd66d057e930a575d`

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
