using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Models.Order;
using StormyCommerce.Core.Models.Order.Request;
using Xunit;

namespace StormyCommerce.Api.Tests.Checkout
{
    public class CheckoutEndpointTest
    {
        private readonly HttpClient client;
        public CheckoutEndpointTest()
        {
            client = new HttpClient();
            client.BaseAddress = new System.Uri(Config.BaseUrl);
        }
        [Fact]
        public async Task CheckoutBoletoEndpointTest()
        {
            await client.Authenticate();
            var response = await client.PostAsJsonAsync<CheckoutBoletoRequest>("/api/Checkout/boleto",new CheckoutBoletoRequest { 
                Amount = 10.0m,
                Items =  new List<CartItem>
                {
                    new CartItem
                    {
                        Quantity = 1,
                        StormyProductId = 2
                    },
                    new CartItem
                    {
                        Quantity = 1,
                        StormyProductId = 1
                    }
                },
                PaymentMethod = PaymentMethod.Boleto,
                PickUpOnStore = false,
                PostalCode = "08621030",
                ShippingMethod = ShippingMethod.Sedex
            });
        }
        [Fact]
        public async Task CheckoutCreditEndpointTest()
        {
            await client.Authenticate();
            var response = await client.PostAsJsonAsync<CheckoutCreditCardRequest>("/api/Checkout/credit_card", new CheckoutCreditCardRequest
            {
                Amount = 12.00m,
                Items = new List<CartItem>
                {
                    new CartItem
                    {
                        Quantity = 1,
                        StormyProductId = 4
                    },
                    new CartItem
                    {
                        Quantity = 1,
                        StormyProductId = 1
                    }
                },
                PickUpOnStore = false,
                ShippingMethod = ShippingMethod.Sedex,
                PostalCode = "08621030",
                CardNumber = "4716854604523016",
                CardExpirationDate = "0720",
                CardCvv = "996",
                CardHolderName = "Test User"
            });
            var content = await response.Content.ReadAsStringAsync();
            Assert.True(response.IsSuccessStatusCode);
        }
        //public async Task CheckoutCreditCardEndpointTest()
        //{

        //}
    }
}
