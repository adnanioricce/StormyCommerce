FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY . ./
RUN dotnet build SimplCommerce.sln
RUN dotnet build *.sln -c Release \
    && cd src/SimplCommerce.WebHost \    
    && dotnet build -c Release \
    && dotnet publish -c Release -o /app/publish
FROM base AS publish
WORKDIR /app
COPY --from=base /app/publish ./
CMD ["dotnet", "SimplCommerce.WebHost.dll"]