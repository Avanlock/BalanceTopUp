using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BalanceTopUp.Utils
{
    public static class RestApi
    {
        private const string MediaType = "application/json";

        public static async Task<string> PostAsync(string url, string data, HttpClient httpClient)
        {
            var encodingData = new StringContent(data, Encoding.UTF8, MediaType);
            using (httpClient)
            {
                var response = await httpClient.PostAsync(url, encodingData);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}