using Foundation;
using Trimble.ID.Maui;
using UIKit;

namespace MauiSampleApp;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override bool OpenUrl(UIApplication app, NSUrl url, NSDictionary options)
    {
        new Task(async () =>
        {
            await IPlatformApplication.Current.Services.GetService<MobileAuthenticator>().OnReceive(url.Query);
        })
        .Start();
        return true;
    }
}
