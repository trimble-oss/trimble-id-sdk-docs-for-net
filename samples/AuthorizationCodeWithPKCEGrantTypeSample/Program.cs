using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Win32;
using Trimble.ID;

namespace AuthorizationCodeWithPKCEGrantTypeSample
{
    class Program
    {
        // This sample demonstrates how to use the Authorization Code grant type with PKCE
        // to authenticate a user and retrieve an access token from the Trimble Identity Provider.
        // The sample uses the HttpListener class to listen on a redirect URI for the authorization code.
        // The authorization code is then exchanged for an access token and ID token.
        // The ID token is validated and the email claim is retrieved from the claimset.
        // The refresh token is also retrieved and can be used to refresh the access token when it expires.
        // The refresh token can also be revoked.
        
        const string LISTENER_PREFIX = "http://localhost:5000/";
        const string REDIRECT_URI = LISTENER_PREFIX + "index.html";
        const string LOGOUT_REDIRECT_URI = "https://www.trimble.com";
        const string EMAIL_CLAIM = "email";

        static OpenIdEndpointProvider _endpointProvider = null;
        static AuthorizationCodeGrantTokenProvider _tokenProvider = null;
        static async Task Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Configure endpoint provider with IDP well-known url
            _endpointProvider = new OpenIdEndpointProvider(new Uri(configuration["OPENID_CONFIGURATION_URL"], UriKind.Absolute));

            // Configure Authorization Code grant token provoder to get OAuth authorize and logout redirect endpoint
            _tokenProvider = new AuthorizationCodeGrantTokenProvider(_endpointProvider, configuration["CLIENT_ID"], REDIRECT_URI)
                .WithProofKeyForCodeExchange(AuthorizationCodeGrantTokenProvider.GenerateCodeVerifier())  // Pass PKCE code verifier here
                .WithScopes(new[] { configuration["REQUESTED_SCOPE"] })
                .WithLogoutRedirect(LOGOUT_REDIRECT_URI);


            // Listener to start listen on redirect endpoint
            var listener = new HttpListener();
            listener.Prefixes.Add(LISTENER_PREFIX);

            listener.Start();
            listener.BeginGetContext(OnHttpListenerGetContext, listener);
            Console.WriteLine("Listening...");

            Console.Write("Opening browser...");
            LaunchBrowser(await _tokenProvider.GetOAuthRedirect());

            Console.WriteLine("Press RETURN to logout");
            Console.ReadLine();

            Console.WriteLine("Logging out...");
            // optionally revoke the refresh token
            //await _tokenProvider.RevokeRefreshToken();
            LaunchBrowser(await _tokenProvider.GetOAuthLogoutRedirect());

            Console.WriteLine("Shutting down...");
            listener.Stop();
            listener.Close();

            Console.WriteLine("Bye!");
        }

        // public static class OperatingSystem
        // {
        //     public static bool IsWindows() =>
        //         RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        //     public static bool IsMacOS() =>
        //         RuntimeInformation.IsOSPlatform(OSPlatform.OSX);

        //     public static bool IsLinux() =>
        //         RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        // }
        private static string DefaultWindowsBrowserPath
        {
            get
            {
                var protocolClass = "https";

                string userChoicePath = @"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\https\UserChoice";
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(userChoicePath))
                {
                    if (key != null)
                    {
                        protocolClass = key.GetValue("ProgId") as string;
                    }
                }

                using (RegistryKey key = Registry.ClassesRoot.OpenSubKey($@"{protocolClass}\shell\open\command"))
                {
                    if (key != null)
                    {
                        string webBrowserPath = key.GetValue(String.Empty) as string;

                        if (!String.IsNullOrEmpty(webBrowserPath))
                        {
                            if (webBrowserPath.First() == '"')
                            {
                                return webBrowserPath.Split('"')[1];
                            }

                            return webBrowserPath.Split(' ')[0];
                        }
                    }
                }
                return null;
            }
        }
        private static void LaunchBrowser(string url)
        {
            try
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    try
                    {
                        try
                        {
                            // the preference is to open a new browser window which means
                            // we need to find the default browser and call it directly
                            var browserPath = DefaultWindowsBrowserPath;
                            if (string.IsNullOrEmpty(browserPath))
                            {
                                throw new Exception("Browser not found");
                            }

                            var arguments = new StringBuilder();
                            if (browserPath.Contains("chrome") ||
                                browserPath.Contains("firefox") ||
                                browserPath.Contains("msedge") ||
                                browserPath.Contains("iexplorer"))
                            {
                                arguments.Append("--new-window ");
                            }

                            // it might be nice to control the browser window size at some point
                            // chrome - window size
                            // --window-size and --window-position do not work unless you create a new session using --user-data-dir
                            //builder.Append(" --window-position=10,10")
                            //builder.Append(" --window-size=640,480");

                            arguments.Append($"\"{url}\"");

                            Process.Start(browserPath, arguments.ToString());
                        }
                        catch
                        {
                            // use the built in start method, this will not allow us to force open a new window
                            Process.Start("start", $"\"{url}\"");
                        }
                    }
                    catch
                    {
                        // as a last ditch effort on windows try starting from a command shell
                        // this used to do Process.Start("explorer.exe", $@"""{url}""") but explorer was truncating the URL
                        Process.Start("cmd.exe", $"/C start \"\" \"{url}\"");
                    }
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    // to open chrome specifically
                    // open -na "Google Chrome" --args --new-window "{url}"

                    // to open safari specifically
                    // open -a "Safari" "{url}"

                    Process.Start("open", $"\"{url}\"");
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", $"\"{url}\"");
                }
            }
            catch
            {
                throw new Exception("Unable to launch the native browser");
            }
        }

        private static void OnHttpListenerGetContext(IAsyncResult result)
        {
            try
            {
                var listener = (HttpListener)result.AsyncState;
                var context = listener.EndGetContext(result);
                listener.BeginGetContext(OnHttpListenerGetContext, listener); // start another listener
                using (var writer = new StreamWriter(context.Response.OutputStream))
                {
                    if (context.Request.QueryString.Count != 0)
                    {
                        Console.WriteLine("Token aquired...");

                        writer.Write($@"
                            <html>
                                <head>
                                    <script>window.close()</script>
                                </head>
                                <body>
                                    <p>You may now close this window</p>
                                </body>
                            </html>"
                        );

                        // id_token is available in context.Request.QueryString["id_token"]
                        // At this point the listener can be closed and the application can do whatever is required
                        // with the id_token value
                        Task.Run(async () =>
                        {
                            // Validate the auth code
                            var validated = await _tokenProvider.ValidateCode(context.Request.QueryString["code"]);

                            if (validated)
                            {
                                // Get authenticated access_token
                                var token = await _tokenProvider.RetrieveToken();

                                // Get ID_token
                                var idToken = await _tokenProvider.RetrieveIdToken();

                                // Get refresh_token
                                var refreshToken = await _tokenProvider.RetrieveRefreshToken();

                                // Get the rotated code_verifier for subsequent calls
                                var codeVerifier = await _tokenProvider.RetrieveCodeVerifier();


                                // Retrieve validated claimset for the ID_Token 
                                var keysetProvider = new OpenIdKeySetProvider(_endpointProvider);
                                var claimsetProvider = new ValidatedClaimsetProvider(keysetProvider);
                                var claimset = await claimsetProvider.RetrieveClaimset(idToken);
                                var email = claimset.Value<string>(EMAIL_CLAIM);
                                Console.WriteLine($"Logged in as {email}");
                            }

                        }).Wait();
                    }
                }
            }
            catch
            {
                // probably just exiting
            }
        }
    }
}