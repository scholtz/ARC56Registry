# Generator crash: StakingPoolPlugin_a75a34b7

- **Repo**: [akita-protocol/akita-sc](https://github.com/akita-protocol/akita-sc)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/arc58/plugins/staking-pool/StakingPoolPlugin.arc56.json](https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/arc58/plugins/staking-pool/StakingPoolPlugin.arc56.json)
- **Namespace used**: `Arc56.Generated.akita_protocol.akita_sc.StakingPoolPlugin_a75a34b7`
- **Detected**: 2026-07-16T21:57:30.484605+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:09f9c0f067d77418e31ce40a1096af29df55b24db52855388f1cd1c703698039`
- **File an issue**: [https://github.com/scholtz/dotnet-algorand-sdk/issues/new](https://github.com/scholtz/dotnet-algorand-sdk/issues/new?title=%5Bakita-protocol%2Fakita-sc%5D+Generator+crash+for+StakingPoolPlugin_a75a34b7&body=Found+via+%5BArc56Registry%5D%28https%3A%2F%2Fgithub.com%2Fscholtz%2FArc56Registry%29%27s+automated+client+generation+pipeline.%0A%0A%2A%2ASource+ARC-56+spec%2A%2A%3A+https%3A%2F%2Fraw.githubusercontent.com%2Fakita-protocol%2Fakita-sc%2FHEAD%2Fprojects%2Fakita-sc%2Fsmart_contracts%2Fartifacts%2Farc58%2Fplugins%2Fstaking-pool%2FStakingPoolPlugin.arc56.json%0A%0A%2A%2ARepro%2A%2A%3A%0A%60%60%60bash%0Adocker+run+--rm+-v+%22%24%28pwd%29%3A%2Fapp%2Fout%22+scholtz2%2Fdotnet-avm-generated-client%3Alatest+%5C%0A++dotnet+client-generator.dll+--namespace+%22Arc56.Generated.akita_protocol.akita_sc.StakingPoolPlugin_a75a34b7%22+%5C%0A++--url+https%3A%2F%2Fraw.githubusercontent.com%2Fakita-protocol%2Fakita-sc%2FHEAD%2Fprojects%2Fakita-sc%2Fsmart_contracts%2Fartifacts%2Farc58%2Fplugins%2Fstaking-pool%2FStakingPoolPlugin.arc56.json%0A%60%60%60%0A%0A%2A%2AError%2A%2A%3A%0A%60%60%60%0ACommand+%27%5B%27docker%27%2C+%27run%27%2C+%27--rm%27%2C+%27-v%27%2C+%27C%3A%5C%5CUsers%5C%5Cludovit.scholtz%5C%5Csource%5C%5Crepos%5C%5Cscholtz%5C%5CArc56Registry%5C%5Cclients%5C%5Cdotnet%5C%5Cakita-protocol%5C%5Cakita-sc%5C%5Carc56%3A%2Fapp%2Fartifacts%27%2C+%27-v%27%2C+%27C%3A%5C%5CUsers%5C%5Cludovit.scholtz%5C%5Csource%5C%5Crepos%5C%5Cscholtz%5C%5CArc56Registry%5C%5Cclients%5C%5Cdotnet%5C%5Cakita-protocol%5C%5Cakita-sc%5C%5Csrc%3A%2Fapp%2Fout%27%2C+%27scholtz2%2Fdotnet-avm-generated-client%3Alatest%27%2C+%27dotnet%27%2C+%27client-generator.dll%27%2C+%27--namespace%27%2C+%27Arc56.Generated.akita_protocol.akita_sc.StakingPoolPlugin_a75a34b7%27%2C+%27--file%27%2C+%27artifacts%2FStakingPoolPlugin_a75a34b7.arc56.json%27%5D%27+returned+non-zero+exit+status+139.%0A%60%60%60%0A%0AGenerator+image%3A+%60scholtz2%2Fdotnet-avm-generated-client%40sha256%3A09f9c0f067d77418e31ce40a1096af29df55b24db52855388f1cd1c703698039%60)

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.akita_protocol.akita_sc.StakingPoolPlugin_a75a34b7" \
  --url https://raw.githubusercontent.com/akita-protocol/akita-sc/HEAD/projects/akita-sc/smart_contracts/artifacts/arc58/plugins/staking-pool/StakingPoolPlugin.arc56.json
```

## Error

```
Command '['docker', 'run', '--rm', '-v', 'C:\\Users\\ludovit.scholtz\\source\\repos\\scholtz\\Arc56Registry\\clients\\dotnet\\akita-protocol\\akita-sc\\arc56:/app/artifacts', '-v', 'C:\\Users\\ludovit.scholtz\\source\\repos\\scholtz\\Arc56Registry\\clients\\dotnet\\akita-protocol\\akita-sc\\src:/app/out', 'scholtz2/dotnet-avm-generated-client:latest', 'dotnet', 'client-generator.dll', '--namespace', 'Arc56.Generated.akita_protocol.akita_sc.StakingPoolPlugin_a75a34b7', '--file', 'artifacts/StakingPoolPlugin_a75a34b7.arc56.json']' returned non-zero exit status 139.
```
