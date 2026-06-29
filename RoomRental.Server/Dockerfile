# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["RoomRental.Server/RoomRental.Server.csproj", "RoomRental.Server/"]
COPY ["LoggerService/LoggerService.csproj", "LoggerService/"]
COPY ["Contracts/Contracts.csproj", "Contracts/"]
COPY ["Entities/Entities.csproj", "Entities/"]
COPY ["Repository/Repository.csproj", "Repository/"]
COPY ["RoomRental.Presentation/RoomRental.Presentation.csproj", "RoomRental.Presentation/"]
COPY ["Service.Contracts/Service.Contracts.csproj", "Service.Contracts/"]
COPY ["Shared/Shared.csproj", "Shared/"]
COPY ["Service/Service.csproj", "Service/"]
RUN dotnet restore "./RoomRental.Server/RoomRental.Server.csproj"
COPY . .
RUN dotnet test ./Tests/Tests.csproj 
WORKDIR "/src/RoomRental.Server"
RUN dotnet build "./RoomRental.Server.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./RoomRental.Server.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RoomRental.Server.dll"]