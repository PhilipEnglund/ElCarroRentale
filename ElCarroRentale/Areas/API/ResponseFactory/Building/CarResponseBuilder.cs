using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using ElCarroRentale.Areas.API.AutoMapper.Resources;
using ElCarroRentale.Areas.API.ResponseFactory.Objects;
using ElCarroRentale.Domain.Entities;
using ElCarroRentale.Interfaces.ResponseFactory;
using ElCarroRentale.Interfaces.ResponseFactory.Base;
using Microsoft.AspNetCore.Http;

namespace ElCarroRentale.Areas.API.ResponseFactory.Building
{
    public class CarResponseBuilder : ICarResponseBuilder
    {
        private readonly IUrlBuilder _urlBuilder;
        private readonly IMapper _mapper;

        public CarResponseBuilder(IUrlBuilder urlBuilder, IMapper mapper)
        {
            _urlBuilder = urlBuilder;
            _mapper = mapper;
        }
        
        public SingleResponse<CarResource> BuildSingleResponse(HttpContext context, Car car)
        {
            return new SingleResponse<CarResource>
            {
                Result = _mapper.Map<Car, CarResource>(car)
            };
        }

        public EnumerableResponse<CarResource> BuildEnumerableResponse(HttpContext context, IEnumerable<Car> cars, 
            int take, int skip, int collectionCountTotal)
        {
            return new EnumerableResponse<CarResource>
            {
                Count = collectionCountTotal,
                Next = _urlBuilder.NextPaginationAvailable(collectionCountTotal, skip, take) 
                    ? _urlBuilder.GetNextPaginated(context, skip, take) 
                    : null,
                Previous = _urlBuilder.PreviousPaginationAvailable(skip)
                    ? _urlBuilder.GetPreviousPaginated(context, skip, take)
                    : null,
                Results = _mapper.Map<IEnumerable<Car>, IEnumerable<CarResource>>(cars)
            };
        }
    }
}