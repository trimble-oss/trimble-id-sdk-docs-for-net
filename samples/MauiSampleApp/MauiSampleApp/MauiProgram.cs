using CommunityToolkit.Maui;
using Trimble.ID;
using Trimble.ID.Maui;

namespace MauiSampleApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>().UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Add MobileAuthenticator as Singleton in service builder
        const string WELL_KNOWN_ENDPOINT = "https://id.trimble.com/.well-known/openid-configuration";
        var endpointProvider = new OpenIdEndpointProvider(new Uri(WELL_KNOWN_ENDPOINT, UriKind.Absolute));

        var options = new MobileAuthenticatorOptions
        {
            EndpointProvider = endpointProvider,
            ClientId = "<CLIENT_ID>",
            Scopes = new[] { "<SCOPES>" },
#if WINDOWS
            RedirectUri = "<LOCALHOST_REDIRECT_URI>",
#else
            RedirectUri = "<REDIRECT_URI>",
#endif
            EnableTokenPersistence = true
        };

        var authenticator = new MobileAuthenticator(options);

        builder.Services.AddSingleton(authenticator);
        builder.Services.AddSingleton<MainPage>();
        return builder.Build();
    }
}
