<a name='assembly'></a>
# Trimble.ID.Maui

## Contents

- [IBrowser](#T-Trimble-ID-Maui-IBrowser 'Trimble.ID.Maui.IBrowser')
  - [Close()](#M-Trimble-ID-Maui-IBrowser-Close 'Trimble.ID.Maui.IBrowser.Close')
  - [Launch(uri)](#M-Trimble-ID-Maui-IBrowser-Launch-System-Uri- 'Trimble.ID.Maui.IBrowser.Launch(System.Uri)')
- [IMobileAuthenticator](#T-Trimble-ID-Maui-IMobileAuthenticator 'Trimble.ID.Maui.IMobileAuthenticator')
  - [OnReceive(query)](#M-Trimble-ID-Maui-IMobileAuthenticator-OnReceive-System-String- 'Trimble.ID.Maui.IMobileAuthenticator.OnReceive(System.String)')
  - [OnReceive(state,code)](#M-Trimble-ID-Maui-IMobileAuthenticator-OnReceive-System-String,System-String- 'Trimble.ID.Maui.IMobileAuthenticator.OnReceive(System.String,System.String)')
- [MobileAuthenticator](#T-Trimble-ID-Maui-MobileAuthenticator 'Trimble.ID.Maui.MobileAuthenticator')
  - [#ctor(mobileAuthenticatorOptions)](#M-Trimble-ID-Maui-MobileAuthenticator-#ctor-Trimble-ID-Maui-MobileAuthenticatorOptions- 'Trimble.ID.Maui.MobileAuthenticator.#ctor(Trimble.ID.Maui.MobileAuthenticatorOptions)')
  - [#ctor(endpointProvider,clientId,scopes,redirectUri,allowPersistenceStorage)](#M-Trimble-ID-Maui-MobileAuthenticator-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String[],System-String,System-Boolean- 'Trimble.ID.Maui.MobileAuthenticator.#ctor(Trimble.ID.IEndpointProvider,System.String,System.String[],System.String,System.Boolean)')
  - [IsLoggedIn](#P-Trimble-ID-Maui-MobileAuthenticator-IsLoggedIn 'Trimble.ID.Maui.MobileAuthenticator.IsLoggedIn')
  - [LegacyTokenProvider](#P-Trimble-ID-Maui-MobileAuthenticator-LegacyTokenProvider 'Trimble.ID.Maui.MobileAuthenticator.LegacyTokenProvider')
  - [TokenProvider](#P-Trimble-ID-Maui-MobileAuthenticator-TokenProvider 'Trimble.ID.Maui.MobileAuthenticator.TokenProvider')
  - [GetUserInfo()](#M-Trimble-ID-Maui-MobileAuthenticator-GetUserInfo 'Trimble.ID.Maui.MobileAuthenticator.GetUserInfo')
  - [Login(silent,timeoutInMs)](#M-Trimble-ID-Maui-MobileAuthenticator-Login-System-Boolean,System-Int32,System-Threading-CancellationToken- 'Trimble.ID.Maui.MobileAuthenticator.Login(System.Boolean,System.Int32,System.Threading.CancellationToken)')
  - [Logout(singleSignOut)](#M-Trimble-ID-Maui-MobileAuthenticator-Logout-System-Boolean,System-Threading-CancellationToken- 'Trimble.ID.Maui.MobileAuthenticator.Logout(System.Boolean,System.Threading.CancellationToken)')
  - [OnReceive(query)](#M-Trimble-ID-Maui-MobileAuthenticator-OnReceive-System-String- 'Trimble.ID.Maui.MobileAuthenticator.OnReceive(System.String)')
  - [OnReceive(state,code)](#M-Trimble-ID-Maui-MobileAuthenticator-OnReceive-System-String,System-String- 'Trimble.ID.Maui.MobileAuthenticator.OnReceive(System.String,System.String)')
  - [WithActivity(activity)](#M-Trimble-ID-Maui-MobileAuthenticator-WithActivity-Android-App-Activity- 'Trimble.ID.Maui.MobileAuthenticator.WithActivity(Android.App.Activity)')
- [MobileAuthenticatorOptions](#T-Trimble-ID-Maui-MobileAuthenticatorOptions 'Trimble.ID.Maui.MobileAuthenticatorOptions')
  - [#ctor()](#M-Trimble-ID-Maui-MobileAuthenticatorOptions-#ctor 'Trimble.ID.Maui.MobileAuthenticatorOptions.#ctor')
  - [ClientId](#P-Trimble-ID-Maui-MobileAuthenticatorOptions-ClientId 'Trimble.ID.Maui.MobileAuthenticatorOptions.ClientId')
  - [EnableTokenPersistence](#P-Trimble-ID-Maui-MobileAuthenticatorOptions-EnableTokenPersistence 'Trimble.ID.Maui.MobileAuthenticatorOptions.EnableTokenPersistence')
  - [EndpointProvider](#P-Trimble-ID-Maui-MobileAuthenticatorOptions-EndpointProvider 'Trimble.ID.Maui.MobileAuthenticatorOptions.EndpointProvider')
  - [RedirectUri](#P-Trimble-ID-Maui-MobileAuthenticatorOptions-RedirectUri 'Trimble.ID.Maui.MobileAuthenticatorOptions.RedirectUri')
  - [Scopes](#P-Trimble-ID-Maui-MobileAuthenticatorOptions-Scopes 'Trimble.ID.Maui.MobileAuthenticatorOptions.Scopes')
- [TokenProviderWrapper](#T-Trimble-ID-Maui-TokenProviderWrapper 'Trimble.ID.Maui.TokenProviderWrapper')
  - [RetrieveToken()](#M-Trimble-ID-Maui-TokenProviderWrapper-RetrieveToken 'Trimble.ID.Maui.TokenProviderWrapper.RetrieveToken')

<a name='T-Trimble-ID-Maui-IBrowser'></a>
## IBrowser `type`

##### Namespace

Trimble.ID.Maui

##### Summary

Represents a browser interface.

<a name='M-Trimble-ID-Maui-IBrowser-Close'></a>
### Close() `method`

##### Summary

Closes the browser.

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-Maui-IBrowser-Launch-System-Uri-'></a>
### Launch(uri) `method`

##### Summary

Launches the specified URI in the browser.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URI to launch. |

<a name='T-Trimble-ID-Maui-IMobileAuthenticator'></a>
## IMobileAuthenticator `type`

##### Namespace

Trimble.ID.Maui

##### Summary

Represents an interface for a mobile authenticator that exchanges authorization code for tokens.

<a name='M-Trimble-ID-Maui-IMobileAuthenticator-OnReceive-System-String-'></a>
### OnReceive(query) `method`

##### Summary

Exchanges authorization code for tokens.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Query string that contains state and authorization code. |

<a name='M-Trimble-ID-Maui-IMobileAuthenticator-OnReceive-System-String,System-String-'></a>
### OnReceive(state,code) `method`

##### Summary

Exchanges authorization code for tokens.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| state | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The state parameter. |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The authorization code. |

<a name='T-Trimble-ID-Maui-MobileAuthenticator'></a>
## MobileAuthenticator `type`

##### Namespace

Trimble.ID.Maui

##### Summary

An authenticator that utilizes a custom URI callback

##### Example

```csharp
const string CONFIGURATION_ENDPOINT = "https://id.trimble.com/.well-known/openid-configuration";
var endpointProvider = new OpenIdEndpointProvider(new Uri(CONFIGURATION_URL, UriKind.Absolute));
const string CLIENT_ID = "CLIENT_ID";
var string SCOPES = new [] { "SCOPE" };
var REDIRECT_URI = "REDIRECT_URI";
var options = new MobileAuthenticatorOptions 
{ 
    EndpointProvider = endpointProvider, 
    ClientId = CLIENT_ID, 
    Scopes = SCOPES, 
#if WINDOWS
    RedirectUri = LOCALHOST_REDIRECT_URI,
#else
    RedirectUri = REDIRECT_URI,
#endif
    EnableTokenPersistence = true 
};
var authenticator = new MobileAuthenticator(options);
if (await authenticator.Login())
{
    var userInfo = await authenticator.GetUserInfo();
    var token = await authenticator.TokenProvider.RetrieveToken();
}
await authenticator.Logout(singleSignOut: true);
```

##### Remarks

Implements IAuthenticator

<a name='M-Trimble-ID-Maui-MobileAuthenticator-#ctor-Trimble-ID-Maui-MobileAuthenticatorOptions-'></a>
### #ctor(mobileAuthenticatorOptions) `constructor`

##### Summary

Public constructor for MobileAuthenticator class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mobileAuthenticatorOptions | [Trimble.ID.Maui.MobileAuthenticatorOptions](#T-Trimble-ID-Maui-MobileAuthenticatorOptions 'Trimble.ID.Maui.MobileAuthenticatorOptions') | The options for configuring the authenticator |

<a name='M-Trimble-ID-Maui-MobileAuthenticator-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String[],System-String,System-Boolean-'></a>
### #ctor(endpointProvider,clientId,scopes,redirectUri,allowPersistenceStorage) `constructor`

##### Summary

Public constructor for MobileAuthenticator class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpointProvider | [Trimble.ID.IEndpointProvider](#T-Trimble-ID-IEndpointProvider 'Trimble.ID.IEndpointProvider') | An endpoint provider that provides the URL for the Trimble Identity authorization and token endpoints |
| clientId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The clientId of the calling application |
| scopes | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The scopes used in the authorization request |
| redirectUri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The custom redirect URI scheme used for this authenticator |
| allowPersistenceStorage | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The allowPersistence helps to retrieve cached tokens on network calls. By default it is set to true. If false, no caching is done |

<a name='P-Trimble-ID-Maui-MobileAuthenticator-IsLoggedIn'></a>
### IsLoggedIn `property`

##### Summary

Get the logged in state

<a name='P-Trimble-ID-Maui-MobileAuthenticator-LegacyTokenProvider'></a>
### LegacyTokenProvider `property`

##### Summary

Get the token provider for this authenticator

##### Remarks

This token provider can be used with other SDK components

<a name='P-Trimble-ID-Maui-MobileAuthenticator-TokenProvider'></a>
### TokenProvider `property`

##### Summary

Get the token provider for this authenticator

##### Remarks

This token provider can be used with other SDK components

<a name='M-Trimble-ID-Maui-MobileAuthenticator-GetUserInfo'></a>
### GetUserInfo() `method`

##### Summary

Validates the ID token and returns user claims

##### Returns

User claims from the ID token

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-Maui-MobileAuthenticator-Login-System-Boolean,System-Int32,System-Threading-CancellationToken-'></a>
### Login(silent,timeoutInMs) `method`

##### Summary

Log the user in

##### Returns

true if the user was successfully logged in

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| silent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if no UI should be shown i.e. prompt=none |
| timeoutInMs | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Specify the length of time that client waits for a login response when making a login attempt.Thedefault timeout value is 3 minutes. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.TimeoutException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeoutException 'System.TimeoutException') | Login operation has timed out after waiting for specified time. |

##### Remarks

Only one login or logout operation is permitted at a time, all previously started operations will return false

<a name='M-Trimble-ID-Maui-MobileAuthenticator-Logout-System-Boolean,System-Threading-CancellationToken-'></a>
### Logout(singleSignOut) `method`

##### Summary

Log the user out

##### Returns

true if the user was successfully logged out

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| singleSignOut | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if the single sign in session should be terminated |

##### Remarks

Only one login or logout operation is permitted at a time, all previously started operations will return false

<a name='M-Trimble-ID-Maui-MobileAuthenticator-OnReceive-System-String-'></a>
### OnReceive(query) `method`

##### Summary

Exchanges authorization code for tokens.
This method is used in iOS and needs to be invoked to complete Login/Logout from the AppDelegate class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Query string that contains state and authorization code |

<a name='M-Trimble-ID-Maui-MobileAuthenticator-OnReceive-System-String,System-String-'></a>
### OnReceive(state,code) `method`

##### Summary

Exchanges authorization code for tokens.
This method is used in Android and needs to be invoked to complete Login/Logout flow from the Activity that handles application redirect.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| state | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | state parameter |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | authorization code |

<a name='M-Trimble-ID-Maui-MobileAuthenticator-WithActivity-Android-App-Activity-'></a>
### WithActivity(activity) `method`

##### Summary

Fluent method to specify current activity

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| activity | [Android.App.Activity](#T-Android-App-Activity 'Android.App.Activity') | Activity that launches the browser during authentication |

<a name='T-Trimble-ID-Maui-MobileAuthenticatorOptions'></a>
## MobileAuthenticatorOptions `type`

##### Namespace

Trimble.ID.Maui

<a name='M-Trimble-ID-Maui-MobileAuthenticatorOptions-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the MobileAuthenticatorOptions class

##### Parameters

This constructor has no parameters.

##### Remarks

Contains the options for configuring the authenticator

<a name='P-Trimble-ID-Maui-MobileAuthenticatorOptions-ClientId'></a>
### ClientId `property`

##### Summary

Gets or sets the client ID (required).

<a name='P-Trimble-ID-Maui-MobileAuthenticatorOptions-EnableTokenPersistence'></a>
### EnableTokenPersistence `property`

##### Summary

Gets or sets a value indicating whether token persistence is enabled. By default, this is set to true.

<a name='P-Trimble-ID-Maui-MobileAuthenticatorOptions-EndpointProvider'></a>
### EndpointProvider `property`

##### Summary

Gets or sets the endpoint provider for the mobile authenticator (required).

<a name='P-Trimble-ID-Maui-MobileAuthenticatorOptions-RedirectUri'></a>
### RedirectUri `property`

##### Summary

Gets or sets the redirect URI (required).

<a name='P-Trimble-ID-Maui-MobileAuthenticatorOptions-Scopes'></a>
### Scopes `property`

##### Summary

Gets or sets the scopes (required).

<a name='T-Trimble-ID-Maui-TokenProviderWrapper'></a>
## TokenProviderWrapper `type`

##### Namespace

Trimble.ID.Maui

<a name='M-Trimble-ID-Maui-TokenProviderWrapper-RetrieveToken'></a>
### RetrieveToken() `method`

##### Summary

Retrieve access token

##### Parameters

This method has no parameters.
