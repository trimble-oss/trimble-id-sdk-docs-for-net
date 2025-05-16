# Trimble.ID Client SDK Developer Guide

### Content

1. [Overview](#overview)
2. [Authentication with Trimble Identity](#identity)
3. [Configure the endpoint](#configure-endpoint)
4. [Code snippets](#snippets)
5. [FAQ](#faq)

## <a name="overview">Overview</a> ##

Trimble.ID is core helper library containing primitives and interaction with supported grant types. It is base library for OAuth 2.0 related protocol operations. It provides, 

- Discovery of endpoints
- Grant Type Token Providers
- Token Refresh and Token Validation
- HTTP Client Handler to access a given API with the access token


Currently we support .NET standard 2.0 / .NET Framework > 4.6.1.

## <a name="identity">Authentication with Trimble Identity</a> ##

> **NOTE:**
> 
> If you do not have access to the Trimble Developer Console, please work with a Trimble partner to get onboarded on to the [Trimble Developer Console](https://console.trimble.com/).

To utilize TID authentication, your identity application must be registered with Trimble Identity. You can conveniently handle the application registration process on [Trimble Developer Console](https://developer.console.trimble.com).

## <a name="configure-endpoint">Configure endpoint</a> ##

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

Trimble.ID.FixedEndpointProvider
======
This endpoint provider is used to provide a fixed set of endpoints.

## Usage
```C#
using Trimble.ID;
IEndpointProvider endpointProvider = new FixedEndpointProvider(new Uri("https://authorization.url"), new Uri("https://token.url"), new Uri("https://userinfo.url"));
var endpoint = await endpointProvider.RetrieveAuthorizationEndpoint();
```

Trimble.ID.OpenIdEndpointProvider
======
This endpoint provider is used to retrieve the endpoints from a well-known URL endpoint.

## Usage
```C#
using Trimble.ID;
IEndpointProvider endpointProvider = new OpenIdEndpointProvider(new Uri("https://id.trimble.com/.well-known/openid-configuration"));
var endpoint = await endpointProvider.RetrieveAuthorizationEndpoint();
```

Trimble.ID.FixedTokenProvider
======
This token provider is used to provide a fixed access token.

## Usage
```C#
using Trimble.ID;
ITokenProvider tokenProvider = new FixedTokenProvider('accessToken');
var token = await tokenProvider.RetrieveToken();
```

Trimble.ID.ClientCredentialTokenProvider
======
This token provider is used to retrieve an access token using the client credentials grant type.

## Usage
```C#
using Trimble.ID;
ITokenProvider tokenProvider = new ClientCredentialTokenProvider(endpointProvider, "clientId", "clientSecret").WithScopes(new[] string { "scope" });;
var token = await tokenProvider.RetrieveToken();
```
Alternatively, you can utilize the `endpointProvider` by specifying `OpenIdEndpointProvider.Staging` for the staging environment and `OpenIdEndpointProvider.Production` for the production environment, simplifying configuration accordingly.

Trimble.ID.AuthorizationCodeGrantTokenProvider
======
This token provider is used to retrieve an access token using the authorization code grant type.

## Usage - Authorization grant
```C#
using Trimble.ID;
var tokenProvider = new AuthorizationCodeTokenProvider(endpointProvider, "clientId", "clientSecret", "https://redirect.url").WithScopes(new[] string { "scope" });
// create auth URL
    var redirectUrl = await tokenProvider.GetOAuthRedirect("state");
    /* launch browser window with given redirect URL */

// After successful redirection, validate the auth code to retrieve tokens
    bool validated = await tokenProvider.ValidateQuery(queryString);
    var token = await tokenProvider.RetrieveToken();
```

## Usage - Authorization grant with PKCE
```C#
using Trimble.ID;
var tokenProvider = new AuthorizationCodeTokenProvider(endpointProvider, "clientId", "https://redirect.url").WithScopes(new[] string { "scope" })
                    .WithProofKeyForCodeExchange(AuthorizationCodeGrantTokenProvider.GenerateCodeVerifier());
// create auth URL
    var redirectUrl = await tokenProvider.GetOAuthRedirect("state");
    /* launch browser window with given redirect URL */

// After successful redirection, validate the auth code to retrieve tokens
    bool validated = await tokenProvider.ValidateQuery(queryString);
    var token = await tokenProvider.RetrieveToken();
    var refreshToken = await tokenProvider.RetrieveRefreshToken();
    var codeVerifier = await tokenProvider.RetrieveCodeVerifier();
```

Trimble.ID.OnBehalfGrantTokenProvider
======
This token provider is used to retrieve an access token using the on behalf/ token exchange grant type.

## Usage
```C#
using Trimble.ID;
ITokenProvider tokenProvider = new OnBehalfGrantTokenProvider(endpointProvider, "client_id", "client_secret", "id_token").WithScopes(new[] string { "scope" });
var token = tokenProvider.RetrieveToken();
```
Trimble.ID.RefreshableTokenProvider
======
This token provider is used to refresh an access token using a refresh token.

## Usage - With Secret
```C#
using Trimble.ID;
var tokenProvider = new RefreshableTokenProvider(endpointProvider, "clientId")
                                    .WithConsumerSecret("clientSecret")
                                    .WithRefreshToken("refreshToken");
var token = await tokenProvider.RetrieveToken();
var refreshToken = await tokenProvider.RetrieveRefreshToken();
```
## Usage - With PKCE
```C#
using Trimble.ID;
var tokenProvider = new RefreshableTokenProvider(endpointProvider, "clientId")
                                    .WithProofKeyForCodeExchange("codeVerifier")
                                    .WithRefreshToken("refreshToken");
var token = await tokenProvider.RetrieveToken();
var refreshToken = await tokenProvider.RetrieveRefreshToken();
```

Trimble.ID.BasicAuthenticationHttpClientProvider
======
It is possible to use the Trimble.ID library to retrieve an HttpClient with the appropriate authorization header set. This can be used to make requests to the Trimble Cloud Core Platform APIs.

## Usage
```C#
using Trimble.ID;
IHttpClientProvider httpClientProvider = new BasicAuthenticationHttpClientProvider("username", "password", new Uri("https://endpoint.base.url"));
var client = await httpClientProvider.RetrieveClient();
```

Trimble.ID.BearerTokenHttpClientProvider
======
It is possible to use the Trimble.ID library to retrieve an HttpClient with the appropriate authorization header set. This can be used to make requests to the Trimble Cloud Core Platform APIs.

## Usage
```C#
using Trimble.ID;
IHttpClientProvider httpClientProvider = new BearerTokenHttpClientProvider(tokenProvider, new Uri("https://endpoint.base.url"));
var client = httpClientProvider.RetrieveClient();
```

Trimble.ID.DeviceAuthorizationTokenProvider
======

Trimble Identity supports the implementation of device authorization, an OAuth 2.0 grant type, which allows users to sign in to input-constrained devices such as Hololens™ or Oculus™, that cannot handle are not capable of handling the UI workflows associated with authenticating the user with Trimble Identity.

## Usage
```C#
using Trimble.ID;

var tokenProvider = new DeviceAuthorizationTokenProvider(_endpointProvider, "CLIENT_ID")
    .WithClientSecret("CLIENT_SECRET")
    .WithScopes(new[] { "SCOPE" });

// create authorization
DeviceAuthorizationResponse authorizationResponse = await _tokenProvider.CreateAuthorization();

// After receiving a successful response from CreateAuthorization,
// poll for the authorization status and get response via callback
tokenProvider.PerformTokenRequest(authorizationResponse.DeviceCode, 5, 600, onCallback);

// Once the status is DeviceAuthorizationStatus.ACCESS_GRANTED, you can retrieve access token
var accessToken = await _tokenProvider.RetrieveToken();
```

Trimble.ID.ValidatedClaimsetProvider
======
Provides the validated claimset for a JSON web token.

## Usage
```C#
using Trimble.ID;
IKeySetProvider keysetProvider = new OpenIdKeySetProvider(endpointProvider);
IClaimsetProvider claimsetProvider = new ValidatedClaimsetProvider(keysetProvider);
var claimset = await claimsetProvider.RetrieveClaimset(idToken);
```

## <a name="faq">FAQ</a> ##

Do you have questions? Do not worry, we have prepared a complete [FAQ](./FAQ.md) answering the most common questions.
