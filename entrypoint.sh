#!/bin/bash

set -e
set EfMigrationsNamespace=ProductWeb
set EfMigrationsDllName=ProductWeb.dll
set EfMigrationsDllDepsJson=ProductWeb.deps.json
set DllDir=%cd%
run_cmd="dotnet ProductWeb.dll"

until dotnet exec --runtimeconfig ProductWeb.runtimeconfig.json --depsfile ProductWeb.deps.json ef.dll --verbose database update --assembly ProductWeb.dll; do
>&2 echo "Waiting until SQL is starting"
sleep 10
done

>&2 echo "SQL Server is up - executing command"
exec $run_cmd