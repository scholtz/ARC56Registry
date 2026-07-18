# Generated code fails to compile: C_7de687fe (Python)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/viaYul/unary_operations/C.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/viaYul/unary_operations/C.arc56.json)
- **Detected**: 2026-07-18T15:42:19.283258+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/viaYul/unary_operations/C.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/python/src/arc56_generated_argimirodelpozo_puya_sol/C_7de687fe.py", line 415
    def not(
        ^^^
SyntaxError: invalid syntax

```
