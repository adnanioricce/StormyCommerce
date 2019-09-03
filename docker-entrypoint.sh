#!/bin/bash
set -e

if PGPASSWORD=postgres psql -h postgres -p 5432 --username postgres -lqt | cut -d \| -f 1 | grep -qw stormydb; then
    echo "postgres database exists"
else
    echo "create new database postgres"
	PGPASSWORD=postgres psql -h postgres -p 5432 --username postgres -c "CREATE DATABASE stormydb WITH ENCODING 'UTF8'"
	PGPASSWORD=postgres psql -h postgres -p 5432 --username postgres -d stormydb -a -f /app/dbscript.sql
fi

cd /app && dotnet SimplCommerce.WebHost.dll 
