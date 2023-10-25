using CommunityToolkit.Maui;
using Trimble.ID.Maui;
using TrimbleCloud.Authentication;

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
        var authenticator = new MobileAuthenticator(
            endpointProvider,
            "<CLIEND_ID>",
            new[] { "<SCOPES>" },
            "<REDIRECT_URI>", allowPersistenceStorage: true);

        builder.Services.AddSingleton(authenticator);
        builder.Services.AddSingleton<MainPage>();
        return builder.Build();
    }
}
