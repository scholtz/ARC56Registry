# Generated code fails to compile: ERC20BurnableTest_1b95fb0f (Python)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC20BurnableTest/ERC20BurnableTest.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC20BurnableTest/ERC20BurnableTest.arc56.json)
- **Detected**: 2026-07-18T17:32:30.594254+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC20BurnableTest/ERC20BurnableTest.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/python/src/arc56_generated_argim_ff1f8b0b/ERC20BurnableTest_1b95fb0f.py", line 138
    from: str
        ^
SyntaxError: invalid syntax

```
