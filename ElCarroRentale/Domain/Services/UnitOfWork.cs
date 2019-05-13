using System.Threading.Tasks;
using ElCarroRentale.Data;
using ElCarroRentale.Interfaces.Services;

namespace ElCarroRentale.Domain.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CompleteTaskAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}