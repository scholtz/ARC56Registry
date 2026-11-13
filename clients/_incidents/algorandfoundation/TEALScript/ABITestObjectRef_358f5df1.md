# Generator crash: ABITestObjectRef_358f5df1

- **Repo**: [algorandfoundation/TEALScript](https://github.com/algorandfoundation/TEALScript)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ABITestObjectRef.arc56.json](https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ABITestObjectRef.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.TEALScript.ABITestObjectRef_358f5df1`
- **Detected**: 2026-11-13T14:07:44.854665+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:23f962c15728699da4c86c52c95d65d4bca48d37e1e21665a2d9d2d181121ddf`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.TEALScript.ABITestObjectRef_358f5df1" \
  --url https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ABITestObjectRef.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/ABITestObjectRef_358f5df1.arc56.json
Namespace: Arc56.Generated.algorandfoundation.TEALScript.ABITestObjectRef_358f5df1

--- stderr ---
Error: the contract spec was rejected: The return struct of method 'objectRef' "{ foo: uint64; }" is not a valid ABI type string and cannot be used to generate code.

```
