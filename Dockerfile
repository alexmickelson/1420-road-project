FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app
COPY . .
WORKDIR /app/Web
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 80

ENTRYPOINT ["dotnet", "Web.dll"]