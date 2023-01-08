using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using BalanceTopUp.Models.RequestModels;

namespace BalanceTopUp.Utils
{
    public class OperatorsHelper
    {
        private readonly HttpClient _httpClient;

        public OperatorsHelper(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> DefineOperator(PaymentRequest paymentRequest)
        {
            string jsonString = JsonSerializer.Serialize(paymentRequest);
            if (paymentRequest.Number.StartsWith("+701") || paymentRequest.Number.StartsWith("701") || paymentRequest.Number.StartsWith("8701"))
            {
                return await RestApi.PostAsync($"https://localhost:5001/api/ActivService/TopUpBalance", jsonString, _httpClient);
            }
            else if (paymentRequest.Number.StartsWith("+705") || paymentRequest.Number.StartsWith("705") || paymentRequest.Number.StartsWith("8705") ||
                     paymentRequest.Number.StartsWith("+777") || paymentRequest.Number.StartsWith("8777") || paymentRequest.Number.StartsWith("+777"))
            {
                return await RestApi.PostAsync($"https://localhost:5001/api/ActivService/TopUpBalance", jsonString, _httpClient);
            }
            else if (paymentRequest.Number.StartsWith("+707") || paymentRequest.Number.StartsWith("707") || paymentRequest.Number.StartsWith("8707") ||
                     paymentRequest.Number.StartsWith("+747") || paymentRequest.Number.StartsWith("8747") || paymentRequest.Number.StartsWith("+747"))
            {
                return await RestApi.PostAsync($"https://localhost:5001/api/ActivService/TopUpBalance", jsonString, _httpClient);
            }
            else if (paymentRequest.Number.StartsWith("+700") || paymentRequest.Number.StartsWith("700") || paymentRequest.Number.StartsWith("8700") ||
                     paymentRequest.Number.StartsWith("+708") || paymentRequest.Number.StartsWith("8708") || paymentRequest.Number.StartsWith("+708"))
            {
                return await RestApi.PostAsync($"https://localhost:5001/api/ActivService/TopUpBalance", jsonString, _httpClient);
            }

            return "Operator not found!";
        }
    }
}