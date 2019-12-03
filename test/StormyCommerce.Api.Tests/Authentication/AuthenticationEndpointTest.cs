using System;
using System.Net.Http;
using System.Threading.Tasks;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Module.Customer.Areas.Customer.ViewModels;
using StormyCommerce.Module.Customer.Models;
using StormyCommerce.Module.Customer.Models.Requests;
using Xunit;

namespace StormyCommerce.Api.Tests.Authentication
{
    public class AuthenticationEndpointTest
    {
        private readonly HttpClient client;
        public AuthenticationEndpointTest()
        {
            client = new HttpClient();
            client.BaseAddress = new System.Uri(Config.BaseUrl);
        }
        [Fact]
        public async Task LoginEndpointTest()
        {
            var response = await client.PostAsJsonAsync("/api/Authentication/login", new { email = "adnangonzaga@gmail.com", password = "!D4velopment" });
            Assert.True(response.IsSuccessStatusCode);            
        }
        [Fact]
        public async Task RegisterEndpointTest()
        {
            var response = await client.PostAsJsonAsync("/api/Authentication/register", new SignUpVm { Email = "example@gmail.com",UserName = "example", Password = "!D4velopment" });            
            Assert.True(response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task AddShippingAddressEndpointTest()
        {
            await SetUserForRequest();
            var response = await client.PostAsJsonAsync("/api/Account/add_shipping_address",new CreateShippingAddressRequest { 
                IsDefault = true,
                Type = Core.Entities.Customer.AddressType.Shipping,
                Address = new Address("br", "São Paulo", "São Paulo", "Jardim Ipanema (Zona Sul)", "Rua Bento Correia de Figueiredo", "Jardim Ipanema (Zona Sul)", "Rua Bento Correia de Figueiredo", "04784110", "640", "complemento"),
                WhoReceives = "I"
            });
            Assert.True(response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task EditAccountEndpointTest()
        {
            await SetUserForRequest();
            var response = await client.PostAsJsonAsync("/api/Account/edit_account", new EditCustomerRequest
            {
                CPF = "12345678910",
                DateOfBirth = DateTimeOffset.UtcNow,
                Email = "aguinobaldo@gmail.com",
                PhoneNumber = "+55111234567",
                FullName = "aguinobaldo silva pereira",
                UserName = "aguinobaldo666"
            });
            Assert.True(response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task EditShippingAddressEndpointTest()
        {
            await SetUserForRequest();
            var response = await client.PostAsJsonAsync("/api/Account/edit_shipping_address", new EditCustomerAddressRequest
            {                
                Address = new Address("br", "São Paulo", "São Paulo", "Jardim Ipanema (Zona Sul)", "Rua Bento Correia de Figueiredo", "Jardim Ipanema (Zona Sul)", "Rua Bento Correia de Figueiredo", "04784110", "640", "complemento"),
                WhoReceives = "I"
            });
        }
        [Fact]
        public async Task ResendConfirmationEmailAsync()
        {
            await SetUserForRequest();
            var response = await client.PostAsJsonAsync("api/Account/resend_confirm_email",new object());
            Assert.True(response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task GetCurrentUserEndPointTest()
        {
            await SetUserForRequest();
            var response = await client.GetAsync("api/Account/get_current_user");
            Assert.True(response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task DeleteAccountEndpointTest()
        {
            var authResponse = await client.PostAsJsonAsync("/api/Authentication/login", new { email = "aguinobaldis@gmail.com", password = "!D4velopment" });
            var authResult = await authResponse.Content.ReadAsAsync<AuthResponse>();
            client.SetBearerToken(authResult.AccessToken);
            var response = await client.DeleteAsync("/api/Account/delete_address?addressId=1");
            Assert.True(response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task DeleteAddressEndpointTest()
        {
            await SetUserForRequest();
            //var response =

        }
        public async Task SetUserForRequest()
        {
            var response = await client.PostAsJsonAsync("/api/Authentication/login", new { email = "adnangonzaga@gmail.com", password = "!D4velopment" });
            var objectResponse = await response.Content.ReadAsAsync<AuthResponse>();
            client.SetBearerToken(objectResponse.AccessToken);
        }
    }
}
