using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.Concat.Concats
{
    public interface IConcatAppService :
        ICrudAppService< //Defines CRUD methods
            ConcatDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateConcatDto> //Used to create/update a book
    {

    }
}
