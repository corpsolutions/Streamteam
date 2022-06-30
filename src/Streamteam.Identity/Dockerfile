FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Streamteam.Identity/Streamteam.Identity.csproj", "Streamteam.Identity/"]
RUN dotnet restore "Streamteam.Identity/Streamteam.Identity.csproj"
COPY . .
WORKDIR "/src/Streamteam.Identity"
RUN dotnet build "Streamteam.Identity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Streamteam.Identity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Streamteam.Identity.dll"]
