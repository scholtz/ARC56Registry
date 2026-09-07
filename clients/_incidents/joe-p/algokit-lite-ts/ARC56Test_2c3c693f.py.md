# Generator crash: ARC56Test_2c3c693f (Python)

- **Repo**: [joe-p/algokit-lite-ts](https://github.com/joe-p/algokit-lite-ts)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/joe-p/algokit-lite-ts/HEAD/__test__/fixtures/ARC56Test.arc56.json](https://raw.githubusercontent.com/joe-p/algokit-lite-ts/HEAD/__test__/fixtures/ARC56Test.arc56.json)
- **Detected**: 2026-09-07T13:27:20.728863+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/joe-p/algokit-lite-ts/HEAD/__test__/fixtures/ARC56Test.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
algokitgen-py exited with code 1
--- stdout ---

--- stderr ---
Traceback (most recent call last):
  File "/opt/hostedtoolcache/Python/3.12.14/x64/lib/python3.12/site-packages/algokit_client_generator/spec.py", line 349, in load_from_json
    return Arc56Contract.from_json(raw_json)
           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.14/x64/lib/python3.12/site-packages/algokit_utils/applications/app_spec/arc56.py", line 928, in from_json
    return Arc56Contract.from_dict(json.loads(application_spec))
           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.14/x64/lib/python3.12/site-packages/algokit_utils/applications/app_spec/arc56.py", line 902, in from_dict
    key: [StructField.from_dict(item) for item in value] for key, value in application_spec["structs"].items()
          ^^^^^^^^^^^^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.14/x64/lib/python3.12/site-packages/algokit_utils/applications/app_spec/arc56.py", line 70, in from_dict
    if isinstance(data["type"], list):
                  ~~~~^^^^^^^^
TypeError: string indices must be integers, not 'str'

The above exception was the direct cause of the following exception:

Traceback (most recent call last):
  File "/opt/hostedtoolcache/Python/3.12.14/x64/bin/algokitgen-py", line 6, in <module>
    sys.exit(main())
             ^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.14/x64/lib/python3.12/site-packages/algokit_client_generator/cli.py", line 93, in main
    process(parser)
  File "/opt/hostedtoolcache/Python/3.12.14/x64/lib/python3.12/site-packages/algokit_client_generator/cli.py", line 86, in process
    generate_client(app_spec, output, preserve_names=args.preserve_names, mode=args.mode)
  File "/opt/hostedtoolcache/Python/3.12.14/x64/lib/python3.12/site-packages/algokit_client_generator/writer.py", line 20, in generate_client
    app_spec = load_from_json(input_path)
               ^^^^^^^^^^^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.14/x64/lib/python3.12/site-packages/algokit_client_generator/spec.py", line 351, in load_from_json
    raise ValueError("Invalid application.json") from ex
ValueError: Invalid application.json

```
