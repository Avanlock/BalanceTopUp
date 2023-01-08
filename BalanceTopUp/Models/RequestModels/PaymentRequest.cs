using System.ComponentModel.DataAnnotations;

namespace BalanceTopUp.Models.RequestModels
{
    public class PaymentRequest
    {
        public string Number { get; set; }
        public int Amount { get; set; }
    }
}