# Generator crash: Reti_07d892ae

- **Repo**: [algorandfoundation/algokit-ts](https://github.com/algorandfoundation/algokit-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/algokit-ts/HEAD/algokit-client-generator-ts/examples/smart_contracts/artifacts/reti/Reti.arc56.json](https://raw.githubusercontent.com/algorandfoundation/algokit-ts/HEAD/algokit-client-generator-ts/examples/smart_contracts/artifacts/reti/Reti.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.algokit_ts.Reti_07d892ae`
- **Detected**: 2026-11-13T13:44:00.191443+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:23f962c15728699da4c86c52c95d65d4bca48d37e1e21665a2d9d2d181121ddf`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.algokit_ts.Reti_07d892ae" \
  --url https://raw.githubusercontent.com/algorandfoundation/algokit-ts/HEAD/algokit-client-generator-ts/examples/smart_contracts/artifacts/reti/Reti.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/Reti_07d892ae.arc56.json
Namespace: Arc56.Generated.algorandfoundation.algokit_ts.Reti_07d892ae

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: [. Path 'structs.ValidatorInfo[0].type', line 1087, position 17.

```
