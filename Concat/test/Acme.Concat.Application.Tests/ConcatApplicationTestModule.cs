using Volo.Abp.Modularity;

namespace Acme.Concat;

[DependsOn(
    typeof(ConcatApplicationModule),
    typeof(ConcatDomainTestModule)
    )]
public class ConcatApplicationTestModule : AbpModule
{

}
