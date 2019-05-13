using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElCarroRentale.Data;
using ElCarroRentale.Domain.Entities;
using ElCarroRentale.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ElCarroRentale.Domain.Repositories
{
    public class CarRepository : ICarRepository
    {

        private readonly ApplicationDbContext _dbContext;

        public CarRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<IEnumerable<Car>> GetPaginatedAsync(int skip, int take)
        {
            return await _dbContext.Cars.Skip(skip).Take(take).ToListAsync();
        }

        public Task<Car> GetByIdAsync(int carId)
        {
            throw new System.NotImplementedException();
        }

        public void LogDeleteCar(Car entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Car> CreateNewAsync(Car entity)
        {
            var car = await _dbContext.Cars.AddAsync(entity);
            return car.Entity;
        }

        public async Task<int> GetCollectionCountAsync()
        {
            return await _dbContext.Cars.CountAsync();
        }
    }
}