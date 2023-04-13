using System.Text.Json;
using System.Text;

namespace MyFinanceBlazor.Services
{
    public class MyHttpService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MyHttpService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<T> GetAsync<T>(string uri)
        {
            var client = _httpClientFactory.CreateClient("AntonsConfig");

            var response = await client.GetAsync(uri);
            response.EnsureSuccessStatusCode();

            var options = new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(content, options);
        }

        public async Task<T?> PostAsync<T>(string uri, T data)
        {
            var client = _httpClientFactory.CreateClient("AntonsConfig");

            var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(uri, content);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseContent);
        }

        public async Task PutAsync<T>(string uri, T data)
        {
            var client = _httpClientFactory.CreateClient("AntonsConfig");

            var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

            var response = await client.PutAsync(uri, content);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteAsync(string uri)
        {
            var client = _httpClientFactory.CreateClient("AntonsConfig");

            var response = await client.DeleteAsync(uri);
            response.EnsureSuccessStatusCode();
        }
    }

}
