# Setting up npm publishing (NPM_TOKEN)

[`publish-npm-packages.yml`](../.github/workflows/publish-npm-packages.yml) /
[`scripts/publish_npm_packages.py`](../scripts/publish_npm_packages.py) (see
[typescript-client-pipeline.md](typescript-client-pipeline.md)) needs credentials to
publish `arc56-generated-*` packages to the public npm registry. This is a one-time,
manual setup - nothing in the workflow can create the secret for you.

## Why a classic token instead of npm's OIDC Trusted Publishing

The .NET pipeline publishes to nuget.org using **Trusted Publishing** (OIDC, short-lived
keys - see [dotnet-client-pipeline.md](dotnet-client-pipeline.md#publishing-to-nugetorg)),
and npm has an equivalent mechanism (npm CLI >= 11.5.1, GitHub Actions
`id-token: write`, generally available since mid-2025). This pipeline uses a classic
**automation access token** instead, for one concrete, repo-specific reason: npm's
Trusted Publishing is configured **per package**, one at a time, on npmjs.com - there is
no account- or organization-wide policy the way nuget.org's Trusted Publishing supports
(see the .NET pipeline's setup: one policy covers every `Arc56.Generated.*` package a
nuget.org account owns). This pipeline creates a **new** npm package automatically
every time a not-yet-seen GitHub repo with an ARC-56 spec is indexed - currently hundreds
and growing. Requiring a manual npmjs.com trusted-publisher configuration step for each
new package before its first publish would silently block publishing for every
newly-discovered repo until someone noticed and did that by hand. A single
account-wide automation token has no such per-package setup step, so new packages
publish successfully the first time, unattended - matching how this whole registry
already operates (fully automated discovery, generation, and publishing).

If npm later adds an account-wide or wildcard Trusted Publishing policy, revisit this
choice - the security properties (short-lived, workflow-scoped credentials) are
strictly better than a long-lived token.

## One-time setup

1. **Create an npm Automation access token.**
   - Log into [npmjs.com](https://www.npmjs.com) with the account (or a member of the
     organization) that should own the `arc56-generated-*` packages.
   - Go to your avatar -> **Access Tokens** -> **Generate New Token** -> **Classic
     Token**.
   - Choose type **Automation** (not "Publish" or "Read-only") - Automation tokens are
     meant for CI: they publish without prompting for a 2FA one-time passcode, which a
     scheduled/unattended workflow can't provide anyway.
   - Copy the token value immediately - npm shows it only once.

2. **Add the `NPM_TOKEN` repo secret.** In this repo's **Settings > Secrets and
   variables > Actions**, add:
   - Name: `NPM_TOKEN`
   - Value: the Automation token you just generated.

   Unlike the nuget.org `NUGET_USER` secret (which holds a username, not a credential),
   `NPM_TOKEN` **is** a real credential - treat it accordingly (don't log it, don't put
   it in a PR, rotate it if you suspect it leaked).

That's the entire setup. No workflow YAML changes are needed - `publish-npm-packages.yml`
already reads `secrets.NPM_TOKEN` and skips publishing (without failing the job) if it's
unset, so the pipeline runs safely before this secret exists; it just won't publish
anything until you add it.

## How the token is used

`scripts/publish_npm_packages.py` never writes the token into any file inside this
repo's working tree (which would risk it being accidentally committed). Instead, at
the start of a run, it writes a throwaway `.npmrc` containing
`//registry.npmjs.org/:_authToken=<token>` to the OS temp directory (**outside** the
git working tree), and points `npm publish` at it per-invocation via the
`NPM_CONFIG_USERCONFIG` environment variable. The temp file is deleted when the script
exits (including on failure), so it never lingers on the runner past a single job.

## First publish of a new package

The first time a given `owner/repo` is generated, `npm publish` creates that package
under whichever npm account/org the `NPM_TOKEN` belongs to. Every `arc56-generated-*`
package is unscoped and public (published with `--access public`, which is the default
for unscoped names anyway but passed explicitly for clarity) - there's no scoped
`@your-org/` prefix, so no separate "create the scope" step is needed before the first
publish.

## Rotating or revoking the token

Automation tokens don't expire on their own. If you need to rotate it: generate a new
one on npmjs.com, update the `NPM_TOKEN` repo secret, then revoke the old token from
your npmjs.com account's Access Tokens page. There's no coordination needed with the
workflow itself - the next scheduled run just picks up the new secret value.
