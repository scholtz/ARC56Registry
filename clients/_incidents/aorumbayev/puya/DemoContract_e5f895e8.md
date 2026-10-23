# Generator crash: DemoContract_e5f895e8

- **Repo**: [aorumbayev/puya](https://github.com/aorumbayev/puya)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/aorumbayev/puya/HEAD/test_cases/struct_by_name/out/DemoContract.arc56.json](https://raw.githubusercontent.com/aorumbayev/puya/HEAD/test_cases/struct_by_name/out/DemoContract.arc56.json)
- **Namespace used**: `Arc56.Generated.aorumbayev.puya.DemoContract_e5f895e8`
- **Detected**: 2026-10-23T11:20:06.331535+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:4c7f0b02126c7a2565338efea6e3a214b086d319bc88c43d227a9fc55b907289`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.aorumbayev.puya.DemoContract_e5f895e8" \
  --url https://raw.githubusercontent.com/aorumbayev/puya/HEAD/test_cases/struct_by_name/out/DemoContract.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/DemoContract_e5f895e8.arc56.json
Namespace: Arc56.Generated.aorumbayev.puya.DemoContract_e5f895e8

--- stderr ---
Error: the contract spec was rejected: The return struct of method 'get_three' "test_cases.struct_by_name.mod.StructTwo" is not a valid ABI type string and cannot be used to generate code.

```
