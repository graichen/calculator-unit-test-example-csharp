FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY CalculatorApp/*.csproj .
RUN dotnet restore

# copy and publish app and libraries
COPY CalculatorApp .
RUN dotnet publish -c release -o /app 

# final stage/image
FROM mcr.microsoft.com/dotnet/core/runtime:3.1
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["./CalculatorApp"]
