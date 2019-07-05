#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-sdk AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build
WORKDIR /src
COPY ["ProductWeb/ProductWeb.csproj", "ProductWeb/"]
COPY ["ProductWeb/appsettings.json", "ProductWeb/"]

RUN dotnet restore "ProductWeb/ProductWeb.csproj"
COPY . .
WORKDIR "/src/ProductWeb"
RUN dotnet build "ProductWeb.csproj" -c Release -o /app


FROM build AS publish
RUN dotnet publish "ProductWeb.csproj" -c Release -o /app

FROM base AS final  
WORKDIR /app  
COPY --from=publish /app . 
COPY ["entrypoint.sh", ""]
COPY ["ef.dll", ""]
RUN chmod +x ./entrypoint.sh
CMD /bin/bash ./entrypoint.sh

