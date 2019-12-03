using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Models.Order;
using StormyCommerce.Core.Models.Order.Request;

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
        public async Task CheckoutBoletoEndpointTest()
        {
            await client.Authenticate();
            var response = await client.PostAsJsonAsync<CheckoutRequest>("/api/Checkout/boleto",new CheckoutRequest { 
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
        //public async Task CheckoutCreditCardEndpointTest()
        //{

        //}
    }
}
