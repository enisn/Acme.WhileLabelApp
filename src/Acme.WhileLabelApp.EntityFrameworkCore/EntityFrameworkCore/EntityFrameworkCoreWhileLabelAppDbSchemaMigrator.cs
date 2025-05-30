using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.WhileLabelApp.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.WhileLabelApp.EntityFrameworkCore;

public class EntityFrameworkCoreWhileLabelAppDbSchemaMigrator
    : IWhileLabelAppDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreWhileLabelAppDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the WhileLabelAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<WhileLabelAppDbContext>()
            .Database
            .MigrateAsync();
    }
}
