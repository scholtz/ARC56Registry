# Generator crash: ABITestUpdateStaticFieldInDynamicObjectInBox_80f6c15d

- **Repo**: [algorandfoundation/TEALScript](https://github.com/algorandfoundation/TEALScript)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ABITestUpdateStaticFieldInDynamicObjectInBox.arc56.json](https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ABITestUpdateStaticFieldInDynamicObjectInBox.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.TEALScript.ABITestUpdateStaticFieldInDynamicObjectInBox_80f6c15d`
- **Detected**: 2026-11-13T14:08:58.290333+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:23f962c15728699da4c86c52c95d65d4bca48d37e1e21665a2d9d2d181121ddf`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.TEALScript.ABITestUpdateStaticFieldInDynamicObjectInBox_80f6c15d" \
  --url https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ABITestUpdateStaticFieldInDynamicObjectInBox.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/ABITestUpdateStaticFieldInDynamicObjectInBox_80f6c15d.arc56.json
Namespace: Arc56.Generated.algorandfoundation.TEALScript.ABITestUpdateStaticFieldInDynamicObjectInBox_80f6c15d

--- stderr ---
Error: the contract spec was rejected: The struct name "{ addr: Address; str: string }" is not a plain identifier ([A-Za-z_][A-Za-z0-9_]*) and cannot be used to generate code.

```
