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
- [MAUI guide](./docs/maui/Index.md) - Our guide for quickly adding login, logout, retrieve token and user information for MAUI iOS & Android applications.

## Getting Started

### Installation

The Trimble Identity SDK is available as a [Nuget](https://www.nuget.org/packages?q=Trimble.ID) package for different platforms. You can install it using the NuGet Package Manager or by running the following command in the Package Manager Console:

```
dotnet add package Trimble.ID --version 1.0.0
dotnet add package Trimble.ID.Maui --version 1.0.0
dotnet add package Trimble.ID.Desktop --version 1.0.0
```

### Configure Trimble Identity

> **NOTE:**
> 
> If you do not have access to the Trimble Developer Console, please work with a Trimble partner to get onboarded on to the [Trimble Developer Console](https://console.trimble.com/).

Create a new application in the [Trimble Developer Console](https://console.trimble.com/) portal and configure the following settings:

To register your application in Trimble Developer Console:

1. On the left pane select "Applications".

2. On the Applications home page, in the top right corner select + NEW APPLICATION. The Create Application page displays.

3. Select Continue to enter the applications details.

    | Field       | Description |
    | ----------- | ----------- |
    | Name        | Name of your application                    |
    | Description | Provide a description for the application.  |

4. Configure Grant Type and Token preferences of your application choice.

    | Field       | Description |
    | ----------- | ----------- |
    | Application Grant Types        | Select the grant types that will be used for authenticating users or applications.                    |
    | Allowed Callback URLS| Refers to the redirect URI of the application after logging into Identity. More than one URL can be added to this field. The total URI length should not exceed 400kb. This field appears only when you select the Authorization Grant type.  |
    | Allowed Logout URLS | The URIs that Identity can redirect to after log out. More than one UL can be added to this field. The total URI length should not exceed 400kb. This field appears only when you select the Authorization Grant type.  |

5. Select "Create Application" to save changes.

Take note of the Client ID and URLs under the "Basic Information" section. You'll need these values to configure the SDK.

**Scopes**

Trimble Identity uses scopes to determine the aud claim in the returned access token. Scope is mandatory for the application to work. You can use the scope as the application name registered in the Trimble Developer Console. For example, if you have registered an application with the name "test", then it must be registered in the format {some_uuid}-"test". For eg., 12345678-1234-1234-1234-123456789012-test.

For more information, see [Authentication documentation](https://developer.trimble.com/docs/authentication).

### Raise an issue

To provide feedback or report a bug, please [raise an issue on our issue tracker](https://github.com/trimble-oss/tcp-sdk-docs-for-net/issues).

## <a name="support">Support</a>

Send email to [support@trimble.com](mailto:support@trimble.com)
