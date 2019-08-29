FROM mcr.microsoft.com/dotnet/core/runtime:2.2-stretch-slim AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["test/Modules/Modules.Tests/Modules.Test.csproj", "test/Modules/Modules.Tests/"]
COPY ["src/Modules/StormyCommerce.Module.Catalog/StormyCommerce.Module.Catalog.csproj", "src/Modules/StormyCommerce.Module.Catalog/"]
COPY ["src/StormyCommerce.Core/StormyCommerce.Core.csproj", "src/StormyCommerce.Core/"]
COPY ["src/SimplCommerce.Infrastructure/SimplCommerce.Infrastructure.csproj", "src/SimplCommerce.Infrastructure/"]
COPY ["src/StormyCommerce.Infraestructure/StormyCommerce.Infraestructure.csproj", "src/StormyCommerce.Infraestructure/"]
COPY ["src/StormyCommerce.Api.Framework/StormyCommerce.Api.Framework.csproj", "src/StormyCommerce.Api.Framework/"]
RUN dotnet restore "test/Modules/Modules.Tests/Modules.Test.csproj"
COPY . .
WORKDIR "/src/test/Modules/Modules.Tests"
RUN dotnet build "Modules.Test.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Modules.Test.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Modules.Test.dll"]