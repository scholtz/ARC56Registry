# Setting up Docker Hub publishing (DOCKERHUB_USERNAME / DOCKERHUB_TOKEN)

[`publish-docker-hash-registry.yml`](../.github/workflows/publish-docker-hash-registry.yml)
(see [docker-hash-registry.md](docker-hash-registry.md)) needs credentials to push the
`scholtz2/arc56-registry` image to Docker Hub, and to keep the repository's Docker Hub
**Overview** tab synced with
[`docker/hash-registry/README.md`](../docker/hash-registry/README.md) (via
`peter-evans/dockerhub-description`) - `docker push` alone only uploads image layers,
never a README, so without this the Overview tab permanently shows "No overview
available". This is a one-time, manual setup - nothing in the workflow can create the
account or the secrets for you.

## Why a classic access token instead of OIDC

Docker Hub does not currently offer an OIDC-based "Trusted Publishing" mechanism
comparable to nuget.org's or npm's newer options (see
[dotnet-client-pipeline.md](dotnet-client-pipeline.md#publishing-to-nugetorg) and
[npm-publishing-setup.md](npm-publishing-setup.md) for those). A classic Docker Hub
**access token** scoped to this one repository is the standard, supported way to
authenticate `docker login`/`docker push` from a GitHub Actions workflow today. If
Docker Hub adds an OIDC option later, revisit this choice.

## One-time setup

1. **Create (or reuse) the Docker Hub account/organization that should own the image.**
   This pipeline pushes to `scholtz2/arc56-registry` - either the `scholtz2` account
   itself, or an org it's a member of with push rights to that repository name.

2. **Create the `scholtz2/arc56-registry` repository on Docker Hub**, if it doesn't
   already exist (Docker Hub -> **Create Repository**). It can be created empty; the
   first successful workflow run pushes the first tags into it. Visibility should be
   **Public**, matching the "wallets can pull this without credentials" goal.

3. **Create a Docker Hub access token.**
   - Log into [hub.docker.com](https://hub.docker.com) with the account from step 1.
   - Go to **Account Settings > Security > Access Tokens > New Access Token**.
   - Description: something identifying this repo, e.g. `ARC56Registry publish-docker-hash-registry.yml`.
   - Permissions: **Read, Write, Delete** - not just "Read & Write". `docker push`
     alone only needs Read & Write, but the description-sync step
     (`peter-evans/dockerhub-description`, which updates the repo's Overview tab from
     `docker/hash-registry/README.md`) calls a different Docker Hub API that 403s on a
     Read & Write-scoped token and specifically requires Read, Write, Delete - see
     [peter-evans/dockerhub-description#10](https://github.com/peter-evans/dockerhub-description/issues/10).
     Since both steps share one `DOCKERHUB_TOKEN` secret, the token needs the higher
     scope even though this pipeline never actually deletes anything on Docker Hub.
   - Copy the token value immediately - Docker Hub shows it only once.

4. **Add two repo secrets.** In this repo's **Settings > Secrets and variables >
   Actions**, add:
   - `DOCKERHUB_USERNAME` - the Docker Hub username (or org name) from step 1. Not a
     credential by itself, but keep it consistent with the token's owner.
   - `DOCKERHUB_TOKEN` - the access token generated in step 3. This **is** a real
     credential - treat it accordingly (don't log it, don't put it in a PR, revoke and
     rotate it if you suspect it leaked).

That's the entire setup. No workflow YAML changes are needed -
`publish-docker-hash-registry.yml` already reads
`secrets.DOCKERHUB_USERNAME`/`secrets.DOCKERHUB_TOKEN` and skips both the
build-and-push step and the README-sync step (without failing the job) if either is
unset, so the pipeline runs safely before these secrets exist; it just won't publish
anything - or touch the Overview tab - until you add them.

If the repository already exists with an image pushed by hand or by an earlier run of
this workflow (i.e. before the README-sync step existed) and its Overview tab still
says "No overview available", nothing further is needed on your end - the next
successful `publish-docker-hash-registry.yml` run syncs it automatically.

## Rotating or revoking the token

Docker Hub access tokens don't expire on their own by default. If you need to rotate
it: generate a new one on Docker Hub, update the `DOCKERHUB_TOKEN` repo secret, then
revoke the old token from Docker Hub's Access Tokens page. There's no coordination
needed with the workflow itself - the next scheduled run just picks up the new secret
value.
