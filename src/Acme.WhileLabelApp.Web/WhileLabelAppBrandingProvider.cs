using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using Acme.WhileLabelApp.Localization;

namespace Acme.WhileLabelApp.Web;

[Dependency(ReplaceServices = true)]
public class WhileLabelAppBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<WhileLabelAppResource> _localizer;

    public WhileLabelAppBrandingProvider(IStringLocalizer<WhileLabelAppResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
