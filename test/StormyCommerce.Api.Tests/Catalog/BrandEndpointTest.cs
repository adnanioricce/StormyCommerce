using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Api.Framework.Extensions;

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
            await client.Authenticate(true);
            var response = await client.PostAsJsonAsync("/api/Brand/create", new Brand());

            Assert.True(response.IsSuccessStatusCode);
        }        
        [Fact]
        public async Task GetAllBrandEndpointTest()
        {
            await client.Authenticate(true);
            var response = await client.GetAsync("/api/Brand/list");
            var result = await response.Content.ReadAsAsync<List<Brand>>();
            Assert.True(response.IsSuccessStatusCode);
            Assert.True(result.Count > 0);
        }
        [Fact]
        public async Task GetBrandByIdEndpointTest()
        {
            await client.Authenticate(true);
            var response = await client.GetAsync("/api/Brand/list");            
            Assert.True(response.IsSuccessStatusCode);            
        }
    }
}
