# Generated code fails to compile: ERC20_42c8e7bc (Python)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/various/erc20/ERC20.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/various/erc20/ERC20.arc56.json)
- **Detected**: 2026-07-18T15:41:38.568388+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/various/erc20/ERC20.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/python/src/arc56_generated_argimirodelpozo_puya_sol/ERC20_42c8e7bc.py", line 109
    from: str
        ^
SyntaxError: invalid syntax

```
