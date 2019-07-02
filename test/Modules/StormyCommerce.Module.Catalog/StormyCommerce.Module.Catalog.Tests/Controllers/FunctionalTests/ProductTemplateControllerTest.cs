using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using TestHelperLibrary;
using Xunit;

namespace StormyCommerce.Module.Catalog.Tests.Controllers.FunctionalTests
{
    public class ProductTemplateControllerTest : IClassFixture<CustomWebApplicationFactory<FakeStartup>>
    {
        private readonly CustomWebApplicationFactory<FakeStartup> _factory;
        private readonly HttpClient _httpClient;
        public ProductTemplateControllerTest(CustomWebApplicationFactory<FakeStartup> factory)
        {
            _factory = factory;
            var clientOptions = new WebApplicationFactoryClientOptions();
            clientOptions.BaseAddress = new System.Uri("http://localhost/api"); 
            _httpClient = _factory.CreateClient(clientOptions);
        }                
    }
}