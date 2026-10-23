# Generator crash: ABITestUpdateStaticFieldInDynamicObjectInBox_80f6c15d

- **Repo**: [algorandfoundation/TEALScript](https://github.com/algorandfoundation/TEALScript)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ABITestUpdateStaticFieldInDynamicObjectInBox.arc56.json](https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ABITestUpdateStaticFieldInDynamicObjectInBox.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.TEALScript.ABITestUpdateStaticFieldInDynamicObjectInBox_80f6c15d`
- **Detected**: 2026-10-23T11:16:22.992806+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:4c7f0b02126c7a2565338efea6e3a214b086d319bc88c43d227a9fc55b907289`

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
