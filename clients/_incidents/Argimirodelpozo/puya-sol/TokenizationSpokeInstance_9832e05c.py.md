# Generated code fails to compile: TokenizationSpokeInstance_9832e05c (Python)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/TokenizationSpokeInstance/TokenizationSpokeInstance.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/TokenizationSpokeInstance/TokenizationSpokeInstance.arc56.json)
- **Detected**: 2026-07-18T15:42:52.372083+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/TokenizationSpokeInstance/TokenizationSpokeInstance.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/python/src/arc56_generated_argimirodelpozo_puya_sol/TokenizationSpokeInstance_9832e05c.py", line 405
    from: str
        ^
SyntaxError: invalid syntax

```
