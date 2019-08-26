FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["SimplCommerce.WebHost/SimplCommerce.WebHost.csproj", "SimplCommerce.WebHost/"]
COPY ["Modules/StormyCommerce.Module.Catalog/StormyCommerce.Module.Catalog.csproj", "Modules/StormyCommerce.Module.Catalog/"]
COPY ["StormyCommerce.Core/StormyCommerce.Core.csproj", "StormyCommerce.Core/"]
COPY ["SimplCommerce.Infrastructure/SimplCommerce.Infrastructure.csproj", "SimplCommerce.Infrastructure/"]
COPY ["StormyCommerce.Infraestructure/StormyCommerce.Infraestructure.csproj", "StormyCommerce.Infraestructure/"]
COPY ["StormyCommerce.Api.Framework/StormyCommerce.Api.Framework.csproj", "StormyCommerce.Api.Framework/"]
COPY ["Modules/SimplCommerce.Module.SampleData/SimplCommerce.Module.SampleData.csproj", "Modules/SimplCommerce.Module.SampleData/"]
COPY ["Modules/SimplCommerce.Module.Core/SimplCommerce.Module.Core.csproj", "Modules/SimplCommerce.Module.Core/"]
COPY ["Modules/StormyCommerce.Module.Customer/StormyCommerce.Module.Customer.csproj", "Modules/StormyCommerce.Module.Customer/"]
COPY ["Modules/SimplCommerce.Module.EmailSenderSendgrid/SimplCommerce.Module.EmailSenderSendgrid.csproj", "Modules/SimplCommerce.Module.EmailSenderSendgrid/"]
COPY ["Modules/StormyCommerce.Module.Orders/StormyCommerce.Module.Orders.csproj", "Modules/StormyCommerce.Module.Orders/"]
RUN dotnet restore "SimplCommerce.WebHost/SimplCommerce.WebHost.csproj"
COPY . .
WORKDIR "/src/SimplCommerce.WebHost"
RUN dotnet build "SimplCommerce.WebHost.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SimplCommerce.WebHost.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SimplCommerce.WebHost.dll"]