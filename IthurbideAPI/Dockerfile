# Etapa 1: build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copiar el csproj de la carpeta del proyecto
COPY IthurbideAPI/IthurbideAPI.csproj ./IthurbideAPI.csproj
RUN dotnet restore ./IthurbideAPI.csproj

# Copiar todo el proyecto
COPY IthurbideAPI/ ./IthurbideAPI/
WORKDIR /src/IthurbideAPI
RUN dotnet publish -c Release -o /app/publish

# Etapa 2: runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 8080
ENTRYPOINT ["dotnet", "IthurbideAPI.dll"]
