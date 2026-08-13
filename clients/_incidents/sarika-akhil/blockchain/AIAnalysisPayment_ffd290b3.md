# Generated code fails to compile: AIAnalysisPayment_ffd290b3

- **Repo**: [sarika-akhil/blockchain](https://github.com/sarika-akhil/blockchain)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/sarika-akhil/blockchain/HEAD/contracts/smart_contracts/artifacts/ai_analysis_payment/AIAnalysisPayment.arc56.json](https://raw.githubusercontent.com/sarika-akhil/blockchain/HEAD/contracts/smart_contracts/artifacts/ai_analysis_payment/AIAnalysisPayment.arc56.json)
- **Namespace used**: `Arc56.Generated.sarika_akhil.blockchain.AIAnalysisPayment_ffd290b3`
- **Detected**: 2026-08-13T07:15:59.506501+00:00
- **Generator image**: `scholtz2/dotnet-avm-generated-client@sha256:373d3f7fe96a2c2c9e361a9c88d822321296511aadc0ad91910dd26077078f37`

## Reproduce

```bash
docker run --rm -v "$(pwd):/app/out" scholtz2/dotnet-avm-generated-client:latest \
  dotnet client-generator.dll --namespace "Arc56.Generated.sarika_akhil.blockchain.AIAnalysisPayment_ffd290b3" \
  --url https://raw.githubusercontent.com/sarika-akhil/blockchain/HEAD/contracts/smart_contracts/artifacts/ai_analysis_payment/AIAnalysisPayment.arc56.json
```

## Error

```
/home/runner/work/ARC56Registry/ARC56Registry/clients/sarika-akhil/blockchain/dotnet/src/AIAnalysisPayment_ffd290b3.cs(250,27): error CS0111: Type 'AIAnalysisPaymentProxy' already defines a member called 'CreateApplication' with the same parameter types [/home/runner/work/ARC56Registry/ARC56Registry/clients/sarika-akhil/blockchain/dotnet/Arc56.Generated.sarika-akhil.blockchain.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sarika-akhil/blockchain/dotnet/src/AIAnalysisPayment_ffd290b3.cs(263,46): error CS0111: Type 'AIAnalysisPaymentProxy' already defines a member called 'CreateApplication_Transactions' with the same parameter types [/home/runner/work/ARC56Registry/ARC56Registry/clients/sarika-akhil/blockchain/dotnet/Arc56.Generated.sarika-akhil.blockchain.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sarika-akhil/blockchain/dotnet/src/AIAnalysisPayment_ffd290b3.cs(250,27): error CS0111: Type 'AIAnalysisPaymentProxy' already defines a member called 'CreateApplication' with the same parameter types [/home/runner/work/ARC56Registry/ARC56Registry/clients/sarika-akhil/blockchain/dotnet/Arc56.Generated.sarika-akhil.blockchain.csproj]
/home/runner/work/ARC56Registry/ARC56Registry/clients/sarika-akhil/blockchain/dotnet/src/AIAnalysisPayment_ffd290b3.cs(263,46): error CS0111: Type 'AIAnalysisPaymentProxy' already defines a member called 'CreateApplication_Transactions' with the same parameter types [/home/runner/work/ARC56Registry/ARC56Registry/clients/sarika-akhil/blockchain/dotnet/Arc56.Generated.sarika-akhil.blockchain.csproj]
```
