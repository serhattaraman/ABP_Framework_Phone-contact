using Acme.Concat.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Concat.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ConcatController : AbpControllerBase
{
    protected ConcatController()
    {
        LocalizationResource = typeof(ConcatResource);
    }
}
