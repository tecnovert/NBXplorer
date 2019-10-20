FROM mcr.microsoft.com/dotnet/core/sdk:2.1.505-alpine3.7 AS builder

RUN apk add libcurl

WORKDIR /source
COPY . .

VOLUME /out
VOLUME /packages

CMD dotnet restore -s /packages -s https://api.nuget.org/v3/index.json NBXplorer/NBXplorer.csproj \
    && dotnet build -c Release NBXplorer/NBXplorer.csproj \
    && dotnet pack -c Release NBXplorer.Client/NBXplorer.Client.csproj -o /out/packages
