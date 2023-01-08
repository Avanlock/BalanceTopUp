using System.Threading.Tasks;
using BalanceTopUp.Infrastructures.Databases;
using BalanceTopUp.Models.BdModels;
using BalanceTopUp.Repositories.Interfaces;

namespace BalanceTopUp.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentDbContext _context;

        public PaymentRepository(PaymentDbContext context)
        {
            _context = context;
        }

        public async Task Create(Payment item)
        {
            await _context.Payments.AddAsync(item);
            await _context.SaveChangesAsync();
        }
    }
}