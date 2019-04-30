using System.Collections.Generic;
using System.Threading.Tasks;
using ElCarroRentale.Domain.Entities;

namespace ElCarroRentale.Interfaces.Repositories
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetPaginatedAsync(int skip, int take);
        Task<Car> GetByIdAsync(int carId);
        void LogDeleteCar(Car car);
        Task<Car> CreateNewAsync(Car car);
    }
}