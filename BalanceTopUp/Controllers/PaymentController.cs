using System;
using System.Net.Http;
using System.Threading.Tasks;
using BalanceTopUp.Models.BdModels;
using BalanceTopUp.Models.RequestModels;
using BalanceTopUp.Repositories.Interfaces;
using BalanceTopUp.Utils;
using Microsoft.AspNetCore.Mvc;

namespace BalanceTopUp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : Controller
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly HttpClient _httpClient;

        public PaymentController(IPaymentRepository paymentRepository, HttpClient httpClient)
        {
            _paymentRepository = paymentRepository;
            _httpClient = httpClient;
        }
        
        /// <summary>
        /// Метод для определения оператора, пополнения баланса и внесения записи в БД
        /// </summary>
        [HttpPost]
        [Route("CratePayment")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<PaymentResponse>> CratePaymentAsync([FromBody]PaymentRequest paymentRequest)
        {
            try
            {
                if (Validator.CheckNumber(paymentRequest.Number))
                {
                    var phoneOperatorResult = new OperatorsHelper(_httpClient).DefineOperator(paymentRequest);

                    if (phoneOperatorResult.Result == "success")
                    {
                        var payment = new Payment()
                        {
                            Number = paymentRequest.Number,
                            Amount = paymentRequest.Amount
                        };
                        await _paymentRepository.Create(payment);
                        return Ok(new PaymentResponse() { Message = "Success" });
                    }
                    return BadRequest(new PaymentResponse() { Message = $"Fail with message: {phoneOperatorResult.Result}" });
                }
                return BadRequest(new PaymentResponse() { Message = $"Not valid number" });

            }
            catch (Exception ex)
            {
                return BadRequest(new PaymentResponse() { Message = $"Fail with error: {ex.Message}" }); 
            }
        }
    }
}