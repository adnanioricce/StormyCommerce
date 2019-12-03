using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using StormyCommerce.Module.Customer.Models;

namespace StormyCommerce.Api.Tests
{
    public static class ClientExtensions
    {
        public static void SetBearerToken(this HttpClient httpClient,string token)
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
        public static async Task AuthenticateAsAdmin(this HttpClient client)
        {
            var response = await client.PostAsJsonAsync("/api/Authentication/login", new { email = "adnangonzaga@gmail.com", password = "!D4velopment" });
            var objectResponse = await response.Content.ReadAsAsync<AuthResponse>();
            client.SetBearerToken(objectResponse.AccessToken);
        }
    }
}
