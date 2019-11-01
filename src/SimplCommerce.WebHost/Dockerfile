FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/SimplCommerce.WebHost/SimplCommerce.WebHost.csproj", "src/SimplCommerce.WebHost/"]
COPY ["src/Modules/StormyCommerce.Module.Catalog/StormyCommerce.Module.Catalog.csproj", "src/Modules/StormyCommerce.Module.Catalog/"]
COPY ["src/StormyCommerce.Core/StormyCommerce.Core.csproj", "src/StormyCommerce.Core/"]
COPY ["src/SimplCommerce.Infrastructure/SimplCommerce.Infrastructure.csproj", "src/SimplCommerce.Infrastructure/"]
COPY ["src/StormyCommerce.Infraestructure/StormyCommerce.Infraestructure.csproj", "src/StormyCommerce.Infraestructure/"]
COPY ["src/StormyCommerce.Api.Framework/StormyCommerce.Api.Framework.csproj", "src/StormyCommerce.Api.Framework/"]
COPY ["src/Modules/StormyCommerce.Module.Customer/StormyCommerce.Module.Customer.csproj", "src/Modules/StormyCommerce.Module.Customer/"]
COPY ["src/Modules/SimplCommerce.Module.EmailSenderSendgrid/SimplCommerce.Module.EmailSenderSendgrid.csproj", "src/Modules/SimplCommerce.Module.EmailSenderSendgrid/"]
COPY ["src/Modules/SimplCommerce.Module.SampleData/SimplCommerce.Module.SampleData.csproj", "src/Modules/SimplCommerce.Module.SampleData/"]
COPY ["src/Modules/StormyCommerce.Module.Orders/StormyCommerce.Module.Orders.csproj", "src/Modules/StormyCommerce.Module.Orders/"]
COPY ["src/Modules/StormyCommerce.Module.PagarMe/StormyCommerce.Module.PagarMe.csproj", "src/Modules/StormyCommerce.Module.PagarMe/"]
RUN dotnet restore "src/SimplCommerce.WebHost/SimplCommerce.WebHost.csproj"
COPY . .
WORKDIR "/src/src/SimplCommerce.WebHost"
RUN dotnet build "SimplCommerce.WebHost.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SimplCommerce.WebHost.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SimplCommerce.WebHost.dll"]