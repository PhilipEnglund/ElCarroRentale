using System;
using System.Threading.Tasks;
using AutoMapper;
using ElCarroRentale.Areas.API.AutoMapper.Resources;
using ElCarroRentale.Areas.API.ResponseFactory.Objects;
using ElCarroRentale.Domain.Entities;
using ElCarroRentale.Interfaces.ResponseFactory;
using ElCarroRentale.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElCarroRentale.Areas.API.Controllers
{
    [ApiController]
    [Route("thecapi/[controller]")]
    public class CarsController : ControllerBase
    {
        //Implement Create, Read (id and enumerable), Delete
        private readonly ICarService _carService;
        private readonly ICarResponseBuilder _responseBuilder;
        private readonly IMapper _mapper;

        public CarsController(ICarService carService, ICarResponseBuilder responseBuilder, IMapper mapper)
        {
            _carService = carService;
            _responseBuilder = responseBuilder;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<EnumerableResponse<CarResource>>> GetPaginatedAsync([FromQuery] int skip,
            int take = 10)
        {
            try
            {
                var cars = await _carService.GetPaginatedAsync(skip, take);
                var collectionCount = await _carService.GetCollectionCountAsync();

                return Ok(_responseBuilder.BuildEnumerableResponse(HttpContext, cars, take, skip, collectionCount));
            }
            catch (Exception ex)
            {
                return BadRequest(new{message = "Could not fetch cars", error = ex});
            }
        }

        [HttpPost]
        public async Task<ActionResult<SingleResponse<CarResource>>> CreateNewAsync([FromBody] CreateCarResource resource)
        {
            try
            {
                var carToCreate = await _carService.CreateNewAsync(_mapper.Map<CreateCarResource, Car>(resource));

                return Created($"https://{HttpContext.Request.Path}/thecapi/cars/{carToCreate.Id}"
                    ,_responseBuilder.BuildSingleResponse(HttpContext, carToCreate));
            }
            catch (Exception ex)
            {
                return BadRequest(new {message = "Could not create car", error = ex});
            }
        }
    }
}