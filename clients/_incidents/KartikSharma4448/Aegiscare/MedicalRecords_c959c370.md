# Generator crash: MedicalRecords_c959c370

- **Repo**: [KartikSharma4448/Aegiscare](https://github.com/KartikSharma4448/Aegiscare)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/KartikSharma4448/Aegiscare/HEAD/projects/aegis-frontend/src/contracts/MedicalRecords.arc56.json](https://raw.githubusercontent.com/KartikSharma4448/Aegiscare/HEAD/projects/aegis-frontend/src/contracts/MedicalRecords.arc56.json)
- **Namespace used**: `Arc56.Generated.KartikSharma4448.Aegiscare.MedicalRecords_c959c370`
- **Detected**: 2026-10-23T11:30:22.324779+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:4c7f0b02126c7a2565338efea6e3a214b086d319bc88c43d227a9fc55b907289`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.KartikSharma4448.Aegiscare.MedicalRecords_c959c370" \
  --url https://raw.githubusercontent.com/KartikSharma4448/Aegiscare/HEAD/projects/aegis-frontend/src/contracts/MedicalRecords.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/MedicalRecords_c959c370.arc56.json
Namespace: Arc56.Generated.KartikSharma4448.Aegiscare.MedicalRecords_c959c370

--- stderr ---
Error: could not generate a client from the spec: Unexpected character encountered while parsing value: �. Path '', line 0, position 0.

```
