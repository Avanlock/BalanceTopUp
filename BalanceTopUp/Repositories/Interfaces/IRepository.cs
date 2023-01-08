using System.Threading.Tasks;
using BalanceTopUp.Models.BdModels;

namespace BalanceTopUp.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        Task Create(T item);
    }
}