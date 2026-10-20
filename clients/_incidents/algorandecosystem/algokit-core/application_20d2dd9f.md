# Generator crash: application_20d2dd9f

- **Repo**: [algorandecosystem/algokit-core](https://github.com/algorandecosystem/algokit-core)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandecosystem/algokit-core/HEAD/crates/algokit_test_artifacts/contracts/arc56_struct_operations/application.arc56.json](https://raw.githubusercontent.com/algorandecosystem/algokit-core/HEAD/crates/algokit_test_artifacts/contracts/arc56_struct_operations/application.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandecosystem.algokit_core.application_20d2dd9f`
- **Detected**: 2026-10-20T11:01:32.883932+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:f7aaa620d62a7a766c9f2ae99d41d7ac7dc6f7d76fecd4ebd66d057e930a575d`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandecosystem.algokit_core.application_20d2dd9f" \
  --url https://raw.githubusercontent.com/algorandecosystem/algokit-core/HEAD/crates/algokit_test_artifacts/contracts/arc56_struct_operations/application.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/application_20d2dd9f.arc56.json
Namespace: Arc56.Generated.algorandecosystem.algokit_core.application_20d2dd9f

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: [. Path 'structs.Inputs[0].type', line 80, position 25.

```
