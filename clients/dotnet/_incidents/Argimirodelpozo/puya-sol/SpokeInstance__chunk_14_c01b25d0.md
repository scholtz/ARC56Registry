# Generator crash: SpokeInstance__chunk_14_c01b25d0

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/SpokeInstance/__uros_split/chunk_14/SpokeInstance__chunk_14.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/SpokeInstance/__uros_split/chunk_14/SpokeInstance__chunk_14.arc56.json)
- **Namespace used**: `Arc56.Generated.Argimirodelpozo.puya_sol.SpokeInstance__chunk_14_c01b25d0`
- **Detected**: 2026-07-17T03:46:50.561962+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.Argimirodelpozo.puya_sol.SpokeInstance__chunk_14_c01b25d0" \
  --url https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/SpokeInstance/__uros_split/chunk_14/SpokeInstance__chunk_14.arc56.json
```

## Error

```
docker generator exited with code 139
--- stdout ---
File: artifacts/SpokeInstance__chunk_14_c01b25d0.arc56.json
Namespace: Arc56.Generated.Argimirodelpozo.puya_sol.SpokeInstance__chunk_14_c01b25d0

--- stderr ---
Unhandled exception. System.Exception: The ABI type is not valid int200 : Integers are currently not supported. Please use unsigned integers.
 ---> System.Exception: Integers are currently not supported. Please use unsigned integers.
   at AVM.ClientGenerator.ABI.TypeHelpers.ABITypeToCSType(String parentStructName, String methodABITypeString, List`1 structs, Boolean isReturn) in /src/dotnet-algorand-sdk/ClientGenerator/ABI/TypeHelpers.cs:line 257
   --- End of inner exception stack trace ---
   at AVM.ClientGenerator.ABI.TypeHelpers.ABITypeToCSType(String parentStructName, String methodABITypeString, List`1 structs, Boolean isReturn) in /src/dotnet-algorand-sdk/ClientGenerator/ABI/TypeHelpers.cs:line 360
   at Algorand.AVM.ClientGenerator.ABI.ARC56.ClientGeneratorARC56.defineStructs(Code proxyBody) in /src/dotnet-algorand-sdk/ClientGenerator/ABI/ARC56/ClientGeneratorARC56.cs:line 408
   at Algorand.AVM.ClientGenerator.ABI.ARC56.ClientGeneratorARC56.ToProxy(String namespaceName) in /src/dotnet-algorand-sdk/ClientGenerator/ABI/ARC56/ClientGeneratorARC56.cs:line 135
   at client_generator.Program.<>c.<<Main>b__1_1>d.MoveNext() in /src/client-generator/Program.cs:line 81
--- End of stack trace from previous location ---
   at CommandLine.ParserResultExtensions.WithParsedAsync[T](ParserResult`1 result, Func`2 action)
   at client_generator.Program.Main(String[] args) in /src/client-generator/Program.cs:line 37
   at client_generator.Program.<Main>(String[] args)

```
