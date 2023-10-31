<a name='assembly'></a>
# Trimble.ID.Maui

## Contents

- [MobileAuthenticator](#T-Trimble-Id-MobileAuthenticator 'Trimble.ID.Maui.MobileAuthenticator')
  - [#ctor(endpointProvider,clientId,scopes,redirectUri,allowPersistenceStorage)](#M-Trimble-Id-MobileAuthenticator-#ctor-TrimbleCloud-Authentication-IEndpointProvider,System-String,System-String[],System-String,System-Boolean- 'Trimble.ID.Maui.MobileAuthenticator.#ctor(TrimbleCloud.Authentication.IEndpointProvider,System.String,System.String[],System.String,System.Boolean)')
  - [IsLoggedIn](#P-Trimble-Id-MobileAuthenticator-IsLoggedIn 'Trimble.ID.Maui.MobileAuthenticator.IsLoggedIn')
  - [TokenProvider](#P-Trimble-Id-MobileAuthenticator-TokenProvider 'Trimble.ID.Maui.MobileAuthenticator.TokenProvider')
  - [GetUserInfo()](#M-Trimble-Id-MobileAuthenticator-GetUserInfo 'Trimble.ID.Maui.MobileAuthenticator.GetUserInfo')
  - [Login(silent,timeoutInMs)](#M-Trimble-Id-MobileAuthenticator-Login-System-Boolean,System-Int32,System-Threading-CancellationToken- 'Trimble.ID.Maui.MobileAuthenticator.Login(System.Boolean,System.Int32,System.Threading.CancellationToken)')
  - [Logout(singleSignOut)](#M-Trimble-Id-MobileAuthenticator-Logout-System-Boolean,System-Threading-CancellationToken- 'Trimble.ID.Maui.MobileAuthenticator.Logout(System.Boolean,System.Threading.CancellationToken)')
  - [OnReceive(query)](#M-Trimble-Id-MobileAuthenticator-OnReceive-System-String- 'Trimble.ID.Maui.MobileAuthenticator.OnReceive(System.String)')
  - [OnReceive(state,code)](#M-Trimble-Id-MobileAuthenticator-OnReceive-System-String,System-String- 'Trimble.ID.Maui.MobileAuthenticator.OnReceive(System.String,System.String)')
  - [WithViewController(viewController)](#M-Trimble-Id-MobileAuthenticator-WithViewController-UIKit-UIViewController- 'Trimble.ID.Maui.MobileAuthenticator.WithViewController(UIKit.UIViewController)')
  - [WithActivity(activity)](#M-Trimble-Id-MobileAuthenticator-WithActivity-Android-App-Activity- 'Trimble.ID.Maui.MobileAuthenticator.WithActivity(Android.App.Activity)')
- [TokenProviderWrapper](#T-Trimble-Id-TokenProviderWrapper 'Trimble.ID.Maui.TokenProviderWrapper')
  - [RetrieveToken()](#M-Trimble-Id-TokenProviderWrapper-RetrieveToken 'Trimble.ID.Maui.TokenProviderWrapper.RetrieveToken')
- [IMobileAuthenticator](#T-Trimble-Id-IMobileAuthenticator 'Trimble.ID.Maui.IMobileAuthenticator')
  - [OnReceive(query)](#M-Trimble-Id-IMobileAuthenticator-OnReceive-System-String- 'Trimble.ID.Maui.IMobileAuthenticator.OnReceive(System.String)')
  - [OnReceive(state,code)](#M-Trimble-Id-IMobileAuthenticator-OnReceive-System-String,System-String- 'Trimble.ID.Maui.IMobileAuthenticator.OnReceive(System.String,System.String)')
<a name='T-Trimble-Id-IMobileAuthenticator'></a>
## IMobileAuthenticator `type`

##### Namespace

Trimble.ID.Maui

##### Summary

Common interface for authenticators

<a name='M-Trimble-Id-IMobileAuthenticator-OnReceive-System-String-'></a>
### OnReceive(query) `method`

##### Summary

Exchanges authorization code for tokens.
This method is used in iOS and needs to be invoked to complete Login/Logout flow from the AppDelegate class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Query string that contains state and authorization code |

<a name='M-Trimble-Id-IMobileAuthenticator-OnReceive-System-String,System-String-'></a>
### OnReceive(state,code) `method`

##### Summary

Exchanges authorization code for tokens.
This method is used in Android and needs to be invoked to complete Login/Logout flow from the Activity that handles application redirect.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| state | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | state parameter |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | authorization code |

<a name='T-Trimble-Id-MobileAuthenticator'></a>
## MobileAuthenticator `type`

##### Namespace

Trimble.ID.Maui

##### Summary

An authenticator that utilizes a custom URI callback

##### Example

```csharp
var endpointProvider = OpenIdEndpointProvider.Staging
const string CLIENT_ID = "CLIENT_ID";
var string SCOPES = new [] { "SCOPE" };
var REDIRECT_URI="REDIRECT_URI";
var authenticator = new
MobileAuthenticator(endpointProvider, CLIENT_ID, SCOPES, REDIRECT_URI, allowPersistenceStorage:true);
if (await authenticator.Login())
{
    var userInfo = await authenticator.GetUserInfo();
    var token = await authenticator.TokenProvider.RetrieveToken();
}
await authenticator.Logout(singleSignOut: true);
```

##### Remarks

Implements IAuthenticator

<a name='M-Trimble-Id-MobileAuthenticator-#ctor-TrimbleCloud-Authentication-IEndpointProvider,System-String,System-String[],System-String,System-Boolean-'></a>
### #ctor(endpointProvider,clientId,scopes,redirectUri,allowPersistenceStorage) `constructor`

##### Summary

Public constructor for MobileAuthenticator class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpointProvider | [TrimbleCloud.Authentication.IEndpointProvider](#T-TrimbleCloud-Authentication-IEndpointProvider 'TrimbleCloud.Authentication.IEndpointProvider') | An endpoint provider that provides the URL for the Trimble Identity authorization and token endpoints |
| clientId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The clientId of the calling application |
| scopes | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The scopes used in the authorization request, openid is specified by default |
| redirectUri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The custom redirect URI scheme used for this authenticator |
| allowPersistenceStorage | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The allowPersistenceStorage helps to retrieve cached tokens on network calls. By default it is set to true. If false, no caching is done |

<a name='P-Trimble-Id-MobileAuthenticator-IsLoggedIn'></a>
### IsLoggedIn `property`

##### Summary

Get the logged in state

<a name='P-Trimble-Id-MobileAuthenticator-TokenProvider'></a>
### TokenProvider `property`

##### Summary

Get the token provider for this authenticator

##### Remarks

This token provider can be used with other SDK components

<a name='M-Trimble-Id-MobileAuthenticator-GetUserInfo'></a>
### GetUserInfo() `method`

##### Summary

Validates the ID token and returns user claims

##### Returns

User claims from the ID token

##### Parameters

This method has no parameters.

<a name='M-Trimble-Id-MobileAuthenticator-Login-System-Boolean,System-Int32,System-Threading-CancellationToken-'></a>
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

<a name='M-Trimble-Id-MobileAuthenticator-Logout-System-Boolean,System-Threading-CancellationToken-'></a>
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

<a name='M-Trimble-Id-MobileAuthenticator-OnReceive-System-String-'></a>
### OnReceive(query) `method`

##### Summary

Exchanges authorization code for tokens.
This method is used in iOS and needs to be invoked to complete Login/Logout from the AppDelegate class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Query string that contains state and authorization code |

<a name='M-Trimble-Id-MobileAuthenticator-OnReceive-System-String,System-String-'></a>
### OnReceive(state,code) `method`

##### Summary

Exchanges authorization code for tokens.
This method is used in Android and needs to be invoked to complete Login/Logout flow from the Activity that handles application redirect.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| state | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | state parameter |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | authorization code |

<a name='M-Trimble-Id-MobileAuthenticator-WithActivity-Android-App-Activity-'></a>
### WithActivity(activity) `method`

##### Summary

Fluent method to specify current activity

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| activity | [Android.App.Activity](#T-Android-App-Activity 'Android.App.Activity') | Activity that launches the browser during authentication |

<a name='M-Trimble-Id-MobileAuthenticator-WithViewController-UIKit-UIViewController-'></a>
### WithViewController(viewController) `method`

##### Summary

Fluent method to specify current viewcontroller in iOS.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewController | [UIKit.UIViewController](#T-UIKit-UIViewController 'UIKit.UIViewController') | Viewcontroller that launches the browser during authentication|

<a name='T-Trimble-Id-TokenProviderWrapper'></a>
## TokenProviderWrapper `type`

##### Namespace

Trimble.ID.Maui

<a name='M-Trimble-Id-TokenProviderWrapper-RetrieveToken'></a>
### RetrieveToken() `method`

##### Summary

Retrieve access token

##### Parameters

This method has no parameters.