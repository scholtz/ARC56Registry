# Generator crash: MedicalRecords_e4a5b094 (Python)

- **Repo**: [Yashwanth112004/Hackseries-3.0](https://github.com/Yashwanth112004/Hackseries-3.0)
- **Source ARC-56 spec**: [https://raw.githubusercontent.com/Yashwanth112004/Hackseries-3.0/HEAD/projects/ojasraksha-frontend/src/contracts/MedicalRecords.arc56.json](https://raw.githubusercontent.com/Yashwanth112004/Hackseries-3.0/HEAD/projects/ojasraksha-frontend/src/contracts/MedicalRecords.arc56.json)
- **Detected**: 2026-07-21T09:34:49.429030+00:00
- **Generator package**: `algokit-client-generator==2.2.0`

## Reproduce

```bash
pip install algokit-client-generator
curl -sL https://raw.githubusercontent.com/Yashwanth112004/Hackseries-3.0/HEAD/projects/ojasraksha-frontend/src/contracts/MedicalRecords.arc56.json -o application.json
algokitgen-py -a application.json -o client.generated.py -m minimal
```

## Error

```
algokitgen-py exited with code 1
--- stdout ---

--- stderr ---
Traceback (most recent call last):
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/site-packages/algokit_client_generator/spec.py", line 343, in load_from_json
    raw_json = path.read_text()
               ^^^^^^^^^^^^^^^^
  File "/opt/hostedtoolcache/Python/3.12.13/x64/lib/python3.12/pathlib.py", line 1028, in read_text
    return f.read()
           ^^^^^^^^
  File "<frozen codecs>", line 322, in decode
UnicodeDecodeError: 'utf-8' codec can't decode byte 0xff in position 0: invalid start byte

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
