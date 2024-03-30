FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY *.csproj  .
RUN dotnet restore 
COPY . .
RUN dotnet publish -c Release -o output

FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "E_CommerceSystemV2.API.dll"]


