# Generated code fails to compile: ERC4626Wrapper__Helper1_50907779 (Python)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/solady/out/ERC4626Wrapper/ERC4626Wrapper__Helper1.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/solady/out/ERC4626Wrapper/ERC4626Wrapper__Helper1.arc56.json)
- **Detected**: 2026-07-18T15:45:12.483794+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/solady/out/ERC4626Wrapper/ERC4626Wrapper__Helper1.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/python/src/arc56_generated_argimirodelpozo_puya_sol/ERC4626Wrapper__Helper1_50907779.py", line 82
    from: str
        ^
SyntaxError: invalid syntax

```
