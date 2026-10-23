# Generator crash: arc56_test_1ff6d903

- **Repo**: [manuelmauro/algonaut](https://github.com/manuelmauro/algonaut)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/manuelmauro/algonaut/HEAD/tests/fixtures/arc56_test.arc56.json](https://raw.githubusercontent.com/manuelmauro/algonaut/HEAD/tests/fixtures/arc56_test.arc56.json)
- **Namespace used**: `Arc56.Generated.manuelmauro.algonaut.arc56_test_1ff6d903`
- **Detected**: 2026-10-23T11:31:51.844061+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:4c7f0b02126c7a2565338efea6e3a214b086d319bc88c43d227a9fc55b907289`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.manuelmauro.algonaut.arc56_test_1ff6d903" \
  --url https://raw.githubusercontent.com/manuelmauro/algonaut/HEAD/tests/fixtures/arc56_test.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/arc56_test_1ff6d903.arc56.json
Namespace: Arc56.Generated.manuelmauro.algonaut.arc56_test_1ff6d903

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: [. Path 'structs.Inputs[0].type', line 80, position 25.

```
