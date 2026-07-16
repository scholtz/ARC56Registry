# Generator crash: TruthRegistry_36fbeecc

- **Repo**: [0xYuvi/TrustAnchor](https://github.com/0xYuvi/TrustAnchor)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/0xYuvi/TrustAnchor/HEAD/projects/TrustAnchor-contracts/smart_contracts/artifacts/truth_registry/TruthRegistry.arc56.json](https://raw.githubusercontent.com/0xYuvi/TrustAnchor/HEAD/projects/TrustAnchor-contracts/smart_contracts/artifacts/truth_registry/TruthRegistry.arc56.json)
- **Namespace used**: `Arc56.Generated._0xYuvi.TrustAnchor.TruthRegistry_36fbeecc`
- **Detected**: 2026-07-16T22:03:16.099881+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:09f9c0f067d77418e31ce40a1096af29df55b24db52855388f1cd1c703698039`
- **File an issue**: [https://github.com/scholtz/dotnet-algorand-sdk/issues/new](https://github.com/scholtz/dotnet-algorand-sdk/issues/new?title=%5B0xYuvi%2FTrustAnchor%5D+Generator+crash+for+TruthRegistry_36fbeecc&body=Found+via+%5BArc56Registry%5D%28https%3A%2F%2Fgithub.com%2Fscholtz%2FArc56Registry%29%27s+automated+client+generation+pipeline.%0A%0A%2A%2ASource+ARC-56+spec%2A%2A%3A+https%3A%2F%2Fraw.githubusercontent.com%2F0xYuvi%2FTrustAnchor%2FHEAD%2Fprojects%2FTrustAnchor-contracts%2Fsmart_contracts%2Fartifacts%2Ftruth_registry%2FTruthRegistry.arc56.json%0A%0A%2A%2ARepro%2A%2A%3A%0A%60%60%60bash%0Adocker+run+--rm+-v+%22%24%28pwd%29%3A%2Fapp%2Fout%22+scholtz2%2Fdotnet-avm-generated-client%3Alatest+%5C%0A++dotnet+client-generator.dll+--namespace+%22Arc56.Generated._0xYuvi.TrustAnchor.TruthRegistry_36fbeecc%22+%5C%0A++--url+https%3A%2F%2Fraw.githubusercontent.com%2F0xYuvi%2FTrustAnchor%2FHEAD%2Fprojects%2FTrustAnchor-contracts%2Fsmart_contracts%2Fartifacts%2Ftruth_registry%2FTruthRegistry.arc56.json%0A%60%60%60%0A%0A%2A%2AError%2A%2A%3A%0A%60%60%60%0Adocker+generator+exited+with+code+139%0A---+stdout+---%0AFile%3A+artifacts%2FTruthRegistry_36fbeecc.arc56.json%0ANamespace%3A+Arc56.Generated._0xYuvi.TrustAnchor.TruthRegistry_36fbeecc%0A%0A---+stderr+---%0AUnhandled+exception.+System.ArgumentException%3A+GenericArguments%5B0%5D%2C+%27AVM.ClientGenerator.ABI.ARC4.Types.UInt%27%2C+on+%27AVM.ClientGenerator.ABI.ARC4.Types.FixedArray%601%5BT%5D%27+violates+the+constraint+of+type+%27T%27.%0A+---%3E+System.TypeLoadException%3A+GenericArguments%5B0%5D%2C+%27AVM.ClientGenerator.ABI.ARC4.Types.UInt%27%2C+on+%27AVM.ClientGenerator.ABI.ARC4.Types.FixedArray%601%5BT%5D%27+violates+the+constraint+of+type+parameter+%27T%27.%0A+++at+System.RuntimeTypeHandle.Instantiate%28RuntimeType+inst%29%0A+++at+System.RuntimeType.MakeGenericType%28Type%5B%5D+instantiation%29%0A+++---+End+of+inner+exception+stack+trace+---%0A+++at+System.RuntimeType.ValidateGenericArguments%28MemberInfo+definition%2C+RuntimeType%5B%5D+genericArguments%2C+Exception+e%29%0A+++at+System.RuntimeType.MakeGenericType%28Type%5B%5D+instantiation%29%0A+++at+AVM.ClientGenerator.ABI.ARC4.Types.WireType.CreateGeneric%28Type+genericType%2C+Type+specificType%2C+Int32+length%2C+String+elementSpec%29+in+%2Fsrc%2Fdotnet-algorand-sdk%2FClientGenerator%2FABI%2FARC4%2FTypes%2FWireType.cs%3Aline+65%0A+++at+AVM.ClientGenerator.ABI.ARC4.Types.WireType.IsArrayType%28String+abiType%29+in+%2Fsrc%2Fdotnet-algorand-sdk%2FClientGenerator%2FABI%2FARC4%2FTypes%2FWireType.cs%3Aline+95%0A+++at+AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription%28String+description%29+in+%2Fsrc%2Fdotnet-algorand-sdk%2FClientGenerator%2FABI%2FARC4%2FTypes%2FWireType.cs%3Aline+35%0A+++at+Algorand.AVM%0A...+%28truncated%2C+see+full+report+in+Arc56Registry%29%0A%60%60%60%0A%0AGenerator+image%3A+%60scholtz2%2Fdotnet-avm-generated-client%40sha256%3A09f9c0f067d77418e31ce40a1096af29df55b24db52855388f1cd1c703698039%60)

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated._0xYuvi.TrustAnchor.TruthRegistry_36fbeecc" \
  --url https://raw.githubusercontent.com/0xYuvi/TrustAnchor/HEAD/projects/TrustAnchor-contracts/smart_contracts/artifacts/truth_registry/TruthRegistry.arc56.json
```

## Error

```
docker generator exited with code 139
--- stdout ---
File: artifacts/TruthRegistry_36fbeecc.arc56.json
Namespace: Arc56.Generated._0xYuvi.TrustAnchor.TruthRegistry_36fbeecc

--- stderr ---
Unhandled exception. System.ArgumentException: GenericArguments[0], 'AVM.ClientGenerator.ABI.ARC4.Types.UInt', on 'AVM.ClientGenerator.ABI.ARC4.Types.FixedArray`1[T]' violates the constraint of type 'T'.
 ---> System.TypeLoadException: GenericArguments[0], 'AVM.ClientGenerator.ABI.ARC4.Types.UInt', on 'AVM.ClientGenerator.ABI.ARC4.Types.FixedArray`1[T]' violates the constraint of type parameter 'T'.
   at System.RuntimeTypeHandle.Instantiate(RuntimeType inst)
   at System.RuntimeType.MakeGenericType(Type[] instantiation)
   --- End of inner exception stack trace ---
   at System.RuntimeType.ValidateGenericArguments(MemberInfo definition, RuntimeType[] genericArguments, Exception e)
   at System.RuntimeType.MakeGenericType(Type[] instantiation)
   at AVM.ClientGenerator.ABI.ARC4.Types.WireType.CreateGeneric(Type genericType, Type specificType, Int32 length, String elementSpec) in /src/dotnet-algorand-sdk/ClientGenerator/ABI/ARC4/Types/WireType.cs:line 65
   at AVM.ClientGenerator.ABI.ARC4.Types.WireType.IsArrayType(String abiType) in /src/dotnet-algorand-sdk/ClientGenerator/ABI/ARC4/Types/WireType.cs:line 95
   at AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription(String description) in /src/dotnet-algorand-sdk/ClientGenerator/ABI/ARC4/Types/WireType.cs:line 35
   at Algorand.AVM.ClientGenerator.ABI.ARC56.ClientGeneratorARC56.defineStructs(Code proxyBody) in /src/dotnet-algorand-sdk/ClientGenerator/ABI/ARC56/ClientGeneratorARC56.cs:line 354
   at Algorand.AVM.ClientGenerator.ABI.ARC56.ClientGeneratorARC56.ToProxy(String namespaceName) in /src/dotnet-algorand-sdk/ClientGenerator/ABI/ARC56/ClientGeneratorARC56.cs:line 113
   at client_generator.Program.<>c.<<Main>b__1_1>d.MoveNext() in /src/client-generator/Program.cs:line 81
--- End of stack trace from previous location ---
   at CommandLine.ParserResultExtensions.WithParsedAsync[T](ParserResult`1 result, Func`2 action)
   at client_generator.Program.Main(String[] args) in /src/client-generator/Program.cs:line 37
   at client_generator.Program.<Main>(String[] args)

```
