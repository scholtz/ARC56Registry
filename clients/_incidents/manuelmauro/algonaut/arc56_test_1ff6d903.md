# Generator crash: arc56_test_1ff6d903

- **Repo**: [manuelmauro/algonaut](https://github.com/manuelmauro/algonaut)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/manuelmauro/algonaut/HEAD/tests/fixtures/arc56_test.arc56.json](https://raw.githubusercontent.com/manuelmauro/algonaut/HEAD/tests/fixtures/arc56_test.arc56.json)
- **Namespace used**: `Arc56.Generated.manuelmauro.algonaut.arc56_test_1ff6d903`
- **Detected**: 2026-11-13T14:21:57.934484+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:23f962c15728699da4c86c52c95d65d4bca48d37e1e21665a2d9d2d181121ddf`

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
