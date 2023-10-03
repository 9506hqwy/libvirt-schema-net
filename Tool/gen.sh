#!/bin/bash

set -eu

VERSION="v9.8.0"
REPO_URL="https://github.com/libvirt/libvirt.git"

SHDIR=`cd $(dirname $0); pwd`

WORKDIR=`mktemp -d`
trap 'popd; rm -rf ${WORKDIR}' EXIT

# Generate binding.
pushd ${WORKDIR}
git clone --depth 1 "${REPO_URL}" -b "${VERSION}"

dotnet run --project "${SHDIR}/Gen/Gen.csproj" -- "${WORKDIR}/libvirt/src/conf/schemas"
mv -f Generated.cs "${SHDIR}/../LibvirtModel/"
