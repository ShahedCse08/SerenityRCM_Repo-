FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SerenityRCM.WebAPI/SerenityRCM.WebAPI.csproj", "SerenityRCM.WebAPI/"]
RUN dotnet restore "SerenityRCM.WebAPI/SerenityRCM.WebAPI.csproj"
COPY . .
WORKDIR "/src/SerenityRCM.WebAPI"
RUN dotnet build "SerenityRCM.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SerenityRCM.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SerenityRCM.WebAPI.dll"]
