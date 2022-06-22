FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

COPY "Corpsolurion.Sreamteam.sln" "Corpsolurion.Sreamteam.sln"

COPY "ApiGateways/Web.Bff.Streamteam/aggregator/Web.Streamteam.HttpAggregator/Web.Streamteam.HttpAggregator.csproj" "Web.Streamteam.HttpAggregator.csproj"
COPY "BuildingBlocks/Devspaces.Support/Devspaces.Support.csproj" "BuildingBlocks/Devspaces.Support/Devspaces.Support.csproj"
COPY "BuildingBlocks/EventBus/EventBus/EventBus.csproj" "BuildingBlocks/EventBus/EventBus/EventBus.csproj"
COPY "BuildingBlocks/EventBus/EventBus.Tests/EventBus.Tests.csproj" "BuildingBlocks/EventBus/EventBus.Tests/EventBus.Tests.csproj"
COPY "BuildingBlocks/EventBus/EventBusRabbitMQ/EventBusRabbitMQ.csproj" "BuildingBlocks/EventBus/EventBusRabbitMQ/EventBusRabbitMQ.csproj"
COPY "BuildingBlocks/EventBus/IntegrationEventLogEF/IntegrationEventLogEF.csproj" "BuildingBlocks/EventBus/IntegrationEventLogEF/IntegrationEventLogEF.csproj"
COPY "BuildingBlocks/WebHostCustomization/WebHost.Customization/WebHost.Customization.csproj" "BuildingBlocks/WebHostCustomization/WebHost.Customization/WebHost.Customization.csproj"

COPY "docker-compose.dcproj" "docker-compose.dcproj"
COPY "NuGet.config" "NuGet.config"

RUN dotnet restore "Corpsolution.Streamteam.sln"

COPY . .
WORKDIR /src/ApiGateways/Web.Bff.Shopping/aggregator
RUN dotnet publish --no-restore -c Release -o /app

FROM build AS publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Web.Streamteam.HttpAggregator.dll"]
