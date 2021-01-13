using DynamicAppIcon.Services;
using Xamarin.Forms;

namespace DynamicAppIcon
{
    public partial class ThemeSwitchPage : ContentPage
    {
        private IAppIconService _appIconService;

        public ThemeSwitchPage()
        {
            InitializeComponent();

            _appIconService = DependencyService.Get<IAppIconService>();
        }

        async void LightModeClicked(object sender, System.EventArgs e)
        {
            ThemeSelected(OSAppTheme.Light);
            await _appIconService.ResetIcon().ConfigureAwait(false);
        }

        async void DarkModeClicked(object sender, System.EventArgs e)
        {
            ThemeSelected(OSAppTheme.Dark);
            await _appIconService.SetAppIcon("XamarinDark").ConfigureAwait(false);
        }

        void ThemeSelected(OSAppTheme theme)
        {
            Application.Current.UserAppTheme = theme;
        }
    }
}