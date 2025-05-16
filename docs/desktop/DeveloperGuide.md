# Trimble.ID.Desktop Client SDK Developer Guide

### Content

1. [Overview](#overview)
2. [Authentication with Trimble Identity](#identity)
3. [Configure the endpoint](#configure-endpoint)
4. [Code snippets](#snippets)
    + [Configure LocalhostAuthenticator](#configure_authenticator)
    + [Persistence Storage](#persistant_storage)
    + [Example: How to Login](#login) 
    + [Example: How to get an access token](#access_token)
    + [Example: How to know logged-in state](#loggedin_state)
    + [Example: How to get logged-in user info](#user_info)
    + [Example: How to Logout](#logout)
5. [FAQ](#faq)

## <a name="overview">Overview</a> ##

Trimble.ID.Desktop is a .NET library that can be used to add authentication to your desktop applications. 

## <a name="identity">Authentication with Trimble Identity</a> ##

> **NOTE:**
> 
> If you do not have access to the Trimble Developer Console, please work with a Trimble partner to get onboarded on to the [Trimble Developer Console](https://console.trimble.com/).

To utilize TID authentication, your identity application must be registered with Trimble Identity. You can conveniently handle the application registration process on [Trimble Developer Console](https://developer.console.trimble.com).

## <a name="configure-endpoint">Configure the endpoint</a> ##

Configure the well-known URL endpoint is used to retrieve the authorization, token and user info endpoints for Trimble OAuth server. 

<table>
    <tbody>
        <tr>
            <th>Well-Known URL</th>
            <td>https://id.trimble.com/.well-known/openid-configuration</td>
        </tr>
    </tbody>
  </table>

## <a name="snippets">Code snippets</a> ##

### <a name="configure_authenticator">Configure LocalhostAuthenticator</a> ###

Create a single instance of the LocalhostAuthenticator which will remain for the lifetime of the application. The LocalhostAuthenticator is responsible for managing the authentication flow and token refresh.

Ensure to configure the `https://localhost` as a valid redirect URI in the [Trimble Developer Console](https://beta.console.trimble.com/home).

```csharp
const string WELL_KNOWN_ENDPOINT = "https://id.trimble.com/.well-known/openid-configuration";
const string CLIENT_ID = "TID_CLIENT_ID";
var string SCOPES = new [] { "TID_SCOPES" };
IEndpointProvider endpointProvider = new OpenIdEndpointProvider(new Uri(WELL_KNOWN_ENDPOINT, UriKind.Absolute));
IAuthenticator authenticator = new LocalhostAuthenticator(endpointProvider, CLIENT_ID, SCOPES);
```

### <a name="persistent_storage">Persistent Storage</a> ###

The SDK uses [Isolated storage](https://learn.microsoft.com/en-us/dotnet/standard/io/isolated-storage) mechanism for storing the user tokens. The storage is encrypted and is only accessible by the application. The storage is not shared between applications. See below code snippet for configuring the persistent storage with encryption.

 ```csharp
    byte[] Salt = { 0xb7, 0xa2, 0x46, 0x53, 0x84, 0xf0, 0x49, 0xc6, 0x4f, 0x9b };
    IAuthenticator authenticator = new LocalhostAuthenticator(OpenIdEndpointProvider.Production, CLIENT_ID, SCOPES)
                                        .WithPersistentStorage(new EncryptedStorage(new IsolatedFileStorage(<"filename.config">), Salt));
  ```

> **_NOTE:_** Token lifetime and refresh are handled automatically. If the client uses persistent storage, our SDK securely stores tokens in [isolated storage](https://learn.microsoft.com/en-us/dotnet/standard/io/isolated-storage). This means that any subsequent application launches will trigger an automatic silent login with the stored tokens. This enables users to seamlessly access the application without the need to manually enter their credentials.

### <a name="offline_access">Offline access</a> ###

Offline access mode allows you to fetch user information and an access token even when offline, and continue to issue new tokens when a network becomes available. This mode bypasses token expiration checks and allows the issuance of existing tokens and user details from persistent storage. It is particularly useful in offline scenarios where you need to retrieve information without an active network connection.

> **_NOTE:_** Requires at least one initial sign-in to initialize the token from the cache.
    
To enable offline access mode, use the following code:

```csharp
IAuthenticator authenticator = new LocalhostAuthenticator(OpenIdEndpointProvider.Production, CLIENT_ID, SCOPES)
                                        .WithPersistentStorage(new EncryptedStorage(new IsolatedFileStorage(<"filename.config">), Salt))
                                        .WithOfflineAccess();
```
Please refer [here](#user_info) to fetch user information

### <a name="login">Example: How to Login</a> ###

<b>Summary</b>

  Log the user in. On Login, authenticator launches the browser for user login.

  <b>Returns</b>

  true if the user was successfully logged in

  ```csharp
  var isLoggedIn = await authenticator.Login(); 
  ```
### <a name="access_token">Example: How to get an access token</a> ###

<b>Summary</b>

  Retrieves access token of authenticated user

  <b>Returns</b>

  Access token of authenticated user

  ```csharp
  var accessToken = await authenticator.TokenProvider.RetrieveToken();
  ```
> **_NOTE:_** Token lifetime and refresh are handled by the SDK.

### <a name="loggedin_state">Example: How to know logged-in state</a> ###
<b>Summary</b>

  Get the logged in state

  ```csharp
  var isLoggedIn = authenticator.IsLoggedIn;
  ```

### <a name="user_info">Example: How to get logged-in user info</a> ###

 <b>Summary</b>

  Validates the ID token and returns user claims

  <b>Returns</b>

  User claims from the ID token

  ```csharp
  var userInfo = await authenticator.GetUserInfo();
  ```

### <a name="logout">Example: How to Logout</a> ###

<b>Summary</b>

  Log the user out. 
<b>Returns</b>

  true if the user was successfully logged out

  ```csharp
  var isLoggedIn = authenticator.Logout(singleSignOut: true);
  ```

## <a name="faq">FAQ</a> ##

Do you have questions? Do not worry, we have prepared a complete [FAQ](./FAQ.md) answering the most common questions.
