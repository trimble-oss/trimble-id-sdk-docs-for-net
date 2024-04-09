# Trimble Identity .NET MAUI SDK

Trimble Identity .NET MAUI SDK is cross-platform framework SDK that enables user authentication flows with Trimble Identity (TID). This abstracts all the complexity by exposing easy method call for developer needs. It includes token refresh rotation, persistent storage management, browser integration, and more. It supports Android, iOS and Windows platforms.

### Acronyms

TID - Trimble Identity, Identity Provider

.NET MAUI - .NET Multi Platform App UI  

## Getting Started ##

Here is useful information for you getting started with SDK:

* [Install .NET MAUI TID SDK](https://www.nuget.org/packages?q=Trimble.ID.Maui)
* [TID .NET MAUI SDK Developer Guide](./DeveloperGuide.md)
* [TID .NET MAUI SDK Reference documentation](./ReferenceDoc.md)
* [TID .NET MAUI SDK Samples](../../samples/)

## Package Reference

.NET CLI
> `dotnet add package Trimble.ID.Maui`

## Supported Platforms

  This SDK supports application built on `.NET8.0`.

  Target Frameworks - `.NET8.0-android`, `.NET8.0-ios` and `.NET8.0-windows`.

  - **Android** : supports Android API 21 and above.
  - **iOS** : supports 12.0 and above.
  - **Windows** : supports Windows 11 and Windows 10 version 1809 (build number 10.0.17763) or higher

## Platform Differences

  - **Android** : `CustomTabs` are used to launch browser whenever available, otherwise the system browser is used as a fallback.
  - **iOS** : `SFSafariViewController` is used to launch browser if available, otherwise Safari.
  - **Windows** : User's default browser is launched.

## <a name="faq">Frequently asked questions</a>

Do you have questions? Do not worry, we have prepared a complete [FAQ](./FAQ.md) answering the most common questions.

## <a name="support">Support</a>

Send an email to [support@trimble.com](mailto:support@trimble.com)
