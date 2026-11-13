# Generator crash: DemoContract_ba10b472

- **Repo**: [algorandfoundation/puya](https://github.com/algorandfoundation/puya)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/struct_by_name/out/DemoContract.arc56.json](https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/struct_by_name/out/DemoContract.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.puya.DemoContract_ba10b472`
- **Detected**: 2026-11-13T13:55:33.229497+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:23f962c15728699da4c86c52c95d65d4bca48d37e1e21665a2d9d2d181121ddf`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.puya.DemoContract_ba10b472" \
  --url https://raw.githubusercontent.com/algorandfoundation/puya/HEAD/test_cases/struct_by_name/out/DemoContract.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/DemoContract_ba10b472.arc56.json
Namespace: Arc56.Generated.algorandfoundation.puya.DemoContract_ba10b472

--- stderr ---
Error: the contract spec was rejected: The return struct of method 'get_three' "test_cases.struct_by_name.mod.StructTwo" is not a valid ABI type string and cannot be used to generate code.

```
