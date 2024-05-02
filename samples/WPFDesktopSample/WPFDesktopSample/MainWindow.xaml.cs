using Newtonsoft.Json;
using System.Windows;
using System.Windows.Controls;
using Trimble.ID;
using Trimble.ID.Desktop;

namespace WPFDesktopSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string Scope = "<SCOPES>";
        private const string ClientId = "<CLIENT_ID>";
        private const string FileName = "userTest.config";
        private static IEndpointProvider endpointProvider = OpenIdEndpointProvider.Production;
        private static IAuthenticator _authenticator;

        public MainWindow()
        {
            InitializeComponent();

            _authenticator = ConfigureAuthenticator(Scope, ClientId);
            if (_authenticator.IsLoggedIn)
            {
                ShowButtons();
            }
            else
            {
                HideButtons();
            }
        }

        #region Authenticator setup

        // While an app specific salt is not the best practice for password based encryption,
        // it's probably safe enough as long as it is truly uncommon
        private static readonly byte[] Salt = { 0xb7, 0xa2, 0x46, 0x53, 0x84, 0xf0, 0x49, 0xc6, 0x4f, 0x9b };

        private static LocalhostAuthenticator ConfigureAuthenticator(string scope, string clientId)
        {
            var persistentStorage = new EncryptedStorage(new IsolatedFileStorage(FileName), Salt);

            return new LocalhostAuthenticator(endpointProvider, clientId, new[] { scope })
                .WithPersistentStorage(persistentStorage);
        }

        #endregion

        private async void Login_OnClick(object sender, RoutedEventArgs e)
        {
            if (!_authenticator.IsLoggedIn)
            {
                try
                {
                    var result = await _authenticator.Login();

                    if (result)
                    {
                        ShowButtons();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    var result = await _authenticator.Logout();

                    if (result)
                    {
                        HideButtons();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void GetAccessToken_OnClick(object sender, RoutedEventArgs e)
        {
            var accessToken = await _authenticator.TokenProvider.RetrieveToken();
            TextBox.Text = accessToken;
        }

        private async void GetUserInfo_OnClick(object sender, RoutedEventArgs e)
        {
            var userInfo = await _authenticator.GetUserInfo();
            var userInfoString = Newtonsoft.Json.JsonConvert.SerializeObject(userInfo, Formatting.Indented);
            TextBox.Text = $"{userInfoString}";
        }

        private void HideButtons()
        {
            LoginBtn.Content = "Login";
            GetAccessTokenBtn.Visibility = Visibility.Hidden;
            GetUserInfoBtn.Visibility = Visibility.Hidden;
            TextBox.Text = "Not logged in!";
        }

        private void ShowButtons()
        {
            LoginBtn.Content = "Logout";
            GetAccessTokenBtn.Visibility = Visibility.Visible;
            GetUserInfoBtn.Visibility = Visibility.Visible;
            TextBox.Text = "Logged in!\nYou can now get access token and user info";
        }
    }
}