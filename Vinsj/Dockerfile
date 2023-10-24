FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Vinsj/Vinsj.csproj", "Vinsj/"]
RUN dotnet restore "Vinsj/Vinsj.csproj"
COPY . .
WORKDIR "/src/Vinsj"
RUN dotnet build "Vinsj.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Vinsj.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Vinsj.dll"]
