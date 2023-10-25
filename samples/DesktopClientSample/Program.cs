using TrimbleCloud.Authentication;
using TrimbleCloud.Authentication.Desktop;

byte[] Salt = { 0xb7, 0xa2, 0x46, 0x53, 0x84, 0xf0, 0x49, 0xc6, 0x4f, 0x9b };

const string CLIENT_ID = "app-client-id";
string[] SCOPES = new[] { "scope" };

// Initialize Local host authenticator
IAuthenticator authenticator = new LocalhostAuthenticator(OpenIdEndpointProvider.Production, CLIENT_ID, SCOPES)
    .WithPersistentStorage(new EncryptedStorage(new IsolatedFileStorage("filename.config"), Salt));

// Login
if (!authenticator.IsLoggedIn)
{
    var isLoggedIn = await authenticator.Login();
}

// Retrieve access token
var token = await authenticator.TokenProvider.RetrieveToken();

// Get Logged-In user information
var user = await authenticator.GetUserInfo();

// Logout
await authenticator.Logout();


