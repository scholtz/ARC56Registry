# Generator crash: ARC56Test_2d6e823c

- **Repo**: [joe-p/algosdk-future-ts](https://github.com/joe-p/algosdk-future-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/joe-p/algosdk-future-ts/HEAD/fixtures/ARC56Test.arc56.json](https://raw.githubusercontent.com/joe-p/algosdk-future-ts/HEAD/fixtures/ARC56Test.arc56.json)
- **Namespace used**: `Arc56.Generated.joe_p.algosdk_future_ts.ARC56Test_2d6e823c`
- **Detected**: 2026-10-23T10:48:00.907026+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:4c7f0b02126c7a2565338efea6e3a214b086d319bc88c43d227a9fc55b907289`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.joe_p.algosdk_future_ts.ARC56Test_2d6e823c" \
  --url https://raw.githubusercontent.com/joe-p/algosdk-future-ts/HEAD/fixtures/ARC56Test.arc56.json
```

## Error

```
docker generator exited with code 1
--- stdout ---
File: artifacts/ARC56Test_2d6e823c.arc56.json
Namespace: Arc56.Generated.joe_p.algosdk_future_ts.ARC56Test_2d6e823c

--- stderr ---
Error: could not generate a client from the spec: Cannot deserialize the current JSON object (e.g. {"name":"value"}) into type 'System.Collections.Generic.List`1[AVM.ClientGenerator.ABI.ARC56.StructField]' because the type requires a JSON array (e.g. [1,2,3]) to deserialize correctly.
To fix this error either change the JSON to a JSON array (e.g. [1,2,3]) or change the deserialized type so that it is a normal .NET type (e.g. not a primitive type like integer, not a collection type like an array or List<T>) that can be deserialized from a JSON object. JsonObjectAttribute can also be added to the type to force it to deserialize from a JSON object.
Path 'structs['{ foo: uint16; bar: uint16 }'].foo', line 49, position 12.

```
