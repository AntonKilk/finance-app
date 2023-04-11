using System.Text.Json;
using System.Text;

namespace MyFinanceBlazor.Services
{
    public class MyHttpService
    {
        private readonly HttpClient _httpClient;

        public MyHttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> GetAsync<T>(string uri)
        {
            var response = await _httpClient.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            var options = new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(content, options);
        }

        public async Task<T?> PostAsync<T>(string uri, T data)
        {
            var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(uri, content);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseContent);
        }

        public async Task PutAsync<T>(string uri, T data)
        {
            var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync(uri, content);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteAsync(string uri)
        {
            var response = await _httpClient.DeleteAsync(uri);
            response.EnsureSuccessStatusCode();
        }
    }

}
