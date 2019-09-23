# ApiGatewaySample
.NET Core project demonstrating how to use Ocelot as the API Gateway of your microservices.

# Usage
1. Clone the repository and run the following commands in CMD or PS:

```
dotnet restore ApiGatewaySample.sln
cd AssetsApi
dotnet run
```

This will run the AssetsApi microservice.

2. Open a second CMD or PS:

```
cd GatewayApi
dotnet run
```

This will start the Api Gateway. Now you can access the Assets microservice through Ocelot Api Gateway:

```
http://localhost/api/v2/assets/
http://localhost/api/v2/assets/325583 <-- use any Id here
http://localhost/api/v2/assets/325583/attributes/
```
