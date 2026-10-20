# Generator crash: Reti_cb1e912a

- **Repo**: [algorandfoundation/algokit-client-generator-ts](https://github.com/algorandfoundation/algokit-client-generator-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/algokit-client-generator-ts/HEAD/examples/smart_contracts/artifacts/reti/Reti.arc56.json](https://raw.githubusercontent.com/algorandfoundation/algokit-client-generator-ts/HEAD/examples/smart_contracts/artifacts/reti/Reti.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandfoundation.algokit_client_generator_ts.Reti_cb1e912a`
- **Detected**: 2026-10-20T11:02:16.439947+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:f7aaa620d62a7a766c9f2ae99d41d7ac7dc6f7d76fecd4ebd66d057e930a575d`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandfoundation.algokit_client_generator_ts.Reti_cb1e912a" \
  --url https://raw.githubusercontent.com/algorandfoundation/algokit-client-generator-ts/HEAD/examples/smart_contracts/artifacts/reti/Reti.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/Reti_cb1e912a.arc56.json
Namespace: Arc56.Generated.algorandfoundation.algokit_client_generator_ts.Reti_cb1e912a

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: [. Path 'structs.ValidatorInfo[0].type', line 1087, position 17.

```
