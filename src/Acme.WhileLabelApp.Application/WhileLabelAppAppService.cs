using Acme.WhileLabelApp.Localization;
using Volo.Abp.Application.Services;

namespace Acme.WhileLabelApp;

/* Inherit your application services from this class.
 */
public abstract class WhileLabelAppAppService : ApplicationService
{
    protected WhileLabelAppAppService()
    {
        LocalizationResource = typeof(WhileLabelAppResource);
    }
}
