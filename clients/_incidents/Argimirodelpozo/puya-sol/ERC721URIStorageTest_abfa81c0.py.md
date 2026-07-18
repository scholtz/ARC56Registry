# Generated code fails to compile: ERC721URIStorageTest_abfa81c0 (Python)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC721URIStorageTest/ERC721URIStorageTest.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC721URIStorageTest/ERC721URIStorageTest.arc56.json)
- **Detected**: 2026-07-18T17:32:37.093250+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/openzeppelin/out/ERC721URIStorageTest/ERC721URIStorageTest.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/Argimirodelpozo/puya-sol/python/src/arc56_generated_argim_ff1f8b0b/ERC721URIStorageTest_abfa81c0.py", line 174
    from: str
        ^
SyntaxError: invalid syntax

```
