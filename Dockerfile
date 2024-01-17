FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 1926
EXPOSE 44301

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Adverts.Api/Adverts.Api.csproj", "Adverts.Api/"]
RUN dotnet restore "Adverts.Api/Adverts.Api.csproj"
COPY . .
WORKDIR "/src/Adverts.Api"
RUN dotnet build "Adverts.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Adverts.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Adverts.Api.dll"]