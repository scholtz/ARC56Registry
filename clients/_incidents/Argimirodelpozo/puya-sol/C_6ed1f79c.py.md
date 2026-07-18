# Generator crash: C_6ed1f79c (Python)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/builtinFunctions/erc7201_equivalent_solidity_spec_comptime/C.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/builtinFunctions/erc7201_equivalent_solidity_spec_comptime/C.arc56.json)
- **Detected**: 2026-07-18T15:35:38.064549+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/tests/solidity-semantic-tests/out/builtinFunctions/erc7201_equivalent_solidity_spec_comptime/C.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
spec declares a fixed-array type of length 9223372036854775807, exceeding MAX_SANE_FIXED_ARRAY_LENGTH (1000000) - skipped without invoking the generator (see spec_has_oversized_array())
```
