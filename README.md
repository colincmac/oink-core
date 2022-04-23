# Sample - Shared libraries
**This is a work in progress. This repo is a part of a larger effort to demonstrate secure workloads on Azure. This is for reference only and not meant for production workloads**
This is a supporting set of libraries. Reference the related repositories below to see them in action.

## Related GitHub repositories

### Supporting
|Item|Description|
|----|-----|
|[Utility Docker Images](https://github.com/colincmac/oink-docker-images)|Images used to support Ops scenarios. Built using [ACR Tasks](https://docs.microsoft.com/en-us/azure/container-registry/container-registry-tasks-overview)|
|[Shared .NET Libraries](https://github.com/colincmac/oink-core-dotnet)|Base .NET seedwork for implementing CQRS, EventSourcing, and DDD|

### Application Workloads
|Item|Description|
|----|-----|
|[Financial Account Management](https://github.com/colincmac/oink-financial-account-mgmt)|TODO|

## Features

This project framework provides the following features:

* Sample [seedwork](https://www.martinfowler.com/bliki/Seedwork.html) to support .NET Azure Function development with various architecture patterns, including:
  * Domain Driven Design
  * CQRS
  * Event Sourcing using CosmosDB as an event store
* Helpers for developing solutions using the Azure SDK
* CI/CD workflow using GitHub actions and the GitHub Nuget package feed

## Getting Started

### Prerequisites

- .NET 6.x
- Visual Studio 2022 (or preferred .NET IDE)

### Quickstart

1. git clone [repository clone url]
2. cd [repository name]
3. ...


## Resources

(Any additional resources or related projects)

- Link to supporting information
- Link to similar sample
- ...
