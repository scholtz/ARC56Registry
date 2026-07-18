# Generator crash: AvmTypes_954480e8 (Python)

- **Repo**: [scholtz/AVMTypes](https://github.com/scholtz/AVMTypes)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/scholtz/AVMTypes/HEAD/projects/AVMTypes/smart_contracts/artifacts/avm_types/AvmTypes.arc56.json](https://raw.githubusercontent.com/scholtz/AVMTypes/HEAD/projects/AVMTypes/smart_contracts/artifacts/avm_types/AvmTypes.arc56.json)
- **Detected**: 2026-07-18T16:04:06.192957+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/scholtz/AVMTypes/HEAD/projects/AVMTypes/smart_contracts/artifacts/avm_types/AvmTypes.arc56.json -o application.json
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
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/writer.py", line 22, in generate_client
    output = render(generate(context))
             ^^^^^^^^^^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/writer.py", line 29, in render
    return "".join(convert_part(parts, context))
                   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/document.py", line 89, in convert_part
    for part in expand_parts(parts):
                ^^^^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/document.py", line 84, in expand_parts
    yield from expand_parts(part)
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/document.py", line 84, in expand_parts
    yield from expand_parts(part)
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/document.py", line 83, in expand_parts
    for part in parts:
                ^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/generators/typed_client.py", line 688, in generate_structs
    raise ValueError(f"Nested struct {field.python_type} not found in context")
ValueError: Nested struct StructAddressUint256 not found in context

```
