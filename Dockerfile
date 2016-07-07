FROM microsoft/dotnet:1.0.0-preview2-sdk
MAINTAINER John Oerter

COPY . /app
WORKDIR /app

RUN ["dotnet", "restore"]

EXPOSE 5000

CMD ["/bin/bash", "-c", "dotnet watch run"]