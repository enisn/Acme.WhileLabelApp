using Volo.Abp.Modularity;

namespace Acme.WhileLabelApp;

[DependsOn(
    typeof(WhileLabelAppApplicationModule),
    typeof(WhileLabelAppDomainTestModule)
)]
public class WhileLabelAppApplicationTestModule : AbpModule
{

}
