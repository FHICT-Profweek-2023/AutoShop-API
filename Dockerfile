# Build

FROM mcr.microsoft.com/dotnet/sdk:8.0 as BUILD

WORKDIR /source
COPY . .

RUN dotnet restore "./AutoShop-API/AutoShop-API.csproj" --disable-parallel

RUN dotnet publish "./AutoShop-API/AutoShop-API.csproj" -c release -o /app --no-restore

# Serve

FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app
COPY --from=build /app ./

EXPOSE 8080

ENTRYPOINT [ "dotnet", "AutoShop-API.dll" ]