using System;
using System.Threading.Tasks;

namespace ElCarroRentale.Interfaces.Services
{
    public interface IUnitOfWork
    {
        Task CompleteTaskAsync();
    }
}