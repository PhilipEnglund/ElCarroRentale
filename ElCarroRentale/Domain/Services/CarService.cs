using System.Collections.Generic;
using System.Threading.Tasks;
using ElCarroRentale.Domain.Entities;
using ElCarroRentale.Interfaces.Repositories;
using ElCarroRentale.Interfaces.Services;

namespace ElCarroRentale.Domain.Services
{
    public class CarService : ICarService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICarRepository _repository;

        public CarService(IUnitOfWork unitOfWork, ICarRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
        
        public async Task<IEnumerable<Car>> GetPaginatedAsync(int skip, int take)
        {
            return await _repository.GetPaginatedAsync(skip, take);
        }

        public Task<Car> GetByIdAsync(int carId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteAsync(Car entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Car> CreateNewAsync(Car entity)
        {
            var newCar = await _repository.CreateNewAsync(entity);
            await _unitOfWork.CompleteTaskAsync();
            return newCar;
        }

        public async Task<int> GetCollectionCountAsync()
        {
            return await _repository.GetCollectionCountAsync();
        }
    }
}