# Generator crash: application_f99f74cb

- **Repo**: [algorandecosystem/algokit-core](https://github.com/algorandecosystem/algokit-core)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandecosystem/algokit-core/HEAD/crates/algokit_test_artifacts/contracts/reti/application.arc56.json](https://raw.githubusercontent.com/algorandecosystem/algokit-core/HEAD/crates/algokit_test_artifacts/contracts/reti/application.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandecosystem.algokit_core.application_f99f74cb`
- **Detected**: 2026-10-20T11:01:48.432025+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:f7aaa620d62a7a766c9f2ae99d41d7ac7dc6f7d76fecd4ebd66d057e930a575d`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandecosystem.algokit_core.application_f99f74cb" \
  --url https://raw.githubusercontent.com/algorandecosystem/algokit-core/HEAD/crates/algokit_test_artifacts/contracts/reti/application.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/application_f99f74cb.arc56.json
Namespace: Arc56.Generated.algorandecosystem.algokit_core.application_f99f74cb

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: [. Path 'structs.ValidatorInfo[0].type', line 1087, position 17.

```
