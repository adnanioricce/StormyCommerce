FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY . ./
RUN sed -i 's/2.2.401/2.2.207' global.json
RUN dotnet build SimplCommerce.sln
RUN dotnet build *.sln -c Release \
    && cd src/SimplCommerce.WebHost \    
    && dotnet build -c Release \
    && dotnet publish -c Release -o out
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=base /app .
ENTRYPOINT ["dotnet", "SimplCommerce.WebHost.dll"]
