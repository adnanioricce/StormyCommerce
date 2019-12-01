FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS base
WORKDIR /app
EXPOSE 443
COPY . ./
RUN rm src/SimplCommerce.WebHost/Migrations/* && cp -f src/SimplCommerce.WebHost/appsettings.docker.json src/SimplCommerce.WebHost/appsettings.json
RUN dotnet build SimplCommerce.sln
RUN dotnet build *.sln -c Release \
    && cd src/SimplCommerce.WebHost \    
    && dotnet build -c Release \
    && dotnet publish -c Release -o /app/publish
FROM base AS publish
WORKDIR /app
COPY --from=base /app/publish ./
CMD ["dotnet", "SimplCommerce.WebHost.dll"]
