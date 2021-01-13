using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DynamicAppIcon
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ThemeSwitchPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
