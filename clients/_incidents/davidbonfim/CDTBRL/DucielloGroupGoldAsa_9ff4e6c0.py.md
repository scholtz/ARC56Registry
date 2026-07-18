# Generated code fails to compile: DucielloGroupGoldAsa_9ff4e6c0 (Python)

- **Repo**: [davidbonfim/CDTBRL](https://github.com/davidbonfim/CDTBRL)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/davidbonfim/CDTBRL/HEAD/out/projects/gold-duciello-group/smart_contracts/duciello_group_gold_asa/DucielloGroupGoldAsa.arc56.json](https://raw.githubusercontent.com/davidbonfim/CDTBRL/HEAD/out/projects/gold-duciello-group/smart_contracts/duciello_group_gold_asa/DucielloGroupGoldAsa.arc56.json)
- **Detected**: 2026-07-18T15:58:28.910165+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/davidbonfim/CDTBRL/HEAD/out/projects/gold-duciello-group/smart_contracts/duciello_group_gold_asa/DucielloGroupGoldAsa.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
  File "/home/runner/work/ARC56Registry/ARC56Registry/clients/davidbonfim/CDTBRL/python/src/arc56_generated_davidbonfim_cdtbrl/DucielloGroupGoldAsa_9ff4e6c0.py", line 89
    from: str
        ^
SyntaxError: invalid syntax

```
