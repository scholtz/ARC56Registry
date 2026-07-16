# Generator crash: CadenciaEscrow_08254c5a

- **Repo**: [AdityaWagh19/Cadencia-A2A-Platform](https://github.com/AdityaWagh19/Cadencia-A2A-Platform)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/AdityaWagh19/Cadencia-A2A-Platform/HEAD/backend/artifacts/CadenciaEscrow.arc56.json](https://raw.githubusercontent.com/AdityaWagh19/Cadencia-A2A-Platform/HEAD/backend/artifacts/CadenciaEscrow.arc56.json)
- **Namespace used**: `Arc56.Generated.AdityaWagh19.Cadencia_A2A_Platform.CadenciaEscrow_08254c5a`
- **Detected**: 2026-07-16T23:50:01.340434+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:e738b4d750aa1f25bbc94eec6a9322ce0e3d53dfeb06368c5806ae7475b201f7`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.AdityaWagh19.Cadencia_A2A_Platform.CadenciaEscrow_08254c5a" \
  --url https://raw.githubusercontent.com/AdityaWagh19/Cadencia-A2A-Platform/HEAD/backend/artifacts/CadenciaEscrow.arc56.json
```

## Error

```
docker generator exited with code 139
--- stdout ---
File: artifacts/CadenciaEscrow_08254c5a.arc56.json
Namespace: Arc56.Generated.AdityaWagh19.Cadencia_A2A_Platform.CadenciaEscrow_08254c5a

--- stderr ---
Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
   at Algorand.AVM.ClientGenerator.ABI.ARC56.ClientGeneratorARC56.ToProxy(String namespaceName) in /src/dotnet-algorand-sdk/ClientGenerator/ABI/ARC56/ClientGeneratorARC56.cs:line 99
   at client_generator.Program.<>c.<<Main>b__1_1>d.MoveNext() in /src/client-generator/Program.cs:line 81
--- End of stack trace from previous location ---
   at CommandLine.ParserResultExtensions.WithParsedAsync[T](ParserResult`1 result, Func`2 action)
   at client_generator.Program.Main(String[] args) in /src/client-generator/Program.cs:line 37
   at client_generator.Program.<Main>(String[] args)

```
