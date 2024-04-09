# Trimble Identity .NET MAUI SDK Developer Guide

### Contents

1. [Overview](#overview)
2. [Authentication with Trimble Identity](#identity)
3. [Configure Client](#configure_client)
    + [Configure MobileAuthenticator](#configure_authenticator)
    + [Set the current view to launch browser](#set_currentview)
    + [Handling the redirect](#handle_redirect)
    + [Persistent Storage](#persistent_storage)
4. [Code Snippets](#code_snippets)
    + [Example: How to Login](#example_login) 
    + [Example: How to Logout](#example_logout)
    + [Example: How to get an access token](#example_access_token)
    + [Example: How to know the logged-in state](#example_loggedin_state)
    + [Example: How to get the logged-in user info](#example_user_info)
5. [FAQ](#faq)

## <a name="overview">Overview</a> ##

The Trimble Identity MAUI SDK is a .NET MAUI Class Library that implements the PKCE OAuth grant, which is used to secure authorization codes in public clients with custom URI scheme redirects (Android/iOS) and http scheme redirects (Windows). 

.NET MAUI TID SDK `MobileAuthenticator` lets you start the authentication flow and listens to callback to a specific redirect URI registered in the application.

This SDK helps to authenticate users by exposing functionalities like,
 - Login
 - Logout
 - Handling redirect
 - Retrieve Access Token
 - Retrieve User Information
 - Know a Logged in state

Once the authorization flow is completed in the browser, application will redirect to a URI specified as part of the authorization request, providing the response via query parameters. In order for your app to capture this response:

- <b>Android/iOS</b>: uses a custom scheme based redirect URI (`scheme:/path`)
- <b>Windows</b>: uses a http scheme based redirect URI (`http://localhost:port/callback`)
    - For example: http://localhost/callback, http://127.0.0.1:3000/login
 
## <a name="identity">Authentication with Trimble Identity</a> ##

To utilize TID authentication, your identity application must be registered with Trimble Identity. You can conveniently handle the application registration process on [Trimble Developer Console](https://console.trimble.com).

## <a name="configure_client">Configure Client</a> ##

### <a name="configure_authenticator">Configure MobileAuthenticator</a> ###

Create a single instance of the MobileAuthenticator which will remain for the lifetime of the application. The registration of this object requiring dependency injection should be performed in the `CreateMauiApp` method of MauiProgram class.

```csharp
var options = new MobileAuthenticatorOptions
  {
    EndpointProvider = "<ENDPOINT_PROVIDER>", // OpenIdEndpointProvider.Staging or OpenIdEndpointProvider.Production
    ClientId = "<CLIENT_ID>",
    Scopes = new[] { "<SCOPES>" },
#if WINDOWS
    RedirectUri = "<LOCALHOST_REDIRECT_URI>", // eg: http://localhost/callback
#else
    RedirectUri = "<CUSTOM_REDIRECT_URI>",  // eg: com.trimble.sample://oauth2redirect
#endif
    EnableTokenPersistence = true
  };

builder.Services.AddSingleton(new MobileAuthenticator(options))
```

> **_NOTE:_**  Windows supports only localhost redirection and does not support any custom URI.

### <a name="set_currentview">Set the current view to launch browser</a> ###

Once the MobileAuthenticator instance is created, we must pass the Activity/ViewController in Android/iOS that launches browser during login/logout to the MobileAuthenticator instance. To achieve this the following platform-specific method calls are required:

<b>Android</b>

Activity that launches the browser during login must be passed using the `WithActivity` method.

```csharp
mobileAuthenticator.WithActivity(activity);
```

<b>iOS</b>

The viewController that launches the browser during login must be passed using the `WithViewController` method.

```csharp
mobileAuthenticator.WithViewController(viewController);
```

<b>Windows</b>

No platform-specific setup is required for Windows. User's default browser is launched.

### <a name="handle_redirect">Handling the redirect</a> ###

To handle redirection to the application from browser, the following platform-specific setup is required.

<b>Android</b>

Android requires an Intent Filter setup to handle your custom redirect URI. For this we must create an activity `RedirectUriReceiverActivity` in the app.

```csharp
using Android.App;
using Android.Content.PM;

namespace YourNameSpace;

[Activity(NoHistory = true, LaunchMode = LaunchMode.SingleTop, Exported = true)]
[IntentFilter(new[] { Android.Content.Intent.ActionView },
              Categories = new[] { Android.Content.Intent.CategoryDefault, Android.Content.Intent.CategoryBrowsable },
              DataScheme = "<CUSTOM_URI_SCHEME>")]

public class RedirectUriReceiverActivity : Activity
{

}
```

Alternatively, the redirect URI can be directly configured by adding an intent-filter for App's' RedirectUriReceiverActivity to your AndroidManifest.xml:

```csharp
[Activity(Name = "companyname.mymauiapp.activity.RedirectUriReceiverActivity")]
public class RedirectUriReceiverActivity : Activity
{
}
```

AndroidManifest.xml:
```xml
<activity android:name="companyname.mymauiapp.activity.RedirectUriReceiverActivity" android:exported="true">
       <intent-filter>
         <action android:name="android.intent.action.VIEW" />
         <category android:name="android.intent.category.DEFAULT" />
         <category android:name="android.intent.category.BROWSABLE" />
         <data android:scheme="<CUSTOM_URI_SCHEME>"/>
        </intent-filter>
     </activity>
```

If your project's Target Android version is set to Android 11 (R API 30) or higher, you must update your Android Manifest with queries that use Android's package visibility requirements.
In the Platforms/Android/AndroidManifest.xml file, add the following queries/intent nodes in the manifest node:

```xml
<queries>
  <intent>
    <action android:name="android.support.customtabs.action.CustomTabsService"/>
  </intent>
</queries>
```

<b>iOS</b>

Add your app's Custom Redirect URI scheme to the Platforms/iOS/Info.plist.

```xml
<key>CFBundleURLTypes</key>
<array>
    <dict>
        <key>CFBundleURLName</key>
        <string>App Name</string>
        <key>CFBundleURLSchemes</key>
        <array>
            <string>CUSTOM_URI_SCHEME</string>
        </array>
        <key>CFBundleTypeRole</key>
        <string>Editor</string>
    </dict>
</array>
```

<b>Windows</b>

No platform-specific setup is required. The SDK internally handles the redirect. 

SDK starts a `LocalhostListener` and listens for callback on the specified localhost redirect uri. When callback is received SDK internally validates the code and returns `isLoggedIn` as true if login was successful.

### <a name="persistent_storage">Persistent Storage</a> ###

The SDK uses Secure Storage for token persistence. It stores data in key and value pairs and gets deleted once the app is uninstalled.
Each platform uses the platform provided native API's for storing data securely:

- <b>Android</b>: Encryption keys are stored in KeyStore and encrypted data is stored in a named shared preference container (PackageId.Microsoft.Maui.Essentials). As a best practice, you can choose to disable Auto Backup for your application, or You can create a custom rule set to exclude Secure Store items from being backed up.

- <b>iOS</b>: Data is stored in KeyChain. When developing on the iOS simulator, enable the Keychain entitlement and add a keychain access group for the application's bundle identifier. For more details refer secure storage on iOS Simulator

- <b>Windows</b>: DataProtectionProvider is used to encrypt values and it is stored in ApplicationData.Current.LocalSettings, inside a container with a name of [YOUR-APP-ID].microsoft.maui.essentials.preferences.

To disable Secure storage, set `EnableTokenPersistence` to false in `MobileAuthenticatorOptions` while instantiating `MobileAuthenticator`.

## <a name="code_snippets">Code Snippets</a> ##

### <a name="example_login">Example: How to Login</a> ###

<b>Summary</b>

Log the user in. On Login, MobileAuthenticator launches the browser and listens to a callback redirect by invoking OnReceive() to complete authorization flow.

<b>Returns</b>

true if the user was successfully logged in

```csharp
var isLoggedIn = mobileAuthenticator.Login(); 
```

In <b>Android</b>, the end application has to invoke `OnReceive(state, code)` of MobileAuthenticator from activity created to handle redirect.

```csharp
public class RedirectUriReceiverActivity : Activity
{
    private readonly MobileAuthenticator _mobileAuthenticator = MauiApplication.Current.Services.GetService<MobileAuthenticator>();

    protected override void OnCreate(Bundle savedInstanceState)
    {

        base.OnCreate(savedInstanceState);

        new Task(async () =>
          {
              await _mobileAuthenticator.OnReceive(this.Intent.Data.GetQueryParameter("state"), this.Intent.Data.GetQueryParameter("code"));

          })
          .Start();

        this.Finish();

    }
```

In <b>iOS</b>, the end application has to invoke `OnReceive(query)` of MobileAuthenticator from `AppDelegate` class to complete Login. 

```csharp
[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override bool OpenUrl(UIApplication app, NSUrl url, NSDictionary options)
    {
        new Task(async () =>
        {

            await MauiUIApplicationDelegate.Current.Services.GetService<MobileAuthenticator>().OnReceive(url.Query);

        })
        .Start();
        return true;
    }
}
```

In <b>Windows</b>, the SDK internally validates the state and code of MobileAuthenticator to complete Login. No action is required from the end application.

### <a name="example_logout">Example: How to Logout</a> ###

<b>Summary</b>

Log the user out. 

<b>Returns</b>

true if the user was successfully logged out

```csharp
var isLoggedIn = mobileAuthenticator.Logout(singleSignOut: true);
```

Set singleSignOut to true to sign out of all SSO session. On Logout, MobileAuthenticator launches the browser and listens for callback redirect using OnReceive() to complete Logout when singleSignOut = true . The same OnReceive() method handles redirect for Login and Logout.

By default singleSignOut is set to false when Logout() is invoked which helps user to logout without clearing the browser session.

### <a name="example_access_token">Example: How to get an access token</a> ###

<b>Summary</b>

Retrieves access token of authenticated user. 

> **_NOTE:_**  If the access token has expired, then the SDK refreshes the access token internally and returns the new access token.

<b>Returns</b>

Access token of authenticated user

```csharp
var accessToken = await mobileAuthenticator.TokenProvider.RetrieveToken();
```

### <a name="example_loggedin_state">Example: How to know the logged-in state</a> ###

<b>Summary</b>

Get the logged in state

```csharp
var isLoggedIn = mobileAuthenticator.IsLoggedIn;
```

### <a name="example_user_info">Example: How to get the logged-in user info</a> ###

<b>Summary</b>

Validates the ID token and returns user claims

<b>Returns</b>

User claims from the ID token

```csharp
var userInfo = await mobileAuthenticator.GetUserInfo();
```

## <a name="faq">FAQ</a> ##

Do you have questions? Do not worry, we have prepared a complete [FAQ](./FAQ.md) answering the most common questions.