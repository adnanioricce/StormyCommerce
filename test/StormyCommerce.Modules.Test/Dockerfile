FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["StormyCommerce.Modules.Test/StormyCommerce.Modules.IntegrationTest.csproj", "StormyCommerce.Modules.Test/"]
COPY ["src/Modules/StormyCommerce.Module.Catalog/StormyCommerce.Module.Catalog.csproj", "src/Modules/StormyCommerce.Module.Catalog/"]
COPY ["src/StormyCommerce.Core/StormyCommerce.Core.csproj", "src/StormyCommerce.Core/"]
COPY ["src/SimplCommerce.Infrastructure/SimplCommerce.Infrastructure.csproj", "src/SimplCommerce.Infrastructure/"]
COPY ["src/StormyCommerce.Infraestructure/StormyCommerce.Infraestructure.csproj", "src/StormyCommerce.Infraestructure/"]
COPY ["src/StormyCommerce.Api.Framework/StormyCommerce.Api.Framework.csproj", "src/StormyCommerce.Api.Framework/"]
COPY ["test/Infraestructure/TestHelperLibrary/TestHelperLibrary.csproj", "test/Infraestructure/TestHelperLibrary/"]
COPY ["src/SimplCommerce.WebHost/SimplCommerce.WebHost.csproj", "src/SimplCommerce.WebHost/"]
COPY ["src/Modules/StormyCommerce.Module.Orders/StormyCommerce.Module.Orders.csproj", "src/Modules/StormyCommerce.Module.Orders/"]
RUN dotnet restore "StormyCommerce.Modules.Test/StormyCommerce.Modules.IntegrationTest.csproj"
COPY . .
WORKDIR "/src/StormyCommerce.Modules.Test"
RUN dotnet build "StormyCommerce.Modules.IntegrationTest.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "StormyCommerce.Modules.IntegrationTest.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "StormyCommerce.Modules.IntegrationTest.dll"]