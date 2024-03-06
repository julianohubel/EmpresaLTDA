# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY Empregados.API/*.csproj Empregados.API/
COPY Empregados.Domain/*.csproj Empregados.Domain/
COPY Empregados.Domain.Infra/*.csproj Empregados.Domain.Infra/
RUN dotnet restore Empregados.API/Empregados.API.csproj

# copy and build app and libraries
COPY Empregados.API/ Empregados.API/
COPY Empregados.Domain/ Empregados.Domain/
COPY Empregados.Domain.Infra/ Empregados.Domain.Infra/

# test stage -- exposes optional entrypoint
# target entrypoint with: docker build --target test
FROM build AS test

COPY Empregados.Domain.Tests/*.csproj Empregados.Domain.Tests/
WORKDIR /app/Empregados.Domain.Tests
RUN dotnet restore

COPY Empregados.Domain.Tests/ .
RUN dotnet build --no-restore

ENTRYPOINT ["dotnet", "Empregados.Domain.Tests", "--logger:trx", "--no-build"]

FROM build as migrations
RUN dotnet tool install --global dotnet-ef
ENV PATH="${PATH}:/root/.dotnet/tools"
ENTRYPOINT dotnet ef database update --project Empregados.Domain.Infra --startup-project Empregados.API

FROM build AS publish
WORKDIR /source/Empregados.API
RUN dotnet publish -c Debug -o /app


# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Empregados.API.dll"]