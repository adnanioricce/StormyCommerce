#!/bin/bash
set -e

if PGPASSWORD=docker psql -h stormydb -p 5432 --username docker -lqt | cut -d \| -f 1 | grep -qw stormydb; then
    echo "postgres database exists"
else
    echo "create new database postgres"
	PGPASSWORD=docker psql -h stormydb -p 5432 --username docker -c "CREATE DATABASE stormydb WITH ENCODING 'UTF8'"
	PGPASSWORD=docker psql -h stormydb -p 5432 --username docker -d stormydb -a -f /var/lib/postgresql/data/dbscript.sql
	PGPASSWORD=docker psql -h stormydb -p 5432 --username docker -d stormydb -a -f /var/lib/postgresql/data/seedScript.sql
fi

cd /app && dotnet SimplCommerce.WebHost.dll 
