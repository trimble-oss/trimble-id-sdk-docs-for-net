<a name='assembly'></a>
# Trimble.ID.Desktop

## Contents

- [BrowserPreferences](#T-Trimble-ID-Desktop-BrowserPreferences 'Trimble.ID.Desktop.BrowserPreferences')
  - [Height](#P-Trimble-ID-Desktop-BrowserPreferences-Height 'Trimble.ID.Desktop.BrowserPreferences.Height')
  - [NewWindow](#P-Trimble-ID-Desktop-BrowserPreferences-NewWindow 'Trimble.ID.Desktop.BrowserPreferences.NewWindow')
  - [Width](#P-Trimble-ID-Desktop-BrowserPreferences-Width 'Trimble.ID.Desktop.BrowserPreferences.Width')
  - [X](#P-Trimble-ID-Desktop-BrowserPreferences-X 'Trimble.ID.Desktop.BrowserPreferences.X')
  - [Y](#P-Trimble-ID-Desktop-BrowserPreferences-Y 'Trimble.ID.Desktop.BrowserPreferences.Y')
- [CustomUrlAuthenticator](#T-Trimble-ID-Desktop-CustomUrlAuthenticator 'Trimble.ID.Desktop.CustomUrlAuthenticator')
  - [#ctor(tokenProvider,productName)](#M-Trimble-ID-Desktop-CustomUrlAuthenticator-#ctor-TrimbleCloud-Authentication-AuthorizationCodeGrantTokenProvider,System-String- 'Trimble.ID.Desktop.CustomUrlAuthenticator.#ctor(TrimbleCloud.Authentication.AuthorizationCodeGrantTokenProvider,System.String)')
  - [Login(silent,timeoutInMs)](#M-Trimble-ID-Desktop-CustomUrlAuthenticator-Login-System-Boolean,System-Int32,System-Threading-CancellationToken- 'Trimble.ID.Desktop.CustomUrlAuthenticator.Login(System.Boolean,System.Int32,System.Threading.CancellationToken)')
  - [WithBrowserPreferences(preferences)](#M-Trimble-ID-Desktop-CustomUrlAuthenticator-WithBrowserPreferences-Trimble-ID-Desktop-BrowserPreferences- 'Trimble.ID.Desktop.CustomUrlAuthenticator.WithBrowserPreferences(Trimble.ID.Desktop.BrowserPreferences)')
- [LocalhostAuthenticator](#T-Trimble-ID-Desktop-LocalhostAuthenticator 'Trimble.ID.Desktop.LocalhostAuthenticator')
  - [#ctor(endpointProvider,consumerKey,scopes,productName)](#M-Trimble-ID-Desktop-LocalhostAuthenticator-#ctor-TrimbleCloud-Authentication-IEndpointProvider,System-String,System-String[],System-String- 'Trimble.ID.Desktop.LocalhostAuthenticator.#ctor(TrimbleCloud.Authentication.IEndpointProvider,System.String,System.String[],System.String)')
  - [IsLoggedIn](#P-Trimble-ID-Desktop-LocalhostAuthenticator-IsLoggedIn 'Trimble.ID.Desktop.LocalhostAuthenticator.IsLoggedIn')
  - [LegacyTokenProvider](#P-Trimble-ID-Desktop-LocalhostAuthenticator-LegacyTokenProvider 'Trimble.ID.Desktop.LocalhostAuthenticator.LegacyTokenProvider')
  - [TokenProvider](#P-Trimble-ID-Desktop-LocalhostAuthenticator-TokenProvider 'Trimble.ID.Desktop.LocalhostAuthenticator.TokenProvider')
  - [Dispose()](#M-Trimble-ID-Desktop-LocalhostAuthenticator-Dispose 'Trimble.ID.Desktop.LocalhostAuthenticator.Dispose')
  - [Dispose(disposing)](#M-Trimble-ID-Desktop-LocalhostAuthenticator-Dispose-System-Boolean- 'Trimble.ID.Desktop.LocalhostAuthenticator.Dispose(System.Boolean)')
  - [GetUserInfo()](#M-Trimble-ID-Desktop-LocalhostAuthenticator-GetUserInfo 'Trimble.ID.Desktop.LocalhostAuthenticator.GetUserInfo')
  - [LoadCachedLogin()](#M-Trimble-ID-Desktop-LocalhostAuthenticator-LoadCachedLogin 'Trimble.ID.Desktop.LocalhostAuthenticator.LoadCachedLogin')
  - [Login(silent,timeoutInMs,cancellationToken)](#M-Trimble-ID-Desktop-LocalhostAuthenticator-Login-System-Boolean,System-Int32,System-Threading-CancellationToken- 'Trimble.ID.Desktop.LocalhostAuthenticator.Login(System.Boolean,System.Int32,System.Threading.CancellationToken)')
  - [Logout(singleSignOut,cancellationToken)](#M-Trimble-ID-Desktop-LocalhostAuthenticator-Logout-System-Boolean,System-Threading-CancellationToken- 'Trimble.ID.Desktop.LocalhostAuthenticator.Logout(System.Boolean,System.Threading.CancellationToken)')
  - [WithBrowserPreferences(preferences)](#M-Trimble-ID-Desktop-LocalhostAuthenticator-WithBrowserPreferences-Trimble-ID-Desktop-BrowserPreferences- 'Trimble.ID.Desktop.LocalhostAuthenticator.WithBrowserPreferences(Trimble.ID.Desktop.BrowserPreferences)')
  - [WithFixedPort(port)](#M-Trimble-ID-Desktop-LocalhostAuthenticator-WithFixedPort-System-Int32- 'Trimble.ID.Desktop.LocalhostAuthenticator.WithFixedPort(System.Int32)')
  - [WithLoopbackAddress(address)](#M-Trimble-ID-Desktop-LocalhostAuthenticator-WithLoopbackAddress-System-String- 'Trimble.ID.Desktop.LocalhostAuthenticator.WithLoopbackAddress(System.String)')
  - [WithPersistentStorage(persistentStorage)](#M-Trimble-ID-Desktop-LocalhostAuthenticator-WithPersistentStorage-TrimbleCloud-Authentication-IPersistantStorage- 'Trimble.ID.Desktop.LocalhostAuthenticator.WithPersistentStorage(TrimbleCloud.Authentication.IPersistantStorage)')
- [LocalhostListener](#T-Trimble-ID-Desktop-LocalhostListener 'Trimble.ID.Desktop.LocalhostListener')
  - [#ctor(address)](#M-Trimble-ID-Desktop-LocalhostListener-#ctor-System-String- 'Trimble.ID.Desktop.LocalhostListener.#ctor(System.String)')
  - [ANY_PORT](#F-Trimble-ID-Desktop-LocalhostListener-ANY_PORT 'Trimble.ID.Desktop.LocalhostListener.ANY_PORT')
  - [LOOPBACK_ADDRESS](#F-Trimble-ID-Desktop-LocalhostListener-LOOPBACK_ADDRESS 'Trimble.ID.Desktop.LocalhostListener.LOOPBACK_ADDRESS')
  - [Address](#P-Trimble-ID-Desktop-LocalhostListener-Address 'Trimble.ID.Desktop.LocalhostListener.Address')
  - [Port](#P-Trimble-ID-Desktop-LocalhostListener-Port 'Trimble.ID.Desktop.LocalhostListener.Port')
  - [Dispose()](#M-Trimble-ID-Desktop-LocalhostListener-Dispose 'Trimble.ID.Desktop.LocalhostListener.Dispose')
  - [Start(port)](#M-Trimble-ID-Desktop-LocalhostListener-Start-System-Int32- 'Trimble.ID.Desktop.LocalhostListener.Start(System.Int32)')

<a name='T-Trimble-ID-Desktop-BrowserPreferences'></a>
## BrowserPreferences `type`

##### Namespace

Trimble.ID.Desktop

<a name='P-Trimble-ID-Desktop-BrowserPreferences-Height'></a>
### Height `property`

<a name='P-Trimble-ID-Desktop-BrowserPreferences-NewWindow'></a>
### NewWindow `property`

<a name='P-Trimble-ID-Desktop-BrowserPreferences-Width'></a>
### Width `property`

<a name='P-Trimble-ID-Desktop-BrowserPreferences-X'></a>
### X `property`

<a name='P-Trimble-ID-Desktop-BrowserPreferences-Y'></a>
### Y `property`

<a name='T-Trimble-ID-Desktop-CustomUrlAuthenticator'></a>
## CustomUrlAuthenticator `type`

##### Namespace

Trimble.ID.Desktop

<a name='M-Trimble-ID-Desktop-CustomUrlAuthenticator-#ctor-TrimbleCloud-Authentication-AuthorizationCodeGrantTokenProvider,System-String-'></a>
### #ctor(tokenProvider,productName) `constructor`

##### Summary

Public constructor for CustomUrlAuthenticator class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenProvider | [TrimbleCloud.Authentication.AuthorizationCodeGrantTokenProvider](#T-TrimbleCloud-Authentication-AuthorizationCodeGrantTokenProvider 'TrimbleCloud.Authentication.AuthorizationCodeGrantTokenProvider') | An authorization Grant token provider object |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The product name of the consuming application (optional). |

<a name='M-Trimble-ID-Desktop-CustomUrlAuthenticator-Login-System-Boolean,System-Int32,System-Threading-CancellationToken-'></a>
### Login(silent,timeoutInMs) `method`

##### Summary

Log the user in

##### Returns

true if the user was successfully logged in

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| silent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if no UI should be shown i.e. prompt=none |
| timeoutInMs | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Specify the length of time that client waits for a login response when making a login attempt. The default timeout value is 3 minutes. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.TimeoutException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeoutException 'System.TimeoutException') | Login operation has timed out after waiting for specified time. |

<a name='M-Trimble-ID-Desktop-CustomUrlAuthenticator-WithBrowserPreferences-Trimble-ID-Desktop-BrowserPreferences-'></a>
### WithBrowserPreferences(preferences) `method`

##### Summary

Fluent method to specify browser preferences

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| preferences | [Trimble.ID.Desktop.BrowserPreferences](#T-Trimble-ID-Desktop-BrowserPreferences 'Trimble.ID.Desktop.BrowserPreferences') | The browser preferences |

<a name='T-Trimble-ID-Desktop-LocalhostAuthenticator'></a>
## LocalhostAuthenticator `type`

##### Namespace

Trimble.ID.Desktop

##### Summary

An authenticator that utilizes a localhost callback

##### Example

```csharp
const string CONFIGURATION_ENDPOINT = "https://id.trimble.com/.well-known/openid-configuration";
const string CONSUMER_KEY = "APPLICATION_CONSUMER_KEY";
var string SCOPES = new [] { "CSharpSDKTesting" };
var endpointProvider = new OpenIdEndpointProvider(new Uri(CONFIGURATION_URL, UriKind.Absolute));
var authenticator = new LocalhostAuthenticator(endpointProvider, CONSUMER_KEY, SCOPES);
if (await authenticator.Login())
{
    var userInfo = await authenticator.GetUserInfo();
    var token = await authenticator.TokenProvider.RetrieveToken();
}
await authenticator.Logout(singleSignOut: true);
authenticator.Dispose();
```

##### Remarks

Implements IAuthenticator

Token lifetime and refresh are handled by the SDK.

<a name='M-Trimble-ID-Desktop-LocalhostAuthenticator-#ctor-TrimbleCloud-Authentication-IEndpointProvider,System-String,System-String[],System-String-'></a>
### #ctor(endpointProvider,consumerKey,scopes,productName) `constructor`

##### Summary

Public constructor for LocalhostAuthenticator class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpointProvider | [TrimbleCloud.Authentication.IEndpointProvider](#T-TrimbleCloud-Authentication-IEndpointProvider 'TrimbleCloud.Authentication.IEndpointProvider') | An endpoint provider that provides the URL for the Trimble Identity authorization and token endpoints |
| consumerKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer key for the calling application |
| scopes | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The scopes used in the authorization request, openid is specified by default |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The product name of the consuming application (optional). |

<a name='P-Trimble-ID-Desktop-LocalhostAuthenticator-IsLoggedIn'></a>
### IsLoggedIn `property`

##### Summary

Get the logged in state

<a name='P-Trimble-ID-Desktop-LocalhostAuthenticator-LegacyTokenProvider'></a>
### LegacyTokenProvider `property`

##### Summary

Get the token provider for this authenticator

##### Remarks

This token provider can be used with other SDK components

<a name='P-Trimble-ID-Desktop-LocalhostAuthenticator-TokenProvider'></a>
### TokenProvider `property`

##### Summary

Get the token provider for this authenticator

##### Remarks

This token provider can be used with other SDK components

<a name='M-Trimble-ID-Desktop-LocalhostAuthenticator-Dispose'></a>
### Dispose() `method`

##### Summary

Dispose method for LocalhostAuthenticator class

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-Desktop-LocalhostAuthenticator-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Dispose of instance

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | True if disposing |

<a name='M-Trimble-ID-Desktop-LocalhostAuthenticator-GetUserInfo'></a>
### GetUserInfo() `method`

##### Summary

Validates the ID token and returns user claims

##### Returns

User claims from the ID token

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-Desktop-LocalhostAuthenticator-LoadCachedLogin'></a>
### LoadCachedLogin() `method`

##### Summary

Initialize the authenticator with a stored refresh token

##### Returns

true if the authenticator was initialzed with an existing refresh token

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-Desktop-LocalhostAuthenticator-Login-System-Boolean,System-Int32,System-Threading-CancellationToken-'></a>
### Login(silent,timeoutInMs,cancellationToken) `method`

##### Summary

Log the user in

##### Returns

true if the user was successfully logged in

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| silent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if no UI should be shown i.e. prompt=none |
| timeoutInMs | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Specify the length of time that client waits for a login response when making a login attempt. The default timeout value is 3 minutes. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The optional cancellation token. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.TimeoutException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeoutException 'System.TimeoutException') | Login operation has timed out after waiting for specified time. |
| [System.Threading.Tasks.TaskCanceledException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.TaskCanceledException 'System.Threading.Tasks.TaskCanceledException') | Task is canceled when cancellation token is requested and the operation might takes longer time to respond |

##### Remarks

Only one login or logout operation is permitted at a time, all previously started operations will return false

<a name='M-Trimble-ID-Desktop-LocalhostAuthenticator-Logout-System-Boolean,System-Threading-CancellationToken-'></a>
### Logout(singleSignOut,cancellationToken) `method`

##### Summary

Log the user out

##### Returns

true if the user was successfully logged out

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| singleSignOut | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if the single sign in session should be terminated |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The optional cancellation token. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.Tasks.TaskCanceledException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.TaskCanceledException 'System.Threading.Tasks.TaskCanceledException') | Task is canceled when cancellation token is requested and the operation might takes longer time to respond |

##### Remarks

Only one login or logout operation is permitted at a time, all previously started operations will return false

<a name='M-Trimble-ID-Desktop-LocalhostAuthenticator-WithBrowserPreferences-Trimble-ID-Desktop-BrowserPreferences-'></a>
### WithBrowserPreferences(preferences) `method`

##### Summary

Fluent method to specify browser preferences

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| preferences | [Trimble.ID.Desktop.BrowserPreferences](#T-Trimble-ID-Desktop-BrowserPreferences 'Trimble.ID.Desktop.BrowserPreferences') | The browser preferences |

<a name='M-Trimble-ID-Desktop-LocalhostAuthenticator-WithFixedPort-System-Int32-'></a>
### WithFixedPort(port) `method`

##### Summary

Fluent method to specify a fixed port

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The fixed port to use for the localhost listener |

<a name='M-Trimble-ID-Desktop-LocalhostAuthenticator-WithLoopbackAddress-System-String-'></a>
### WithLoopbackAddress(address) `method`

##### Summary

Fluent method to specify an alternative host

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The alternative host to use for the localhost listener |

<a name='M-Trimble-ID-Desktop-LocalhostAuthenticator-WithPersistentStorage-TrimbleCloud-Authentication-IPersistantStorage-'></a>
### WithPersistentStorage(persistentStorage) `method`

##### Summary

Fluent method to specify persistent storage option. This initializes to load cached login first if present

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| persistentStorage | [TrimbleCloud.Authentication.IPersistantStorage](#T-TrimbleCloud-Authentication-IPersistantStorage 'TrimbleCloud.Authentication.IPersistantStorage') | The persistent storage for refresh tokens |

<a name='T-Trimble-ID-Desktop-LocalhostListener'></a>
## LocalhostListener `type`

##### Namespace

Trimble.ID.Desktop

<a name='M-Trimble-ID-Desktop-LocalhostListener-#ctor-System-String-'></a>
### #ctor(address) `constructor`

##### Summary

Constructor for localhost listener

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host address to listen on, default 127.0.0.1 |

<a name='F-Trimble-ID-Desktop-LocalhostListener-ANY_PORT'></a>
### ANY_PORT `constants`

<a name='F-Trimble-ID-Desktop-LocalhostListener-LOOPBACK_ADDRESS'></a>
### LOOPBACK_ADDRESS `constants`

<a name='P-Trimble-ID-Desktop-LocalhostListener-Address'></a>
### Address `property`

<a name='P-Trimble-ID-Desktop-LocalhostListener-Port'></a>
### Port `property`

<a name='M-Trimble-ID-Desktop-LocalhostListener-Dispose'></a>
### Dispose() `method`

##### Summary

Dispose method for LocalhostListener class

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-Desktop-LocalhostListener-Start-System-Int32-'></a>
### Start(port) `method`

##### Summary

Start a listener on the specified port

##### Returns

true on success

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The port to start the listener on, or ANY_PORT |
