# Generator crash: CadenciaEscrow_4599f3fd (Python)

- **Repo**: [shreyaaassss/cadencia-magic-wallet](https://github.com/shreyaaassss/cadencia-magic-wallet)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/shreyaaassss/cadencia-magic-wallet/HEAD/backend/artifacts/CadenciaEscrow.arc56.json](https://raw.githubusercontent.com/shreyaaassss/cadencia-magic-wallet/HEAD/backend/artifacts/CadenciaEscrow.arc56.json)
- **Detected**: 2026-07-18T17:53:47.471796+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/shreyaaassss/cadencia-magic-wallet/HEAD/backend/artifacts/CadenciaEscrow.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
algokitgen-py exited with code 1
--- stdout ---

--- stderr ---
Traceback (most recent call last):
  File "/opt/hostedtoolcache/Python/3.12.13/x64/bin/algokitgen-py", line 6, in <module>
    sys.exit(main())
             ^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/cli.py", line 93, in main
    process(parser)
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/cli.py", line 86, in process
    generate_client(app_spec, output, preserve_names=args.preserve_names, mode=args.mode)
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/writer.py", line 21, in generate_client
    context = GeneratorContext(app_spec, preserve_names=preserve_names, mode=mode)
              ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/context.py", line 99, in __init__
    self.methods = get_contract_methods(
                   ^^^^^^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/spec.py", line 336, in get_contract_methods
    result.add_method(abi, method.actions.call or [], method.actions.create or [])
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/spec.py", line 94, in add_method
    collection = getattr(self, action_name)
                 ^^^^^^^^^^^^^^^^^^^^^^^^^^
AttributeError: 'ContractMethods' object has no attribute 'call'

```
