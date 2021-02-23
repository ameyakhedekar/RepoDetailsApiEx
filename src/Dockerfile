
###Create Build and publish###
FROM mcr.microsoft.com/dotnet/sdk:5.0 as build
WORKDIR /src
COPY "RepoDetailsApi.csproj" .
RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o /out

###Deploy in Runtime###

FROM mcr.microsoft.com/dotnet/aspnet:5.0 as runti
EXPOSE 80
WORKDIR /app
COPY --from=build /out .
ENTRYPOINT ["dotnet", "RepoDetailsApi.dll"]

###RUNNING DOCKER###
#docker build -t repodetailsapi:v1 .
#docker run -e ASPNETCORE_ENVIRONMENT=Staging -p 8088:80 -i repodetailsapi:v1
#docker exec -it <container> /bin/bash