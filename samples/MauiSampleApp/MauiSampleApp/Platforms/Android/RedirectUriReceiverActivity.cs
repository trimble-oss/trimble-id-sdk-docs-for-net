using Android.App;
using Android.Content.PM;
using Android.OS;
using Trimble.ID.Maui;

namespace MauiSampleApp;

[Activity(NoHistory = true, LaunchMode = LaunchMode.SingleTop, Exported = true)]
[IntentFilter(new[] { Android.Content.Intent.ActionView },
    Categories = new[] { Android.Content.Intent.CategoryDefault, Android.Content.Intent.CategoryBrowsable },
    DataScheme = "<CUSTOM_URI_SCHEME>")]

public class RedirectUriReceiverActivity : Activity
{
    private readonly MobileAuthenticator _mobileAuthenticator = MauiApplication.Current.Services.GetService<MobileAuthenticator>();

    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        new Task(async () =>
         {
             await _mobileAuthenticator.OnReceive(this.Intent.Data.GetQueryParameter("state"), this.Intent.Data.GetQueryParameter("code"));

         })
         .Start();
        this.Finish();
    }
}