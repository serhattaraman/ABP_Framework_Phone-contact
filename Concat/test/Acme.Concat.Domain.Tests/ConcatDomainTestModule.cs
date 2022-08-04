using Acme.Concat.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.Concat;

[DependsOn(
    typeof(ConcatEntityFrameworkCoreTestModule)
    )]
public class ConcatDomainTestModule : AbpModule
{

}
