# Docker Hub hash registry image

In addition to the [GitHub Pages site](hash-registry.md#github-pages-site), the
program hash + ABI signature registry is also published as a self-hosted webserver
image, [`scholtz2/arc56-registry`](https://hub.docker.com/r/scholtz2/arc56-registry),
via
[`publish-docker-hash-registry.yml`](../.github/workflows/publish-docker-hash-registry.yml)
and [`docker/hash-registry/Dockerfile`](../docker/hash-registry/Dockerfile).

## Why

The GitHub Pages site is great for one-off lookups, but a wallet that wants to decode
calls without depending on `scholtz.github.io` being reachable at call time - or that
wants the registry served from inside its own infrastructure - needs its own copy of
the whole dataset available over HTTP. Running this image gives exactly that,
refreshed daily along with the rest of the registry.

## What's in the image

Built on [`nginxinc/nginx-unprivileged`](https://hub.docker.com/r/nginxinc/nginx-unprivileged)
(an nginx build that listens on port 8080 and runs as a non-root user by default, so
the container needs no special privileges to run), serving:

```
/approval-programs/**   # same content as approval-programs/ in this repo
/clear-programs/**      # same content as clear-programs/ in this repo
/abi-signatures/**      # same content as abi-signatures/ in this repo
/README.md              # usage guide - also served as human-readable text
/                        # landing page, same content as pages/index.html
```

See [`hash-registry.md`](hash-registry.md) for the full description of these three
tables (layout, tie-breaking rules, freshness).

## Tags

- `latest` - always the most recently published snapshot.
- `YYYY-MM-DD` (UTC) - a dated snapshot, one per day the image was rebuilt, so a
  consumer can pin to a known dataset instead of floating on `latest`.

Both tags are pushed together on every publish, from the same build - see the
"Build and push" step in
[`publish-docker-hash-registry.yml`](../.github/workflows/publish-docker-hash-registry.yml).

## Docker Hub repository description

Right after pushing, the workflow's "Sync Docker Hub repository description" step
(`peter-evans/dockerhub-description`) uploads
[`docker/hash-registry/README.md`](../docker/hash-registry/README.md) as the
repository's Docker Hub **Overview** tab content, and sets a short description.
`docker push` itself never touches this - it's pure image-layer transfer - so without
this step the Overview tab would permanently read "No overview available" regardless
of how good the README in this repo is. Gated behind the same
`DOCKERHUB_USERNAME`/`DOCKERHUB_TOKEN` secrets as the push itself; see
[docs/dockerhub-publishing-setup.md](dockerhub-publishing-setup.md).

## Trigger and cadence

Runs after every successful
[`generate-hash-registry.yml`](../.github/workflows/generate-hash-registry.yml) run
(via a `workflow_run` trigger - the same pattern
[`deploy-hash-registry-pages.yml`](../.github/workflows/deploy-hash-registry-pages.yml)
uses), so the image tracks the daily hash-registry regeneration. Also runs on
`workflow_dispatch` and on any push touching `docker/hash-registry/**` (Dockerfile,
README, or landing-page changes, so a documentation-only fix doesn't have to wait for
the next scheduled regeneration).

## One-time setup

Needs a Docker Hub account and repo secrets before it can actually push - see
**[docs/dockerhub-publishing-setup.md](dockerhub-publishing-setup.md)**. Until those
secrets exist, the workflow still builds and smoke-tests the image on every run (see
below) but logs "Skipping publish" and pushes nothing - it never fails the job,
matching the npm/PyPI publish scripts' pattern of being safe to run before their
secrets are configured.

## Using the image

```bash
docker run -d --name arc56-registry -p 8080:8080 scholtz2/arc56-registry:latest
curl http://localhost:8080/README.md
```

See [`docker/hash-registry/README.md`](../docker/hash-registry/README.md) - the exact
same file served at `/README.md` inside the running container, so the usage
instructions travel with the image itself. Covers running the container, the HTTP
paths for both the program-hash and ABI-selector lookups, worked examples, and how to
pull the raw files onto disk with `docker cp` instead of querying over HTTP if you
prefer that.

## Building and testing locally

```bash
docker build -f docker/hash-registry/Dockerfile -t arc56-registry:local .
docker run -d --name arc56-registry-local -p 8080:8080 arc56-registry:local
curl -fsS http://localhost:8080/README.md
curl -fsS http://localhost:8080/ >/dev/null
docker rm -f arc56-registry-local
```

Build context is the repo root (not `docker/hash-registry/`), since the Dockerfile
`COPY`s `approval-programs/`, `clear-programs/`, and `abi-signatures/` from the repo
root - keep that in mind if you ever move the Dockerfile.

`publish-docker-hash-registry.yml` runs the same build-run-curl smoke test on every
workflow run, *before* attempting to log in or push - a broken Dockerfile or nginx
config fails the job right there, regardless of whether Docker Hub credentials are
configured yet.

## Base image and vulnerabilities

The Dockerfile pins a specific `nginxinc/nginx-unprivileged` tag (currently the
`-alpine-slim` variant of the current mainline release) rather than a floating tag,
because the base image - not this repo's own static files - is the only realistic
source of CVEs in this image. `-alpine-slim` bundles fewer packages than plain
`-alpine`, which measurably reduces the vulnerability count in local scans. Bump the
pin periodically to the current mainline release rather than leaving it indefinitely;
see the comment above the `FROM` line in
[`docker/hash-registry/Dockerfile`](../docker/hash-registry/Dockerfile).

On top of that pin, the Dockerfile also runs `apk update && apk upgrade --no-cache`
(as root, then switches back to the image's own non-root `USER 101` before copying any
files) right after `FROM`, so every build picks up whatever Alpine security patches
have shipped since that base tag was last published - not just whatever was current
the day the tag was built. `rm -rf /var/cache/apk/*` immediately after removes the
package index/cache apk downloads to do the upgrade, so it doesn't linger as dead
weight (or stale, now-inaccurate metadata) in the final image. This is the Alpine/`apk`
equivalent of the classic Debian/`apt` pattern
(`apt update && apt dist-upgrade -y && apt-get clean && rm -rf /var/lib/apt/lists/*`) -
same goal (patch, then leave no package-manager residue behind), different tool
because this base image is Alpine, not Debian.
