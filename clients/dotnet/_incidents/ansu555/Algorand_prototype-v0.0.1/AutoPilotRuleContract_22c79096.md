# Generated code fails to compile: AutoPilotRuleContract_22c79096

- **Repo**: [ansu555/Algorand_prototype-v0.0.1](https://github.com/ansu555/Algorand_prototype-v0.0.1)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/ansu555/Algorand_prototype-v0.0.1/HEAD/Blockchain/projects/10x_Swap/artifacts/autopilot_rule/AutoPilotRuleContract.arc56.json](https://raw.githubusercontent.com/ansu555/Algorand_prototype-v0.0.1/HEAD/Blockchain/projects/10x_Swap/artifacts/autopilot_rule/AutoPilotRuleContract.arc56.json)
- **Namespace used**: `Arc56.Generated.ansu555.Algorand_prototype_v0_0_1.AutoPilotRuleContract_22c79096`
- **Detected**: 2026-07-17T07:41:13.104522+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:76700131f07234ca74e2ca11c5eed20920edf8dcce99efcda161765d9c7af451`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.ansu555.Algorand_prototype_v0_0_1.AutoPilotRuleContract_22c79096" \
  --url https://raw.githubusercontent.com/ansu555/Algorand_prototype-v0.0.1/HEAD/Blockchain/projects/10x_Swap/artifacts/autopilot_rule/AutoPilotRuleContract.arc56.json
```

## Error

```
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\ansu555\Algorand_prototype-v0.0.1\src\AutoPilotRuleContract_22c79096.cs(965,27): error CS0111: Type 'AutoPilotRuleContractProxy' already defines a member called 'CreateApplication' with the same parameter types [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\ansu555\Algorand_prototype-v0.0.1\Arc56.Generated.ansu555.Algorand_prototype-v0.0.1.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\ansu555\Algorand_prototype-v0.0.1\src\AutoPilotRuleContract_22c79096.cs(978,46): error CS0111: Type 'AutoPilotRuleContractProxy' already defines a member called 'CreateApplication_Transactions' with the same parameter types [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\ansu555\Algorand_prototype-v0.0.1\Arc56.Generated.ansu555.Algorand_prototype-v0.0.1.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\ansu555\Algorand_prototype-v0.0.1\src\AutoPilotRuleContract_22c79096.cs(965,27): error CS0111: Type 'AutoPilotRuleContractProxy' already defines a member called 'CreateApplication' with the same parameter types [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\ansu555\Algorand_prototype-v0.0.1\Arc56.Generated.ansu555.Algorand_prototype-v0.0.1.csproj]
C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\ansu555\Algorand_prototype-v0.0.1\src\AutoPilotRuleContract_22c79096.cs(978,46): error CS0111: Type 'AutoPilotRuleContractProxy' already defines a member called 'CreateApplication_Transactions' with the same parameter types [C:\Users\ludovit.scholtz\source\repos\scholtz\Arc56Registry\clients\dotnet\ansu555\Algorand_prototype-v0.0.1\Arc56.Generated.ansu555.Algorand_prototype-v0.0.1.csproj]
```
