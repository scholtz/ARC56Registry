# Generator crash: LocalStateDemo_4417ba7c (Python)

- **Repo**: [algorandfoundation/puya-ts](https://github.com/algorandfoundation/puya-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/o1/local-state/LocalStateDemo.arc56.json](https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/o1/local-state/LocalStateDemo.arc56.json)
- **Detected**: 2026-07-18T15:54:57.883421+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/algorandfoundation/puya-ts/HEAD/tests/approvals/out/o1/local-state/LocalStateDemo.arc56.json -o application.json
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
ValueError: Nested struct ReadonlyObjectEff43f36 not found in context

```
