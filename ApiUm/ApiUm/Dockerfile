FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ./ ApiUm/
RUN dotnet restore "ApiUm/ApiUm/ApiUm.csproj"
WORKDIR "/src/ApiUm/ApiUm"
RUN dotnet build "ApiUm.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApiUm.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiUm.dll"]