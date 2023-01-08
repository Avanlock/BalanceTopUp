using System;

namespace BalanceTopUp.Models.BdModels
{
    public class Payment
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int Amount { get; set; }
        public DateTime ReplenishmentDate { get; set; } = DateTime.Now;
    }
}