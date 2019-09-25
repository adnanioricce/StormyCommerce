using Xunit;
using TestHelperLibrary.Mocks;
using System.Net.Http;
using StormyCommerce.Modules.IntegrationTest;
using Microsoft.AspNetCore.TestHost;

namespace StormyCommerce.Modules.Test.Controllers
{
    public class ShippingControllerTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;
        public ShippingControllerTest(CustomWebApplicationFactory factory)
        {
            _client = factory.WithWebHostBuilder(builder => 
            {
                builder.UseSolutionRelativeContentRoot("src/SimplCommerce.WebHost");
            }).CreateClient();                        
        }
        [Fact]
        public void CalculateDeliveryCostAsync_WhenReceivesCalculateDeliveryVm_ReturnAllShippingOption()
        {
            //Given
            var model = new CalculateShippingModel {
                CodigoEmpresa = "",
                sDsSenha = "",
                CodigoServico = ServiceCode.SedexAVista,
                CepOrigem = "19190970",
                CepDestino = "19570970",
                Peso = "1kg",
                CodigoFormato = FormatCode.CaixaOuPacote,
                Comprimento = 10.5m,
                Altura = 5.5m,
                Largura = 5.5m,
                Diametro = 0.0m,
                CodigoMaoPropria = "N",
                ValorDeclarado = 10.0m,
                CodigoAvisoRecebimento = "N"
            };            
            //When
            var response = await _client.PostAsJsonAsync(model);
        
            //Then
            //Provavelmente não vai ser assim 
            //vai no site dos correios, faz um teste e tenta simular aqui
            Assert.Equal(0.0,response.Price);
        }
    }
}