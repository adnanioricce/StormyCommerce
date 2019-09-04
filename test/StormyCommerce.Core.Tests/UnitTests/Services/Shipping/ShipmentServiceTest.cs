using Xunit;
using StormyCommerce.Module.Shipping;
using Moq;
using System.Net.Http;
using StormyCommerce.Module.Shipping.Services;
using TestHelperLibrary.Utils;
using StormyCommerce.Core.Entities;
using System.Threading.Tasks;
using StormyCommerce.Module.Shipping.Areas.Shipping.Models;

namespace StormyCommerce.Core.Tests.UnitTests.Services.Shipping
{
    public class ShipmentServiceTest
    {
        private CorreiosService CreateService()
        {
            var fakeHttpClient = new Mock<HttpClient>();
            fakeHttpClient.Setup(f => f.GetAsync(It.IsAny<string>()))
            .ReturnsAsync(new HttpResponseMessage(System.Net.HttpStatusCode.OK));
            return new CorreiosService(RepositoryHelper.GetRepository<Shipment>(),fakeHttpClient.Object);
        }
        public ShipmentServiceTest()
        {

        }
        [Fact]
        public async Task CalculateDeliveryPrice_OriginAndReceiverPostalCodes_ShouldReturnPriceAndDeliveryTime()
        {
            //Arrange
            var calculateShippingModel = new CalculateShippingModel{
                nCdEmpresa = "",
                nCdServico = ServiceCode.SedexAVista,
                nVlAltura = 5.0m,
                nVlLargura = 5.0m,
                nVlDiametro = 0.0m,
                nVlComprimento = 5.0m,
                nVlPeso = "0.5kg",
                nCdFormato = 1,
                nVlValorDeclarado = 0,
                sDsSenha = "",
                sCdMaoPropria = "N",
                sCdAvisoRecebimento = "N",
                sCepOrigem = "01330000",
                sCepDestino = "65930000"
            };
            var service = CreateService();
            //Act
            var result = await service.CalculateDeliveryPrice(null);
            //Assert            
            Assert.Equal(14.99m,result.Price,2);
        }
        [Fact]
        public async Task CreateShipmentAsync_PassingNotShippedStormyOrder_ShouldReturnShipmentObject()
        {

        }
    }
}
