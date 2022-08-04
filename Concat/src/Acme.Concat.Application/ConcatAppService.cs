using System;
using System.Collections.Generic;
using System.Text;
using Acme.Concat.Localization;
using Volo.Abp.Application.Services;

namespace Acme.Concat;

/* Inherit your application services from this class.
 */
public abstract class ConcatAppService : ApplicationService
{
    protected ConcatAppService()
    {
        LocalizationResource = typeof(ConcatResource);
    }
}
