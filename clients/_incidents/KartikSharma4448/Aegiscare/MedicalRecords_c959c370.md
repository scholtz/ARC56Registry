# Generator crash: MedicalRecords_c959c370

- **Repo**: [KartikSharma4448/Aegiscare](https://github.com/KartikSharma4448/Aegiscare)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/KartikSharma4448/Aegiscare/HEAD/projects/aegis-frontend/src/contracts/MedicalRecords.arc56.json](https://raw.githubusercontent.com/KartikSharma4448/Aegiscare/HEAD/projects/aegis-frontend/src/contracts/MedicalRecords.arc56.json)
- **Namespace used**: `Arc56.Generated.KartikSharma4448.Aegiscare.MedicalRecords_c959c370`
- **Detected**: 2026-08-13T08:37:54.628079+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:373d3f7fe96a2c2c9e361a9c88d822321296511aadc0ad91910dd26077078f37`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.KartikSharma4448.Aegiscare.MedicalRecords_c959c370" \
  --url https://raw.githubusercontent.com/KartikSharma4448/Aegiscare/HEAD/projects/aegis-frontend/src/contracts/MedicalRecords.arc56.json
```

## Error

```
docker generator exited with code 139
--- stdout ---
File: artifacts/MedicalRecords_c959c370.arc56.json
Namespace: Arc56.Generated.KartikSharma4448.Aegiscare.MedicalRecords_c959c370

--- stderr ---
Unhandled exception. Newtonsoft.Json.JsonReaderException: Unexpected character encountered while parsing value: �. Path '', line 0, position 0.
   at Newtonsoft.Json.JsonTextReader.ParseValue()
   at Newtonsoft.Json.JsonTextReader.Read()
   at Newtonsoft.Json.JsonReader.ReadAndMoveToContent()
   at Newtonsoft.Json.JsonReader.ReadForType(JsonContract contract, Boolean hasConverter)
   at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.Deserialize(JsonReader reader, Type objectType, Boolean checkAdditionalContent)
   at Newtonsoft.Json.JsonSerializer.DeserializeInternal(JsonReader reader, Type objectType)
   at Newtonsoft.Json.JsonSerializer.Deserialize(JsonReader reader, Type objectType)
   at Newtonsoft.Json.JsonConvert.DeserializeObject(String value, Type type, JsonSerializerSettings settings)
   at Newtonsoft.Json.JsonConvert.DeserializeObject[T](String value, JsonSerializerSettings settings)
   at Algorand.AVM.ClientGenerator.ABI.ARC56.ClientGeneratorARC56.LoadFromByteArray(Byte[] data) in /src/dotnet-algorand-sdk/ClientGenerator/ABI/ARC56/ClientGeneratorARC56.cs:line 33
   at client_generator.Program.<>c.<<Main>b__1_1>d.MoveNext() in /src/client-generator/Program.cs:line 77
--- End of stack trace from previous location ---
   at CommandLine.ParserResultExtensions.WithParsedAsync[T](ParserResult`1 result, Func`2 action)
   at client_generator.Program.Main(String[] args) in /src/client-generator/Program.cs:line 34
   at client_generator.Program.<Main>(String[] args)

```
