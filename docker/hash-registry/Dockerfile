# Self-hosting webserver image for the ARC-56 program hash + ABI signature registry.
#
# Bundles the three registry folders (approval-programs/, clear-programs/,
# abi-signatures/) plus a landing page on top of nginxinc/nginx-unprivileged - an
# nginx build that listens on port 8080 and runs as a non-root user (uid 101) by
# default, so this image needs no special privileges (no `--user root`, no
# `NET_BIND_SERVICE` capability) to run anywhere, including under a default
# "run as non-root" Kubernetes/PodSecurity policy.
#
# The point: a wallet/indexer can `docker run` this image and query
# http://<host>:8080/approval-programs/..., /clear-programs/..., /abi-signatures/...,
# and /arc56.links.csv directly over HTTP, getting its own private mirror of the
# registry instead of depending on scholtz.github.io/ARC56Registry being reachable.
#
# Built from the repo root as build context - see
# .github/workflows/publish-docker-hash-registry.yml and
# docs/docker-hash-registry.md.
#
# Base tag is pinned to the current mainline nginx release's `-alpine-slim` variant
# (fewer bundled packages than plain `-alpine`, which showed noticeably more CVEs in
# local scans) - re-check for a newer mainline tag periodically rather than pinning
# this forever, since it's the main source of any CVEs reported against this image.
FROM nginxinc/nginx-unprivileged:1.29-alpine-slim

# Alpine base, not Debian - apk, not apt. Applies any package security fixes released
# since the base image was built, then removes the package index/cache so it doesn't
# linger as unnecessary bytes (and stale metadata) in the final image layer. The base
# image already sets USER 101 (nginx-unprivileged's whole point), but apk needs root
# to write /var/cache/apk and friends - switch to root only for this step, then back
# to the image's own non-root default before COPYing any files, so nothing later runs
# as root.
USER root
RUN apk update && apk upgrade --no-cache && rm -rf /var/cache/apk/*
USER 101

COPY approval-programs /usr/share/nginx/html/approval-programs
COPY clear-programs /usr/share/nginx/html/clear-programs
COPY abi-signatures /usr/share/nginx/html/abi-signatures
COPY arc56.links.csv /usr/share/nginx/html/arc56.links.csv
COPY docker/hash-registry/README.md /usr/share/nginx/html/README.md
COPY docker/hash-registry/index.html /usr/share/nginx/html/index.html

EXPOSE 8080
