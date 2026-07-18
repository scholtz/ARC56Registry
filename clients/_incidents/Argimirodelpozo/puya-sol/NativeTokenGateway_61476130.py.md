# Generated code fails to compile: NativeTokenGateway_61476130 (Python)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/NativeTokenGateway/NativeTokenGateway.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/NativeTokenGateway/NativeTokenGateway.arc56.json)
- **Detected**: 2026-07-18T17:31:08.572499+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/NativeTokenGateway/NativeTokenGateway.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/python/src/arc56_generated_argim_ff1f8b0b/NativeTokenGateway_61476130.py", line 256
    def (
        ^
SyntaxError: invalid syntax

```
