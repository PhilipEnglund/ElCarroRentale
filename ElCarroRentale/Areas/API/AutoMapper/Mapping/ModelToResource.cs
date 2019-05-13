using AutoMapper;
using ElCarroRentale.Areas.API.AutoMapper.Resources;
using ElCarroRentale.Domain.Entities;

namespace ElCarroRentale.Areas.API.AutoMapper.Mapping
{
    public class ModelToResource : Profile
    {
        public ModelToResource()
        {
            CreateMap<Car, CarResource>();
        }
    }
}