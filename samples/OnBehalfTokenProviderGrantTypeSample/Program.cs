// The On Behalf grant flow allows an application to act on behalf of a user.
// The On Behalf grant is only supported for access tokens.
// It does not work with any other type of token, including refresh tokens.

using Trimble.ID;

IEndpointProvider endpointProvider = OpenIdEndpointProvider.Production;
var tokenProvider = new OnBehalfGrantTokenProvider(endpointProvider, "CLIENT_ID", "CLIENT_SECRET", "ACCESS_TOKEN");
var token = tokenProvider.RetrieveToken();

Console.WriteLine($"Retreived token is {token} for onBehalf grant token provider");
Console.Read();