# Generated code fails to compile: UniswapV2Pair_a805eaef (Python)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/uniswap-v2/out/UniswapV2Pair/UniswapV2Pair.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/uniswap-v2/out/UniswapV2Pair/UniswapV2Pair.arc56.json)
- **Detected**: 2026-07-18T15:45:29.815253+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/uniswap-v2/out/UniswapV2Pair/UniswapV2Pair.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/python/src/arc56_generated_argimirodelpozo_puya_sol/UniswapV2Pair_a805eaef.py", line 146
    from: str
        ^
SyntaxError: invalid syntax

```
