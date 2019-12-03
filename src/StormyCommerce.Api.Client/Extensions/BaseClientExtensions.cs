using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using StormyCommerce.Module.Customer.Models;

namespace StormyCommerce.Api.Client.Extensions
{
    public static class BaseClientExtensions
    {
        public static void SetBearerToken(this HttpClient httpClient, string token)
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
        public static async Task Authenticate(this HttpClient client, bool isAdmin = false)
        {
            string email = "";
            string password = "";
            if (isAdmin)
            {
                email = "stormycommerce@gmail.com";
                password = "!D4vpassword";
            }
            else
            {
                email = "adnangonzaga@gmail.com";
                password = "!D4velopment";
            }
            var response = await client.PostAsJsonAsync("/api/Authentication/login", new { email = email, password = password });
            var objectResponse = await response.Content.ReadAsAsync<AuthResponse>();
            client.SetBearerToken(objectResponse.AccessToken);
        }
    }
}
