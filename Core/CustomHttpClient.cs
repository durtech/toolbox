using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Toolbox.Core
{
    public class CustomHttpClient
    {
        public async Task<T> GetJsonAsync<T>(string requestUri)
        {
            HttpClient httpClient = new HttpClient();
            var httpContent = await httpClient.GetAsync(requestUri);
            string jsonContent = httpContent.Content.ReadAsStringAsync().Result;
            T obj = JsonSerializer.Deserialize<T>(jsonContent);
            httpContent.Dispose();
            httpClient.Dispose();
            return obj;
        }
        public async Task<HttpResponseMessage> PostJsonAsync<T>(string requestUri, T content)
        {
            HttpClient httpClient = new HttpClient();
            string myContent = JsonSerializer.Serialize(content);
            StringContent stringContent = new StringContent(myContent, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(requestUri, stringContent);
            httpClient.Dispose();
            return response;
        }
        public async Task<HttpResponseMessage> PutJsonAsync<T>(string requestUri, T content)
        {
            HttpClient httpClient = new HttpClient();
            string myContent = JsonSerializer.Serialize(content);
            StringContent stringContent = new StringContent(myContent, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync(requestUri, stringContent);
            httpClient.Dispose();
            return response;
        }
    }
}
