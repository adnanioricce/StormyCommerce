#!/bin/bash
set -e

if PGPASSWORD=postgres psql -h postgres -p 5432 --username postgres -lqt | cut -d \| -f 1 | grep -qw postgres; then
    echo "postgres database exists"
else
    echo "create new database postgres"
	PGPASSWORD=postgres psql -h postgres -p 5432 --username postgres -c "CREATE DATABASE postgres WITH ENCODING 'UTF8'"
	PGPASSWORD=postgres psql -h postgres -p 5432 --username postgres -d postgres -a -f /app/postgresql-initdb/dbscript.sql
fi

cd /app && dotnet SimplCommerce.WebHost.dll 
