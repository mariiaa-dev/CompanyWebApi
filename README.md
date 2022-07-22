# Company API

Simple RESTful API built with ASP.NET 5 to show how to create RESTful services using a decoupled, maintainable architecture.

## Frameworks and Libraries
- [ASP.NET 5](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-5.0);
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) (for data access);
- [EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Microsoft.Entity) (for SqlServer);
- [EntityFrameworkCore.Tools](https://docs.microsoft.com/en-us/ef/core/cli/) (EF tools)
- [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle) (API documentation)
- [AutoMapper.Extensions.Microsoft.DependencyInjection](https://www.nuget.org/packages/AutoMapper.Extensions.Microsoft.DependencyInjection) (dependency injection)
- [AutoMapper](https://automapper.org/) (for mapping resources and models);

## How to Test

First, install [.NET 6](https://dotnet.microsoft.com/download/dotnet/6.0). Then, open the terminal or command prompt at the API root path (```/src/CompanyWebApi/```) and run the following commands, in sequence:

```
dotnet restore
dotnet run
```

Navigate to ```https://localhost:44395/api/Companies``` to check if the API is working. If you see a HTTPS security error, just add an exception to see the results.

Navigate to ```https://localhost:44395/swagger/``` to check the API documentation and to test all API endpoints.

![API Documentation]()