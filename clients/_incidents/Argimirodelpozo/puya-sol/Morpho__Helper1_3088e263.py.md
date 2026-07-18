# Generated code fails to compile: Morpho__Helper1_3088e263 (Python)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/morpho-blue/out/MorphoTest/Morpho__Helper1.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/morpho-blue/out/MorphoTest/Morpho__Helper1.arc56.json)
- **Detected**: 2026-07-18T17:32:12.801251+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/morpho-blue/out/MorphoTest/Morpho__Helper1.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/python/src/arc56_generated_argim_ff1f8b0b/Morpho__Helper1_3088e263.py", line 193
    from: str
        ^
SyntaxError: invalid syntax

```
