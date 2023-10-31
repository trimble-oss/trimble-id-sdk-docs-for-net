// Retrieve a token for the client credential grant type, typically suited for server-side authentication

using Trimble.ID;

const string clientId = "app-client-id";
const string clientSecret = "app-client-secret";
string[] scopes = new[] { "scope" };

ITokenProvider tokenProvider = new ClientCredentialTokenProvider(OpenIdEndpointProvider.Production, clientId, clientSecret)
    .WithScopes(scopes);
var token = await tokenProvider.RetrieveToken();

Console.WriteLine($"Access token is {token}");

Console.ReadLine();
