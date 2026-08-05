# Generator crash: Hub__chunk_8_8757cfad

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/Hub/__uros_split/chunk_8/Hub__chunk_8.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/Hub/__uros_split/chunk_8/Hub__chunk_8.arc56.json)
- **Namespace used**: `Arc56.Generated.Argimirodelpozo.puya_sol.Hub__chunk_8_8757cfad`
- **Detected**: 2026-08-05T09:24:15.778085+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:508821bfbb37c3c0d4d6f2867be89c794b766971b607e9ee5b39cde816fbb352`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.Argimirodelpozo.puya_sol.Hub__chunk_8_8757cfad" \
  --url https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/Hub/__uros_split/chunk_8/Hub__chunk_8.arc56.json
```

## Error

```
docker generator exited with code 139
--- stdout ---
File: artifacts/Hub__chunk_8_8757cfad.arc56.json
Namespace: Arc56.Generated.Argimirodelpozo.puya_sol.Hub__chunk_8_8757cfad

--- stderr ---
Unhandled exception. System.Exception: The ABI type is not valid int200 : Integers are currently not supported. Please use unsigned integers.
 ---> System.Exception: Integers are currently not supported. Please use unsigned integers.
   at AVM.ClientGenerator.ABI.TypeHelpers.ABITypeToCSType(String parentStructName, String methodABITypeString, List`1 structs, Boolean isReturn) in /src/dotnet-algorand-sdk/ClientGenerator/ABI/TypeHelpers.cs:line 257
   --- End of inner exception stack trace ---
   at AVM.ClientGenerator.ABI.TypeHelpers.ABITypeToCSType(String parentStructName, String methodABITypeString, List`1 structs, Boolean isReturn) in /src/dotnet-algorand-sdk/ClientGenerator/ABI/TypeHelpers.cs:line 360
   at Algorand.AVM.ClientGenerator.ABI.ARC56.ClientGeneratorARC56.defineStructs(Code proxyBody) in /src/dotnet-algorand-sdk/ClientGenerator/ABI/ARC56/ClientGeneratorARC56.cs:line 402
   at Algorand.AVM.ClientGenerator.ABI.ARC56.ClientGeneratorARC56.ToProxy(String namespaceName) in /src/dotnet-algorand-sdk/ClientGenerator/ABI/ARC56/ClientGeneratorARC56.cs:line 129
   at client_generator.Program.<>c.<<Main>b__1_1>d.MoveNext() in /src/client-generator/Program.cs:line 78
--- End of stack trace from previous location ---
   at CommandLine.ParserResultExtensions.WithParsedAsync[T](ParserResult`1 result, Func`2 action)
   at client_generator.Program.Main(String[] args) in /src/client-generator/Program.cs:line 34
   at client_generator.Program.<Main>(String[] args)

```
