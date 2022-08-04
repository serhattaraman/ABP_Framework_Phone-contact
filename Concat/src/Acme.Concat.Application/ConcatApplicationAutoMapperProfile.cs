using Acme.Concat.Concats;
using AutoMapper;

namespace Acme.Concat;

public class ConcatApplicationAutoMapperProfile : Profile
{
    public ConcatApplicationAutoMapperProfile()
    {
        CreateMap<Concats.Concat, ConcatDto>();
        CreateMap<CreateUpdateConcatDto, Concats.Concat>();
    }
}
