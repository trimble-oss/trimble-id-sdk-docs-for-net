# Frequently Asked Questions

1. [Does Trimble Identity .NET MAUI support PKCE?](#pkce-support)
2. [How is persistent storage implemented in the SDK?](#persistent-storage-implementation)
3. [Can we provide two seperate redirect uri to sdk to handle redirect in Android and iOS apps?](#can-we-provide-two-seperate-redirect-uri-for-android-and-ios-apps)
4. [How to fix Compiler Error CS1705.](#how-to-fix-compiler-error-cs1705)\
Error CS1705: Assembly 'Trimble.Id' with identity 'Trimble.Id, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' uses 'Microsoft.iOS, Version=16.4.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065' which has a higher version than referenced assembly 'Microsoft.iOS' with identity 'Microsoft.iOS, Version=16.2.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065' (CS1705)
5. [What does OnReceive() do?](#what-does-on-receive-do)
6. [How to use WithActivity() or WithViewController() and why?](#how-to-use-withactivity-withviewcontroller-and-why)

## <a name="pkce-support">Does Trimble Identity .NET MAUI support PKCE?</a> ##

Yes Trimble Identity .NET MAUI supports `PKCE`.

## <a name="persistent-storage-implementation">How is persistent storage implemented in the SDK?</a> ##

Persistent storage is implemented using `Secure Storage` in the sdk. For more details refer [Secure Storage](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/storage/secure-storage?tabs=android).

## <a name="can-we-provide-two-seperate-redirect-uri-for-android-and-ios-apps">Can we provide two seperate redirect uri for Android and iOS apps?</a> ##

Yes, you can specify different redirect uri for Android, iOS and Windows.

```csharp
var options = new MobileAuthenticatorOptions
  {
    EndpointProvider = "<ENDPOINT_PROVIDER>",
    ClientId = "<CLIENT_ID>",
    Scopes = new[] { "<SCOPES>" },
#if ANDROID
    RedirectUri = "<ANDROID_REDIRECT_URI>", 
#elif IOS
    RedirectUri = "<IOS_REDIRECT_URI>", 
#elif WINDOWS
    RedirectUri = "<WINDOWS_REDIRECT_URI>",  
#endif
    EnableTokenPersistence = true
  };
```

## <a name="how-to-fix-compiler-error-cs1705">How to fix Compiler Error CS1705?</a> ##

Error CS1705: Assembly 'Trimble.Id' with identity 'Trimble.Id, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' uses 'Microsoft.iOS, Version=16.4.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065' which has a higher version than referenced assembly 'Microsoft.iOS' with identity 'Microsoft.iOS, Version=16.2.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065' (CS1705)

This error is caused by the accidental use of two versions of the same assembly. Ensure that the latest dotnet workloads are installed in your app. To resolve this, please try updating the iOS MAUI workloads on your machine using the command `dotnet workload install` or `dotnet workload update`. Please check the dotnet workload for more information. 

## <a name="what-does-on-receive-do">What does OnReceive() do?</a> ##

`OnReceieve()` is invoked to complete the authentication flow. OnReceive() basically exchanges the authcode for tokens and completes Login. On Logout (singleSignOut must be set to true), OnReceive() clears the browser session.
For more details on usage of OnReceive() refer [README](./ReferenceDoc.md#onreceivequery-method).

## <a name="how-to-use-withactivity-withviewcontroller-and-why">How to use WithActivity() or WithViewController() and why?</a> ##

`WithActivity()` and `WithViewController()` is needed to launch the browser. Once the MobileAuthenticator instance is created, these methods need to be invoked in platform specific ways before invoking any other sdk methods like Login, Logout etc. Activity/ViewController from which the browser needs to launched/closed needs to be passed as a parameter. 

```csharp
#if IOS
        _mobileAuthenticator = mobileAuthenticator.WithViewController(Platform.GetCurrentUIViewController());

#elif ANDROID
        _mobileAuthenticator = mobileAuthenticator.WithActivity(Platform.CurrentActivity);
```