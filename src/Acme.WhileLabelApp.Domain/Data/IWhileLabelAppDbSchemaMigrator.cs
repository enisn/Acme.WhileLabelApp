using System.Threading.Tasks;

namespace Acme.WhileLabelApp.Data;

public interface IWhileLabelAppDbSchemaMigrator
{
    Task MigrateAsync();
}
