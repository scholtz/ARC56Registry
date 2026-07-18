# Generator crash: SpokeInstance__chunk_0_6b71107f (Python)

- **Repo**: [Argimirodelpozo/puya-sol](https://github.com/Argimirodelpozo/puya-sol)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/SpokeInstance/__uros_split/chunk_0/SpokeInstance__chunk_0.arc56.json](https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/SpokeInstance/__uros_split/chunk_0/SpokeInstance__chunk_0.arc56.json)
- **Detected**: 2026-07-18T15:42:40.212930+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/Argimirodelpozo/puya-sol/HEAD/WIP/examples/aave-v4/out/SpokeInstance/__uros_split/chunk_0/SpokeInstance__chunk_0.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
algokitgen-py exited with code 1
--- stdout ---

--- stderr ---
Traceback (most recent call last):
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/spec.py", line 349, in load_from_json
    return Arc56Contract.from_json(raw_json)
           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_utils/applications/app_spec/arc56.py", line 928, in from_json
    return Arc56Contract.from_dict(json.loads(application_spec))
           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_utils/applications/app_spec/arc56.py", line 899, in from_dict
    data["methods"] = [Method.from_dict(item) for item in data["methods"]]
                       ^^^^^^^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_utils/applications/app_spec/arc56.py", line 465, in from_dict
    return Method(**data)
           ^^^^^^^^^^^^^^
  File "<string>", line 12, in __init__
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_utils/applications/app_spec/arc56.py", line 444, in __post_init__
    self._abi_method = AlgosdkMethod.undictify(asdict(self))
                       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algosdk/abi/method.py", line 136, in undictify
    return_obj = Returns.undictify(d["returns"])
                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algosdk/abi/method.py", line 251, in undictify
    return Returns(
           ^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algosdk/abi/method.py", line 231, in __init__
    self.type = abi.ABIType.from_string(arg_type)
                ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algosdk/abi/base_type.py", line 125, in from_string
    tt = ABIType.from_string(tup)
         ^^^^^^^^^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algosdk/abi/base_type.py", line 134, in from_string
    raise error.ABITypeError(
algosdk.error.ABITypeError: cannot convert int200 to an ABI type

The above exception was the direct cause of the following exception:

Traceback (most recent call last):
  File "/opt/hostedtoolcache/Python/3.12.13/x64/bin/algokitgen-py", line 6, in <module>
    sys.exit(main())
             ^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/cli.py", line 93, in main
    process(parser)
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/cli.py", line 86, in process
    generate_client(app_spec, output, preserve_names=args.preserve_names, mode=args.mode)
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/writer.py", line 20, in generate_client
    app_spec = load_from_json(input_path)
               ^^^^^^^^^^^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/spec.py", line 351, in load_from_json
    raise ValueError("Invalid application.json") from ex
ValueError: Invalid application.json

```
