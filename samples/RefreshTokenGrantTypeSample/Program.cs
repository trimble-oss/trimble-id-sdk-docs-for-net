/// --- REFRESH A TOKEN ---
///
/// AuthorizationCodeGrantTokenProvider internally refreshes the token, we don't need to explicitly refresh the token.
/// 
/// Access Tokens are short-lived and must be refreshed after they expire to continue accessing resources.
/// You can refresh the access_token by submitting another POST request to the /token endpoint,
/// but this time providing the refresh_token as the grant type.

/// In Trimble Identity, an access_token is valid for 1 hour, and Refresh Tokens are valid for 9 days.
/// However, errors can occur when tokens expire, are revoked, or lack sufficient privileges.
/// Please ensure application can address errors returned by the token issuance endpoint.
using Trimble.ID;

IEndpointProvider endpointProvider = OpenIdEndpointProvider.Production;
var tokenProvider = new RefreshableTokenProvider(endpointProvider, "CLIENT_ID")
                                    .WithConsumerSecret("CLIENT_SECRET")
                                    .WithRefreshToken("OLD_REFRESH_TOKEN");

var token = await tokenProvider.RetrieveToken();
var refreshToken = await tokenProvider.RetrieveRefreshToken();

Console.WriteLine($"Refreshed access_token: {token}, refresh_token: {refreshToken}");