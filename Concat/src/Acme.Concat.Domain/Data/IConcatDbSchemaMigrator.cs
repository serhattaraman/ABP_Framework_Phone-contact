using System.Threading.Tasks;

namespace Acme.Concat.Data;

public interface IConcatDbSchemaMigrator
{
    Task MigrateAsync();
}
