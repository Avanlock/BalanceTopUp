using System.ComponentModel.DataAnnotations;

namespace BalanceTopUp.Models.RequestModels
{
    public class PaymentRequest
    {
        
        [Required]
        public string Number { get; set; }
        [Required]
        public int Amount { get; set; }
    }
}