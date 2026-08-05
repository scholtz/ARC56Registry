# Generator crash: MedicalRecords_e4a5b094

- **Repo**: [Yashwanth112004/Hackseries-3.0](https://github.com/Yashwanth112004/Hackseries-3.0)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Yashwanth112004/Hackseries-3.0/HEAD/projects/ojasraksha-frontend/src/contracts/MedicalRecords.arc56.json](https://raw.githubusercontent.com/Yashwanth112004/Hackseries-3.0/HEAD/projects/ojasraksha-frontend/src/contracts/MedicalRecords.arc56.json)
- **Namespace used**: `Arc56.Generated.Yashwanth112004.Hackseries_3_0.MedicalRecords_e4a5b094`
- **Detected**: 2026-08-05T09:59:42.333351+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:508821bfbb37c3c0d4d6f2867be89c794b766971b607e9ee5b39cde816fbb352`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.Yashwanth112004.Hackseries_3_0.MedicalRecords_e4a5b094" \
  --url https://raw.githubusercontent.com/Yashwanth112004/Hackseries-3.0/HEAD/projects/ojasraksha-frontend/src/contracts/MedicalRecords.arc56.json
```

## Error

```
docker generator exited with code 139
--- stdout ---
File: artifacts/MedicalRecords_e4a5b094.arc56.json
Namespace: Arc56.Generated.Yashwanth112004.Hackseries_3_0.MedicalRecords_e4a5b094

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
