FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PizzaController/PizzaController.csproj", "PizzaController/"]
RUN dotnet restore "PizzaController/PizzaController.csproj"
COPY . .
WORKDIR "/src/PizzaController"
RUN dotnet build "PizzaController.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PizzaController.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PizzaController.dll"]
