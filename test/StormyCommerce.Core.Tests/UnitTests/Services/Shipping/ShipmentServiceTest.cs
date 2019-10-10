using Moq;
using StormyCommerce.Core.Entities;
using StormyCommerce.Module.Orders.Area.Models;
using StormyCommerce.Module.Orders.Area.Models.Correios;
using StormyCommerce.Module.Orders.Services;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.Services.Shipping
{
    public class ShipmentServiceTest
    {
        private CorreiosService CreateService()
        {
            var fakeHttpClient = new Mock<HttpClient>();
            fakeHttpClient.Setup(f => f.GetAsync(It.IsAny<string>()))
            .ReturnsAsync(new HttpResponseMessage(System.Net.HttpStatusCode.OK));
            return new CorreiosService(RepositoryHelper.GetRepository<Shipment>(), fakeHttpClient.Object,null);
        }

        public ShipmentServiceTest()
        {
        }

        [Fact]
        public async Task CalculateDeliveryPrice_OriginAndReceiverPostalCodes_ShouldReturnPriceAndDeliveryTime()
        {
            //Arrange
            // var calculateShippingModel = new CalculateShippingModel{
            //     nCdEmpresa = "",
            //     nCdServico = ServiceCode.SedexAVista,
            //     nVlAltura = 5.0m,
            //     nVlLargura = 5.0m,
            //     nVlDiametro = 0.0m,
            //     nVlComprimento = 5.0m,
            //     nVlPeso = "0.5kg",
            //     nCdFormato = 1,
            //     nVlValorDeclarado = 0,
            //     sDsSenha = "",
            //     sCdMaoPropria = "N",
            //     sCdAvisoRecebimento = "N",
            //     sCepOrigem = "01330000",
            //     sCepDestino = "65930000"
            // };
            var service = CreateService();
            //Act
            var result = await service.CalculateDeliveryPriceAndTime(null);
            //Assert
            cServico containPrice = result.Servicos.ToList().FirstOrDefault(s => s.Valor == "R$14.55");
            Assert.NotNull(containPrice);
        }

        [Fact]
        public async Task CreateShipmentAsync_PassingNotShippedStormyOrder_ShouldReturnShipmentObject()
        {
        }
    }
}
