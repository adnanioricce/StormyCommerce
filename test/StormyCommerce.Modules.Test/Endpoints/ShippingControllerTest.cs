using Xunit;
using TestHelperLibrary.Mocks;
using System.Net.Http;
using StormyCommerce.Modules.IntegrationTest;
using Microsoft.AspNetCore.TestHost;
//using StormyCommerce.Module.Shipping.Areas.Shipping.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xunit.Abstractions;
using StormyCommerce.Module.Orders.Area.Models;
using System.Linq;
using StormyCommerce.Module.Orders.Area.Models.Correios;

namespace StormyCommerce.Modules.Test.Controllers
{
    public class ShippingControllerTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;
        private readonly ITestOutputHelper _output;
        public ShippingControllerTest(CustomWebApplicationFactory factory,ITestOutputHelper output)
        {
            _client = factory.WithWebHostBuilder(builder => 
            {
                builder.UseSolutionRelativeContentRoot("src/SimplCommerce.WebHost");
            }).CreateClient();
            _output = output;
        }
        [Fact]
        public async Task CalculateDeliveryCostAsync_WhenReceivesCalculateDeliveryVm_ReturnAllShippingOption()
        {
            //Given
            var model = new CalcPrecoPrazoModel {
                nCdEmpresa = "",
                sDsSenha = "",
                nCdServico = ServiceCode.Sedex,
                sCepOrigem = "19190970",
                sCepDestino = "19570970",
                nVlPeso = "1",
                nCdFormato = (int)FormatCode.CaixaOuPacote,
                nVlComprimento = 15,
                nVlAltura = 10,
                nVlLargura = 10,
                nVlDiametro = 0,
                sCdMaoPropria = "N",
                nVlValorDeclarado = 10.0m,
                sCdAvisoRecebimento = "N"
            };            
            //When
            var response = await _client.PostAsJsonAsync("api/Shipping/calcdelivery", model);
            _output.WriteLine($"response status code {response.StatusCode},content: {await response.Content.ReadAsStringAsync()}");
            //Then            
            var result = Assert.IsType<cResultado>(response);                        
            var serviceCost = result.Servicos.ToList().First();
            Assert.Equal("26,10",serviceCost.Valor);
        }
    }
}
