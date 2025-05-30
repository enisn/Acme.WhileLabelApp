using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.WhileLabelApp.Data;

/* This is used if database provider does't define
 * IWhileLabelAppDbSchemaMigrator implementation.
 */
public class NullWhileLabelAppDbSchemaMigrator : IWhileLabelAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
