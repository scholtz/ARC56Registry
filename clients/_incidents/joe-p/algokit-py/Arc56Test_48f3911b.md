# Generator crash: Arc56Test_48f3911b

- **Repo**: [joe-p/algokit-py](https://github.com/joe-p/algokit-py)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/joe-p/algokit-py/HEAD/algokit-client-generator-py/examples/smart_contracts/artifacts/arc56_test/Arc56Test.arc56.json](https://raw.githubusercontent.com/joe-p/algokit-py/HEAD/algokit-client-generator-py/examples/smart_contracts/artifacts/arc56_test/Arc56Test.arc56.json)
- **Namespace used**: `Arc56.Generated.joe_p.algokit_py.Arc56Test_48f3911b`
- **Detected**: 2026-11-11T13:17:05.835751+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:4c7f0b02126c7a2565338efea6e3a214b086d319bc88c43d227a9fc55b907289`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.joe_p.algokit_py.Arc56Test_48f3911b" \
  --url https://raw.githubusercontent.com/joe-p/algokit-py/HEAD/algokit-client-generator-py/examples/smart_contracts/artifacts/arc56_test/Arc56Test.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/Arc56Test_48f3911b.arc56.json
Namespace: Arc56.Generated.joe_p.algokit_py.Arc56Test_48f3911b

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: [. Path 'structs.Inputs[0].type', line 80, position 25.

```
