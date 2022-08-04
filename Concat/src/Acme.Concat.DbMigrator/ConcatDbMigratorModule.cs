using Acme.Concat.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.Concat.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ConcatEntityFrameworkCoreModule),
    typeof(ConcatApplicationContractsModule)
    )]
public class ConcatDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
