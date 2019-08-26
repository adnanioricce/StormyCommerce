#!/bin/bash
set -e

if PGPASSWORD=postgres psql -h postgres --username postgres -lqt | cut -d \| -f 1 | grep -qw simplcommerce; then
    echo "simplcommerce database existed"
else
    echo "create new database simplcommerce"
	PGPASSWORD=postgres psql -h postgres --username postgres -c "CREATE DATABASE simplcommerce WITH ENCODING 'UTF8'"
	PGPASSWORD=postgres psql -h postgres --username postgres -d simplcommerce -a -f /app/dbscript.sql
fi

cd /app && dotnet SimplCommerce.WebHost.dll 
