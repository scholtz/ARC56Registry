# Generator crash: application_f99f74cb

- **Repo**: [algorandecosystem/algokit-core](https://github.com/algorandecosystem/algokit-core)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandecosystem/algokit-core/HEAD/crates/algokit_test_artifacts/contracts/reti/application.arc56.json](https://raw.githubusercontent.com/algorandecosystem/algokit-core/HEAD/crates/algokit_test_artifacts/contracts/reti/application.arc56.json)
- **Namespace used**: `Arc56.Generated.algorandecosystem.algokit_core.application_f99f74cb`
- **Detected**: 2026-07-21T08:15:22.195054+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:0093cb1562e2d8125477e45e9b2045a81c983a91f38f1a2f9b738be110520613`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.algorandecosystem.algokit_core.application_f99f74cb" \
  --url https://raw.githubusercontent.com/algorandecosystem/algokit-core/HEAD/crates/algokit_test_artifacts/contracts/reti/application.arc56.json
```

## Error

```
docker generator exited with code 139
--- stdout ---
File: artifacts/application_f99f74cb.arc56.json
Namespace: Arc56.Generated.algorandecosystem.algokit_core.application_f99f74cb

--- stderr ---
Unhandled exception. Newtonsoft.Json.JsonReaderException: Unexpected character encountered while parsing value: [. Path 'structs.ValidatorInfo[0].type', line 1087, position 17.
   at Newtonsoft.Json.JsonTextReader.ReadStringValue(ReadType readType)
   at Newtonsoft.Json.JsonTextReader.ReadAsString()
   at Newtonsoft.Json.JsonReader.ReadForType(JsonContract contract, Boolean hasConverter)
   at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PopulateObject(Object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, String id)
   at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, Object existingValue)
   at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, Object existingValue)
   at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, String id)
   at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, Object existingValue, String id)
   at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, Object existingValue)
   at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, String id)
   at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, Object existingValue)
   at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, Object existingValue)
   at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, Object target)
   at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PopulateObject(Object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, String id)
   at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, Object existingValue)
   at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, Object existingValue)
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
