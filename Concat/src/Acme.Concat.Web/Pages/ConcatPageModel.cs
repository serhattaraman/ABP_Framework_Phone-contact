using Acme.Concat.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.Concat.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ConcatPageModel : AbpPageModel
{
    protected ConcatPageModel()
    {
        LocalizationResourceType = typeof(ConcatResource);
    }
}
