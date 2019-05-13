using System.Collections.Generic;
using System.Threading.Tasks;
using ElCarroRentale.Domain.Entities;

namespace ElCarroRentale.Interfaces.Repositories
{
    public interface IRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetPaginatedAsync(int skip, int take);
        Task<TEntity> GetByIdAsync(int carId);
        void LogDeleteCar(TEntity entity);
        Task<TEntity> CreateNewAsync(TEntity entity);
        Task<int> GetCollectionCountAsync();
    }
}