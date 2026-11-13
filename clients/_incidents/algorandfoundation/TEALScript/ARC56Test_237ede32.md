# Generator crash: ARC56Test_237ede32

- **Repo**: [algorandfoundation/TEALScript](https://github.com/algorandfoundation/TEALScript)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ARC56Test.arc56.json](https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ARC56Test.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.TEALScript.ARC56Test_237ede32`
- **Detected**: 2026-11-13T14:09:03.441641+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:23f962c15728699da4c86c52c95d65d4bca48d37e1e21665a2d9d2d181121ddf`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.TEALScript.ARC56Test_237ede32" \
  --url https://raw.githubusercontent.com/algorandfoundation/TEALScript/HEAD/tests/contracts/artifacts/ARC56Test.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/ARC56Test_237ede32.arc56.json
Namespace: Arc56.Generated.algorandfoundation.TEALScript.ARC56Test_237ede32

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: [. Path 'structs.Inputs[0].type', line 120, position 17.

```
