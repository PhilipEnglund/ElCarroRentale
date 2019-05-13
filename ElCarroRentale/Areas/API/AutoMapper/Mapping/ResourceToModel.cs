using AutoMapper;
using ElCarroRentale.Areas.API.AutoMapper.Resources;
using ElCarroRentale.Domain.Entities;

namespace ElCarroRentale.Areas.API.AutoMapper.Mapping
{
    public class ResourceToModel : Profile
    {
        public ResourceToModel()
        {
            CreateMap<CarResource, Car>();
            CreateMap<CreateCarResource, Car>();
        }
    }
}