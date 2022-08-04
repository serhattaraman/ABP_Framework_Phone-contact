using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.Concat.Data;

/* This is used if database provider does't define
 * IConcatDbSchemaMigrator implementation.
 */
public class NullConcatDbSchemaMigrator : IConcatDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
