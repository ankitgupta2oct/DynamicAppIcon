using System.Threading.Tasks;

namespace DynamicAppIcon.Services
{
    public interface IAppIconService
    {
        Task ResetIcon();
        Task SetAppIcon(string icon);
    }
}