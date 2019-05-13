using System.Collections.Generic;
using ElCarroRentale.Areas.API.AutoMapper.Resources;
using ElCarroRentale.Areas.API.ResponseFactory.Objects;
using ElCarroRentale.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace ElCarroRentale.Interfaces.ResponseFactory
{
    public interface ICarResponseBuilder
    {
        SingleResponse<CarResource> BuildSingleResponse(HttpContext context, Car car);

        EnumerableResponse<CarResource> BuildEnumerableResponse(HttpContext context, IEnumerable<Car> cars, int take,
            int skip, int collectionCountTotal);
    }
}