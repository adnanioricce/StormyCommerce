using Microsoft.AspNetCore.Mvc.Testing;
using PagarMe;
using SimplCommerce.WebHost;
using StormyCommerce.Module.PagarMe.Services;
using Xunit;

namespace StormyCommerce.Modules.IntegrationTest.Services
{
    public class PagarMeServiceTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private PagarMeWrapper pagarMeWrapper;
        public PagarMeServiceTest()
        {
            pagarMeWrapper = new PagarMeWrapper(PagarMeService.GetDefaultService(), null, null);
        }
    }
}
