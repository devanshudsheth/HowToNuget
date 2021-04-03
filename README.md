# HowToNuget
This repo makes use of some commonly used Nuget packages.

# Packages added so far
================================================================

1. Swashbuckle.AspNetCore for Swagger UI
2. Serilog for logging
3. Bogus for faking data
4. Automapper for mapping
5. Autofac for dependency injection


# Disclaimer
================================================================

This is a learning repository. This is not necessarily the most optimum way of combining Nuget packages, and I may have intentionally excluded packages
which have better integration with each other.
For example,
Automapper has a better integration for dependency injection with Microsoft.Extensions.DependencyInjection.
However, I chose to use Autofac for my dependency injection and used another Nuget package for Automapper integration with Autofac.

