# Generator crash: Reti_cf77e550

- **Repo**: [joe-p/algokit-monorepo-ts](https://github.com/joe-p/algokit-monorepo-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/joe-p/algokit-monorepo-ts/HEAD/algokit-client-generator-ts/examples/smart_contracts/artifacts/reti/Reti.arc56.json](https://raw.githubusercontent.com/joe-p/algokit-monorepo-ts/HEAD/algokit-client-generator-ts/examples/smart_contracts/artifacts/reti/Reti.arc56.json)
- **Namespace used**: `Arc56.Generated.joe_p.algokit_monorepo_ts.Reti_cf77e550`
- **Detected**: 2026-10-23T10:48:06.417386+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:4c7f0b02126c7a2565338efea6e3a214b086d319bc88c43d227a9fc55b907289`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.joe_p.algokit_monorepo_ts.Reti_cf77e550" \
  --url https://raw.githubusercontent.com/joe-p/algokit-monorepo-ts/HEAD/algokit-client-generator-ts/examples/smart_contracts/artifacts/reti/Reti.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/Reti_cf77e550.arc56.json
Namespace: Arc56.Generated.joe_p.algokit_monorepo_ts.Reti_cf77e550

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: [. Path 'structs.ValidatorInfo[0].type', line 1087, position 17.

```
