# Trimble Identity .NET MAUI SDK Developer Guide

### Content

1. [Overview](#overview)
2. [Authentication with Trimble Identity](#identity)
3. [Code snippets](#snippets)
   + [Configure MobileAuthenticator](#configure_authenticator)
   + [Set the current view to launch browser](#set_currentview)
   + [Handling the redirect](#handle_redirect)
   + [Persistence Storage](#persistant_storage)
   + [Example: How to Login](#login) 
   + [Example: How to Logout](#logout)
   + [Example: How to get an access token](#access_token)
   + [Example: How to know logged-in state](#loggedin_state)
   + [Example: How to get logged-in user info](#user_info)
4. [FAQ](#faq)

## <a name="overview">Overview</a> ##

The Trimble Identity MAUI SDK is a .NET MAUI Class Library that implements the PKCE OAuth grant, which is used to secure authorization codes in public clients with custom URI scheme redirects. 

.NET MAUI TID SDK `MobileAuthenticator` lets you start the authentication flow and listens to callback to a specific Custom Redirect URI registered in the application.
This SDK helps to authenticate users by exposing functionalities like,
 - Login 
 - Logout 
 - Handling redirect 
 - Retrieve Access Token 
 - Retrieve User Information 
 - Know a Logged in state

Once the authorization flow is completed in the browser, application will redirect to a URI specified as part of the authorization request, providing the response via query parameters. In order for your app to capture this response, a custom scheme based redirect URI (i.e. those of form scheme:/path) is used.


## <a name="identity">Authentication with Trimble Identity</a> ##

To utilize TID authentication, the calling app must be registered with Trimble. This process can be initiated by contacting the Trimble Support team at [cloudplatform_support@trimble.com](mailto:cloudplatform_support@trimble.com).

Upon successful registration, the requesting developer will receive the following OAuth2 parameters: client credentials and redirectUri. These parameters must be used in the SDK client to initiate the browser-based authentication flow for your native apps.

> NOTE: Developers can conveniently handle this registration process on their own once the Trimble developer console becomes available. In the meantime, developers should reach out to our support team to initiate the registration process and get onboarded.


## <a name="snippets">Code snippets</a> ##

### <a name="configure_authenticator">Configure MobileAuthenticator</a> ###

Create a single instance of the MobileAuthenticator which will remain for the lifetime of the application. The registration of this object requiring dependency injection should be performed in the CreateMauiApp method of MauiProgram class.

```
builder.Services.AddSingleton(new MobileAuthenticator
    (
      <"ENDPOINT_PROVIDER">, // OpenIdEndpointProvider.Staging or OpenIdEndpointProvider.Production
      <"CLIENT_ID">,
      new[]{<"SCOPES">},
      <"REDIRECT_URI">", // REDIRECT_URI added in Trimble cloud console.
      allowPersistenceStorage:true
    )
```

### <a name="set_currentview">Set the current view to launch browser</a> ###

Once the MobileAuthenticator instance is created, we must pass the Activity/ViewController that launches browser during login/logout to the MobileAuthenticator instance. To achieve this the following platform-specific method calls are required:

### iOS

The viewController that launches the browser during login must be passed using the WithViewController method.

```
mobileAuthenticator.WithViewController(viewController);
```

### Android

Activity that launches the browser during login must be passed using the WithActivity method.

```
mobileAuthenticator.WithActivity(activity);
```

### <a name="handle_redirect">Handling the redirect</a> ###

To handle redirection to the application from browser, the following platform-specific setup is required.

### Android

Android requires an Intent Filter setup to handle your custom redirect URI. For this we must create an activity 'RedirectUriReceiverActivity' in the app.

```
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

```
[Activity(Name = "companyname.mymauiapp.activity.RedirectUriReceiverActivity")]
public class RedirectUriReceiverActivity : Activity
{
}
```

AndroidManifest.xml:
```
<activity android:name="companyname.mymauiapp.activity.RedirectUriReceiverActivity" android:exported="true">
       <intent-filter>
         <action android:name="android.intent.action.VIEW" />
         <category android:name="android.intent.category.DEFAULT" />
         <category android:name="android.intent.category.BROWSABLE" />
         <data android:scheme="<CUSTOM_URI_SCHEME>"/>       </intent-filt
er>
     </activity>
```

If your project's Target Android version is set to Android 11 (R API 30) or higher, you must update your Android Manifest with queries that use Android's package visibility requirements.
In the Platforms/Android/AndroidManifest.xml file, add the following queries/intent nodes in the manifest node:

```
<queries>
  <intent>
    <action android:name="android.support.customtabs.action.CustomTabsService" />
  </intent>
</queries>
```

### iOS

Add your app's Custom Redirect URI scheme to the Platforms/iOS/Info.plist.

```
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

### <a name="persistent_storage">Persistent Storage</a> ###

The SDK uses Secure Storage for token persistence. It stores data in key and value pairs and gets deleted once the app is uninstalled.
Each platform uses the platform provided native API's for storing data securely:

- <b>Android</b>: Encryption keys are stored in KeyStore and encrypted data is stored in a named shared preference container (PackageId.Microsoft.Maui.Essentials). As a best practice, you can choose to disable Auto Backup for your application, or You can create a custom rule set to exclude Secure Store items from being backed up.

- <b>iOS</b>: Data is stored in KeyChain. When developing on the iOS simulator, enable the Keychain entitlement and add a keychain access group for the application's bundle identifier. For more details refer secure storage on iOS Simulator
To disable Secure storage, set `allowPersistenceStorage` to false while instantiating `MobileAuthenticator`.


### <a name="login">Example: How to Login</a> ###

<b>Summary</b>

  Log the user in. On Login, MobileAuthenticator launches the browser and listens to a callback redirect by invoking OnReceive() to complete authorization flow.

  <b>Returns</b>

  true if the user was successfully logged in

  ```csharp
  var isLoggedIn = mobileAuthenticator.Login(); 
  ```

  In iOS, the end application has to invoke `OnReceive(query)` of MobileAuthenticator from `Appdelegate class` to complete Login. 
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
  In Android, the end application has to invoke `OnReceive(state,code)` of MobileAuthenticator from activity created to handle redirect.
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

### <a name="logout">Example: How to Logout</a> ###

<b>Summary</b>

  Log the user out. 
<b>Returns</b>

  true if the user was successfully logged out

  ```csharp
  var isLoggedIn = mobileAuthenticator.Logout(singleSignOut: true);
  ```
  Set singleSignOut to true to sign out of all SSO session. On Logout, MobileAuthenticator launches the browser and listens for callback redirect using OnReceive() to complete Logout when singleSignOut = true . The same OnReceive() method handles redirect for Login and Logout.
  By default singleSignOut is set to false when Logout() is invoked which helps user to logout without clearing the browser session.

### <a name="access_token">Example: How to get an access token</a> ###

<b>Summary</b>

  Retrieves access token of authenticated user

  <b>Returns</b>

  Access token of authenticated user

  ```csharp
  var accessToken = await mobileAuthenticator.TokenProvider.RetrieveToken();
  ```

### <a name="loggedin_state">Example: How to know logged-in state</a> ###
<b>Summary</b>

  Get the logged in state

  ```csharp
  var isLoggedIn = mobileAuthenticator.IsLoggedIn;
  ```

### <a name="user_info">Example: How to get logged-in user info</a> ###

 <b>Summary</b>

  Validates the ID token and returns user claims

  <b>Returns</b>

  User claims from the ID token

  ```csharp
  var userInfo = await mobileAuthenticator.GetUserInfo();
  ```

## <a name="faq">FAQ</a> ##

Do you have questions? Do not worry, we have prepared a complete [FAQ](./FAQ.md) answering the most common questions.