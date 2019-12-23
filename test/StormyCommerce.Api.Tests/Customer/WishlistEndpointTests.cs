using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Api.Tests.Customer
{
    public class WishlistEndpointTests 
    {
        private readonly HttpClient client;
        public WishlistEndpointTests()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(Config.BaseUrl);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]        
        public async Task AddItemToWishlistEndpointTest(long productId)
        {
            await client.Authenticate();
            var response = await client.PostAsJsonAsync($"/api/Wishlist/add_item?productId={productId}", new object());
            Assert.True(response.IsSuccessStatusCode);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public async Task RemoveItemFromWishlistEndpointTest(long productId)
        {
            await client.Authenticate();
            var response = await client.PostAsJsonAsync($"/api/Wishlist/remove_item?productId={productId}", new object());
            Assert.True(response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task GetWishlistEndpointTest()
        {
            await client.Authenticate();
            var response = await client.GetAsync("/api/Wishlist/get");
            var content = await response.Content.ReadAsStringAsync();
            Assert.True(response.IsSuccessStatusCode);
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}

