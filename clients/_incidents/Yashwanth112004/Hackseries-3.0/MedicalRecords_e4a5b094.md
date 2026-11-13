# Generator crash: MedicalRecords_e4a5b094

- **Repo**: [Yashwanth112004/Hackseries-3.0](https://github.com/Yashwanth112004/Hackseries-3.0)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Yashwanth112004/Hackseries-3.0/HEAD/projects/ojasraksha-frontend/src/contracts/MedicalRecords.arc56.json](https://raw.githubusercontent.com/Yashwanth112004/Hackseries-3.0/HEAD/projects/ojasraksha-frontend/src/contracts/MedicalRecords.arc56.json)
- **Namespace used**: `Arc56.Generated.Yashwanth112004.Hackseries_3_0.MedicalRecords_e4a5b094`
- **Detected**: 2026-11-13T14:32:38.819198+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:23f962c15728699da4c86c52c95d65d4bca48d37e1e21665a2d9d2d181121ddf`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.Yashwanth112004.Hackseries_3_0.MedicalRecords_e4a5b094" \
  --url https://raw.githubusercontent.com/Yashwanth112004/Hackseries-3.0/HEAD/projects/ojasraksha-frontend/src/contracts/MedicalRecords.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/MedicalRecords_e4a5b094.arc56.json
Namespace: Arc56.Generated.Yashwanth112004.Hackseries_3_0.MedicalRecords_e4a5b094

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: �. Path '', line 0, position 0.

```
