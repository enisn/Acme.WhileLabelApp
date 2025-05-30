using Acme.WhileLabelApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.WhileLabelApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class WhileLabelAppController : AbpControllerBase
{
    protected WhileLabelAppController()
    {
        LocalizationResource = typeof(WhileLabelAppResource);
    }
}
