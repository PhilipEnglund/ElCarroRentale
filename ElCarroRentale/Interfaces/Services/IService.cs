using System.Collections.Generic;
using System.Threading.Tasks;
using ElCarroRentale.Domain.Entities;

namespace ElCarroRentale.Interfaces.Services
{
    public interface IService<TEntity>
    {
        Task<IEnumerable<TEntity>> GetPaginatedAsync(int skip, int take);
        Task<TEntity> GetByIdAsync(int carId);
        Task<bool> DeleteAsync(TEntity entity);
        Task<TEntity> CreateNewAsync(TEntity entity);
        Task<int> GetCollectionCountAsync();
    }
}