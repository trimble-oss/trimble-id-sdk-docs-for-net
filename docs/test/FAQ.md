# Frequently Asked Questions

1. [Does Trimble Identity .NET MAUI support PKCE?](#does-trimble-identity-net-maui-support-pkce)
2. [How is persistence storage implemented in the sdk?](#how-is-persistence-storage-implemented-in-the-sdk)
3. [Can we provide two seperate redirect uri to sdk to handle redirect in Android and iOS app's?](#can-we-provide-two-seperate-redirect-uri-for-android-and-ios-apps)
4. [How to fix Compiler Error CS1705.](#how-to-fix-compiler-error-cs1705)\
Error CS1705: Assembly 'Trimble.Id' with identity 'Trimble.Id, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' uses 'Microsoft.iOS, Version=16.4.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065' which has a higher version than referenced assembly 'Microsoft.iOS' with identity 'Microsoft.iOS, Version=16.2.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065' (CS1705)
5. [What does OnReceive() do?](#what-does-onreceive-do)
6. [How to use WithActivity()/ WithViewController() and why?](#how-to-use-withactivity-withviewcontroller-and-why)
## Does Trimble Identity .NET MAUI support PKCE?

Yes Trimble Identity .NET MAUI support `PKCE`.

## How is persistence storage implemented in the SDK?

Persistence storage is implemented using `Secure Storage` in the sdk. For more details refer [Secure Storage](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/storage/secure-storage?tabs=android).

## Can we provide two seperate redirect uri for Android and iOS app's?

No, Currently Trimble.Id SDK takes only a single redirect uri for Android and iOS.
## How to fix Compiler Error CS1705?

Error CS1705: Assembly 'Trimble.Id' with identity 'Trimble.Id, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' uses 'Microsoft.iOS, Version=16.4.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065' which has a higher version than referenced assembly 'Microsoft.iOS' with identity 'Microsoft.iOS, Version=16.2.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065' (CS1705)

This error is caused by the accidental use of two versions of the same assembly. Ensure that the latest dotnet workloads are installed in your app. To resolve this, please try updating the iOS MAUI workloads on your machine using the command `dotnet workload install` or `dotnet workload update`. Please check the dotnet workload for more information. 

## What does OnReceive() do?

OnReceieve() is invoked to complete the authentication flow. OnReceive() basically exchanges the authcode for tokens and completes Login. On Logout ( singleSignOut must be set to true), OnReceive() clears the browser session.
For more details on usage of OnReceive() refer [README](README.md#onreceivequery-method).

## How to use WithActivity()/ WithViewController() and why?

WithActivity()/ WithViewController() is needed to launch the browser. Once the MobileAuthenticator instance is created, these methods need to be invoked in platform specific ways before invoking any other sdk methods like Login,Logout etc. Activity/ViewController from which the broswer needs to launched/closed needs to be passed as a parameter. 

```

#if IOS
        _mobileAuthenticator = mobileAuthenticator.WithViewController(Platform.GetCurrentUIViewController());
#elif ANDROID
        _mobileAuthenticator = mobileAuthenticator.WithActivity(Platform.CurrentActivity);

```