using Volo.Abp.Modularity;

namespace Acme.WhileLabelApp;

/* Inherit from this class for your domain layer tests. */
public abstract class WhileLabelAppDomainTestBase<TStartupModule> : WhileLabelAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
