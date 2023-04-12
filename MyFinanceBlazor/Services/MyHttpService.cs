using System.Text.Json;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace MyFinanceBlazor.Services
{
    public class MyHttpService
    {
        private readonly HttpClient _httpClient;
        private readonly string _mainUrl;

        public MyHttpService(HttpClient httpClient, string mainUrl)
        {
            _httpClient = httpClient;
            _mainUrl = mainUrl;
        }

        public async Task<T> GetAsync<T>(string uri)
        {
            var response = await _httpClient.GetAsync(_mainUrl + uri);
            response.EnsureSuccessStatusCode();
            var options = new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(content, options);
        }

        public async Task<T?> PostAsync<T>(string uri, T data)
        {
            var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_mainUrl + uri, content);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseContent);
        }

        public async Task PutAsync<T>(string uri, T data)
        {
            var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync(_mainUrl + uri, content);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteAsync(string uri)
        {
            var response = await _httpClient.DeleteAsync(_mainUrl + uri);
            response.EnsureSuccessStatusCode();
        }
    }

}
