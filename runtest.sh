#!/bin/bash
set -eu -o pipefail

dotnet restore /MyXunitProject.csproj
dotnet test /MyXunitProject.csproj
