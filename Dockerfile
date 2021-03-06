FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY . ./
FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /app
RUN dotnet restore "app/src/SimplCommerce.WebHost/SimplCommerce.WebHost.csproj"
RUN dotnet build SimplCommerce.sln
WORKDIR "/src/SimplCommerce.WebHost"
RUN dotnet build "SimplCommerce.WebHost.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SimplCommerce.WebHost.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SimplCommerce.WebHost.dll"]