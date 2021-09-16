#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["XTools.Web.Entry/XTools.Web.Entry.csproj", "XTools.Web.Entry/"]
COPY ["XTools.Web.Core/XTools.Web.Core.csproj", "XTools.Web.Core/"]
COPY ["XTools.Application/XTools.Application.csproj", "XTools.Application/"]
COPY ["XTools.Core/XTools.Core.csproj", "XTools.Core/"]
COPY ["XTools.Database.Migrations/XTools.Database.Migrations.csproj", "XTools.Database.Migrations/"]
COPY ["XTools.EntityFramework.Core/XTools.EntityFramework.Core.csproj", "XTools.EntityFramework.Core/"]
RUN dotnet restore "XTools.Web.Entry/XTools.Web.Entry.csproj"
COPY . .
WORKDIR "/src/XTools.Web.Entry"
RUN dotnet build "XTools.Web.Entry.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "XTools.Web.Entry.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "XTools.Web.Entry.dll"]