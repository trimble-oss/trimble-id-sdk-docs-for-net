using Android.App;
using Android.Content.PM;
using Android.OS;
using Trimble.ID.Maui;

namespace MauiSampleApp;

[Activity(Theme = "@style/Maui.MainTheme.NoActionBar", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle bundle)
    {
        base.OnCreate(bundle);

    }
}
