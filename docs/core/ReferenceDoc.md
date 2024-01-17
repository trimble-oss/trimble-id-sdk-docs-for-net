<a name='assembly'></a>
# Trimble.ID

## Contents

- [AuthorizationCodeGrantTokenProvider](#T-Trimble-ID-AuthorizationCodeGrantTokenProvider 'Trimble.ID.AuthorizationCodeGrantTokenProvider')
  - [#ctor(endpointProvider,consumerKey,redirectUrl,productName)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String,System-String- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.#ctor(Trimble.ID.IEndpointProvider,System.String,System.String,System.String)')
  - [#ctor(endpointProvider,consumerKey,redirectUri,productName)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-Uri,System-String- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.#ctor(Trimble.ID.IEndpointProvider,System.String,System.Uri,System.String)')
  - [State](#P-Trimble-ID-AuthorizationCodeGrantTokenProvider-State 'Trimble.ID.AuthorizationCodeGrantTokenProvider.State')
  - [GetOAuthLogoutRedirect(state)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-GetOAuthLogoutRedirect-System-String- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.GetOAuthLogoutRedirect(System.String)')
  - [GetOAuthRedirect(state)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-GetOAuthRedirect-System-String- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.GetOAuthRedirect(System.String)')
  - [ValidateCode(code)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-ValidateCode-System-String- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.ValidateCode(System.String)')
  - [ValidateQuery(query)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-ValidateQuery-System-String- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.ValidateQuery(System.String)')
  - [WithIdentityProvider(identityProvider)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-WithIdentityProvider-System-String- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.WithIdentityProvider(System.String)')
  - [WithLogoutRedirect(logoutRedirectUrl)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-WithLogoutRedirect-System-String- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.WithLogoutRedirect(System.String)')
  - [WithLogoutRedirect(logoutRedirectUri)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-WithLogoutRedirect-System-Uri- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.WithLogoutRedirect(System.Uri)')
  - [WithScopes(scopes)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-WithScopes-System-Collections-Generic-IEnumerable{System-String}- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.WithScopes(System.Collections.Generic.IEnumerable{System.String})')
- [BearerTokenHttpClientProvider](#T-Trimble-ID-BearerTokenHttpClientProvider 'Trimble.ID.BearerTokenHttpClientProvider')
  - [#ctor(tokenProvider,baseAddress,productName)](#M-Trimble-ID-BearerTokenHttpClientProvider-#ctor-Trimble-ID-ITokenProvider,System-Uri,System-String- 'Trimble.ID.BearerTokenHttpClientProvider.#ctor(Trimble.ID.ITokenProvider,System.Uri,System.String)')
  - [Logger](#F-Trimble-ID-BearerTokenHttpClientProvider-Logger 'Trimble.ID.BearerTokenHttpClientProvider.Logger')
  - [RetrieveClient()](#M-Trimble-ID-BearerTokenHttpClientProvider-RetrieveClient 'Trimble.ID.BearerTokenHttpClientProvider.RetrieveClient')
- [ClientCredentialTokenProvider](#T-Trimble-ID-ClientCredentialTokenProvider 'Trimble.ID.ClientCredentialTokenProvider')
  - [#ctor(endpointProvider,consumerKey,consumerSecret,productName)](#M-Trimble-ID-ClientCredentialTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String,System-String- 'Trimble.ID.ClientCredentialTokenProvider.#ctor(Trimble.ID.IEndpointProvider,System.String,System.String,System.String)')
  - [RetrieveToken()](#M-Trimble-ID-ClientCredentialTokenProvider-RetrieveToken 'Trimble.ID.ClientCredentialTokenProvider.RetrieveToken')
  - [WithScopes(scopes)](#M-Trimble-ID-ClientCredentialTokenProvider-WithScopes-System-Collections-Generic-IEnumerable{System-String}- 'Trimble.ID.ClientCredentialTokenProvider.WithScopes(System.Collections.Generic.IEnumerable{System.String})')
- [DeviceAuthorizationTokenProvider](#T-Trimble-ID-DeviceAuthorizationTokenProvider 'Trimble.ID.DeviceAuthorizationTokenProvider')
  - [#ctor(endpointProvider,clientId,productName)](#M-Trimble-ID-DeviceAuthorizationTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String- 'Trimble.ID.DeviceAuthorizationTokenProvider.#ctor(Trimble.ID.IEndpointProvider,System.String,System.String)')
  - [CreateAuthorization()](#M-Trimble-ID-DeviceAuthorizationTokenProvider-CreateAuthorization 'Trimble.ID.DeviceAuthorizationTokenProvider.CreateAuthorization')
  - [PerformTokenRequest(deviceCode,pollInterval,timeout,onCallback)](#M-Trimble-ID-DeviceAuthorizationTokenProvider-PerformTokenRequest-System-String,System-Int32,System-Int32,System-Action{Trimble-ID-DeviceAuthorizationStatus},System-Threading-CancellationToken- 'Trimble.ID.DeviceAuthorizationTokenProvider.PerformTokenRequest(System.String,System.Int32,System.Int32,System.Action{Trimble.ID.DeviceAuthorizationStatus},System.Threading.CancellationToken)')
  - [RetrieveIdToken()](#M-Trimble-ID-DeviceAuthorizationTokenProvider-RetrieveIdToken 'Trimble.ID.DeviceAuthorizationTokenProvider.RetrieveIdToken')
  - [RetrieveRefreshToken()](#M-Trimble-ID-DeviceAuthorizationTokenProvider-RetrieveRefreshToken 'Trimble.ID.DeviceAuthorizationTokenProvider.RetrieveRefreshToken')
  - [RetrieveToken()](#M-Trimble-ID-DeviceAuthorizationTokenProvider-RetrieveToken 'Trimble.ID.DeviceAuthorizationTokenProvider.RetrieveToken')
  - [WithClientSecret(clientSecret)](#M-Trimble-ID-DeviceAuthorizationTokenProvider-WithClientSecret-System-String- 'Trimble.ID.DeviceAuthorizationTokenProvider.WithClientSecret(System.String)')
  - [WithScopes(scopes)](#M-Trimble-ID-DeviceAuthorizationTokenProvider-WithScopes-System-Collections-Generic-IEnumerable{System-String}- 'Trimble.ID.DeviceAuthorizationTokenProvider.WithScopes(System.Collections.Generic.IEnumerable{System.String})')
- [EncryptedStorage](#T-Trimble-ID-EncryptedStorage 'Trimble.ID.EncryptedStorage')
  - [#ctor()](#M-Trimble-ID-EncryptedStorage-#ctor-Trimble-ID-IPersistantStorage,System-Byte[]- 'Trimble.ID.EncryptedStorage.#ctor(Trimble.ID.IPersistantStorage,System.Byte[])')
  - [GetItem()](#M-Trimble-ID-EncryptedStorage-GetItem-System-String- 'Trimble.ID.EncryptedStorage.GetItem(System.String)')
  - [RemoveItem()](#M-Trimble-ID-EncryptedStorage-RemoveItem-System-String- 'Trimble.ID.EncryptedStorage.RemoveItem(System.String)')
  - [SetItem()](#M-Trimble-ID-EncryptedStorage-SetItem-System-String,System-String- 'Trimble.ID.EncryptedStorage.SetItem(System.String,System.String)')
- [FixedEndpointProvider](#T-Trimble-ID-FixedEndpointProvider 'Trimble.ID.FixedEndpointProvider')
  - [#ctor(productName)](#M-Trimble-ID-FixedEndpointProvider-#ctor-System-String- 'Trimble.ID.FixedEndpointProvider.#ctor(System.String)')
  - [#ctor()](#M-Trimble-ID-FixedEndpointProvider-#ctor-Trimble-ID-FixedEndpointProvider- 'Trimble.ID.FixedEndpointProvider.#ctor(Trimble.ID.FixedEndpointProvider)')
  - [#ctor(authorizationEndpoint,tokenEndpoint,userInfoEndpoint,tokenRevocationEndpoint,jwksEndpoint,endSessionEndpoint)](#M-Trimble-ID-FixedEndpointProvider-#ctor-System-Uri,System-Uri,System-Uri,System-Uri,System-Uri,System-Uri,System-Uri- 'Trimble.ID.FixedEndpointProvider.#ctor(System.Uri,System.Uri,System.Uri,System.Uri,System.Uri,System.Uri,System.Uri)')
  - [RetrieveAuthorizationEndpoint()](#M-Trimble-ID-FixedEndpointProvider-RetrieveAuthorizationEndpoint 'Trimble.ID.FixedEndpointProvider.RetrieveAuthorizationEndpoint')
  - [RetrieveDeviceAuthorizationEndpoint()](#M-Trimble-ID-FixedEndpointProvider-RetrieveDeviceAuthorizationEndpoint 'Trimble.ID.FixedEndpointProvider.RetrieveDeviceAuthorizationEndpoint')
  - [RetrieveEndSessionEndpoint()](#M-Trimble-ID-FixedEndpointProvider-RetrieveEndSessionEndpoint 'Trimble.ID.FixedEndpointProvider.RetrieveEndSessionEndpoint')
  - [RetrieveJSONWebKeySetEndpoint()](#M-Trimble-ID-FixedEndpointProvider-RetrieveJSONWebKeySetEndpoint 'Trimble.ID.FixedEndpointProvider.RetrieveJSONWebKeySetEndpoint')
  - [RetrieveTokenEndpoint()](#M-Trimble-ID-FixedEndpointProvider-RetrieveTokenEndpoint 'Trimble.ID.FixedEndpointProvider.RetrieveTokenEndpoint')
  - [RetrieveTokenRevocationEndpoint()](#M-Trimble-ID-FixedEndpointProvider-RetrieveTokenRevocationEndpoint 'Trimble.ID.FixedEndpointProvider.RetrieveTokenRevocationEndpoint')
  - [RetrieveUserInfoEndpoint()](#M-Trimble-ID-FixedEndpointProvider-RetrieveUserInfoEndpoint 'Trimble.ID.FixedEndpointProvider.RetrieveUserInfoEndpoint')
  - [WithAuthorizationEndpoint(authorizationEndpoint)](#M-Trimble-ID-FixedEndpointProvider-WithAuthorizationEndpoint-System-Uri- 'Trimble.ID.FixedEndpointProvider.WithAuthorizationEndpoint(System.Uri)')
  - [WithDeviceAuthorizationEndpoint(jwksEndpoint)](#M-Trimble-ID-FixedEndpointProvider-WithDeviceAuthorizationEndpoint-System-Uri- 'Trimble.ID.FixedEndpointProvider.WithDeviceAuthorizationEndpoint(System.Uri)')
  - [WithEndSessionEndpoint(endSessionEndpoint)](#M-Trimble-ID-FixedEndpointProvider-WithEndSessionEndpoint-System-Uri- 'Trimble.ID.FixedEndpointProvider.WithEndSessionEndpoint(System.Uri)')
  - [WithJWKSEndpoint(jwksEndpoint)](#M-Trimble-ID-FixedEndpointProvider-WithJWKSEndpoint-System-Uri- 'Trimble.ID.FixedEndpointProvider.WithJWKSEndpoint(System.Uri)')
  - [WithTokenEndpoint(tokenEndpoint)](#M-Trimble-ID-FixedEndpointProvider-WithTokenEndpoint-System-Uri- 'Trimble.ID.FixedEndpointProvider.WithTokenEndpoint(System.Uri)')
  - [WithTokenRevocationEndpoint(tokenRevocationEndpoint)](#M-Trimble-ID-FixedEndpointProvider-WithTokenRevocationEndpoint-System-Uri- 'Trimble.ID.FixedEndpointProvider.WithTokenRevocationEndpoint(System.Uri)')
  - [WithUserInfoEndpoint(userInfoEndpoint)](#M-Trimble-ID-FixedEndpointProvider-WithUserInfoEndpoint-System-Uri- 'Trimble.ID.FixedEndpointProvider.WithUserInfoEndpoint(System.Uri)')
- [FixedKeySetProvider](#T-Trimble-ID-FixedKeySetProvider 'Trimble.ID.FixedKeySetProvider')
  - [#ctor(keyset)](#M-Trimble-ID-FixedKeySetProvider-#ctor-System-Collections-Generic-Dictionary{System-String,System-Security-Cryptography-RSACryptoServiceProvider}- 'Trimble.ID.FixedKeySetProvider.#ctor(System.Collections.Generic.Dictionary{System.String,System.Security.Cryptography.RSACryptoServiceProvider})')
  - [RetrieveKeySet()](#M-Trimble-ID-FixedKeySetProvider-RetrieveKeySet 'Trimble.ID.FixedKeySetProvider.RetrieveKeySet')
- [FixedTokenProvider](#T-Trimble-ID-FixedTokenProvider 'Trimble.ID.FixedTokenProvider')
  - [#ctor(token,productName)](#M-Trimble-ID-FixedTokenProvider-#ctor-System-String,System-String- 'Trimble.ID.FixedTokenProvider.#ctor(System.String,System.String)')
  - [RetrieveToken()](#M-Trimble-ID-FixedTokenProvider-RetrieveToken 'Trimble.ID.FixedTokenProvider.RetrieveToken')
- [IAuthenticator](#T-Trimble-ID-IAuthenticator 'Trimble.ID.IAuthenticator')
  - [IsLoggedIn](#P-Trimble-ID-IAuthenticator-IsLoggedIn 'Trimble.ID.IAuthenticator.IsLoggedIn')
  - [LegacyTokenProvider](#P-Trimble-ID-IAuthenticator-LegacyTokenProvider 'Trimble.ID.IAuthenticator.LegacyTokenProvider')
  - [TokenProvider](#P-Trimble-ID-IAuthenticator-TokenProvider 'Trimble.ID.IAuthenticator.TokenProvider')
  - [GetUserInfo()](#M-Trimble-ID-IAuthenticator-GetUserInfo 'Trimble.ID.IAuthenticator.GetUserInfo')
  - [Login(silent,timeoutInMs,cancellationToken)](#M-Trimble-ID-IAuthenticator-Login-System-Boolean,System-Int32,System-Threading-CancellationToken- 'Trimble.ID.IAuthenticator.Login(System.Boolean,System.Int32,System.Threading.CancellationToken)')
  - [Logout(singleSignOut,cancellationToken)](#M-Trimble-ID-IAuthenticator-Logout-System-Boolean,System-Threading-CancellationToken- 'Trimble.ID.IAuthenticator.Logout(System.Boolean,System.Threading.CancellationToken)')
- [IClaimsetProvider](#T-Trimble-ID-IClaimsetProvider 'Trimble.ID.IClaimsetProvider')
  - [RetrieveClaimset()](#M-Trimble-ID-IClaimsetProvider-RetrieveClaimset-System-String- 'Trimble.ID.IClaimsetProvider.RetrieveClaimset(System.String)')
- [IEndpointProvider](#T-Trimble-ID-IEndpointProvider 'Trimble.ID.IEndpointProvider')
  - [RetrieveAuthorizationEndpoint()](#M-Trimble-ID-IEndpointProvider-RetrieveAuthorizationEndpoint 'Trimble.ID.IEndpointProvider.RetrieveAuthorizationEndpoint')
  - [RetrieveDeviceAuthorizationEndpoint()](#M-Trimble-ID-IEndpointProvider-RetrieveDeviceAuthorizationEndpoint 'Trimble.ID.IEndpointProvider.RetrieveDeviceAuthorizationEndpoint')
  - [RetrieveEndSessionEndpoint()](#M-Trimble-ID-IEndpointProvider-RetrieveEndSessionEndpoint 'Trimble.ID.IEndpointProvider.RetrieveEndSessionEndpoint')
  - [RetrieveJSONWebKeySetEndpoint()](#M-Trimble-ID-IEndpointProvider-RetrieveJSONWebKeySetEndpoint 'Trimble.ID.IEndpointProvider.RetrieveJSONWebKeySetEndpoint')
  - [RetrieveTokenEndpoint()](#M-Trimble-ID-IEndpointProvider-RetrieveTokenEndpoint 'Trimble.ID.IEndpointProvider.RetrieveTokenEndpoint')
  - [RetrieveTokenRevocationEndpoint()](#M-Trimble-ID-IEndpointProvider-RetrieveTokenRevocationEndpoint 'Trimble.ID.IEndpointProvider.RetrieveTokenRevocationEndpoint')
  - [RetrieveUserInfoEndpoint()](#M-Trimble-ID-IEndpointProvider-RetrieveUserInfoEndpoint 'Trimble.ID.IEndpointProvider.RetrieveUserInfoEndpoint')
- [IHttpClientProvider](#T-Trimble-ID-IHttpClientProvider 'Trimble.ID.IHttpClientProvider')
  - [RetrieveClient()](#M-Trimble-ID-IHttpClientProvider-RetrieveClient 'Trimble.ID.IHttpClientProvider.RetrieveClient')
  - [SetHttpMessageHandler(handler)](#M-Trimble-ID-IHttpClientProvider-SetHttpMessageHandler-System-Net-Http-HttpMessageHandler- 'Trimble.ID.IHttpClientProvider.SetHttpMessageHandler(System.Net.Http.HttpMessageHandler)')
- [IKeySetProvider](#T-Trimble-ID-IKeySetProvider 'Trimble.ID.IKeySetProvider')
  - [RetrieveKeySet()](#M-Trimble-ID-IKeySetProvider-RetrieveKeySet 'Trimble.ID.IKeySetProvider.RetrieveKeySet')
- [IPersistantStorage](#T-Trimble-ID-IPersistantStorage 'Trimble.ID.IPersistantStorage')
  - [GetItem()](#M-Trimble-ID-IPersistantStorage-GetItem-System-String- 'Trimble.ID.IPersistantStorage.GetItem(System.String)')
  - [RemoveItem()](#M-Trimble-ID-IPersistantStorage-RemoveItem-System-String- 'Trimble.ID.IPersistantStorage.RemoveItem(System.String)')
  - [SetItem()](#M-Trimble-ID-IPersistantStorage-SetItem-System-String,System-String- 'Trimble.ID.IPersistantStorage.SetItem(System.String,System.String)')
- [ITokenProvider](#T-Trimble-ID-ITokenProvider 'Trimble.ID.ITokenProvider')
  - [RetrieveToken()](#M-Trimble-ID-ITokenProvider-RetrieveToken 'Trimble.ID.ITokenProvider.RetrieveToken')
- [IsolatedFileStorage](#T-Trimble-ID-IsolatedFileStorage 'Trimble.ID.IsolatedFileStorage')
  - [#ctor()](#M-Trimble-ID-IsolatedFileStorage-#ctor-System-String- 'Trimble.ID.IsolatedFileStorage.#ctor(System.String)')
  - [GetItem()](#M-Trimble-ID-IsolatedFileStorage-GetItem-System-String- 'Trimble.ID.IsolatedFileStorage.GetItem(System.String)')
  - [RemoveItem()](#M-Trimble-ID-IsolatedFileStorage-RemoveItem-System-String- 'Trimble.ID.IsolatedFileStorage.RemoveItem(System.String)')
  - [SetItem()](#M-Trimble-ID-IsolatedFileStorage-SetItem-System-String,System-String- 'Trimble.ID.IsolatedFileStorage.SetItem(System.String,System.String)')
- [OnBehalfGrantTokenProvider](#T-Trimble-ID-OnBehalfGrantTokenProvider 'Trimble.ID.OnBehalfGrantTokenProvider')
  - [#ctor(endpointProvider,consumerKey,consumerSecret,accessToken,productName)](#M-Trimble-ID-OnBehalfGrantTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String,System-String,System-String- 'Trimble.ID.OnBehalfGrantTokenProvider.#ctor(Trimble.ID.IEndpointProvider,System.String,System.String,System.String,System.String)')
  - [RetrieveToken()](#M-Trimble-ID-OnBehalfGrantTokenProvider-RetrieveToken 'Trimble.ID.OnBehalfGrantTokenProvider.RetrieveToken')
  - [WithScopes(scopes)](#M-Trimble-ID-OnBehalfGrantTokenProvider-WithScopes-System-Collections-Generic-IEnumerable{System-String}- 'Trimble.ID.OnBehalfGrantTokenProvider.WithScopes(System.Collections.Generic.IEnumerable{System.String})')
- [OpenIdEndpointProvider](#T-Trimble-ID-OpenIdEndpointProvider 'Trimble.ID.OpenIdEndpointProvider')
  - [#ctor(configurationEndpoint,productName)](#M-Trimble-ID-OpenIdEndpointProvider-#ctor-System-Uri,System-String- 'Trimble.ID.OpenIdEndpointProvider.#ctor(System.Uri,System.String)')
  - [#ctor(configurationEndpoint,tokenRevocationEndpoint)](#M-Trimble-ID-OpenIdEndpointProvider-#ctor-System-Uri,System-Uri- 'Trimble.ID.OpenIdEndpointProvider.#ctor(System.Uri,System.Uri)')
  - [Production](#P-Trimble-ID-OpenIdEndpointProvider-Production 'Trimble.ID.OpenIdEndpointProvider.Production')
  - [Staging](#P-Trimble-ID-OpenIdEndpointProvider-Staging 'Trimble.ID.OpenIdEndpointProvider.Staging')
  - [RetrieveAuthorizationEndpoint()](#M-Trimble-ID-OpenIdEndpointProvider-RetrieveAuthorizationEndpoint 'Trimble.ID.OpenIdEndpointProvider.RetrieveAuthorizationEndpoint')
  - [RetrieveDeviceAuthorizationEndpoint()](#M-Trimble-ID-OpenIdEndpointProvider-RetrieveDeviceAuthorizationEndpoint 'Trimble.ID.OpenIdEndpointProvider.RetrieveDeviceAuthorizationEndpoint')
  - [RetrieveEndSessionEndpoint()](#M-Trimble-ID-OpenIdEndpointProvider-RetrieveEndSessionEndpoint 'Trimble.ID.OpenIdEndpointProvider.RetrieveEndSessionEndpoint')
  - [RetrieveJSONWebKeySetEndpoint()](#M-Trimble-ID-OpenIdEndpointProvider-RetrieveJSONWebKeySetEndpoint 'Trimble.ID.OpenIdEndpointProvider.RetrieveJSONWebKeySetEndpoint')
  - [RetrieveTokenEndpoint()](#M-Trimble-ID-OpenIdEndpointProvider-RetrieveTokenEndpoint 'Trimble.ID.OpenIdEndpointProvider.RetrieveTokenEndpoint')
  - [RetrieveTokenRevocationEndpoint()](#M-Trimble-ID-OpenIdEndpointProvider-RetrieveTokenRevocationEndpoint 'Trimble.ID.OpenIdEndpointProvider.RetrieveTokenRevocationEndpoint')
  - [RetrieveUserInfoEndpoint()](#M-Trimble-ID-OpenIdEndpointProvider-RetrieveUserInfoEndpoint 'Trimble.ID.OpenIdEndpointProvider.RetrieveUserInfoEndpoint')
- [OpenIdKeySetProvider](#T-Trimble-ID-OpenIdKeySetProvider 'Trimble.ID.OpenIdKeySetProvider')
  - [#ctor(endpointProvider,productName)](#M-Trimble-ID-OpenIdKeySetProvider-#ctor-Trimble-ID-IEndpointProvider,System-String- 'Trimble.ID.OpenIdKeySetProvider.#ctor(Trimble.ID.IEndpointProvider,System.String)')
  - [RetrieveKeySet()](#M-Trimble-ID-OpenIdKeySetProvider-RetrieveKeySet 'Trimble.ID.OpenIdKeySetProvider.RetrieveKeySet')
- [RefreshableTokenProvider](#T-Trimble-ID-RefreshableTokenProvider 'Trimble.ID.RefreshableTokenProvider')
  - [#ctor(endpointProvider,consumerKey,productName)](#M-Trimble-ID-RefreshableTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String- 'Trimble.ID.RefreshableTokenProvider.#ctor(Trimble.ID.IEndpointProvider,System.String,System.String)')
  - [#ctor(endpointProvider,consumerKey,consumerSecret,accessToken,tokenExpiry,idToken,refreshToken)](#M-Trimble-ID-RefreshableTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String,System-String,System-DateTime,System-String,System-String- 'Trimble.ID.RefreshableTokenProvider.#ctor(Trimble.ID.IEndpointProvider,System.String,System.String,System.String,System.DateTime,System.String,System.String)')
- [RefreshableTokenProvider\`1](#T-Trimble-ID-RefreshableTokenProvider`1 'Trimble.ID.RefreshableTokenProvider`1')
  - [#ctor(endpointProvider,consumerKey,productName)](#M-Trimble-ID-RefreshableTokenProvider`1-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String- 'Trimble.ID.RefreshableTokenProvider`1.#ctor(Trimble.ID.IEndpointProvider,System.String,System.String)')
  - [#ctor(endpointProvider,consumerKey,consumerSecret,accessToken,tokenExpiry,idToken,refreshToken)](#M-Trimble-ID-RefreshableTokenProvider`1-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String,System-String,System-DateTime,System-String,System-String- 'Trimble.ID.RefreshableTokenProvider`1.#ctor(Trimble.ID.IEndpointProvider,System.String,System.String,System.String,System.DateTime,System.String,System.String)')
  - [_codeVerifier](#F-Trimble-ID-RefreshableTokenProvider`1-_codeVerifier 'Trimble.ID.RefreshableTokenProvider`1._codeVerifier')
  - [_consumerKey](#F-Trimble-ID-RefreshableTokenProvider`1-_consumerKey 'Trimble.ID.RefreshableTokenProvider`1._consumerKey')
  - [_consumerSecret](#F-Trimble-ID-RefreshableTokenProvider`1-_consumerSecret 'Trimble.ID.RefreshableTokenProvider`1._consumerSecret')
  - [_endpointProvider](#F-Trimble-ID-RefreshableTokenProvider`1-_endpointProvider 'Trimble.ID.RefreshableTokenProvider`1._endpointProvider')
  - [_idToken](#F-Trimble-ID-RefreshableTokenProvider`1-_idToken 'Trimble.ID.RefreshableTokenProvider`1._idToken')
  - [_messageHandler](#F-Trimble-ID-RefreshableTokenProvider`1-_messageHandler 'Trimble.ID.RefreshableTokenProvider`1._messageHandler')
  - [_timeProvider](#F-Trimble-ID-RefreshableTokenProvider`1-_timeProvider 'Trimble.ID.RefreshableTokenProvider`1._timeProvider')
  - [GenerateCodeVerifier()](#M-Trimble-ID-RefreshableTokenProvider`1-GenerateCodeVerifier 'Trimble.ID.RefreshableTokenProvider`1.GenerateCodeVerifier')
  - [RetrieveCodeVerifier()](#M-Trimble-ID-RefreshableTokenProvider`1-RetrieveCodeVerifier 'Trimble.ID.RefreshableTokenProvider`1.RetrieveCodeVerifier')
  - [RetrieveIdToken()](#M-Trimble-ID-RefreshableTokenProvider`1-RetrieveIdToken 'Trimble.ID.RefreshableTokenProvider`1.RetrieveIdToken')
  - [RetrieveRefreshToken()](#M-Trimble-ID-RefreshableTokenProvider`1-RetrieveRefreshToken 'Trimble.ID.RefreshableTokenProvider`1.RetrieveRefreshToken')
  - [RetrieveToken()](#M-Trimble-ID-RefreshableTokenProvider`1-RetrieveToken 'Trimble.ID.RefreshableTokenProvider`1.RetrieveToken')
  - [RevokeRefreshToken()](#M-Trimble-ID-RefreshableTokenProvider`1-RevokeRefreshToken 'Trimble.ID.RefreshableTokenProvider`1.RevokeRefreshToken')
  - [WithAccessToken(accessToken,tokenExpiry)](#M-Trimble-ID-RefreshableTokenProvider`1-WithAccessToken-System-String,System-DateTime- 'Trimble.ID.RefreshableTokenProvider`1.WithAccessToken(System.String,System.DateTime)')
  - [WithConsumerSecret(consumerSecret)](#M-Trimble-ID-RefreshableTokenProvider`1-WithConsumerSecret-System-String- 'Trimble.ID.RefreshableTokenProvider`1.WithConsumerSecret(System.String)')
  - [WithIdToken(idToken)](#M-Trimble-ID-RefreshableTokenProvider`1-WithIdToken-System-String- 'Trimble.ID.RefreshableTokenProvider`1.WithIdToken(System.String)')
  - [WithPersistentStorage(persistentStorage)](#M-Trimble-ID-RefreshableTokenProvider`1-WithPersistentStorage-Trimble-ID-IPersistantStorage- 'Trimble.ID.RefreshableTokenProvider`1.WithPersistentStorage(Trimble.ID.IPersistantStorage)')
  - [WithProofKeyForCodeExchange(codeVerifier)](#M-Trimble-ID-RefreshableTokenProvider`1-WithProofKeyForCodeExchange-System-String- 'Trimble.ID.RefreshableTokenProvider`1.WithProofKeyForCodeExchange(System.String)')
  - [WithRefreshToken(refreshToken)](#M-Trimble-ID-RefreshableTokenProvider`1-WithRefreshToken-System-String- 'Trimble.ID.RefreshableTokenProvider`1.WithRefreshToken(System.String)')
  - [_GenerateCodeChallenge()](#M-Trimble-ID-RefreshableTokenProvider`1-_GenerateCodeChallenge-System-String- 'Trimble.ID.RefreshableTokenProvider`1._GenerateCodeChallenge(System.String)')
- [SelfSignedTokenProvider](#T-Trimble-ID-SelfSignedTokenProvider 'Trimble.ID.SelfSignedTokenProvider')
  - [#ctor(privateKey,payload)](#M-Trimble-ID-SelfSignedTokenProvider-#ctor-System-String,Newtonsoft-Json-Linq-JObject- 'Trimble.ID.SelfSignedTokenProvider.#ctor(System.String,Newtonsoft.Json.Linq.JObject)')
  - [RetrieveToken()](#M-Trimble-ID-SelfSignedTokenProvider-RetrieveToken 'Trimble.ID.SelfSignedTokenProvider.RetrieveToken')
- [TokenValidationOptions](#T-Trimble-ID-TokenValidationOptions 'Trimble.ID.TokenValidationOptions')
  - [ClockSkew](#P-Trimble-ID-TokenValidationOptions-ClockSkew 'Trimble.ID.TokenValidationOptions.ClockSkew')
- [UserInfo](#T-Trimble-ID-UserInfo 'Trimble.ID.UserInfo')
  - [Email](#P-Trimble-ID-UserInfo-Email 'Trimble.ID.UserInfo.Email')
  - [EmailVerified](#P-Trimble-ID-UserInfo-EmailVerified 'Trimble.ID.UserInfo.EmailVerified')
  - [FamilyName](#P-Trimble-ID-UserInfo-FamilyName 'Trimble.ID.UserInfo.FamilyName')
  - [GivenName](#P-Trimble-ID-UserInfo-GivenName 'Trimble.ID.UserInfo.GivenName')
  - [Id](#P-Trimble-ID-UserInfo-Id 'Trimble.ID.UserInfo.Id')
  - [Picture](#P-Trimble-ID-UserInfo-Picture 'Trimble.ID.UserInfo.Picture')
- [ValidatedClaimsetProvider](#T-Trimble-ID-ValidatedClaimsetProvider 'Trimble.ID.ValidatedClaimsetProvider')
  - [#ctor(keysetProvider,productName)](#M-Trimble-ID-ValidatedClaimsetProvider-#ctor-Trimble-ID-IKeySetProvider,System-String- 'Trimble.ID.ValidatedClaimsetProvider.#ctor(Trimble.ID.IKeySetProvider,System.String)')
  - [RetrieveClaimset()](#M-Trimble-ID-ValidatedClaimsetProvider-RetrieveClaimset-System-String- 'Trimble.ID.ValidatedClaimsetProvider.RetrieveClaimset(System.String)')
  - [WithOptions(options)](#M-Trimble-ID-ValidatedClaimsetProvider-WithOptions-Trimble-ID-TokenValidationOptions- 'Trimble.ID.ValidatedClaimsetProvider.WithOptions(Trimble.ID.TokenValidationOptions)')

<a name='T-Trimble-ID-AuthorizationCodeGrantTokenProvider'></a>
## AuthorizationCodeGrantTokenProvider `type`

##### Namespace

Trimble.ID

##### Summary

A token provider based on the OAuth Authorization Code grant type

##### Example

```csharp
const string CONSUMER_KEY = "APPLICATION_CONSUMER_KEY";
const string CONSUMER_SECRET = "APPLICATION_CONSUMER_SECRET";
const string REDIRECT_URL = "http://localhost:8080";
const string AUTHORIZATION_ENDPOINT = "https://id.trimble.com/oauth/authorize";
const string TOKEN_ENDPOINT = "https://id.trimble.com/oauth/token?tenantDomain=trimble.com";
var endpointProvider = new FixedEndpointProvider(new Uri(AUTHORIZATION_ENDPOINT, UriKind.Absolute), new Uri(TOKEN_ENDPOINT, UriKind.Absolute));
var tokenProvider = new AuthorizationCodeGrantTokenProvider(endpointProvider, CONSUMER_KEY, REDIRECT_URL)
   .WithConsumerSecret(CONSUMER_SECRET)
   .WithScopes(new[] string { "scope" });
var token = await tokenProvider.RetrieveToken();
```

##### Remarks

Implements ITokenProvider

<a name='M-Trimble-ID-AuthorizationCodeGrantTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String,System-String-'></a>
### #ctor(endpointProvider,consumerKey,redirectUrl,productName) `constructor`

##### Summary

Public constructor for AuthorizationCodeGrantTokenProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpointProvider | [Trimble.ID.IEndpointProvider](#T-Trimble-ID-IEndpointProvider 'Trimble.ID.IEndpointProvider') | An endpoint provider that provides the URL for the Trimble Identity authorization and token endpoints |
| consumerKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer key for the calling application |
| redirectUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URL to which Trimble Identity should redirect after successfully authenticating a user |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The product name of the consuming application (Optional). |

<a name='M-Trimble-ID-AuthorizationCodeGrantTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-Uri,System-String-'></a>
### #ctor(endpointProvider,consumerKey,redirectUri,productName) `constructor`

##### Summary

Public constructor for AuthorizationCodeGrantTokenProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpointProvider | [Trimble.ID.IEndpointProvider](#T-Trimble-ID-IEndpointProvider 'Trimble.ID.IEndpointProvider') | An endpoint provider that provides the URL for the Trimble Identity authorization and token endpoints |
| consumerKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer key for the calling application |
| redirectUri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL to which Trimble Identity should redirect after successfully authenticating a user |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The product name of the consuming application (Optional). |

##### Remarks

This is provided as a convienence method, be aware it is critical to ensure that redirectUri.AbsoluteUri matches the value specified when creating the application

<a name='P-Trimble-ID-AuthorizationCodeGrantTokenProvider-State'></a>
### State `property`

<a name='M-Trimble-ID-AuthorizationCodeGrantTokenProvider-GetOAuthLogoutRedirect-System-String-'></a>
### GetOAuthLogoutRedirect(state) `method`

##### Summary

Return a redirect URL to log out of all Trimble Identity applications

##### Returns

A Task that resolves to the value of the redirect URL on completion

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| state | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | An optional state parameter that will be passed back to the caller via the redirect URL |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when an ID token is not available |

<a name='M-Trimble-ID-AuthorizationCodeGrantTokenProvider-GetOAuthRedirect-System-String-'></a>
### GetOAuthRedirect(state) `method`

##### Summary

Get a redirect URL for Trimble Identity

##### Returns

An awaitable Task that resolves to the redirect URL

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| state | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | An optional state parameter that will be passed back to the caller via the redirect URL |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when an authorization endpoint is not provided by the endpoint provider |

<a name='M-Trimble-ID-AuthorizationCodeGrantTokenProvider-ValidateCode-System-String-'></a>
### ValidateCode(code) `method`

##### Summary

Validate the code parameter passed to the application by Trimble Identity

##### Returns

True if the code is valid

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The code query string from the URL |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a token endpoint is not provided by the endpoint provider |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a call to the token endpoint fails |

<a name='M-Trimble-ID-AuthorizationCodeGrantTokenProvider-ValidateQuery-System-String-'></a>
### ValidateQuery(query) `method`

##### Summary

Validate the query parameters passed back to the application by Trimble Identity

##### Returns

True if the query string is valid

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The query string from the URL |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a token endpoint is not provided by the endpoint provider |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a call to the token endpoint fails |

<a name='M-Trimble-ID-AuthorizationCodeGrantTokenProvider-WithIdentityProvider-System-String-'></a>
### WithIdentityProvider(identityProvider) `method`

##### Summary

Add Identity Provider to the authorization URL

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| identityProvider | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | An optional parameter which specifies a federated identity provider that should be used to authenticate |

<a name='M-Trimble-ID-AuthorizationCodeGrantTokenProvider-WithLogoutRedirect-System-String-'></a>
### WithLogoutRedirect(logoutRedirectUrl) `method`

##### Summary

Add Redirect URL to an AuthorizationCodeGrantTokenProvider

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logoutRedirectUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A URL which the browser will return to after logout |

##### Remarks

This URL must match one of the URLs configured for the calling client

<a name='M-Trimble-ID-AuthorizationCodeGrantTokenProvider-WithLogoutRedirect-System-Uri-'></a>
### WithLogoutRedirect(logoutRedirectUri) `method`

##### Summary

Add Redirect URL to an AuthorizationCodeGrantTokenProvider

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logoutRedirectUri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | A URL which the browser will return to after logout |

##### Remarks

This URL must match one of the URLs configured for the calling client

<a name='M-Trimble-ID-AuthorizationCodeGrantTokenProvider-WithScopes-System-Collections-Generic-IEnumerable{System-String}-'></a>
### WithScopes(scopes) `method`

##### Summary

Fluent extension for adding scopes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scopes | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | The requested scopes |

<a name='T-Trimble-ID-BearerTokenHttpClientProvider'></a>
## BearerTokenHttpClientProvider `type`

##### Namespace

Trimble.ID

##### Summary

A HttpClient provider for APIs using Bearer token authorization

##### Example

```csharp
const string API_BASE_URL = "https://api-usw2.trimblepaas.com/data_ocean-v1.0";
const string TOKEN = "USER_OR_APPLICATION_ACCESS_TOKEN";
var tokenProvider = new FixedTokenProvider(TOKEN);
var httpclientProvider = new BearerTokenHttpClientProvider(tokenProvider, new Uri(API_BASE_URL, UriKind.Absolute));
var httpClient = await httpclientProvider.RetrieveClient();
```

##### Remarks

Implements IHttpClientProvider

<a name='M-Trimble-ID-BearerTokenHttpClientProvider-#ctor-Trimble-ID-ITokenProvider,System-Uri,System-String-'></a>
### #ctor(tokenProvider,baseAddress,productName) `constructor`

##### Summary

Public constructor for BearerTokenHttpClientProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenProvider | [Trimble.ID.ITokenProvider](#T-Trimble-ID-ITokenProvider 'Trimble.ID.ITokenProvider') | A token provider that provides the access token for the authenticated application or user |
| baseAddress | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The base address for the API that will be called |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The product name of the consuming application (Optional). |

##### Remarks

Implements IHttpClientProvider

<a name='F-Trimble-ID-BearerTokenHttpClientProvider-Logger'></a>
### Logger `constants`

<a name='M-Trimble-ID-BearerTokenHttpClientProvider-RetrieveClient'></a>
### RetrieveClient() `method`

##### Summary

Retrieves a preconfigured HttpClient to access a given API

##### Returns

A Task that resolves to the value of the preconfigured HttpClient on completion

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a token is not provided by the token provider |

<a name='T-Trimble-ID-ClientCredentialTokenProvider'></a>
## ClientCredentialTokenProvider `type`

##### Namespace

Trimble.ID

##### Summary

A token provider based on the OAuth Client Credential grant type

##### Example

```csharp
const string CLIENT_ID = "APPLICATION_CLIENT_ID";
const string CLIENT_SECRET = "APPLICATION_CLIENT_SECRET";
const string TOKEN_ENDPOINT = "https://id.trimble.com/oauth/token?tenantDomain=trimble.com";
var endpointProvider = new FixedEndpointProvider(tokenEndpoint: new Uri(TOKEN_ENDPOINT, UriKind.Absolute));
var tokenProvider = new ClientCredentialTokenProvider(endpointProvider, CLIENT_ID, CLIENT_SECRET).WithScopes(new[] string { "scope" });
var token = await tokenProvider.RetrieveToken();
```

##### Remarks

Implements ITokenProvider

<a name='M-Trimble-ID-ClientCredentialTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String,System-String-'></a>
### #ctor(endpointProvider,consumerKey,consumerSecret,productName) `constructor`

##### Summary

Public constructor for ClientCredentialTokenProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpointProvider | [Trimble.ID.IEndpointProvider](#T-Trimble-ID-IEndpointProvider 'Trimble.ID.IEndpointProvider') | An endpoint provider that provides the URL for the Trimble Identity token endpoint |
| consumerKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer key for the calling application |
| consumerSecret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer secret for the calling application |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The product name of the consuming application (Optional). |

##### Remarks

Implements ITokenProvider

<a name='M-Trimble-ID-ClientCredentialTokenProvider-RetrieveToken'></a>
### RetrieveToken() `method`

##### Summary

Retrieves an access token for the application

##### Returns

A Task that resolves to the value of the access token on completion

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a token endpoint is not provided by the endpoint provider |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a call to the token endpoint fails |

<a name='M-Trimble-ID-ClientCredentialTokenProvider-WithScopes-System-Collections-Generic-IEnumerable{System-String}-'></a>
### WithScopes(scopes) `method`

##### Summary

Fluent extension for adding scopes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scopes | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | The requested scopes |

<a name='T-Trimble-ID-DeviceAuthorizationTokenProvider'></a>
## DeviceAuthorizationTokenProvider `type`

##### Namespace

Trimble.ID

##### Summary

A token provider based on the Device Authorization grant type

##### Remarks

Implements ITokenProvider

<a name='M-Trimble-ID-DeviceAuthorizationTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String-'></a>
### #ctor(endpointProvider,clientId,productName) `constructor`

##### Summary

Public constructor for DeviceAuthorizationTokenProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpointProvider | [Trimble.ID.IEndpointProvider](#T-Trimble-ID-IEndpointProvider 'Trimble.ID.IEndpointProvider') | An endpoint provider that provides the URL for the Trimble Identity token endpoint |
| clientId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer key for the calling application |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The product name of the consuming application (Optional). |

<a name='M-Trimble-ID-DeviceAuthorizationTokenProvider-CreateAuthorization'></a>
### CreateAuthorization() `method`

##### Summary

Request authorization

##### Returns

DeviceAuthorizationResponse that contains user code, device code and verification uri

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a call to the device authorization endpoint fails |

<a name='M-Trimble-ID-DeviceAuthorizationTokenProvider-PerformTokenRequest-System-String,System-Int32,System-Int32,System-Action{Trimble-ID-DeviceAuthorizationStatus},System-Threading-CancellationToken-'></a>
### PerformTokenRequest(deviceCode,pollInterval,timeout,onCallback) `method`

##### Summary

Performs token request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deviceCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Device code to perform token request |
| pollInterval | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Time interval between each request |
| timeout | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum time until the request times out |
| onCallback | [System.Action{Trimble.ID.DeviceAuthorizationStatus}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Trimble.ID.DeviceAuthorizationStatus}') | Callback method to check whether the device has been authorized |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.TimeoutException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeoutException 'System.TimeoutException') | Thrown when a token request times out |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a call to the token endpoint fails |

<a name='M-Trimble-ID-DeviceAuthorizationTokenProvider-RetrieveIdToken'></a>
### RetrieveIdToken() `method`

##### Summary

Retrieves a id token for the application

##### Returns

Id token

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-DeviceAuthorizationTokenProvider-RetrieveRefreshToken'></a>
### RetrieveRefreshToken() `method`

##### Summary

Retrieves a refresh token for the application

##### Returns

Refresh token

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-DeviceAuthorizationTokenProvider-RetrieveToken'></a>
### RetrieveToken() `method`

##### Summary

Retrieves an access token for the application

##### Returns

A Task that resolves to the value of the access token on completion

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a token endpoint is not provided by the endpoint provider |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a call to the token endpoint fails |

<a name='M-Trimble-ID-DeviceAuthorizationTokenProvider-WithClientSecret-System-String-'></a>
### WithClientSecret(clientSecret) `method`

##### Summary

Fluent extension for adding client secret

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientSecret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The client secret for the calling application |

<a name='M-Trimble-ID-DeviceAuthorizationTokenProvider-WithScopes-System-Collections-Generic-IEnumerable{System-String}-'></a>
### WithScopes(scopes) `method`

##### Summary

Fluent extension for adding scopes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scopes | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | The requested scopes |

<a name='T-Trimble-ID-EncryptedStorage'></a>
## EncryptedStorage `type`

##### Namespace

Trimble.ID

##### Summary

Wrapper for IPersistantStorage that adds encryption functionality

<a name='M-Trimble-ID-EncryptedStorage-#ctor-Trimble-ID-IPersistantStorage,System-Byte[]-'></a>
### #ctor() `constructor`

##### Summary

Constructor

##### Parameters

This constructor has no parameters.

<a name='M-Trimble-ID-EncryptedStorage-GetItem-System-String-'></a>
### GetItem() `method`

##### Summary

Retrieve a named value from persistant storage

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-EncryptedStorage-RemoveItem-System-String-'></a>
### RemoveItem() `method`

##### Summary

Remove a named value from persistant storage

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-EncryptedStorage-SetItem-System-String,System-String-'></a>
### SetItem() `method`

##### Summary

Store a named value in persistant storage

##### Parameters

This method has no parameters.

<a name='T-Trimble-ID-FixedEndpointProvider'></a>
## FixedEndpointProvider `type`

##### Namespace

Trimble.ID

##### Summary

An endpoint provider that returns fixed values

##### Example

```csharp
const string AUTHORIZATION_ENDPOINT = "https://id.trimble.com/oauth/authorize";
const string TOKEN_ENDPOINT = "https://id.trimble.com/oauth/token?tenantDomain=trimble.com";
var endpointProvider = new FixedEndpointProvider()
    .WithAuthorizationEndpoint(new Uri(AUTHORIZATION_ENDPOINT, UriKind.Absolute))
    .WithTokenEndpoint(new Uri(TOKEN_ENDPOINT, UriKind.Absolute));
var authorizationEndpoint = await endpointProvider.RetrieveAuthorizationEndpoint();
var tokenEndpoint = await endpointProvider.RetrieveTokenEndpoint();
```

##### Remarks

Implements IEndpointProvider

<a name='M-Trimble-ID-FixedEndpointProvider-#ctor-System-String-'></a>
### #ctor(productName) `constructor`

##### Summary

Public constructor for FixedEndpointProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The product name of the consuming application (Optional). |

<a name='M-Trimble-ID-FixedEndpointProvider-#ctor-Trimble-ID-FixedEndpointProvider-'></a>
### #ctor() `constructor`

##### Summary

Protected copy constructor for FixedEndpointProvider class

##### Parameters

This constructor has no parameters.

<a name='M-Trimble-ID-FixedEndpointProvider-#ctor-System-Uri,System-Uri,System-Uri,System-Uri,System-Uri,System-Uri,System-Uri-'></a>
### #ctor(authorizationEndpoint,tokenEndpoint,userInfoEndpoint,tokenRevocationEndpoint,jwksEndpoint,endSessionEndpoint) `constructor`

##### Summary

Public constructor for FixedEndpointProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| authorizationEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity authorization endpoint |
| tokenEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity token endpoint |
| userInfoEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity user information endpoint |
| tokenRevocationEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity token revocation endpoint, if not supplied this is computed relative to the token endpoint |
| jwksEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity JSON web keyset endpoint |
| endSessionEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity end session endpoint, if not supplied this is computed relative to the token endpoint |

##### Remarks

Implements IEndpointProvider

<a name='M-Trimble-ID-FixedEndpointProvider-RetrieveAuthorizationEndpoint'></a>
### RetrieveAuthorizationEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity authorization endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-FixedEndpointProvider-RetrieveDeviceAuthorizationEndpoint'></a>
### RetrieveDeviceAuthorizationEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity device authorization endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-FixedEndpointProvider-RetrieveEndSessionEndpoint'></a>
### RetrieveEndSessionEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity token revocation endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-FixedEndpointProvider-RetrieveJSONWebKeySetEndpoint'></a>
### RetrieveJSONWebKeySetEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity JSON web keyset endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-FixedEndpointProvider-RetrieveTokenEndpoint'></a>
### RetrieveTokenEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity token endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-FixedEndpointProvider-RetrieveTokenRevocationEndpoint'></a>
### RetrieveTokenRevocationEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity token revocation endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-FixedEndpointProvider-RetrieveUserInfoEndpoint'></a>
### RetrieveUserInfoEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity user information endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-FixedEndpointProvider-WithAuthorizationEndpoint-System-Uri-'></a>
### WithAuthorizationEndpoint(authorizationEndpoint) `method`

##### Summary

Add an authorization endpoint

##### Returns

A new instance of a FixedEndpointProvider

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| authorizationEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity authorization endpoint |

<a name='M-Trimble-ID-FixedEndpointProvider-WithDeviceAuthorizationEndpoint-System-Uri-'></a>
### WithDeviceAuthorizationEndpoint(jwksEndpoint) `method`

##### Returns

A new instance of a FixedEndpointProvider

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| jwksEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity device authorization endpoint |

<a name='M-Trimble-ID-FixedEndpointProvider-WithEndSessionEndpoint-System-Uri-'></a>
### WithEndSessionEndpoint(endSessionEndpoint) `method`

##### Summary

Add an end session endpoint

##### Returns

A new instance of a FixedEndpointProvider

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endSessionEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity end session endpoint, if not supplied this is computed relative to the token endpoint |

<a name='M-Trimble-ID-FixedEndpointProvider-WithJWKSEndpoint-System-Uri-'></a>
### WithJWKSEndpoint(jwksEndpoint) `method`

##### Summary

Add a JWKS endpoint

##### Returns

A new instance of a FixedEndpointProvider

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| jwksEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity JSON web keyset endpoint |

<a name='M-Trimble-ID-FixedEndpointProvider-WithTokenEndpoint-System-Uri-'></a>
### WithTokenEndpoint(tokenEndpoint) `method`

##### Summary

Add a token endpoint

##### Returns

A new instance of a FixedEndpointProvider

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity token endpoint |

<a name='M-Trimble-ID-FixedEndpointProvider-WithTokenRevocationEndpoint-System-Uri-'></a>
### WithTokenRevocationEndpoint(tokenRevocationEndpoint) `method`

##### Summary

Add a token revocation endpoint

##### Returns

A new instance of a FixedEndpointProvider

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenRevocationEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity token revocation endpoint, if not supplied this is computed relative to the token endpoint |

<a name='M-Trimble-ID-FixedEndpointProvider-WithUserInfoEndpoint-System-Uri-'></a>
### WithUserInfoEndpoint(userInfoEndpoint) `method`

##### Summary

Add a user info endpoint

##### Returns

A new instance of a FixedEndpointProvider

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userInfoEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity user information endpoint |

<a name='T-Trimble-ID-FixedKeySetProvider'></a>
## FixedKeySetProvider `type`

##### Namespace

Trimble.ID

##### Summary

A keyset provider that returns a fixed keyset

##### Example

```csharp
 var keyset = new Dictionary&lt;string, RSACryptoServiceProvider&gt;)();
 var key = new RSACryptoServiceProvider();
 key.ImportParameters(new RSAParameters()
 {
     Modulus = Base64Url.Decode("nzyis1ZjfNB0bBgK..."),
     Exponent = Base64Url.Decode("AQAB")
 });
 keyset.Add("31824ffd-777e-458a-a3b6-2808f64a0bdd", key);
 var keysetProvider = new FixedKeySetProvider(keyset);
 var keyset = await keysetProvider.RetrieveKeySet();
 
```

##### Remarks

Implements IKeysetProvider

<a name='M-Trimble-ID-FixedKeySetProvider-#ctor-System-Collections-Generic-Dictionary{System-String,System-Security-Cryptography-RSACryptoServiceProvider}-'></a>
### #ctor(keyset) `constructor`

##### Summary

Public constructor for FixedKeySetProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyset | [System.Collections.Generic.Dictionary{System.String,System.Security.Cryptography.RSACryptoServiceProvider}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.Security.Cryptography.RSACryptoServiceProvider}') | A dictionary of named keys |

##### Remarks

Implements IKeySetProvider

<a name='M-Trimble-ID-FixedKeySetProvider-RetrieveKeySet'></a>
### RetrieveKeySet() `method`

##### Summary

Retrieves an dictionary of named keys

##### Returns

A Task that resolves to a dictionary of named keys on completion

##### Parameters

This method has no parameters.

<a name='T-Trimble-ID-FixedTokenProvider'></a>
## FixedTokenProvider `type`

##### Namespace

Trimble.ID

##### Summary

A token provider that returns a fixed token

##### Example

```csharp
const string TOKEN = "USER_OR_APPLICATION_ACCESS_TOKEN";
var tokenProvider = new FixedTokenProvider(TOKEN);
var token = await tokenProvider.RetrieveToken();
```

##### Remarks

Implements ITokenProvider

<a name='M-Trimble-ID-FixedTokenProvider-#ctor-System-String,System-String-'></a>
### #ctor(token,productName) `constructor`

##### Summary

Public constructor for FixedTokenProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| token | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The fixed token to return |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The product name of the consuming application (Optional). |

##### Remarks

Implements ITokenProvider

<a name='M-Trimble-ID-FixedTokenProvider-RetrieveToken'></a>
### RetrieveToken() `method`

##### Summary

Retrieves an access token for the user or application

##### Returns

A Task that resolves to the value of the access token on completion

##### Parameters

This method has no parameters.

<a name='T-Trimble-ID-IAuthenticator'></a>
## IAuthenticator `type`

##### Namespace

Trimble.ID

##### Summary

Common interface for authenticators

<a name='P-Trimble-ID-IAuthenticator-IsLoggedIn'></a>
### IsLoggedIn `property`

##### Summary

Get the logged in state

<a name='P-Trimble-ID-IAuthenticator-LegacyTokenProvider'></a>
### LegacyTokenProvider `property`

##### Summary

Get the token provider for this authenticator

##### Remarks

This token provider can be used with other SDK components

<a name='P-Trimble-ID-IAuthenticator-TokenProvider'></a>
### TokenProvider `property`

##### Summary

Get the token provider for this authenticator

##### Remarks

This token provider can be used with other SDK components

<a name='M-Trimble-ID-IAuthenticator-GetUserInfo'></a>
### GetUserInfo() `method`

##### Summary

Validates the ID token and returns user claims

##### Returns

User claims from the ID token

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-IAuthenticator-Login-System-Boolean,System-Int32,System-Threading-CancellationToken-'></a>
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
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Token which can be used to cancel the task. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.TimeoutException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeoutException 'System.TimeoutException') | Login operation has timed out after waiting for specified time. |
| [System.Threading.Tasks.TaskCanceledException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.TaskCanceledException 'System.Threading.Tasks.TaskCanceledException') | The task is cancelled for specified time. |

<a name='M-Trimble-ID-IAuthenticator-Logout-System-Boolean,System-Threading-CancellationToken-'></a>
### Logout(singleSignOut,cancellationToken) `method`

##### Summary

Log the user out

##### Returns

true if the user was successfully logged out

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| singleSignOut | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if the single sign in session should be terminated |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Token which can be used to cancel the task. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Threading.Tasks.TaskCanceledException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.TaskCanceledException 'System.Threading.Tasks.TaskCanceledException') | The task is cancelled for specified time. |

<a name='T-Trimble-ID-IClaimsetProvider'></a>
## IClaimsetProvider `type`

##### Namespace

Trimble.ID

##### Summary

Common interface for claimset providers

<a name='M-Trimble-ID-IClaimsetProvider-RetrieveClaimset-System-String-'></a>
### RetrieveClaimset() `method`

##### Summary

Retrieves a validate claimset from a given JSON web token

##### Returns

A Task that resolves to the claimset completion

##### Parameters

This method has no parameters.

<a name='T-Trimble-ID-IEndpointProvider'></a>
## IEndpointProvider `type`

##### Namespace

Trimble.ID

##### Summary

Common interface for endpoint providers

<a name='M-Trimble-ID-IEndpointProvider-RetrieveAuthorizationEndpoint'></a>
### RetrieveAuthorizationEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity authorization endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-IEndpointProvider-RetrieveDeviceAuthorizationEndpoint'></a>
### RetrieveDeviceAuthorizationEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity device authorization endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-IEndpointProvider-RetrieveEndSessionEndpoint'></a>
### RetrieveEndSessionEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity end session endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-IEndpointProvider-RetrieveJSONWebKeySetEndpoint'></a>
### RetrieveJSONWebKeySetEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity JSON web keyset endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-IEndpointProvider-RetrieveTokenEndpoint'></a>
### RetrieveTokenEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity token endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-IEndpointProvider-RetrieveTokenRevocationEndpoint'></a>
### RetrieveTokenRevocationEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity token revocation endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-IEndpointProvider-RetrieveUserInfoEndpoint'></a>
### RetrieveUserInfoEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity user information endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

<a name='T-Trimble-ID-IHttpClientProvider'></a>
## IHttpClientProvider `type`

##### Namespace

Trimble.ID

##### Summary

Common interface for all HTTP client providers

<a name='M-Trimble-ID-IHttpClientProvider-RetrieveClient'></a>
### RetrieveClient() `method`

##### Summary

Retrieves a preconfigured HttpClient to access a given API

##### Returns

A Task that resolves to the value of the preconfigured HttpClient on completion

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-IHttpClientProvider-SetHttpMessageHandler-System-Net-Http-HttpMessageHandler-'></a>
### SetHttpMessageHandler(handler) `method`

##### Summary

Sets an additional and optional [HttpMessageHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMessageHandler 'System.Net.Http.HttpMessageHandler').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| handler | [System.Net.Http.HttpMessageHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMessageHandler 'System.Net.Http.HttpMessageHandler') | The handler. |

<a name='T-Trimble-ID-IKeySetProvider'></a>
## IKeySetProvider `type`

##### Namespace

Trimble.ID

##### Summary

Common interface for all key set providers

<a name='M-Trimble-ID-IKeySetProvider-RetrieveKeySet'></a>
### RetrieveKeySet() `method`

##### Summary

Returns a Task that resolves to a key set

##### Parameters

This method has no parameters.

<a name='T-Trimble-ID-IPersistantStorage'></a>
## IPersistantStorage `type`

##### Namespace

Trimble.ID

##### Summary

Interface for persistant storage

<a name='M-Trimble-ID-IPersistantStorage-GetItem-System-String-'></a>
### GetItem() `method`

##### Summary

Retrieve a named value from persistant storage

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-IPersistantStorage-RemoveItem-System-String-'></a>
### RemoveItem() `method`

##### Summary

Remove a named value from persistant storage

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-IPersistantStorage-SetItem-System-String,System-String-'></a>
### SetItem() `method`

##### Summary

Store a named value in persistant storage

##### Parameters

This method has no parameters.

<a name='T-Trimble-ID-ITokenProvider'></a>
## ITokenProvider `type`

##### Namespace

Trimble.ID

##### Summary

Interface implemented by all token providers

<a name='M-Trimble-ID-ITokenProvider-RetrieveToken'></a>
### RetrieveToken() `method`

##### Summary

Retrieves an access token for the authenticated application or user

##### Returns

A Task that resolves to the value of the access token on completion

##### Parameters

This method has no parameters.

<a name='T-Trimble-ID-IsolatedFileStorage'></a>
## IsolatedFileStorage `type`

##### Namespace

Trimble.ID

##### Summary

Wrapper for IPersistantStorage that adds encryption functionality

<a name='M-Trimble-ID-IsolatedFileStorage-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Constructor

##### Parameters

This constructor has no parameters.

<a name='M-Trimble-ID-IsolatedFileStorage-GetItem-System-String-'></a>
### GetItem() `method`

##### Summary

Retrieve a named value from persistant storage

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-IsolatedFileStorage-RemoveItem-System-String-'></a>
### RemoveItem() `method`

##### Summary

Remove a named value from persistant storage

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-IsolatedFileStorage-SetItem-System-String,System-String-'></a>
### SetItem() `method`

##### Summary

Store a named value in persistant storage

##### Parameters

This method has no parameters.

<a name='T-Trimble-ID-OnBehalfGrantTokenProvider'></a>
## OnBehalfGrantTokenProvider `type`

##### Namespace

Trimble.ID

##### Summary

A token provider based on the OAuth On Behalf grant type

##### Example

```csharp
const string CLIENT_ID = "APPLICATION_CLIENT_ID";
const string CLIENT_SECRET = "APPLICATION_CLIENT_SECRET";
var accessToken = "CALLERS_ACCESS_TOKEN";
const string TOKEN_ENDPOINT = "https://id.trimble.com/oauth/token";
var endpointProvider = new FixedEndpointProvider(tokenEndpoint: new Uri(TOKEN_ENDPOINT, UriKind.Absolute));
var tokenProvider = new OnBehalfGrantTokenProvider(endpointProvider, CLIENT_ID, CLIENT_SECRET, accessToken);
var token = await tokenProvider.RetrieveToken();
```

##### Remarks

Implements ITokenProvider

<a name='M-Trimble-ID-OnBehalfGrantTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String,System-String,System-String-'></a>
### #ctor(endpointProvider,consumerKey,consumerSecret,accessToken,productName) `constructor`

##### Summary

Public constructor for OnBehalfTokenProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpointProvider | [Trimble.ID.IEndpointProvider](#T-Trimble-ID-IEndpointProvider 'Trimble.ID.IEndpointProvider') | An endpoint provider that provides the URL for the Trimble Identity token endpoints |
| consumerKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer key for the calling application |
| consumerSecret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer secret for the calling application |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The access token for the authenticated user that this application wishes to act on behalf of when calling another API |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The product name of the consuming application (Optional). |

##### Remarks

Implements ITokenProvider

<a name='M-Trimble-ID-OnBehalfGrantTokenProvider-RetrieveToken'></a>
### RetrieveToken() `method`

##### Summary

Retrieves an access token for the application

##### Returns

A Task that resolves to the value of the access token on completion

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a token endpoint is not provided by the endpoint provider |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a call to the token endpoint fails |

<a name='M-Trimble-ID-OnBehalfGrantTokenProvider-WithScopes-System-Collections-Generic-IEnumerable{System-String}-'></a>
### WithScopes(scopes) `method`

##### Summary

Fluent extension for adding scopes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scopes | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | The requested scopes |

<a name='T-Trimble-ID-OpenIdEndpointProvider'></a>
## OpenIdEndpointProvider `type`

##### Namespace

Trimble.ID

##### Summary

An endpoint provider that returns values from a OpenID well known configuration

##### Example

```csharp
const string PROD_CONFIGURATION_ENDPOINT = "https://id.trimble.com/.well-known/openid-configuration";
const string STAGE_CONFIGURATION_ENDPOINT = "https://stage.id.trimblecloud.com/.well-known/openid-configuration";
var endpointProvider = new OpenIdEndpointProvider(new Uri(PROD_CONFIGURATION_ENDPOINT, UriKind.Absolute));
var authorizationEndpoint = await endpointProvider.RetrieveAuthorizationEndpoint();
var tokenEndpoint = await endpointProvider.RetrieveTokenEndpoint();
```

##### Remarks

Implements IEndpointProvider

<a name='M-Trimble-ID-OpenIdEndpointProvider-#ctor-System-Uri,System-String-'></a>
### #ctor(configurationEndpoint,productName) `constructor`

##### Summary

Public constructor for OpenIdEndpointProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configurationEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity OpenID well know configuration endpoint |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The product name of the consuming application (optional). |

<a name='M-Trimble-ID-OpenIdEndpointProvider-#ctor-System-Uri,System-Uri-'></a>
### #ctor(configurationEndpoint,tokenRevocationEndpoint) `constructor`

##### Summary

Public constructor for OpenIdEndpointProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configurationEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity OpenID well know configuration endpoint |
| tokenRevocationEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity token revocation endpoint, if not supplied this is computed relative to the token endpoint |

<a name='P-Trimble-ID-OpenIdEndpointProvider-Production'></a>
### Production `property`

<a name='P-Trimble-ID-OpenIdEndpointProvider-Staging'></a>
### Staging `property`

<a name='M-Trimble-ID-OpenIdEndpointProvider-RetrieveAuthorizationEndpoint'></a>
### RetrieveAuthorizationEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity authorization endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown if the configuration endpoint returns an error |

<a name='M-Trimble-ID-OpenIdEndpointProvider-RetrieveDeviceAuthorizationEndpoint'></a>
### RetrieveDeviceAuthorizationEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity device authorization endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown if the configuration endpoint returns an error |

<a name='M-Trimble-ID-OpenIdEndpointProvider-RetrieveEndSessionEndpoint'></a>
### RetrieveEndSessionEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity token revocation endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-OpenIdEndpointProvider-RetrieveJSONWebKeySetEndpoint'></a>
### RetrieveJSONWebKeySetEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity authorization endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown if the configuration endpoint returns an error |

<a name='M-Trimble-ID-OpenIdEndpointProvider-RetrieveTokenEndpoint'></a>
### RetrieveTokenEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity authorization endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown if the configuration endpoint returns an error |

<a name='M-Trimble-ID-OpenIdEndpointProvider-RetrieveTokenRevocationEndpoint'></a>
### RetrieveTokenRevocationEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity authorization endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown if the configuration endpoint returns an error |

<a name='M-Trimble-ID-OpenIdEndpointProvider-RetrieveUserInfoEndpoint'></a>
### RetrieveUserInfoEndpoint() `method`

##### Summary

Retrieves a URL for the Trimble Identity authorization endpoint

##### Returns

A Task that resolves to the value of the URL on completion

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown if the configuration endpoint returns an error |

<a name='T-Trimble-ID-OpenIdKeySetProvider'></a>
## OpenIdKeySetProvider `type`

##### Namespace

Trimble.ID

##### Summary

A keyset provider based on the OAuth well known configuration

##### Example

```csharp
const string JWKS_ENDPOINT = "https://id.trimble.com/.well-known/jwks.json";
var endpointProvider = new FixedEndpointProvider(jwksEndpoint: new Uri(JWKS_ENDPOINT, UriKind.Absolute));
var keysetProvider = new OpenIdKeySetProvider(endpointProvider);
var keyset = await keysetProvider.RetrieveKeySet();
```

##### Remarks

Implements IKeysetProvider

<a name='M-Trimble-ID-OpenIdKeySetProvider-#ctor-Trimble-ID-IEndpointProvider,System-String-'></a>
### #ctor(endpointProvider,productName) `constructor`

##### Summary

Public constructor for OpenIdKeySetProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpointProvider | [Trimble.ID.IEndpointProvider](#T-Trimble-ID-IEndpointProvider 'Trimble.ID.IEndpointProvider') | An endpoint provider that provides the URL for the Trimble Identity JSON web keyset endpoint |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The product name of the consuming application (optional). |

##### Remarks

Implements IKeySetProvider

<a name='M-Trimble-ID-OpenIdKeySetProvider-RetrieveKeySet'></a>
### RetrieveKeySet() `method`

##### Summary

Retrieves an dictionary of named keys

##### Returns

A Task that resolves to a dictionary of named keys on completion

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a JSON web keyset endpoint is not provided by the endpoint provider |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a call to the JSON web keyset endpoint fails |

<a name='T-Trimble-ID-RefreshableTokenProvider'></a>
## RefreshableTokenProvider `type`

##### Namespace

Trimble.ID

##### Summary

Class to allow instansiation of RefreshableTokenProvider

<a name='M-Trimble-ID-RefreshableTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String-'></a>
### #ctor(endpointProvider,consumerKey,productName) `constructor`

##### Summary

Public constructor for RefreshableTokenProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpointProvider | [Trimble.ID.IEndpointProvider](#T-Trimble-ID-IEndpointProvider 'Trimble.ID.IEndpointProvider') | An endpoint provider that provides the URL for the Trimble Identity token endpoint |
| consumerKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer key for the calling application |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The product name of the consuming application (optional). |

##### Remarks

Implements ITokenProvider

<a name='M-Trimble-ID-RefreshableTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String,System-String,System-DateTime,System-String,System-String-'></a>
### #ctor(endpointProvider,consumerKey,consumerSecret,accessToken,tokenExpiry,idToken,refreshToken) `constructor`

##### Summary

Public constructor for RefreshableTokenProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpointProvider | [Trimble.ID.IEndpointProvider](#T-Trimble-ID-IEndpointProvider 'Trimble.ID.IEndpointProvider') | An endpoint provider that provides the URL for the Trimble Identity token endpoint |
| consumerKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer key for the calling application |
| consumerSecret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer secret for the calling application |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The initial access token issued for the authenticated user |
| tokenExpiry | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The expiry time for the initial access token issued for the authenticated user |
| idToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID token for the authenticated user |
| refreshToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The refresh token for the authenticated user |

##### Remarks

Implements ITokenProvider

<a name='T-Trimble-ID-RefreshableTokenProvider`1'></a>
## RefreshableTokenProvider\`1 `type`

##### Namespace

Trimble.ID

##### Summary

A token provider based on the OAuth refresh grant type

##### Remarks

Implements ITokenProvider

<a name='M-Trimble-ID-RefreshableTokenProvider`1-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String-'></a>
### #ctor(endpointProvider,consumerKey,productName) `constructor`

##### Summary

Public constructor for RefreshableTokenProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpointProvider | [Trimble.ID.IEndpointProvider](#T-Trimble-ID-IEndpointProvider 'Trimble.ID.IEndpointProvider') | An endpoint provider that provides the URL for the Trimble Identity token endpoint |
| consumerKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer key for the calling application |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The product name of the consuming application (optional). |

##### Remarks

Implements ITokenProvider

<a name='M-Trimble-ID-RefreshableTokenProvider`1-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String,System-String,System-DateTime,System-String,System-String-'></a>
### #ctor(endpointProvider,consumerKey,consumerSecret,accessToken,tokenExpiry,idToken,refreshToken) `constructor`

##### Summary

Public constructor for RefreshableTokenProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpointProvider | [Trimble.ID.IEndpointProvider](#T-Trimble-ID-IEndpointProvider 'Trimble.ID.IEndpointProvider') | An endpoint provider that provides the URL for the Trimble Identity token endpoint |
| consumerKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer key for the calling application |
| consumerSecret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer secret for the calling application |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The initial access token issued for the authenticated user |
| tokenExpiry | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The expiry time for the initial access token issued for the authenticated user |
| idToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID token for the authenticated user |
| refreshToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The refresh token for the authenticated user |

##### Remarks

Implements ITokenProvider

<a name='F-Trimble-ID-RefreshableTokenProvider`1-_codeVerifier'></a>
### _codeVerifier `constants`

<a name='F-Trimble-ID-RefreshableTokenProvider`1-_consumerKey'></a>
### _consumerKey `constants`

<a name='F-Trimble-ID-RefreshableTokenProvider`1-_consumerSecret'></a>
### _consumerSecret `constants`

<a name='F-Trimble-ID-RefreshableTokenProvider`1-_endpointProvider'></a>
### _endpointProvider `constants`

<a name='F-Trimble-ID-RefreshableTokenProvider`1-_idToken'></a>
### _idToken `constants`

<a name='F-Trimble-ID-RefreshableTokenProvider`1-_messageHandler'></a>
### _messageHandler `constants`

<a name='F-Trimble-ID-RefreshableTokenProvider`1-_timeProvider'></a>
### _timeProvider `constants`

<a name='M-Trimble-ID-RefreshableTokenProvider`1-GenerateCodeVerifier'></a>
### GenerateCodeVerifier() `method`

##### Summary

Static method to generate a code verifier

##### Returns

A code verifier string

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-RefreshableTokenProvider`1-RetrieveCodeVerifier'></a>
### RetrieveCodeVerifier() `method`

##### Summary

Retrieves a code verifier for the authenticated user for PKCE grant flow

##### Returns

A Task that resolves to the value of the code verifier on completion

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a token endpoint is not provided by the endpoint provider |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a call to the token endpoint fails |

<a name='M-Trimble-ID-RefreshableTokenProvider`1-RetrieveIdToken'></a>
### RetrieveIdToken() `method`

##### Summary

Retrieves an ID token for the authenticated user

##### Returns

A Task that resolves to the value of the ID token on completion

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a token endpoint is not provided by the endpoint provider |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a call to the token endpoint fails |

<a name='M-Trimble-ID-RefreshableTokenProvider`1-RetrieveRefreshToken'></a>
### RetrieveRefreshToken() `method`

##### Summary

Retrieves a refresh token for the authenticated user

##### Returns

A Task that resolves to the value of the refresh token on completion

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a token endpoint is not provided by the endpoint provider |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a call to the token endpoint fails |

<a name='M-Trimble-ID-RefreshableTokenProvider`1-RetrieveToken'></a>
### RetrieveToken() `method`

##### Summary

Retrieves an access token for the authenticated user

##### Returns

A Task that resolves to the value of the access token on completion

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a token endpoint is not provided by the endpoint provider |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when a call to the token endpoint fails |

<a name='M-Trimble-ID-RefreshableTokenProvider`1-RevokeRefreshToken'></a>
### RevokeRefreshToken() `method`

##### Summary

Revokes a refresh token for the authenticated user

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-RefreshableTokenProvider`1-WithAccessToken-System-String,System-DateTime-'></a>
### WithAccessToken(accessToken,tokenExpiry) `method`

##### Summary

Fluent method for RefreshableTokenProvider class

##### Returns

The current RefreshableTokenProvider

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The initial access token issued for the authenticated user |
| tokenExpiry | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The expiry time for the initial access token issued for the authenticated user |

<a name='M-Trimble-ID-RefreshableTokenProvider`1-WithConsumerSecret-System-String-'></a>
### WithConsumerSecret(consumerSecret) `method`

##### Summary

Fluent method for RefreshableTokenProvider class

##### Returns

The current RefreshableTokenProvider

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| consumerSecret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The consumer secret for the calling application |

<a name='M-Trimble-ID-RefreshableTokenProvider`1-WithIdToken-System-String-'></a>
### WithIdToken(idToken) `method`

##### Summary

Fluent method for RefreshableTokenProvider class

##### Returns

The current RefreshableTokenProvider

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| idToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID token for the authenticated user |

<a name='M-Trimble-ID-RefreshableTokenProvider`1-WithPersistentStorage-Trimble-ID-IPersistantStorage-'></a>
### WithPersistentStorage(persistentStorage) `method`

##### Summary

Fluent method for RefreshableTokenProvider class

##### Returns

The current RefreshableTokenProvider

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| persistentStorage | [Trimble.ID.IPersistantStorage](#T-Trimble-ID-IPersistantStorage 'Trimble.ID.IPersistantStorage') | The persistent storage for the refresh token |

<a name='M-Trimble-ID-RefreshableTokenProvider`1-WithProofKeyForCodeExchange-System-String-'></a>
### WithProofKeyForCodeExchange(codeVerifier) `method`

##### Summary

Fluent extension for Authorization Code with PKCE

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| codeVerifier | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The PKCE code verifier for the calling application |

<a name='M-Trimble-ID-RefreshableTokenProvider`1-WithRefreshToken-System-String-'></a>
### WithRefreshToken(refreshToken) `method`

##### Summary

Fluent method for RefreshableTokenProvider class

##### Returns

The current RefreshableTokenProvider

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| refreshToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The refresh token for the authenticated user |

<a name='M-Trimble-ID-RefreshableTokenProvider`1-_GenerateCodeChallenge-System-String-'></a>
### _GenerateCodeChallenge() `method`

##### Summary

Generate a code challenge for the current code verifier

##### Returns

The calculated code challenge

##### Parameters

This method has no parameters.

<a name='T-Trimble-ID-SelfSignedTokenProvider'></a>
## SelfSignedTokenProvider `type`

##### Namespace

Trimble.ID

##### Summary

A token provider that returns a self signed token

##### Remarks

Implements ITokenProvider

<a name='M-Trimble-ID-SelfSignedTokenProvider-#ctor-System-String,Newtonsoft-Json-Linq-JObject-'></a>
### #ctor(privateKey,payload) `constructor`

##### Summary

Public constructor for SelfSignedTokenProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| privateKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The private key used to sign the token |
| payload | [Newtonsoft.Json.Linq.JObject](#T-Newtonsoft-Json-Linq-JObject 'Newtonsoft.Json.Linq.JObject') | The payload for the token |

##### Remarks

Implements ITokenProvider

<a name='M-Trimble-ID-SelfSignedTokenProvider-RetrieveToken'></a>
### RetrieveToken() `method`

##### Summary

Retrieves an access token for the user or application

##### Returns

A Task that resolves to the value of the access token on completion

##### Parameters

This method has no parameters.

<a name='T-Trimble-ID-TokenValidationOptions'></a>
## TokenValidationOptions `type`

##### Namespace

Trimble.ID

<a name='P-Trimble-ID-TokenValidationOptions-ClockSkew'></a>
### ClockSkew `property`

##### Summary

Gets or sets the clock skew for validating tokens.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | If 'value' is less than 0. |

<a name='T-Trimble-ID-UserInfo'></a>
## UserInfo `type`

##### Namespace

Trimble.ID

##### Summary

User information

<a name='P-Trimble-ID-UserInfo-Email'></a>
### Email `property`

##### Summary

The user's email address

<a name='P-Trimble-ID-UserInfo-EmailVerified'></a>
### EmailVerified `property`

##### Summary

The user's email address verification status

<a name='P-Trimble-ID-UserInfo-FamilyName'></a>
### FamilyName `property`

##### Summary

The user's family name

<a name='P-Trimble-ID-UserInfo-GivenName'></a>
### GivenName `property`

##### Summary

The user's given name

<a name='P-Trimble-ID-UserInfo-Id'></a>
### Id `property`

##### Summary

The user's unique identifier

<a name='P-Trimble-ID-UserInfo-Picture'></a>
### Picture `property`

##### Summary

A URL to the user's profile picture

<a name='T-Trimble-ID-ValidatedClaimsetProvider'></a>
## ValidatedClaimsetProvider `type`

##### Namespace

Trimble.ID

##### Summary

A claimset provider that returns a validated claimset

##### Example

```csharp
var idToken = "USERS_ID_TOKEN";
const string JWKS_ENDPOINT = "https://identity.trimble.com/openid-certs";
var endpointProvider = new FixedEndpointProvider(jwksEndpoint: new Uri(JWKS_ENDPOINT, UriKind.Absolute));
var keysetProvider = new OpenIdKeySetProvider(endpointProvider);
var claimsetProvider = new ValidatedClaimsetProvider(keysetProvider);
var claimset = await RetrieveClaimset(idToken);
var userId = claimset["sub"];
```

##### Remarks

Implements IKeysetProvider

<a name='M-Trimble-ID-ValidatedClaimsetProvider-#ctor-Trimble-ID-IKeySetProvider,System-String-'></a>
### #ctor(keysetProvider,productName) `constructor`

##### Summary

Public constructor for ValidatedClaimsetProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keysetProvider | [Trimble.ID.IKeySetProvider](#T-Trimble-ID-IKeySetProvider 'Trimble.ID.IKeySetProvider') | A provider for the keyset used to validate the JWT claimeset |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The product name of the consuming application (optional). |

##### Remarks

Implements IClaimsetProvider

<a name='M-Trimble-ID-ValidatedClaimsetProvider-RetrieveClaimset-System-String-'></a>
### RetrieveClaimset() `method`

##### Summary

Retrieves a validate claimset from a given JSON web token

##### Returns

A Task that resolves to the claimset completion

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when the keyset provider does not provide the named key |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown when the JSON web token is invalid |

<a name='M-Trimble-ID-ValidatedClaimsetProvider-WithOptions-Trimble-ID-TokenValidationOptions-'></a>
### WithOptions(options) `method`

##### Summary

Fluent extension for setting token validation Options

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Trimble.ID.TokenValidationOptions](#T-Trimble-ID-TokenValidationOptions 'Trimble.ID.TokenValidationOptions') | Contains a set of validation options when validating the token |
