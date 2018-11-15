FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["BusinessLibrary.Shared/BusinessLibrary.Shared.shproj", "BusinessLibrary.Shared/"]
COPY ["BusinessLibrary/BusinessLibrary.csproj", "BusinessLibrary/"]
RUN dotnet restore "BusinessLibrary/BusinessLibrary.csproj"
COPY ["AppServer/AppServer.csproj", "AppServer/"]
RUN dotnet restore "AppServer/AppServer.csproj"
COPY . .
WORKDIR "/src/AppServer"
RUN dotnet build "AppServer.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AppServer.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AppServer.dll"]