# Microsoft Graph .NET Client Library

[![Build status](https://ci.appveyor.com/api/projects/status/m8qncaosr2ry4ks6/branch/master?svg=true)](https://ci.appveyor.com/project/MIchaelMainer/msgraph-sdk-dotnet/branch/master)
[![NuGet Version](https://buildstats.info/nuget/Microsoft.Graph)](https://www.nuget.org/packages/Microsoft.Graph/)

Integrate the [Microsoft Graph API](https://graph.microsoft.io) into your .NET
project!

The Microsoft Graph .NET Client Library targets .NetStandard 2.0 and .Net Framework 4.6.1.

## Installation via NuGet

To install the client library via NuGet:

* Search for `Microsoft.Graph` in the NuGet Library, or
* Type `Install-Package Microsoft.Graph` into the Package Manager Console.

## Getting started

### 1. Register your application

Register your application to use Microsoft Graph API using the [Microsoft Application Registration Portal](https://aka.ms/appregistrations).

### 2. Authenticate for the Microsoft Graph service

The Microsoft Graph .NET Client Library supports the use of TokenCredential classes in the [Azure.Identity](https://www.nuget.org/packages/Azure.Identity) library.

You can read more about available Credential classes [here](https://docs.microsoft.com/en-us/dotnet/api/overview/azure/identity-readme#key-concepts) and examples on how to quickly setup TokenCredential instances can be found [here](docs/tokencredentials.md).

For more information on `DelegateAuthenticationProvider`, see the [library overview](docs/overview.md).  

The recommended library for authenticating against Microsoft Identity (Azure AD) is [MSAL](https://github.com/AzureAD/microsoft-authentication-library-for-dotnet).

For an example of authenticating a UWP app using the V2 Authentication Endpoint, see the [Microsoft Graph UWP Connect Library](https://github.com/OfficeDev/Microsoft-Graph-UWP-Connect-Library).

### 3. Create a Microsoft Graph client object with an authentication provider

An instance of the **GraphServiceClient** class handles building requests,
sending them to Microsoft Graph API, and processing the responses. To create a
new instance of this class, you need to provide an instance of
`IAuthenticationProvider` which can authenticate requests to Microsoft Graph.

For more information on initializing a client instance, see the [library overview](docs/overview.md)

### 4. Make requests to the graph

Once you have completed authentication and have a GraphServiceClient, you can
begin to make calls to the service. The requests in the SDK follow the format
of the Microsoft Graph API's RESTful syntax.

For example, to retrieve a user's default drive:

```csharp
var drive = await graphClient.Me.Drive.Request().GetAsync();
```

`GetAsync` will return a `Drive` object on success and throw a
`ServiceException` on error.

To get the current user's root folder of their default drive:

```csharp
var rootItem = await graphClient.Me.Drive.Root.Request().GetAsync();
```

`GetAsync` will return a `DriveItem` object on success and throw a
`ServiceException` on error.

For a general overview of how the SDK is designed, see [overview](docs/overview.md).

The following sample applications are also available:
* [Microsoft Graph UWP Connect Sample](https://github.com/microsoftgraph/uwp-csharp-connect-sample)
* [Microsoft Graph UWP Snippets Sample](https://github.com/microsoftgraph/uwp-csharp-snippets-sample)
* [Microsoft Graph MeetingBot sample for UWP](https://github.com/microsoftgraph/uwp-csharp-meetingbot-sample)
* [Microsoft Graph Connect Sample for ASP.NET 4.6](https://github.com/microsoftgraph/aspnet-connect-sample)
* [Microsoft Graph Snippets Sample for ASP.NET 4.6](https://github.com/microsoftgraph/aspnet-snippets-sample)
* [Microsoft Graph SDK Snippets Library for Xamarin.Forms](https://github.com/microsoftgraph/xamarin-csharp-snippets-sample)
* [Microsoft Graph Connect Sample for Xamarin Forms](https://github.com/microsoftgraph/xamarin-csharp-connect-sample)
* [Microsoft Graph Meeting Manager Sample for Xamarin.Forms](https://github.com/microsoftgraph/xamarin-csharp-meetingmanager-sample)
* [Microsoft Graph Property Manager Sample for Xamarin Native](https://github.com/microsoftgraph/xamarin-csharp-propertymanager-sample)

## Documentation and resources

* [Overview](docs/overview.md)
* [Collections](docs/collections.md)
* [Errors](docs/errors.md)
* [Headers](docs/headers.md)
* [Microsoft Graph API](https://graph.microsoft.io)
* [Release notes](https://github.com/microsoftgraph/msgraph-sdk-dotnet/releases)
* [Blog - Microsoft Graph .NET SDK updates 3/16/20](https://developer.microsoft.com/en-us/graph/blogs/microsoft-graph-net-sdk-updates/)

## Notes

### Upgrading from v1

Between 1.x and 3.x there were some minor possibly breaking changes:

 * .NET Standard minimum version bumped from `netStandard1.3` to `netstandard2.0`
 * .NET Framework minimum version bumped from `net45` to `net461`
 * a change in enum order for `GiphyRatingType`
 * `ParticipantInfo` became `InvitationParticipantInfo`
 * `CallRecordRequestBody` became `CallRecordResponseRequestBody`

### Upgrading to v4

Between 3.x and 4.x there were some major breaking changes:

 * .NET Standard minimum version bumped from `netStandard1.3` to `netstandard2.0`
 * .NET Framework minimum version bumped from `net45` to `net462`
 * Replacing Newtosoft.Json with System.Text.Json
 * Upgrading Microsoft.Graph.Core dependency to version 2.0.0

View the upgrade guide [here](docs/upgrade-to-v4.md).

## Issues

To view or log issues, see [issues](https://github.com/microsoftgraph/msgraph-sdk-dotnet/issues).

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Other resources

* NuGet Package: [https://www.nuget.org/packages/Microsoft.Graph](https://www.nuget.org/packages/Microsoft.Graph)

## Building library locally

If you are looking to build the library locally for the purposes of contributing code or running tests, you will need to:

- Have the .NET Core SDK (> 1.0) installed
- Run `dotnet restore` from the command line in your package directory
- Run `nuget restore` and `msbuild` from CLI or run Build from Visual Studio to restore Nuget packages and build the project

## License

Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT [license](LICENSE.txt). See [Third Party Notices](https://github.com/microsoftgraph/msgraph-sdk-dotnet/blob/master/THIRD%20PARTY%20NOTICES) for information on the packages referenced via NuGet.
