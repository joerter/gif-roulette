FROM microsoft/dotnet:1.0.0-preview2-sdk
MAINTAINER John Oerter

ENV ASPNETCORE_URLS="http://*:5000"
ENV ASPNETCORE_ENVIRONMENT="Development"
# ENV USE_POLLING_FILE_WATCHER=1

COPY . /app
WORKDIR /app

RUN ["dotnet", "restore"]

EXPOSE 5000

CMD ["/bin/bash", "-c", "dotnet watch run"]

