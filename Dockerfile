FROM microsoft/dotnet:1.0.0-core
WORKDIR /app
EXPOSE 5000
ENTRYPOINT ["dotnet", "gif-roulette.dll"]
COPY . /app
