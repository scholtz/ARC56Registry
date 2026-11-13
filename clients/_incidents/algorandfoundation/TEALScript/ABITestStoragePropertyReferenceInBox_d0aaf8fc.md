# Generator crash: ABITestStoragePropertyReferenceInBox_d0aaf8fc

- **Repo**: [algorandfoundation/TEALScript](https://github.com/algorandfoundation/TEALScript)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ABITestStoragePropertyReferenceInBox.arc56.json](https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ABITestStoragePropertyReferenceInBox.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.TEALScript.ABITestStoragePropertyReferenceInBox_d0aaf8fc`
- **Detected**: 2026-11-13T14:08:25.254185+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:23f962c15728699da4c86c52c95d65d4bca48d37e1e21665a2d9d2d181121ddf`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.TEALScript.ABITestStoragePropertyReferenceInBox_d0aaf8fc" \
  --url https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ABITestStoragePropertyReferenceInBox.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/ABITestStoragePropertyReferenceInBox_d0aaf8fc.arc56.json
Namespace: Arc56.Generated.algorandfoundation.TEALScript.ABITestStoragePropertyReferenceInBox_d0aaf8fc

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: [. Path 'structs['{ foo: Address; bar: { baz: uint64 } }'][1].type', line 44, position 17.

```
