using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using SimplCommerce.WebHost;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using TestHelperLibrary;
using Xunit;
using Xunit.Abstractions;

namespace StormyCommerce.Modules.IntegrationTest
{
    public class BasicTests : IClassFixture<CustomWebApplicationFactory>
    {
        //private readonly CustomWebApplicationFactory _factory;
        private readonly HttpClient _httpClient;
        private readonly ITestOutputHelper _output;
        public BasicTests(CustomWebApplicationFactory factory,ITestOutputHelper output)
        {
            //_factory = factory;
            _httpClient = factory.WithWebHostBuilder(builder =>
            {
                builder.UseSolutionRelativeContentRoot("src/SimplCommerce.WebHost");                                
            }).CreateClient();
            
            _output = output;
        }
        [Theory]
        [InlineData("/api/Product/GetProductById/1?id=1")]
        [InlineData("/api/Product/GetProductOverviewAsync/1?id=1")]
        [InlineData("/api/Product/GetAllProducts?startIndex=1&endIndex=15")]
        [InlineData("/api/Product/GetNumberOfProductsInCategory/")]
        [InlineData("/api/Category/GetAll/list")]
        [InlineData("/api/Category/GetCategoryById/1")]  
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            //Arrange            
            await _httpClient.GetAsync("http://localhost/seed");
            var response = await _httpClient.GetAsync(url);
            //Act
            response.EnsureSuccessStatusCode();            
            //Assert
            Assert.Equal("application/json; charset=utf-8",response.Content.Headers.ContentType.ToString());
        }        
    }
}
