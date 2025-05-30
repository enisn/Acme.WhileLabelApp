using Volo.Abp.Modularity;

namespace Acme.WhileLabelApp;

[DependsOn(
    typeof(WhileLabelAppDomainModule),
    typeof(WhileLabelAppTestBaseModule)
)]
public class WhileLabelAppDomainTestModule : AbpModule
{

}
