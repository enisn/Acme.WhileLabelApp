using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using Acme.WhileLabelApp.Localization;
using Volo.Abp.Settings;
using Acme.WhileLabelApp.Settings;

namespace Acme.WhileLabelApp.Web;

[Dependency(ReplaceServices = true)]
public class WhileLabelAppBrandingProvider(
    IStringLocalizer<WhileLabelAppResource> l,
    ISettingProvider settingProvider
    ) : DefaultBrandingProvider
{
    public override string AppName 
    { 
        get 
        {
            var appNameSettingValue = settingProvider.GetOrNullAsync(WhileLabelAppSettings.AppName)
            .GetAwaiter().GetResult();
            
            return appNameSettingValue ?? l["AppName"];
        }
    }


    public override string? LogoUrl
    {
        get
        {
            var logoUrlSettingValue = settingProvider.GetOrNullAsync(WhileLabelAppSettings.AppLogo).GetAwaiter().GetResult();
            return logoUrlSettingValue ?? base.LogoUrl;
        }
    }
}
