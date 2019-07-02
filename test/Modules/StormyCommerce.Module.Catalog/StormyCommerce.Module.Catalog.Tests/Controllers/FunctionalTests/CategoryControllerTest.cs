using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Module.Catalog.Dtos;
using TestHelperLibrary;
using Xunit;

namespace StormyCommerce.Module.Catalog.Tests.Controllers.FunctionalTests
{
    //TODO:Create/Get sample data 
    public class CategoryControllerTest : IClassFixture<CustomWebApplicationFactory<FakeStartup>>
    {    
        private readonly CustomWebApplicationFactory<FakeStartup> _factory;    
        private readonly HttpClient _httpClient;
        public CategoryControllerTest(CustomWebApplicationFactory<FakeStartup> factory)
        {            
            _factory = factory;
            var clientOptions = new WebApplicationFactoryClientOptions();
            clientOptions.BaseAddress = new System.Uri("http://localhost/api/");
            _httpClient = _factory.CreateClient(clientOptions);            
        }
        [Theory]
        [InlineData("category/list")]
        [InlineData("category/{1}")]
        public async Task<List<CategoryDto>> Get_EndpointReturnSuccess_And_CorrectContentType(string url)
        {
            
        }
    }
}