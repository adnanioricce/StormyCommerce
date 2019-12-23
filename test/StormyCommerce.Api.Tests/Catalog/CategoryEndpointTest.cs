using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Api.Tests.Catalog
{
    public class CategoryEndpointTest
    {
        private readonly HttpClient client;
        public CategoryEndpointTest()
        {
            client = new HttpClient();
            client.BaseAddress = new System.Uri(Config.BaseUrl);
        }
        [Fact]
        public async Task GetAllCategoriesEndpointTest()
        {
             
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(9999999999999999)]
        public async Task GetByIdEndpointTest(long id)
        {

        }
        [Fact]
        public async Task CreateCategoryEndpointTest()
        {

        }
        [Fact]
        public async Task EditCategoryEndpointTest()
        {

        }
    }
}
