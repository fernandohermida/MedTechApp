# Geodesics 
This is a solution calculate the distance between 2 coordinates points. 
We use ASP.NET Core following the principles of Clean Architecture with CQRS and SOLID. 
 
## Technologies
* .NET Core 3.1
* ASP .NET Core 3.1
* Entity Framework Core 3.1
* Angular 9
* Angular Material
* MediatR
* AutoMapper
* FluentValidation
* NUnit, FluentAssertions, Moq & Respawn

## Getting Started
The easiest way to get started is 

1. Be sure to have  the latest .NET Core SDK
2. Clone Solution
3. Build Project
4. Navigate to src/WebUI and run dotnet run to launch the project

## Overview
### Domain
This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.
### Application
This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.
### Infrastructure
This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the application layer.
### WebUI
This layer is a single page application based on Angular 9 and ASP.NET Core 3.1. This layer depends on both the Application and Infrastructure layers, however, the dependency on Infrastructure is only to support dependency injection. Therefore only Startup.cs should reference Infrastructure.
