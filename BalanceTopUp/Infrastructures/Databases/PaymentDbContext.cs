using BalanceTopUp.Models.BdModels;
using Microsoft.EntityFrameworkCore;

namespace BalanceTopUp.Infrastructures.Databases
{
    public class PaymentDbContext : DbContext
    {
        public DbSet<Payment> Payments { get; set; }

        public PaymentDbContext(DbContextOptions<PaymentDbContext> options) : base(options)
        {
            
        }
    }
}