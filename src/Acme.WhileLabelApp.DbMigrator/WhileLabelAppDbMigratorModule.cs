using Acme.WhileLabelApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.WhileLabelApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(WhileLabelAppEntityFrameworkCoreModule),
    typeof(WhileLabelAppApplicationContractsModule)
)]
public class WhileLabelAppDbMigratorModule : AbpModule
{
}
