# Setting up PyPI publishing (PYPI_TOKEN)

[`publish-python-packages.yml`](../.github/workflows/publish-python-packages.yml) /
[`scripts/publish_python_packages.py`](../scripts/publish_python_packages.py) (see
[python-client-pipeline.md](python-client-pipeline.md)) needs credentials to publish
`arc56-generated-*` packages to the public PyPI registry ([pypi.org](https://pypi.org)).
This is a one-time, manual setup - nothing in the workflow can create the secret or
the account for you. This doc assumes you've never published anything to PyPI before.

## Why a classic API token instead of PyPI's Trusted Publishing

PyPI supports [Trusted Publishing](https://docs.pypi.org/trusted-publishers/) (OIDC,
short-lived credentials, no stored secret at all) - the same idea the .NET pipeline
uses for nuget.org. This pipeline uses a classic **API token** instead, for the same
concrete reason the npm pipeline's own doc gives for using `NPM_TOKEN` instead of npm's
OIDC mechanism: PyPI's Trusted Publishing has to be configured **per project**, one at
a time, on pypi.org - and worse, for a *brand-new* project name, that configuration has
to be done **before that project's very first release ever happens** (PyPI calls this
"pending publisher" setup). There is no account- or organization-wide policy the way
nuget.org's Trusted Publishing supports. This pipeline creates a **new** PyPI package
automatically every time a not-yet-seen GitHub repo with an ARC-56 spec is indexed -
currently hundreds and growing. Requiring a manual pypi.org configuration step for each
new package before its first publish would silently block publishing for every
newly-discovered repo until someone noticed and did that by hand. A single
account-wide API token has no such per-package setup step, so new packages publish
successfully the first time, unattended - matching how this whole registry already
operates (fully automated discovery, generation, and publishing).

If PyPI later adds an account-wide or wildcard Trusted Publishing policy, revisit this
choice - the security properties (short-lived, workflow-scoped credentials) are
strictly better than a long-lived token.

## One-time setup

1. **Create a PyPI account**, if you don't already have one: go to
   [pypi.org/account/register](https://pypi.org/account/register/). You'll need to
   verify your email address. **Enable two-factor authentication** (Account settings ->
   Add 2FA) - PyPI has required 2FA for all accounts since 2024, and you can't create an
   API token without it.

2. **Create an API token scoped to your whole account** (not a single project - a
   single-project-scoped token can't be created yet for a project that doesn't exist,
   which is exactly the "new package" problem this pipeline needs to avoid; see above).
   - Log into [pypi.org](https://pypi.org), go to **Account settings** -> **API
     tokens** -> **Add API token**.
   - Give it a descriptive name, e.g. `arc56registry-github-actions`.
   - Scope: **Entire account (all projects)**.
   - Click **Create token**. Copy the value immediately (it starts with `pypi-`) - PyPI
     shows it only once.
   - Once every `arc56-generated-*` package exists on PyPI, you can optionally come
     back and narrow this to a project-scoped token covering just those packages (PyPI
     doesn't support wildcard/prefix scoping, so this would mean re-issuing the token
     whenever a new repo is discovered - probably not worth the operational overhead
     for this pipeline, but it's a valid tightening if you want it later).

3. **Add the `PYPI_TOKEN` repo secret.** In this repo's **Settings > Secrets and
   variables > Actions**, add:
   - Name: `PYPI_TOKEN`
   - Value: the token you just generated (including the `pypi-` prefix).

   Like the npm pipeline's `NPM_TOKEN` (and unlike the nuget.org `NUGET_USER` secret,
   which holds a username, not a credential), `PYPI_TOKEN` **is** a real credential -
   treat it accordingly (don't log it, don't put it in a PR, rotate it if you suspect
   it leaked).

That's the entire setup. No workflow YAML changes are needed -
`publish-python-packages.yml` already reads `secrets.PYPI_TOKEN` and skips publishing
(without failing the job) if it's unset, so the pipeline runs safely before this secret
exists; it just won't publish anything until you add it.

## How the token is used

`scripts/publish_python_packages.py` never writes the token into any file inside this
repo's working tree. It passes the token to `twine upload` via the `TWINE_PASSWORD`
environment variable (with `TWINE_USERNAME=__token__`, the fixed username PyPI expects
for token-based auth) - both set only in the subprocess's environment for the duration
of that one `twine upload` call, never persisted to disk.

## First publish of a new package

The first time a given `owner/repo` is generated and published, `twine upload` creates
that package on PyPI under whichever account `PYPI_TOKEN` belongs to. Every
`arc56-generated-*` package is unscoped and public - there's no PyPI equivalent of npm
scoped packages, so no separate "reserve the namespace" step is needed before the first
publish, beyond the account-scoped token already covering it.

## Rotating or revoking the token

API tokens don't expire on their own. If you need to rotate it: generate a new one on
pypi.org (Account settings -> API tokens -> Add API token), update the `PYPI_TOKEN`
repo secret, then revoke the old token from the same page. There's no coordination
needed with the workflow itself - the next scheduled run just picks up the new secret
value.
