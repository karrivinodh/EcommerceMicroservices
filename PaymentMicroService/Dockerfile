#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["PaymentMicroService/PaymentMicroService.csproj", "PaymentMicroService/"]
RUN dotnet restore "PaymentMicroService/PaymentMicroService.csproj"
COPY . .
WORKDIR "/src/PaymentMicroService"
RUN dotnet build "PaymentMicroService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PaymentMicroService.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PaymentMicroService.dll"]