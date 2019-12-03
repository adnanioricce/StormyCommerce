using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities.Catalog.Product;
using Xunit;

namespace StormyCommerce.Api.Tests.Catalog
{
    public class BrandEndpointTest
    {
        private readonly HttpClient client;
        public BrandEndpointTest()
        {
            client = new HttpClient();
            client.BaseAddress = new System.Uri(Config.BaseUrl);            
        }
        [Fact]
        public async Task CreateBrandEndpointTest()
        {
            await client.AuthenticateAsAdmin();
            var response = await client.PostAsJsonAsync("/api/Brand/create", Seeders.BrandSeed().FirstOrDefault());
            Assert.True(response.IsSuccessStatusCode);
        }        
    }
}
