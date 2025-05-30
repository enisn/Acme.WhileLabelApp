using Acme.WhileLabelApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.WhileLabelApp.Web.Pages;

public abstract class WhileLabelAppPageModel : AbpPageModel
{
    protected WhileLabelAppPageModel()
    {
        LocalizationResourceType = typeof(WhileLabelAppResource);
    }
}
