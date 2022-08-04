using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.Concat.Web;

[Dependency(ReplaceServices = true)]
public class ConcatBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Concat";
}
