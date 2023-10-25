# Trimble Identity SDK Libraries for .NET applications

The Trimble Identity(TID) client allows you to add authentication for your .NET applications. It supports following platforms:

- netstandard2.0
- Desktop .NET
- .NET Framework >= 4.6.1
- .NET Core >= 2.0
- MAUI iOS 
- MAUI Android

## Documentation

- [Trimble.ID guide](./docs/core/Index.md) - Our Trimble Identity core SDK to facilitate authentication on various grant types.
- [Desktop guide](./docs/desktop/Index.md) - Our guide for quickly adding login, logout, retrieve token and user information for desktop applications like WPF/WinForms.
- [MAUI guide](./docs/Maui/Index.md) - Our guide for quickly adding login, logout, retrieve token and user information for MAUI iOS & Android applications.

## Getting Started

### Installation

The Trimble Identity SDK is available as a [Nuget](https://www.nuget.org/packages?q=Trimble.ID) package for different platforms. You can install it using the NuGet Package Manager or by running the following command in the Package Manager Console:

```
dotnet add package Trimble.ID --version 1.0.0
dotnet add package Trimble.ID.Maui --version 1.0.0
dotnet add package Trimble.ID.Desktop --version 1.0.0
```

### Configure Trimble Identity

Create a new application in the [Trimble Developer Console](https://beta.console.trimble.com/home) portal and configure the following settings:

To register your service application in Trimble Cloud Console:

1. On the left pane select Identity Management > Applications.

2. On the Applications home page, in the top right corner select + ADD APPLICATION. The Create Application page displays.

3. In the Application Type section, select one of the following options:

    - Service Application - A service application are intended to be used in programmatic workflows or server-server communication.

    - Application - Refers to any Trimble application that is intended to be accessed by an end user.

4. Select Continue to enter the applications details.

| Field       | Description |
| ----------- | ----------- |
| Name        | Name of your application                    |
| Display Name| Provide a display name of the application.  |
| Description | Provide a description for the application.  |

5. Continue with completing the Configurations section. The fields that display depend on your selection in step 3.
    - For Service Application: 
      Service Application Grant types - Only Client Credentials Grant displays.
    - For Application:

| Field       | Description |
| ----------- | ----------- |
| Application Grant Types        | Select the grant types that will be used for authenticating users or applications.                    |
| Allowed Callback URLS| Refers to the redirect URI of the application after logging into Identity. More than one UL can be added to this field. The total URI length should not exceed 400kb. This field appears only when you select the Authorization Grant type.  |
| Allowed Logout URLS | The URIs that Identity can redirect to after log out. More than one UL can be added to this field. The total URI length should not exceed 400kb. This field appears only when you select the Authorization Grant type.  |

6. Select COMPLETE to save changes.

Take note of the Client ID and URLs under the "Basic Information" section. You'll need these values to configure the SDK.


### Raise an issue

To provide feedback or report a bug, please [raise an issue on our issue tracker](https://github.com/trimble-oss/tcp-sdk-docs-for-net/issues).

## <a name="support">Support</a>

Send email to [cloudplatform_support@trimble.com](mailto:cloudplatform_support@trimble.com)