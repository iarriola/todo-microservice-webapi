# microservice-webapi
Simple microservice based on dotnet and Web API

## Project structure
```
.
├── README.md
├── src
|   ├── MicroserviceWebapi.Api (webapi)
|   ├── MicroserviceWebapi.Data (migration)
|   ├── MicroserviceWebapi.Model (classlib)
|   ├── MicroserviceWebapi.Repository (classlib)
└── MicroserviceWebapi.sln
```

## How to run
- Execute `dotnet run --project src/MicroserviceWebapi.Api`
- Open a web browser at `http://localhost:5000/WeatherForecast` to see sample `WeatherForecast` controller

## References
1. [.NET Tutorial - Your First Microservice](https://dotnet.microsoft.com/learn/aspnet/microservice-tutorial/install)
2. [Dependency injection in .NET](https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection)
3. [.NET Core CLI - Create Multi-Project Solution](https://www.skylinetechnologies.com/Blog/Skyline-Blog/February_2018/how-to-use-dot-net-core-cli-create-multi-project)
4. [WebAPI with .NET Core and PostgreSQL](https://medium.com/@agavatar/webapi-with-net-core-and-postgres-in-visual-studio-code-8b3587d12823)
5. [Organizing .NET Core Projects](https://medium.com/@fredrik_erasmus/organizing-net-core-projects-7ee335ea6af)
6. [Organize your project to support both .NET Framework and .NET Core](https://docs.microsoft.com/en-us/dotnet/core/porting/project-structure)
