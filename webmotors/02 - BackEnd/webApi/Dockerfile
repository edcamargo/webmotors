#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["02 - BackEnd/webApi/webApi.csproj", "02 - BackEnd/webApi/"]
COPY ["02 - BackEnd/WebMotors.Domain.Core/WebMotors.Domain.Core.csproj", "02 - BackEnd/WebMotors.Domain.Core/"]
COPY ["02 - BackEnd/WebMotors.Domain/WebMotors.Domain.csproj", "02 - BackEnd/WebMotors.Domain/"]
COPY ["02 - BackEnd/WebMotors.InfraStructure.Data/WebMotors.InfraStructure.Data.csproj", "02 - BackEnd/WebMotors.InfraStructure.Data/"]
COPY ["02 - BackEnd/WebMotors.InfraStructure.Ioc/WebMotors.InfraStructure.Ioc.csproj", "02 - BackEnd/WebMotors.InfraStructure.Ioc/"]
COPY ["02 - BackEnd/WebMotors.Domain.Services/WebMotors.Domain.Services.csproj", "02 - BackEnd/WebMotors.Domain.Services/"]
COPY ["02 - BackEnd/WebMotors.InfraStructure.AntiCorruption/WebMotors.InfraStructure.AntiCorruption.csproj", "02 - BackEnd/WebMotors.InfraStructure.AntiCorruption/"]
RUN dotnet restore "02 - BackEnd/webApi/webApi.csproj"
COPY . .
WORKDIR "/src/02 - BackEnd/webApi"
RUN dotnet build "webApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "webApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "webApi.dll"]