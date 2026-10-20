# Generator crash: MedicalRecords_c959c370

- **Repo**: [KartikSharma4448/Aegiscare](https://github.com/KartikSharma4448/Aegiscare)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/KartikSharma4448/Aegiscare/HEAD/projects/aegis-frontend/src/contracts/MedicalRecords.arc56.json](https://raw.githubusercontent.com/KartikSharma4448/Aegiscare/HEAD/projects/aegis-frontend/src/contracts/MedicalRecords.arc56.json)
- **Namespace used**: `Arc56.Generated.KartikSharma4448.Aegiscare.MedicalRecords_c959c370`
- **Detected**: 2026-10-20T11:19:41.535475+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:f7aaa620d62a7a766c9f2ae99d41d7ac7dc6f7d76fecd4ebd66d057e930a575d`

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
