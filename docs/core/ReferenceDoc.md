<a name='assembly'></a>
# Trimble.ID

## Contents

- [AccessToken](#T-Trimble-ID-AccessToken 'Trimble.ID.AccessToken')
  - [#ctor(accessToken,expiresOn)](#M-Trimble-ID-AccessToken-#ctor-System-String,System-DateTimeOffset- 'Trimble.ID.AccessToken.#ctor(System.String,System.DateTimeOffset)')
  - [ExpiresOn](#P-Trimble-ID-AccessToken-ExpiresOn 'Trimble.ID.AccessToken.ExpiresOn')
  - [Token](#P-Trimble-ID-AccessToken-Token 'Trimble.ID.AccessToken.Token')
  - [Equals()](#M-Trimble-ID-AccessToken-Equals-System-Object- 'Trimble.ID.AccessToken.Equals(System.Object)')
  - [GetHashCode()](#M-Trimble-ID-AccessToken-GetHashCode 'Trimble.ID.AccessToken.GetHashCode')
- [AuthorizationCodeGrantTokenProvider](#T-Trimble-ID-AuthorizationCodeGrantTokenProvider 'Trimble.ID.AuthorizationCodeGrantTokenProvider')
  - [#ctor(endpointProvider,clientId,redirectUrl,productName)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String,System-String- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.#ctor(Trimble.ID.IEndpointProvider,System.String,System.String,System.String)')
  - [#ctor(endpointProvider,clientId,redirectUri,productName)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-Uri,System-String- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.#ctor(Trimble.ID.IEndpointProvider,System.String,System.Uri,System.String)')
  - [State](#P-Trimble-ID-AuthorizationCodeGrantTokenProvider-State 'Trimble.ID.AuthorizationCodeGrantTokenProvider.State')
  - [GetOAuthLogoutRedirect(state)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-GetOAuthLogoutRedirect-System-String- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.GetOAuthLogoutRedirect(System.String)')
  - [GetOAuthRedirect(state,prompt)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-GetOAuthRedirect-System-String,System-Boolean- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.GetOAuthRedirect(System.String,System.Boolean)')
  - [ValidateCode(code)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-ValidateCode-System-String- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.ValidateCode(System.String)')
  - [ValidateQuery(query)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-ValidateQuery-System-String- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.ValidateQuery(System.String)')
  - [WithIdentityProvider(identityProvider)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-WithIdentityProvider-System-String- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.WithIdentityProvider(System.String)')
  - [WithLogoutRedirect(logoutRedirectUrl)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-WithLogoutRedirect-System-String- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.WithLogoutRedirect(System.String)')
  - [WithLogoutRedirect(logoutRedirectUri)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-WithLogoutRedirect-System-Uri- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.WithLogoutRedirect(System.Uri)')
  - [WithScopes(scopes)](#M-Trimble-ID-AuthorizationCodeGrantTokenProvider-WithScopes-System-Collections-Generic-IEnumerable{System-String}- 'Trimble.ID.AuthorizationCodeGrantTokenProvider.WithScopes(System.Collections.Generic.IEnumerable{System.String})')
- [AuthorizationFailedException](#T-Trimble-ID-AuthorizationFailedException 'Trimble.ID.AuthorizationFailedException')
  - [#ctor(message)](#M-Trimble-ID-AuthorizationFailedException-#ctor-System-String- 'Trimble.ID.AuthorizationFailedException.#ctor(System.String)')
  - [#ctor(message,innerException)](#M-Trimble-ID-AuthorizationFailedException-#ctor-System-String,System-Exception- 'Trimble.ID.AuthorizationFailedException.#ctor(System.String,System.Exception)')
- [BearerTokenHttpClientProvider](#T-Trimble-ID-BearerTokenHttpClientProvider 'Trimble.ID.BearerTokenHttpClientProvider')
  - [#ctor(tokenProvider,baseAddress,productName)](#M-Trimble-ID-BearerTokenHttpClientProvider-#ctor-Trimble-ID-ITokenProvider,System-Uri,System-String- 'Trimble.ID.BearerTokenHttpClientProvider.#ctor(Trimble.ID.ITokenProvider,System.Uri,System.String)')
  - [ClientId](#P-Trimble-ID-BearerTokenHttpClientProvider-ClientId 'Trimble.ID.BearerTokenHttpClientProvider.ClientId')
  - [Logger](#P-Trimble-ID-BearerTokenHttpClientProvider-Logger 'Trimble.ID.BearerTokenHttpClientProvider.Logger')
  - [GetClientIdAsync()](#M-Trimble-ID-BearerTokenHttpClientProvider-GetClientIdAsync 'Trimble.ID.BearerTokenHttpClientProvider.GetClientIdAsync')
  - [RetrieveClient()](#M-Trimble-ID-BearerTokenHttpClientProvider-RetrieveClient 'Trimble.ID.BearerTokenHttpClientProvider.RetrieveClient')
  - [SetHttpMessageHandler(handler)](#M-Trimble-ID-BearerTokenHttpClientProvider-SetHttpMessageHandler-System-Net-Http-HttpMessageHandler- 'Trimble.ID.BearerTokenHttpClientProvider.SetHttpMessageHandler(System.Net.Http.HttpMessageHandler)')
- [ClientCredentialTokenProvider](#T-Trimble-ID-ClientCredentialTokenProvider 'Trimble.ID.ClientCredentialTokenProvider')
  - [#ctor(endpointProvider,consumerKey,consumerSecret,productName)](#M-Trimble-ID-ClientCredentialTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String,System-String- 'Trimble.ID.ClientCredentialTokenProvider.#ctor(Trimble.ID.IEndpointProvider,System.String,System.String,System.String)')
  - [RetrieveToken()](#M-Trimble-ID-ClientCredentialTokenProvider-RetrieveToken 'Trimble.ID.ClientCredentialTokenProvider.RetrieveToken')
  - [RetrieveTokenAsync()](#M-Trimble-ID-ClientCredentialTokenProvider-RetrieveTokenAsync-System-Threading-CancellationToken- 'Trimble.ID.ClientCredentialTokenProvider.RetrieveTokenAsync(System.Threading.CancellationToken)')
  - [WithScopes(scopes)](#M-Trimble-ID-ClientCredentialTokenProvider-WithScopes-System-Collections-Generic-IEnumerable{System-String}- 'Trimble.ID.ClientCredentialTokenProvider.WithScopes(System.Collections.Generic.IEnumerable{System.String})')
- [DeviceAuthorizationResponse](#T-Trimble-ID-DeviceAuthorizationResponse 'Trimble.ID.DeviceAuthorizationResponse')
  - [DeviceCode](#P-Trimble-ID-DeviceAuthorizationResponse-DeviceCode 'Trimble.ID.DeviceAuthorizationResponse.DeviceCode')
  - [ExpiresIn](#P-Trimble-ID-DeviceAuthorizationResponse-ExpiresIn 'Trimble.ID.DeviceAuthorizationResponse.ExpiresIn')
  - [Interval](#P-Trimble-ID-DeviceAuthorizationResponse-Interval 'Trimble.ID.DeviceAuthorizationResponse.Interval')
  - [UserCode](#P-Trimble-ID-DeviceAuthorizationResponse-UserCode 'Trimble.ID.DeviceAuthorizationResponse.UserCode')
  - [VerificationUri](#P-Trimble-ID-DeviceAuthorizationResponse-VerificationUri 'Trimble.ID.DeviceAuthorizationResponse.VerificationUri')
  - [VerificationUriComplete](#P-Trimble-ID-DeviceAuthorizationResponse-VerificationUriComplete 'Trimble.ID.DeviceAuthorizationResponse.VerificationUriComplete')
- [DeviceAuthorizationStatus](#T-Trimble-ID-DeviceAuthorizationStatus 'Trimble.ID.DeviceAuthorizationStatus')
  - [ACCESS_DENIED](#F-Trimble-ID-DeviceAuthorizationStatus-ACCESS_DENIED 'Trimble.ID.DeviceAuthorizationStatus.ACCESS_DENIED')
  - [ACCESS_GRANTED](#F-Trimble-ID-DeviceAuthorizationStatus-ACCESS_GRANTED 'Trimble.ID.DeviceAuthorizationStatus.ACCESS_GRANTED')
  - [AUTHORIZATION_PENDING](#F-Trimble-ID-DeviceAuthorizationStatus-AUTHORIZATION_PENDING 'Trimble.ID.DeviceAuthorizationStatus.AUTHORIZATION_PENDING')
  - [CODE_EXPIRED](#F-Trimble-ID-DeviceAuthorizationStatus-CODE_EXPIRED 'Trimble.ID.DeviceAuthorizationStatus.CODE_EXPIRED')
  - [NONE](#F-Trimble-ID-DeviceAuthorizationStatus-NONE 'Trimble.ID.DeviceAuthorizationStatus.NONE')
  - [SLOW_DOWN](#F-Trimble-ID-DeviceAuthorizationStatus-SLOW_DOWN 'Trimble.ID.DeviceAuthorizationStatus.SLOW_DOWN')
- [DeviceAuthorizationTokenProvider](#T-Trimble-ID-DeviceAuthorizationTokenProvider 'Trimble.ID.DeviceAuthorizationTokenProvider')
  - [#ctor(endpointProvider,clientId,productName)](#M-Trimble-ID-DeviceAuthorizationTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String- 'Trimble.ID.DeviceAuthorizationTokenProvider.#ctor(Trimble.ID.IEndpointProvider,System.String,System.String)')
  - [CreateAuthorization()](#M-Trimble-ID-DeviceAuthorizationTokenProvider-CreateAuthorization 'Trimble.ID.DeviceAuthorizationTokenProvider.CreateAuthorization')
  - [PerformTokenRequest(deviceCode,pollInterval,timeout,onCallback,cancellationToken)](#M-Trimble-ID-DeviceAuthorizationTokenProvider-PerformTokenRequest-System-String,System-Int32,System-Int32,System-Action{Trimble-ID-DeviceAuthorizationStatus},System-Threading-CancellationToken- 'Trimble.ID.DeviceAuthorizationTokenProvider.PerformTokenRequest(System.String,System.Int32,System.Int32,System.Action{Trimble.ID.DeviceAuthorizationStatus},System.Threading.CancellationToken)')
  - [RetrieveIdToken()](#M-Trimble-ID-DeviceAuthorizationTokenProvider-RetrieveIdToken 'Trimble.ID.DeviceAuthorizationTokenProvider.RetrieveIdToken')
  - [RetrieveRefreshToken()](#M-Trimble-ID-DeviceAuthorizationTokenProvider-RetrieveRefreshToken 'Trimble.ID.DeviceAuthorizationTokenProvider.RetrieveRefreshToken')
  - [RetrieveToken()](#M-Trimble-ID-DeviceAuthorizationTokenProvider-RetrieveToken 'Trimble.ID.DeviceAuthorizationTokenProvider.RetrieveToken')
  - [RetrieveTokenAsync()](#M-Trimble-ID-DeviceAuthorizationTokenProvider-RetrieveTokenAsync-System-Threading-CancellationToken- 'Trimble.ID.DeviceAuthorizationTokenProvider.RetrieveTokenAsync(System.Threading.CancellationToken)')
  - [WithClientSecret(clientSecret)](#M-Trimble-ID-DeviceAuthorizationTokenProvider-WithClientSecret-System-String- 'Trimble.ID.DeviceAuthorizationTokenProvider.WithClientSecret(System.String)')
  - [WithScopes(scopes)](#M-Trimble-ID-DeviceAuthorizationTokenProvider-WithScopes-System-Collections-Generic-IEnumerable{System-String}- 'Trimble.ID.DeviceAuthorizationTokenProvider.WithScopes(System.Collections.Generic.IEnumerable{System.String})')
- [DeviceTokenErrorResponse](#T-Trimble-ID-DeviceTokenErrorResponse 'Trimble.ID.DeviceTokenErrorResponse')
  - [Error](#P-Trimble-ID-DeviceTokenErrorResponse-Error 'Trimble.ID.DeviceTokenErrorResponse.Error')
  - [ErrorDescription](#P-Trimble-ID-DeviceTokenErrorResponse-ErrorDescription 'Trimble.ID.DeviceTokenErrorResponse.ErrorDescription')
- [EncryptedStorage](#T-Trimble-ID-EncryptedStorage 'Trimble.ID.EncryptedStorage')
  - [#ctor()](#M-Trimble-ID-EncryptedStorage-#ctor-Trimble-ID-IPersistantStorage,System-Byte[]- 'Trimble.ID.EncryptedStorage.#ctor(Trimble.ID.IPersistantStorage,System.Byte[])')
  - [GetItem()](#M-Trimble-ID-EncryptedStorage-GetItem-System-String- 'Trimble.ID.EncryptedStorage.GetItem(System.String)')
  - [RemoveItem()](#M-Trimble-ID-EncryptedStorage-RemoveItem-System-String- 'Trimble.ID.EncryptedStorage.RemoveItem(System.String)')
  - [SetItem()](#M-Trimble-ID-EncryptedStorage-SetItem-System-String,System-String- 'Trimble.ID.EncryptedStorage.SetItem(System.String,System.String)')
- [ErrorMessage](#T-Trimble-ID-ErrorMessage 'Trimble.ID.ErrorMessage')
  - [FailedToGetToken](#F-Trimble-ID-ErrorMessage-FailedToGetToken 'Trimble.ID.ErrorMessage.FailedToGetToken')
  - [FailedToRefreshToken](#F-Trimble-ID-ErrorMessage-FailedToRefreshToken 'Trimble.ID.ErrorMessage.FailedToRefreshToken')
  - [FailedToReturnOAuthRedirect](#F-Trimble-ID-ErrorMessage-FailedToReturnOAuthRedirect 'Trimble.ID.ErrorMessage.FailedToReturnOAuthRedirect')
  - [FailedToValidateOAuthCode](#F-Trimble-ID-ErrorMessage-FailedToValidateOAuthCode 'Trimble.ID.ErrorMessage.FailedToValidateOAuthCode')
  - [IdTokenIsRequired](#F-Trimble-ID-ErrorMessage-IdTokenIsRequired 'Trimble.ID.ErrorMessage.IdTokenIsRequired')
  - [NoKeysetEndpointProvider](#F-Trimble-ID-ErrorMessage-NoKeysetEndpointProvider 'Trimble.ID.ErrorMessage.NoKeysetEndpointProvider')
  - [RefreshTokenIsNullOrEmpty](#F-Trimble-ID-ErrorMessage-RefreshTokenIsNullOrEmpty 'Trimble.ID.ErrorMessage.RefreshTokenIsNullOrEmpty')
  - [TokenRefreshFailed](#F-Trimble-ID-ErrorMessage-TokenRefreshFailed 'Trimble.ID.ErrorMessage.TokenRefreshFailed')
- [FixedEndpointProvider](#T-Trimble-ID-FixedEndpointProvider 'Trimble.ID.FixedEndpointProvider')
  - [#ctor(productName)](#M-Trimble-ID-FixedEndpointProvider-#ctor-System-String- 'Trimble.ID.FixedEndpointProvider.#ctor(System.String)')
  - [#ctor()](#M-Trimble-ID-FixedEndpointProvider-#ctor-Trimble-ID-FixedEndpointProvider- 'Trimble.ID.FixedEndpointProvider.#ctor(Trimble.ID.FixedEndpointProvider)')
  - [#ctor(authorizationEndpoint,tokenEndpoint,userInfoEndpoint,tokenRevocationEndpoint,jwksEndpoint,endSessionEndpoint,deviceAuthorizationEndpoint)](#M-Trimble-ID-FixedEndpointProvider-#ctor-System-Uri,System-Uri,System-Uri,System-Uri,System-Uri,System-Uri,System-Uri- 'Trimble.ID.FixedEndpointProvider.#ctor(System.Uri,System.Uri,System.Uri,System.Uri,System.Uri,System.Uri,System.Uri)')
  - [RetrieveAuthorizationEndpoint()](#M-Trimble-ID-FixedEndpointProvider-RetrieveAuthorizationEndpoint 'Trimble.ID.FixedEndpointProvider.RetrieveAuthorizationEndpoint')
  - [RetrieveDeviceAuthorizationEndpoint()](#M-Trimble-ID-FixedEndpointProvider-RetrieveDeviceAuthorizationEndpoint 'Trimble.ID.FixedEndpointProvider.RetrieveDeviceAuthorizationEndpoint')
  - [RetrieveEndSessionEndpoint()](#M-Trimble-ID-FixedEndpointProvider-RetrieveEndSessionEndpoint 'Trimble.ID.FixedEndpointProvider.RetrieveEndSessionEndpoint')
  - [RetrieveJSONWebKeySetEndpoint()](#M-Trimble-ID-FixedEndpointProvider-RetrieveJSONWebKeySetEndpoint 'Trimble.ID.FixedEndpointProvider.RetrieveJSONWebKeySetEndpoint')
  - [RetrieveTokenEndpoint()](#M-Trimble-ID-FixedEndpointProvider-RetrieveTokenEndpoint 'Trimble.ID.FixedEndpointProvider.RetrieveTokenEndpoint')
  - [RetrieveTokenRevocationEndpoint()](#M-Trimble-ID-FixedEndpointProvider-RetrieveTokenRevocationEndpoint 'Trimble.ID.FixedEndpointProvider.RetrieveTokenRevocationEndpoint')
  - [RetrieveUserInfoEndpoint()](#M-Trimble-ID-FixedEndpointProvider-RetrieveUserInfoEndpoint 'Trimble.ID.FixedEndpointProvider.RetrieveUserInfoEndpoint')
  - [WithAuthorizationEndpoint(authorizationEndpoint)](#M-Trimble-ID-FixedEndpointProvider-WithAuthorizationEndpoint-System-Uri- 'Trimble.ID.FixedEndpointProvider.WithAuthorizationEndpoint(System.Uri)')
  - [WithDeviceAuthorizationEndpoint(deviceAuthorizationEndpoint)](#M-Trimble-ID-FixedEndpointProvider-WithDeviceAuthorizationEndpoint-System-Uri- 'Trimble.ID.FixedEndpointProvider.WithDeviceAuthorizationEndpoint(System.Uri)')
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
  - [#ctor(token,expiresIn,productName)](#M-Trimble-ID-FixedTokenProvider-#ctor-System-String,System-Int32,System-String- 'Trimble.ID.FixedTokenProvider.#ctor(System.String,System.Int32,System.String)')
  - [RetrieveToken()](#M-Trimble-ID-FixedTokenProvider-RetrieveToken 'Trimble.ID.FixedTokenProvider.RetrieveToken')
  - [RetrieveTokenAsync()](#M-Trimble-ID-FixedTokenProvider-RetrieveTokenAsync-System-Threading-CancellationToken- 'Trimble.ID.FixedTokenProvider.RetrieveTokenAsync(System.Threading.CancellationToken)')
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
  - [ClientId](#P-Trimble-ID-IHttpClientProvider-ClientId 'Trimble.ID.IHttpClientProvider.ClientId')
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
  - [RetrieveTokenAsync(cancellationToken)](#M-Trimble-ID-ITokenProvider-RetrieveTokenAsync-System-Threading-CancellationToken- 'Trimble.ID.ITokenProvider.RetrieveTokenAsync(System.Threading.CancellationToken)')
- [IsolatedFileStorage](#T-Trimble-ID-IsolatedFileStorage 'Trimble.ID.IsolatedFileStorage')
  - [#ctor()](#M-Trimble-ID-IsolatedFileStorage-#ctor-System-String- 'Trimble.ID.IsolatedFileStorage.#ctor(System.String)')
  - [GetItem()](#M-Trimble-ID-IsolatedFileStorage-GetItem-System-String- 'Trimble.ID.IsolatedFileStorage.GetItem(System.String)')
  - [RemoveItem()](#M-Trimble-ID-IsolatedFileStorage-RemoveItem-System-String- 'Trimble.ID.IsolatedFileStorage.RemoveItem(System.String)')
  - [SetItem()](#M-Trimble-ID-IsolatedFileStorage-SetItem-System-String,System-String- 'Trimble.ID.IsolatedFileStorage.SetItem(System.String,System.String)')
- [LoggingHandler](#T-Trimble-ID-LoggingHandler 'Trimble.ID.LoggingHandler')
  - [#ctor(logger)](#M-Trimble-ID-LoggingHandler-#ctor-TrimbleCloud-Common-Logging-ILogger- 'Trimble.ID.LoggingHandler.#ctor(TrimbleCloud.Common.Logging.ILogger)')
  - [SendAsync(request,cancellationToken)](#M-Trimble-ID-LoggingHandler-SendAsync-System-Net-Http-HttpRequestMessage,System-Threading-CancellationToken- 'Trimble.ID.LoggingHandler.SendAsync(System.Net.Http.HttpRequestMessage,System.Threading.CancellationToken)')
- [OnBehalfGrantTokenProvider](#T-Trimble-ID-OnBehalfGrantTokenProvider 'Trimble.ID.OnBehalfGrantTokenProvider')
  - [#ctor(endpointProvider,consumerKey,consumerSecret,accessToken,productName)](#M-Trimble-ID-OnBehalfGrantTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String,System-String,System-String- 'Trimble.ID.OnBehalfGrantTokenProvider.#ctor(Trimble.ID.IEndpointProvider,System.String,System.String,System.String,System.String)')
  - [RetrieveToken()](#M-Trimble-ID-OnBehalfGrantTokenProvider-RetrieveToken 'Trimble.ID.OnBehalfGrantTokenProvider.RetrieveToken')
  - [RetrieveTokenAsync()](#M-Trimble-ID-OnBehalfGrantTokenProvider-RetrieveTokenAsync-System-Threading-CancellationToken- 'Trimble.ID.OnBehalfGrantTokenProvider.RetrieveTokenAsync(System.Threading.CancellationToken)')
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
- [RefreshableTokenProvider\`1](#T-Trimble-ID-RefreshableTokenProvider`1 'Trimble.ID.RefreshableTokenProvider`1')
  - [#ctor(endpointProvider,consumerKey,productName)](#M-Trimble-ID-RefreshableTokenProvider`1-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String- 'Trimble.ID.RefreshableTokenProvider`1.#ctor(Trimble.ID.IEndpointProvider,System.String,System.String)')
  - [#ctor(endpointProvider,consumerKey,consumerSecret,accessToken,tokenExpiry,idToken,refreshToken)](#M-Trimble-ID-RefreshableTokenProvider`1-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String,System-String,System-DateTime,System-String,System-String- 'Trimble.ID.RefreshableTokenProvider`1.#ctor(Trimble.ID.IEndpointProvider,System.String,System.String,System.String,System.DateTime,System.String,System.String)')
  - [_clientId](#F-Trimble-ID-RefreshableTokenProvider`1-_clientId 'Trimble.ID.RefreshableTokenProvider`1._clientId')
  - [_clientSecret](#F-Trimble-ID-RefreshableTokenProvider`1-_clientSecret 'Trimble.ID.RefreshableTokenProvider`1._clientSecret')
  - [_endpointProvider](#F-Trimble-ID-RefreshableTokenProvider`1-_endpointProvider 'Trimble.ID.RefreshableTokenProvider`1._endpointProvider')
  - [_gaParameters](#F-Trimble-ID-RefreshableTokenProvider`1-_gaParameters 'Trimble.ID.RefreshableTokenProvider`1._gaParameters')
  - [_messageHandler](#F-Trimble-ID-RefreshableTokenProvider`1-_messageHandler 'Trimble.ID.RefreshableTokenProvider`1._messageHandler')
  - [CheckIsOnline()](#M-Trimble-ID-RefreshableTokenProvider`1-CheckIsOnline 'Trimble.ID.RefreshableTokenProvider`1.CheckIsOnline')
  - [ConvertToUrlSafeBase64String()](#M-Trimble-ID-RefreshableTokenProvider`1-ConvertToUrlSafeBase64String-System-Byte[]- 'Trimble.ID.RefreshableTokenProvider`1.ConvertToUrlSafeBase64String(System.Byte[])')
  - [GenerateCodeVerifier()](#M-Trimble-ID-RefreshableTokenProvider`1-GenerateCodeVerifier 'Trimble.ID.RefreshableTokenProvider`1.GenerateCodeVerifier')
  - [GetSilentTokenAsync(cancellationToken)](#M-Trimble-ID-RefreshableTokenProvider`1-GetSilentTokenAsync-System-Threading-CancellationToken- 'Trimble.ID.RefreshableTokenProvider`1.GetSilentTokenAsync(System.Threading.CancellationToken)')
  - [RetrieveCodeVerifier()](#M-Trimble-ID-RefreshableTokenProvider`1-RetrieveCodeVerifier 'Trimble.ID.RefreshableTokenProvider`1.RetrieveCodeVerifier')
  - [RetrieveIdToken()](#M-Trimble-ID-RefreshableTokenProvider`1-RetrieveIdToken 'Trimble.ID.RefreshableTokenProvider`1.RetrieveIdToken')
  - [RetrieveRefreshToken()](#M-Trimble-ID-RefreshableTokenProvider`1-RetrieveRefreshToken 'Trimble.ID.RefreshableTokenProvider`1.RetrieveRefreshToken')
  - [RetrieveToken()](#M-Trimble-ID-RefreshableTokenProvider`1-RetrieveToken 'Trimble.ID.RefreshableTokenProvider`1.RetrieveToken')
  - [RetrieveTokenAsync()](#M-Trimble-ID-RefreshableTokenProvider`1-RetrieveTokenAsync-System-Threading-CancellationToken- 'Trimble.ID.RefreshableTokenProvider`1.RetrieveTokenAsync(System.Threading.CancellationToken)')
  - [RevokeRefreshToken()](#M-Trimble-ID-RefreshableTokenProvider`1-RevokeRefreshToken 'Trimble.ID.RefreshableTokenProvider`1.RevokeRefreshToken')
  - [WithAccessToken(accessToken,tokenExpiry)](#M-Trimble-ID-RefreshableTokenProvider`1-WithAccessToken-System-String,System-DateTime- 'Trimble.ID.RefreshableTokenProvider`1.WithAccessToken(System.String,System.DateTime)')
  - [WithConsumerSecret(clientSecret)](#M-Trimble-ID-RefreshableTokenProvider`1-WithConsumerSecret-System-String- 'Trimble.ID.RefreshableTokenProvider`1.WithConsumerSecret(System.String)')
  - [WithIdToken(idToken)](#M-Trimble-ID-RefreshableTokenProvider`1-WithIdToken-System-String- 'Trimble.ID.RefreshableTokenProvider`1.WithIdToken(System.String)')
  - [WithOfflineAccess()](#M-Trimble-ID-RefreshableTokenProvider`1-WithOfflineAccess 'Trimble.ID.RefreshableTokenProvider`1.WithOfflineAccess')
  - [WithPersistentStorage(persistentStorage)](#M-Trimble-ID-RefreshableTokenProvider`1-WithPersistentStorage-Trimble-ID-IPersistantStorage- 'Trimble.ID.RefreshableTokenProvider`1.WithPersistentStorage(Trimble.ID.IPersistantStorage)')
  - [WithProofKeyForCodeExchange(codeVerifier)](#M-Trimble-ID-RefreshableTokenProvider`1-WithProofKeyForCodeExchange-System-String- 'Trimble.ID.RefreshableTokenProvider`1.WithProofKeyForCodeExchange(System.String)')
  - [WithRefreshToken(refreshToken)](#M-Trimble-ID-RefreshableTokenProvider`1-WithRefreshToken-System-String- 'Trimble.ID.RefreshableTokenProvider`1.WithRefreshToken(System.String)')
  - [WithRetryConfiguration(maxRetries,retryDelayInSeconds)](#M-Trimble-ID-RefreshableTokenProvider`1-WithRetryConfiguration-System-Int32,System-Int32- 'Trimble.ID.RefreshableTokenProvider`1.WithRetryConfiguration(System.Int32,System.Int32)')
  - [_GenerateCodeChallenge()](#M-Trimble-ID-RefreshableTokenProvider`1-_GenerateCodeChallenge-System-String- 'Trimble.ID.RefreshableTokenProvider`1._GenerateCodeChallenge(System.String)')
- [TokenRefreshException](#T-Trimble-ID-TokenRefreshException 'Trimble.ID.TokenRefreshException')
  - [#ctor(message)](#M-Trimble-ID-TokenRefreshException-#ctor-System-String- 'Trimble.ID.TokenRefreshException.#ctor(System.String)')
  - [#ctor(message,innerException)](#M-Trimble-ID-TokenRefreshException-#ctor-System-String,System-Exception- 'Trimble.ID.TokenRefreshException.#ctor(System.String,System.Exception)')
- [TokenRefreshedEventArgs](#T-TokenRefreshedEventArgs 'TokenRefreshedEventArgs')
  - [#ctor(accessToken,expiresIn)](#M-TokenRefreshedEventArgs-#ctor-System-String,System-Int64- 'TokenRefreshedEventArgs.#ctor(System.String,System.Int64)')
  - [AccessToken](#P-TokenRefreshedEventArgs-AccessToken 'TokenRefreshedEventArgs.AccessToken')
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

<a name='T-Trimble-ID-AccessToken'></a>
## AccessToken `type`

##### Namespace

Trimble.ID

##### Summary

Represents Trimble identity access token with expiry information.

<a name='M-Trimble-ID-AccessToken-#ctor-System-String,System-DateTimeOffset-'></a>
### #ctor(accessToken,expiresOn) `constructor`

##### Summary

Creates a new instance of [AccessToken](#T-Trimble-ID-AccessToken 'Trimble.ID.AccessToken') using the provided `accessToken` and `expiresOn`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The access token value. |
| expiresOn | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | The access token expiry date. |

<a name='P-Trimble-ID-AccessToken-ExpiresOn'></a>
### ExpiresOn `property`

##### Summary

Gets the time when the provided token expires.

<a name='P-Trimble-ID-AccessToken-Token'></a>
### Token `property`

##### Summary

Get the access token value.

<a name='M-Trimble-ID-AccessToken-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-AccessToken-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

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
IEndpointProvider endpointProvider = new FixedEndpointProvider(new Uri(AUTHORIZATION_ENDPOINT, UriKind.Absolute), new Uri(TOKEN_ENDPOINT, UriKind.Absolute));
ITokenProvider tokenProvider = new AuthorizationCodeGrantTokenProvider(endpointProvider, CONSUMER_KEY, REDIRECT_URL)
   .WithConsumerSecret(CONSUMER_SECRET)
   .WithScopes(new[] string { "scope" });
var token = await tokenProvider.RetrieveToken();
```

##### Remarks

Implements ITokenProvider

<a name='M-Trimble-ID-AuthorizationCodeGrantTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-String,System-String-'></a>
### #ctor(endpointProvider,clientId,redirectUrl,productName) `constructor`

##### Summary

Public constructor for AuthorizationCodeGrantTokenProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpointProvider | [Trimble.ID.IEndpointProvider](#T-Trimble-ID-IEndpointProvider 'Trimble.ID.IEndpointProvider') | An endpoint provider that provides the URL for the Trimble Identity authorization and token endpoints |
| clientId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The client Id for the calling application |
| redirectUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URL to which Trimble Identity should redirect after successfully authenticating a user |
| productName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The product name of the consuming application (Optional). |

<a name='M-Trimble-ID-AuthorizationCodeGrantTokenProvider-#ctor-Trimble-ID-IEndpointProvider,System-String,System-Uri,System-String-'></a>
### #ctor(endpointProvider,clientId,redirectUri,productName) `constructor`

##### Summary

Public constructor for AuthorizationCodeGrantTokenProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpointProvider | [Trimble.ID.IEndpointProvider](#T-Trimble-ID-IEndpointProvider 'Trimble.ID.IEndpointProvider') | An endpoint provider that provides the URL for the Trimble Identity authorization and token endpoints |
| clientId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The client Id for the calling application |
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
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown when an ID token is not available |

<a name='M-Trimble-ID-AuthorizationCodeGrantTokenProvider-GetOAuthRedirect-System-String,System-Boolean-'></a>
### GetOAuthRedirect(state,prompt) `method`

##### Summary

Get a redirect URL for Trimble Identity

##### Returns

An awaitable Task that resolves to the redirect URL

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| state | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | An optional state parameter that will be passed back to the caller via the redirect URL |
| prompt | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | This parameter is optional and determines whether to display the login UI. The default value is True. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Trimble.ID.AuthorizationFailedException](#T-Trimble-ID-AuthorizationFailedException 'Trimble.ID.AuthorizationFailedException') | Thrown when an authorization endpoint is not provided by the endpoint provider |

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
| [Trimble.ID.AuthorizationFailedException](#T-Trimble-ID-AuthorizationFailedException 'Trimble.ID.AuthorizationFailedException') | Thrown when failed to validate the given auth code |

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
| [Trimble.ID.AuthorizationFailedException](#T-Trimble-ID-AuthorizationFailedException 'Trimble.ID.AuthorizationFailedException') | Thrown when failed to validate the given auth code |

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

<a name='T-Trimble-ID-AuthorizationFailedException'></a>
## AuthorizationFailedException `type`

##### Namespace

Trimble.ID

##### Summary

An exception class raised for errors in authorizing client requests.

<a name='M-Trimble-ID-AuthorizationFailedException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Creates a new AuthorizationFailedException with the specified message.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Trimble-ID-AuthorizationFailedException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

Creates a new AuthorizationFailedException with the specified message.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message describing the authorization failure. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception underlying the authorization failure. |

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
ITokenProvider tokenProvider = new FixedTokenProvider(TOKEN);
IHttpClientProvider httpclientProvider = new BearerTokenHttpClientProvider(tokenProvider, new Uri(API_BASE_URL, UriKind.Absolute));
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

<a name='P-Trimble-ID-BearerTokenHttpClientProvider-ClientId'></a>
### ClientId `property`

##### Summary

Gets the client ID.

<a name='P-Trimble-ID-BearerTokenHttpClientProvider-Logger'></a>
### Logger `property`

##### Summary

Gets or sets the logger for this HTTP client provider

<a name='M-Trimble-ID-BearerTokenHttpClientProvider-GetClientIdAsync'></a>
### GetClientIdAsync() `method`

##### Summary

Gets the client ID asynchronously.

##### Parameters

This method has no parameters.

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

<a name='M-Trimble-ID-BearerTokenHttpClientProvider-SetHttpMessageHandler-System-Net-Http-HttpMessageHandler-'></a>
### SetHttpMessageHandler(handler) `method`

##### Summary

Sets the HTTP message handler to be used by the client provider.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| handler | [System.Net.Http.HttpMessageHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMessageHandler 'System.Net.Http.HttpMessageHandler') | The HTTP message handler to be set. |

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
IEndpointProvider endpointProvider = new FixedEndpointProvider(tokenEndpoint: new Uri(TOKEN_ENDPOINT, UriKind.Absolute));
ITokenProvider tokenProvider = new ClientCredentialTokenProvider(endpointProvider, CLIENT_ID, CLIENT_SECRET).WithScopes(new[] string { "scope" });
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
| [Trimble.ID.AuthorizationFailedException](#T-Trimble-ID-AuthorizationFailedException 'Trimble.ID.AuthorizationFailedException') | Thrown when a call to the token endpoint fails to obtain token |

<a name='M-Trimble-ID-ClientCredentialTokenProvider-RetrieveTokenAsync-System-Threading-CancellationToken-'></a>
### RetrieveTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-ClientCredentialTokenProvider-WithScopes-System-Collections-Generic-IEnumerable{System-String}-'></a>
### WithScopes(scopes) `method`

##### Summary

Fluent extension for adding scopes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scopes | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | The requested scopes |

<a name='T-Trimble-ID-CrossPlatLock'></a>
## DeviceAuthorizationResponse `type`

##### Namespace

Trimble.ID

##### Summary

Represents the response of DeviceAuthorization.

<a name='P-Trimble-ID-DeviceAuthorizationResponse-DeviceCode'></a>
### DeviceCode `property`

##### Summary

Gets or sets the device code.

<a name='P-Trimble-ID-DeviceAuthorizationResponse-ExpiresIn'></a>
### ExpiresIn `property`

##### Summary

Gets or sets the expiration time in seconds.

<a name='P-Trimble-ID-DeviceAuthorizationResponse-Interval'></a>
### Interval `property`

##### Summary

Gets or sets the interval.

<a name='P-Trimble-ID-DeviceAuthorizationResponse-UserCode'></a>
### UserCode `property`

##### Summary

Gets or sets the user code.

<a name='P-Trimble-ID-DeviceAuthorizationResponse-VerificationUri'></a>
### VerificationUri `property`

##### Summary

Gets or sets the verification URI.

<a name='P-Trimble-ID-DeviceAuthorizationResponse-VerificationUriComplete'></a>
### VerificationUriComplete `property`

##### Summary

Gets or sets the complete verification URI.

<a name='T-Trimble-ID-DeviceAuthorizationStatus'></a>
## DeviceAuthorizationStatus `type`

##### Namespace

Trimble.ID

##### Summary

Represents the authorization status of a device.

<a name='F-Trimble-ID-DeviceAuthorizationStatus-ACCESS_DENIED'></a>
### ACCESS_DENIED `constants`

##### Summary

Access denied authorization status.

<a name='F-Trimble-ID-DeviceAuthorizationStatus-ACCESS_GRANTED'></a>
### ACCESS_GRANTED `constants`

##### Summary

Access granted authorization status.

<a name='F-Trimble-ID-DeviceAuthorizationStatus-AUTHORIZATION_PENDING'></a>
### AUTHORIZATION_PENDING `constants`

##### Summary

Authorization pending authorization status.

<a name='F-Trimble-ID-DeviceAuthorizationStatus-CODE_EXPIRED'></a>
### CODE_EXPIRED `constants`

##### Summary

Code expired authorization status.

<a name='F-Trimble-ID-DeviceAuthorizationStatus-NONE'></a>
### NONE `constants`

##### Summary

No authorization status.

<a name='F-Trimble-ID-DeviceAuthorizationStatus-SLOW_DOWN'></a>
### SLOW_DOWN `constants`

##### Summary

Slow down authorization status.

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
### PerformTokenRequest(deviceCode,pollInterval,timeout,onCallback,cancellationToken) `method`

##### Summary

Performs token request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deviceCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Device code to perform token request |
| pollInterval | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Time interval between each request |
| timeout | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The maximum time until the request times out |
| onCallback | [System.Action{Trimble.ID.DeviceAuthorizationStatus}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Trimble.ID.DeviceAuthorizationStatus}') | Callback method to check whether the device has been authorized |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.TimeoutException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeoutException 'System.TimeoutException') | Thrown when a token request times out |
| [Trimble.ID.AuthorizationFailedException](#T-Trimble-ID-AuthorizationFailedException 'Trimble.ID.AuthorizationFailedException') | Thrown when a call to device authoiration fails |

<a name='M-Trimble-ID-DeviceAuthorizationTokenProvider-RetrieveIdToken'></a>
### RetrieveIdToken() `method`

##### Summary

Retrieves a id token for the application

##### Returns

A Task that resolves to the value of the ID token on completion

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-DeviceAuthorizationTokenProvider-RetrieveRefreshToken'></a>
### RetrieveRefreshToken() `method`

##### Summary

Retrieves a refresh token for the application

##### Returns

A Task that resolves to the value of the refresh token on completion

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
| [Trimble.ID.TokenRefreshException](#T-Trimble-ID-TokenRefreshException 'Trimble.ID.TokenRefreshException') | Thrown when a call to the token endpoint fails |

<a name='M-Trimble-ID-DeviceAuthorizationTokenProvider-RetrieveTokenAsync-System-Threading-CancellationToken-'></a>
### RetrieveTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

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

<a name='T-Trimble-ID-DeviceTokenErrorResponse'></a>
## DeviceTokenErrorResponse `type`

##### Namespace

Trimble.ID

##### Summary

Represents the device token error response.

<a name='P-Trimble-ID-DeviceTokenErrorResponse-Error'></a>
### Error `property`

##### Summary

Gets or sets the error message.

<a name='P-Trimble-ID-DeviceTokenErrorResponse-ErrorDescription'></a>
### ErrorDescription `property`

##### Summary

Gets or sets the error description.

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

<a name='M-Trimble-ID-EncryptedStorage-CombineEntropy-System-Byte[],System-Byte[]-'></a>
### CombineEntropy() `method`

##### Summary

Combines the secret with additional entropy

##### Parameters

This method has no parameters.

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

<a name='T-Trimble-ID-ErrorMessage'></a>
## ErrorMessage `type`

##### Namespace

Trimble.ID

##### Summary

The Authorization Error messages.

<a name='F-Trimble-ID-ErrorMessage-FailedToGetToken'></a>
### FailedToGetToken `constants`

##### Summary

The error message.

<a name='F-Trimble-ID-ErrorMessage-FailedToRefreshToken'></a>
### FailedToRefreshToken `constants`

##### Summary

The error message.

<a name='F-Trimble-ID-ErrorMessage-FailedToReturnOAuthRedirect'></a>
### FailedToReturnOAuthRedirect `constants`

##### Summary

The error message.

<a name='F-Trimble-ID-ErrorMessage-FailedToValidateOAuthCode'></a>
### FailedToValidateOAuthCode `constants`

##### Summary

The error message.

<a name='F-Trimble-ID-ErrorMessage-IdTokenIsRequired'></a>
### IdTokenIsRequired `constants`

##### Summary

The error message.

<a name='F-Trimble-ID-ErrorMessage-NoKeysetEndpointProvider'></a>
### NoKeysetEndpointProvider `constants`

##### Summary

The error message.

<a name='F-Trimble-ID-ErrorMessage-RefreshTokenIsNullOrEmpty'></a>
### RefreshTokenIsNullOrEmpty `constants`

##### Summary

Error message for when refresh token is null or empty

<a name='F-Trimble-ID-ErrorMessage-TokenRefreshFailed'></a>
### TokenRefreshFailed `constants`

##### Summary

Error message for failed token refresh

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
IEndpointProvider endpointProvider = new FixedEndpointProvider()
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
### #ctor(authorizationEndpoint,tokenEndpoint,userInfoEndpoint,tokenRevocationEndpoint,jwksEndpoint,endSessionEndpoint,deviceAuthorizationEndpoint) `constructor`

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
| deviceAuthorizationEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity device authorization endpoint |

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
### WithDeviceAuthorizationEndpoint(deviceAuthorizationEndpoint) `method`

##### Returns

A new instance of a FixedEndpointProvider

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deviceAuthorizationEndpoint | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL for the Trimble Identity device authorization endpoint |

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
 IKeySetProvider keysetProvider = new FixedKeySetProvider(keyset);
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
ITokenProvider tokenProvider = new FixedTokenProvider(TOKEN);
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

<a name='M-Trimble-ID-FixedTokenProvider-#ctor-System-String,System-Int32,System-String-'></a>
### #ctor(token,expiresIn,productName) `constructor`

##### Summary

Public constructor for FixedTokenProvider class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| token | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The fixed token to return |
| expiresIn | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The expiration time of the token in seconds |
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

<a name='M-Trimble-ID-FixedTokenProvider-RetrieveTokenAsync-System-Threading-CancellationToken-'></a>
### RetrieveTokenAsync() `method`

##### Summary

*Inherit from parent.*

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

<a name='P-Trimble-ID-IHttpClientProvider-ClientId'></a>
### ClientId `property`

##### Summary

The ClientId for the calling application

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

<a name='M-Trimble-ID-ITokenProvider-RetrieveTokenAsync-System-Threading-CancellationToken-'></a>
### RetrieveTokenAsync(cancellationToken) `method`

##### Summary

Retrieves an access token asynchronously for the authenticated application or user

##### Returns

An [AccessToken](#T-Trimble-ID-AccessToken 'Trimble.ID.AccessToken') which can be used to authenticate service client calls.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') controlling the request lifetime. |

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

<a name='T-Trimble-ID-LinuxNativeMethods'></a>
## LoggingHandler `type`

##### Namespace

Trimble.ID

##### Summary

Represents a logging handler for HTTP requests and responses.

<a name='M-Trimble-ID-LoggingHandler-#ctor-TrimbleCloud-Common-Logging-ILogger-'></a>
### #ctor(logger) `constructor`

##### Summary

Initializes a new instance of the [LoggingHandler](#T-Trimble-ID-LoggingHandler 'Trimble.ID.LoggingHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [TrimbleCloud.Common.Logging.ILogger](#T-TrimbleCloud-Common-Logging-ILogger 'TrimbleCloud.Common.Logging.ILogger') | The logger instance. |

<a name='M-Trimble-ID-LoggingHandler-SendAsync-System-Net-Http-HttpRequestMessage,System-Threading-CancellationToken-'></a>
### SendAsync(request,cancellationToken) `method`

##### Summary

Sends an HTTP request and logs the request and response.

##### Returns

The HTTP response message.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [System.Net.Http.HttpRequestMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestMessage 'System.Net.Http.HttpRequestMessage') | The HTTP request message. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

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
IEndpointProvider endpointProvider = new FixedEndpointProvider(tokenEndpoint: new Uri(TOKEN_ENDPOINT, UriKind.Absolute));
ITokenProvider tokenProvider = new OnBehalfGrantTokenProvider(endpointProvider, CLIENT_ID, CLIENT_SECRET, accessToken);
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
| [Trimble.ID.AuthorizationFailedException](#T-Trimble-ID-AuthorizationFailedException 'Trimble.ID.AuthorizationFailedException') | Thrown when a call to the token endpoint fails |

<a name='M-Trimble-ID-OnBehalfGrantTokenProvider-RetrieveTokenAsync-System-Threading-CancellationToken-'></a>
### RetrieveTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

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
IEndpointProvider endpointProvider = new OpenIdEndpointProvider(new Uri(PROD_CONFIGURATION_ENDPOINT, UriKind.Absolute));
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
IKeySetProvider keysetProvider = new OpenIdKeySetProvider(endpointProvider);
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

<a name='F-Trimble-ID-RefreshableTokenProvider`1-_clientId'></a>
### _clientId `constants`

<a name='F-Trimble-ID-RefreshableTokenProvider`1-_clientSecret'></a>
### _clientSecret `constants`

<a name='F-Trimble-ID-RefreshableTokenProvider`1-_endpointProvider'></a>
### _endpointProvider `constants`

<a name='F-Trimble-ID-RefreshableTokenProvider`1-_gaParameters'></a>
### _gaParameters `constants`

<a name='F-Trimble-ID-RefreshableTokenProvider`1-_messageHandler'></a>
### _messageHandler `constants`

<a name='M-Trimble-ID-RefreshableTokenProvider`1-CheckIsOnline'></a>
### CheckIsOnline() `method`

##### Summary

Checks online state.

##### Returns

True if online.

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-RefreshableTokenProvider`1-ConvertToUrlSafeBase64String-System-Byte[]-'></a>
### ConvertToUrlSafeBase64String() `method`

##### Parameters

This method has no parameters.

### GenerateCodeVerifier() `method`

##### Summary

Static method to generate a code verifier

##### Returns

A code verifier string

##### Parameters

This method has no parameters.

<a name='M-Trimble-ID-RefreshableTokenProvider`1-GetSilentTokenAsync-System-Threading-CancellationToken-'></a>
### GetSilentTokenAsync(cancellationToken) `method`

##### Summary

Get a token silently. Use CrossPlatLock to synchronize access to the cache only if the cache is stored in IsolatedFileStorage.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |  |

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
| [Trimble.ID.TokenRefreshException](#T-Trimble-ID-TokenRefreshException 'Trimble.ID.TokenRefreshException') | Thrown when a call to the token endpoint fails |

<a name='M-Trimble-ID-RefreshableTokenProvider`1-RetrieveTokenAsync-System-Threading-CancellationToken-'></a>
### RetrieveTokenAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

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
### WithConsumerSecret(clientSecret) `method`

##### Summary

Fluent method for RefreshableTokenProvider class

##### Returns

The current RefreshableTokenProvider

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientSecret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The client secret for the calling application |

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

<a name='M-Trimble-ID-RefreshableTokenProvider`1-WithOfflineAccess'></a>
### WithOfflineAccess() `method`

##### Summary

Fluent method for enabling offline access

##### Returns

The current RefreshableTokenProvider

##### Parameters

This method has no parameters.

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

<a name='M-Trimble-ID-RefreshableTokenProvider`1-WithRetryConfiguration-System-Int32,System-Int32-'></a>
### WithRetryConfiguration(maxRetries,retryDelayInSeconds) `method`

##### Summary

Fluent method to configure retry behavior

##### Returns

The current RefreshableTokenProvider

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| maxRetries | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Maximum number of retries |
| retryDelayInSeconds | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Base delay between retries in seconds |

<a name='M-Trimble-ID-RefreshableTokenProvider`1-_GenerateCodeChallenge-System-String-'></a>
### _GenerateCodeChallenge() `method`

##### Summary

Generate a code challenge for the current code verifier

##### Returns

The calculated code challenge

##### Parameters

This method has no parameters.

<a name='T-Trimble-ID-Utilities-RetryHandler'></a>
## RetryHandler `type`

##### Namespace

Trimble.ID.Utilities

<a name='M-Trimble-ID-Utilities-RetryHandler-ExecuteWithRetryAsync``1-System-Func{System-Threading-Tasks-Task{``0}},System-Func{System-Exception,System-Net-Http-HttpResponseMessage,System-Boolean},System-Int32,System-Nullable{System-TimeSpan},System-Threading-CancellationToken-'></a>
### ExecuteWithRetryAsync\`\`1(func,shouldRetryPredicate,maxRetries,retryDelay,cancellationToken) `method`

##### Summary

Executes the provided function with retry logic.

##### Returns

The result of the function execution.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| func | [System.Func{System.Threading.Tasks.Task{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Threading.Tasks.Task{``0}}') | The function to execute. |
| shouldRetryPredicate | [System.Func{System.Exception,System.Net.Http.HttpResponseMessage,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Exception,System.Net.Http.HttpResponseMessage,System.Boolean}') | Function to determine if retry should be attempted based on the exception. |
| maxRetries | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Maximum number of retry attempts. |
| retryDelay | [System.Nullable{System.TimeSpan}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.TimeSpan}') | Base delay between retries (will be multiplied by retry count for backoff). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Cancellation token. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The return type of the function. |

<a name='M-Trimble-ID-Utilities-RetryHandler-ShouldRetryOnServerError-System-Exception,System-Net-Http-HttpResponseMessage-'></a>
### ShouldRetryOnServerError(ex,response) `method`

##### Summary

Determines if the request should be retried based on the HTTP status code.

##### Returns

True if the request should be retried, otherwise false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ex | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception that was thrown. |
| response | [System.Net.Http.HttpResponseMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpResponseMessage 'System.Net.Http.HttpResponseMessage') | The HTTP response. |

## TokenHandler `type`

##### Namespace

Trimble.ID

##### Summary

Represents a handler for adding authentication token to the request headers.

<a name='M-Trimble-ID-TokenHandler-#ctor-Trimble-ID-ITokenProvider-'></a>
### #ctor(tokenProvider) `constructor`

##### Summary

Initializes a new instance of the [TokenHandler](#T-Trimble-ID-TokenHandler 'Trimble.ID.TokenHandler') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| tokenProvider | [Trimble.ID.ITokenProvider](#T-Trimble-ID-ITokenProvider 'Trimble.ID.ITokenProvider') | The token provider used to retrieve the authentication token. |

<a name='F-Trimble-ID-TokenHandler-_tokenProvider'></a>
### _tokenProvider `constants`

##### Summary

Represents a handler that adds an authentication token to the request headers before sending the request.

<a name='M-Trimble-ID-TokenHandler-SendAsync-System-Net-Http-HttpRequestMessage,System-Threading-CancellationToken-'></a>
### SendAsync(request,cancellationToken) `method`

##### Summary

Sends the HTTP request with the added authentication token in the request headers.

##### Returns

The HTTP response message.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [System.Net.Http.HttpRequestMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestMessage 'System.Net.Http.HttpRequestMessage') | The HTTP request message. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token. |

<a name='T-Trimble-ID-TokenRefreshException'></a>
## TokenRefreshException `type`

##### Namespace

Trimble.ID

##### Summary

An exception class raised when a token refresh fails.

<a name='M-Trimble-ID-TokenRefreshException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Creates a new TokenRefreshException with the specified message.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Trimble-ID-TokenRefreshException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

Creates a new TokenRefreshException with the specified message.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message describing the token refresh failure. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception underlying the token refresh failure. |

<a name='T-TokenRefreshedEventArgs'></a>
## TokenRefreshedEventArgs `type`

##### Namespace



##### Summary

Represents the event arguments for token refreshed event.

<a name='M-TokenRefreshedEventArgs-#ctor-System-String,System-Int64-'></a>
### #ctor(accessToken,expiresIn) `constructor`

##### Summary

Initializes a new instance of the [TokenRefreshedEventArgs](#T-TokenRefreshedEventArgs 'TokenRefreshedEventArgs') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The access token. |
| expiresIn | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The access token expiration time |

<a name='P-TokenRefreshedEventArgs-AccessToken'></a>
### AccessToken `property`

##### Summary

Gets the access token.

<a name='T-Trimble-ID-TokenValidationOptions'></a>
## TokenValidationOptions `type`

##### Namespace

Trimble.ID

##### Summary

Represents the options for token validation.

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
IEndpointProvider endpointProvider = new FixedEndpointProvider(jwksEndpoint: new Uri(JWKS_ENDPOINT, UriKind.Absolute));
IKeysetProvider keysetProvider = new OpenIdKeySetProvider(endpointProvider);
IClaimsetProvider claimsetProvider = new ValidatedClaimsetProvider(keysetProvider);
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