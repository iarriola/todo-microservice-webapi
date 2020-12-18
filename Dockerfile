FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src/MicroserviceWebapi.Api
COPY /src/MicroserviceWebapi.Api/MicroserviceWebapi.Api.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "MicroserviceWebapi.Api.dll"]
