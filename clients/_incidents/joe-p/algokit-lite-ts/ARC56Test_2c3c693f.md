# Generator crash: ARC56Test_2c3c693f

- **Repo**: [joe-p/algokit-lite-ts](https://github.com/joe-p/algokit-lite-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/joe-p/algokit-lite-ts/HEAD/__test__/fixtures/ARC56Test.arc56.json](https://raw.githubusercontent.com/joe-p/algokit-lite-ts/HEAD/__test__/fixtures/ARC56Test.arc56.json)
- **Namespace used**: `Arc56.Generated.joe_p.algokit_lite_ts.ARC56Test_2c3c693f`
- **Detected**: 2026-09-07T11:08:43.285452+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:373d3f7fe96a2c2c9e361a9c88d822321296511aadc0ad91910dd26077078f37`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.joe_p.algokit_lite_ts.ARC56Test_2c3c693f" \
  --url https://raw.githubusercontent.com/joe-p/algokit-lite-ts/HEAD/__test__/fixtures/ARC56Test.arc56.json
```

## Error

```
docker generator exited with code 139
--- stdout ---
File: artifacts/ARC56Test_2c3c693f.arc56.json
Namespace: Arc56.Generated.joe_p.algokit_lite_ts.ARC56Test_2c3c693f

--- stderr ---
Unhandled exception. Newtonsoft.Json.JsonSerializationException: Cannot deserialize the current JSON object (e.g. {"name":"value"}) into type 'System.Collections.Generic.List`1[AVM.ClientGenerator.ABI.ARC56.StructField]' because the type requires a JSON array (e.g. [1,2,3]) to deserialize correctly.
To fix this error either change the JSON to a JSON array (e.g. [1,2,3]) or change the deserialized type so that it is a normal .NET type (e.g. not a primitive type like integer, not a collection type like an array or List<T>) that can be deserialized from a JSON object. JsonObjectAttribute can also be added to the type to force it to deserialize from a JSON object.
Path 'structs['{ foo: uint16; bar: uint16 }'].foo', line 49, position 12.
   at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, Object existingValue)
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
