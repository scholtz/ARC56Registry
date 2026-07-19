# Generator crash: AgentEscrowVault_ce7b1e31

- **Repo**: [devndesigner6/unsubly](https://github.com/devndesigner6/unsubly)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/devndesigner6/unsubly/HEAD/smart_contracts/artifacts/AgentEscrowVault/AgentEscrowVault.arc56.json](https://raw.githubusercontent.com/devndesigner6/unsubly/HEAD/smart_contracts/artifacts/AgentEscrowVault/AgentEscrowVault.arc56.json)
- **Namespace used**: `Arc56.Generated.devndesigner6.unsubly.AgentEscrowVault_ce7b1e31`
- **Detected**: 2026-07-19T23:41:55.259777+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:0093cb1562e2d8125477e45e9b2045a81c983a91f38f1a2f9b738be110520613`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.devndesigner6.unsubly.AgentEscrowVault_ce7b1e31" \
  --url https://raw.githubusercontent.com/devndesigner6/unsubly/HEAD/smart_contracts/artifacts/AgentEscrowVault/AgentEscrowVault.arc56.json
```

## Error

```
docker generator exited with code 139
--- stdout ---
File: artifacts/AgentEscrowVault_ce7b1e31.arc56.json
Namespace: Arc56.Generated.devndesigner6.unsubly.AgentEscrowVault_ce7b1e31

--- stderr ---
Unhandled exception. Newtonsoft.Json.JsonSerializationException: Cannot deserialize the current JSON array (e.g. [1,2,3]) into type 'System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.List`1[AVM.ClientGenerator.ABI.ARC56.StructField]]' because the type requires a JSON object (e.g. {"name":"value"}) to deserialize correctly.
To fix this error either change the JSON to a JSON object (e.g. {"name":"value"}) or change the deserialized type to an array or a type that implements a collection interface (e.g. ICollection, IList) like List<T> that can be deserialized from a JSON array. JsonArrayAttribute can also be added to the type to force it to deserialize from a JSON array.
Path 'structs', line 5, position 14.
   at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract)
   at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, Object existingValue, String id)
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
