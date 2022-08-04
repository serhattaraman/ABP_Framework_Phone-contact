using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Concat.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.Concat.Concats
{
    public class ConcatAppService: CrudAppService<
            Concat, //The concat entity
            ConcatDto, //Used to show concats
            Guid, //Primary key of the concat entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateConcatDto>, //Used to create/update a concat
        IConcatAppService //implement the IConcatAppService
    {
        public ConcatAppService(IRepository<Concat, Guid> repository) : base(repository)
        {
            GetPolicyName = ConcatPermissions.Concats.Default;
            GetListPolicyName = ConcatPermissions.Concats.Default;
            CreatePolicyName = ConcatPermissions.Concats.Create;
            UpdatePolicyName = ConcatPermissions.Concats.Edit;
            DeletePolicyName = ConcatPermissions.Concats.Delete;
        }
    }
}
