using System.Threading.Tasks;
using DynamicAppIcon.iOS.Services;
using DynamicAppIcon.Services;
using Xamarin.Forms;
using uiApplication = UIKit.UIApplication;

[assembly: Dependency(typeof(AppIconService))]
namespace DynamicAppIcon.iOS.Services
{
    public class AppIconService : IAppIconService
    {
        public Task ResetIcon()
        {
            return SetAppIcon(null);
        }

        public Task SetAppIcon(string icon)
        {
            if (!uiApplication.SharedApplication.SupportsAlternateIcons)
                return Task.CompletedTask;

            return uiApplication.SharedApplication.SetAlternateIconNameAsync(icon);
        }
    }
}