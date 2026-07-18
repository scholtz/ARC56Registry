# Generated code fails to compile: PairTestHelper_b4c72f33 (Python)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/sushiswap-v2/out/PairTestHelperTest/PairTestHelper.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/sushiswap-v2/out/PairTestHelperTest/PairTestHelper.arc56.json)
- **Detected**: 2026-07-18T17:34:25.788586+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/sushiswap-v2/out/PairTestHelperTest/PairTestHelper.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/python/src/arc56_generated_argim_ff1f8b0b/PairTestHelper_b4c72f33.py", line 162
    from: str
        ^
SyntaxError: invalid syntax

```
