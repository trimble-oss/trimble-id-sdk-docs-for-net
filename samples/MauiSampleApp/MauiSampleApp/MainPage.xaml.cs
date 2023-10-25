using Trimble.ID.Maui;

namespace MauiSampleApp;

public partial class MainPage : ContentPage
{
    private readonly MobileAuthenticator _mobileAuthenticator;

    public MainPage(MobileAuthenticator mobileAuthenticator)
    {
        InitializeComponent();
        BindingContext = this;

#if IOS
        _mobileAuthenticator = mobileAuthenticator.WithViewController(Platform.GetCurrentUIViewController());
#elif ANDROID
        _mobileAuthenticator = mobileAuthenticator.WithActivity(Platform.CurrentActivity);
#endif
        new Task(async () =>
        {
            await UiUpdateAsync();

        }).Start();

    }

    private bool _loggedIn
    {
        get { return _mobileAuthenticator.IsLoggedIn; }
        set { }
    }


    private async void LoginButton_Clicked(object sender, EventArgs e)
    {

        if (_loggedIn)
        {
            await _mobileAuthenticator.Logout(singleSignOut: true);
            _loggedIn = false;

        }
        else
        {
            _loggedIn = await _mobileAuthenticator.Login();

            if (_loggedIn)
            {
                ShowToast("User logged in ");
            }
            else
            {
                ShowToast("Login Unsuccessfull");

            }
        }
        await UiUpdateAsync();
    }

    private void ShowToast(string msg)
    {
        MainThread.BeginInvokeOnMainThread(async () =>
        {
            await CommunityToolkit.Maui.Alerts.Toast.Make(msg).Show();

        });
    }

    async void GetAccessToken_Clicked(object sender, EventArgs e)
    {

        if (_mobileAuthenticator.IsLoggedIn)
        {

            var accessToken = await _mobileAuthenticator.TokenProvider.RetrieveToken();
            GetAccessTokenText = accessToken;
        }
        else
        {
            GetAccessTokenText = "";
            ShowToast("User is not logged-in. Please try login.");
        }
    }

    private string _loginButtonText = "Login";

    public string LoginButtonText
    {
        get { return _loginButtonText; }
        set
        {
            _loginButtonText = value;
            OnPropertyChanged(nameof(LoginButtonText));
        }
    }

    private string _introText = "Please login to continue";

    public string IntroText
    {
        get { return _introText; }
        set
        {
            _introText = value;
            OnPropertyChanged(nameof(IntroText));
        }
    }
    private string _givenName;
    public string GivenName
    {
        get { return _givenName; }
        set
        {
            _givenName = value;
            OnPropertyChanged(nameof(GivenName));
        }
    }

    private string _familyName;
    public string FamilyName
    {
        get { return _familyName; }
        set
        {
            _familyName = value;
            OnPropertyChanged(nameof(FamilyName));
        }
    }

    private string _getAccessTokenText = "";

    public string GetAccessTokenText
    {
        get { return _getAccessTokenText; }
        set
        {
            _getAccessTokenText = value;
            OnPropertyChanged(nameof(GetAccessTokenText));
        }
    }

    private async Task UiUpdateAsync()
    {
        if (_loggedIn)
        {

            var userInfo = await _mobileAuthenticator.GetUserInfo();
            IntroText = "User Details";
            GivenName = userInfo.GivenName;
            FamilyName = userInfo.FamilyName;
            LoginButtonText = "Logout";
            GetAccessTokenText = "";
        }
        else
        {
            GivenName = string.Empty;
            FamilyName = string.Empty;
            LoginButtonText = "Login";
            IntroText = "Please login to continue";
            GetAccessTokenText = "";

        }
    }
}