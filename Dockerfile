FROM microsoft/dotnet:sdk AS build
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore TopCoderStarterApp.csproj

COPY . ./
RUN dotnet publish TopCoderStarterApp.csproj -c Release -o out

FROM microsoft/dotnet:aspnetcore-runtime AS runtime

WORKDIR /app

COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "TopCoderStarterApp.dll"]`
