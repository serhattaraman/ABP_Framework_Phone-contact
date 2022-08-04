using Acme.Concat.Concats;
using AutoMapper;

namespace Acme.Concat.Web;

public class ConcatWebAutoMapperProfile : Profile
{
    public ConcatWebAutoMapperProfile()
    {
        CreateMap<ConcatDto, CreateUpdateConcatDto>();
    }
}
