using System.Collections.Generic;
using System.Threading.Tasks;
using ElCarroRentale.Domain.Entities;

namespace ElCarroRentale.Interfaces.Services
{
    public interface ICarService
    {
        Task<IEnumerable<Car>> GetPaginatedAsync(int skip, int take);
        Task<Car> GetByIdAsync(int carId);
        Task<Car> DeleteCarAsync(Car car);
        Task<Car> CreateNewAsync(Car car);
    }
}