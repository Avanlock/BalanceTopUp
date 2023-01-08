using BalanceTopUp.Models.BdModels;
using Microsoft.AspNetCore.Mvc;

namespace BalanceTopUp.Services
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActivServiceController : Controller
    {
        [HttpPost]
        [Route("TopUpBalance")]
        public string TopUpBalance(Payment payment)
        {
            return "success";
        }
    }
}