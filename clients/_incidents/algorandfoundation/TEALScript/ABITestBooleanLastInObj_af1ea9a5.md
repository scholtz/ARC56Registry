# Generator crash: ABITestBooleanLastInObj_af1ea9a5

- **Repo**: [algorandfoundation/TEALScript](https://github.com/algorandfoundation/TEALScript)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ABITestBooleanLastInObj.arc56.json](https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ABITestBooleanLastInObj.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.TEALScript.ABITestBooleanLastInObj_af1ea9a5`
- **Detected**: 2026-11-13T14:06:35.070629+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:23f962c15728699da4c86c52c95d65d4bca48d37e1e21665a2d9d2d181121ddf`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.TEALScript.ABITestBooleanLastInObj_af1ea9a5" \
  --url https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ABITestBooleanLastInObj.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/ABITestBooleanLastInObj_af1ea9a5.arc56.json
Namespace: Arc56.Generated.algorandfoundation.TEALScript.ABITestBooleanLastInObj_af1ea9a5

--- stderr ---
Error: the contract spec was rejected: The return struct of method 'booleanLastInObj' "{ n: uint64; b: boolean; }" is not a valid ABI type string and cannot be used to generate code.

```
