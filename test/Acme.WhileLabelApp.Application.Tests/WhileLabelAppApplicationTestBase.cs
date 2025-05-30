using Volo.Abp.Modularity;

namespace Acme.WhileLabelApp;

public abstract class WhileLabelAppApplicationTestBase<TStartupModule> : WhileLabelAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
