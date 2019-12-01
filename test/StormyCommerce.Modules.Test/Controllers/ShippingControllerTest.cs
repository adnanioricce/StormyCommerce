using Xunit;
using System.Threading.Tasks;
using System.Linq;
using StormyCommerce.Module.Orders.Services;
using AutoMapper;
using StormyCommerce.Module.Orders.Area.Controllers;
using SimplCommerce.WebHost;
using StormyCommerce.Core.Shipment;
using StormyCommerce.Core.Models.Shipment.Response;
using StormyCommerce.Core.Models.Shipment.Request;

namespace StormyCommerce.Modules.Test.Controllers
{
    public class ShippingControllerTest : IClassFixture<Startup>
    {
        private readonly ShippingController _controller;
        public ShippingControllerTest(CorreiosService correiosService,       
        IMapper mapper)
        {            
            _controller = new ShippingController(correiosService,null,mapper);
        }
        [Fact]
        public async Task CalculateDeliveryCostAsync_WhenReceivesCalculateDeliveryVm_ReturnAllShippingOption()
        {
            //Given
            var model = new DeliveryCalculationRequest{
                ShippingMethod = "40010",
                FormatCode = FormatCode.CaixaOuPacote,
                Height = 3,
                Width = 16,
                Length = 11,
                Diameter = 0,
                Weight = 0.3m,
                DestinationPostalCode = "08621030"                
            };         
            //When
            var response = await _controller.CalculateDeliveryCost(model);            
            //Then            
            var result = Assert.IsType<DeliveryCalculationResponse>(response.Value);                        
            var serviceCost = response.Value.FirstOrDefault();
            Assert.Equal(26.10m,serviceCost.Price);
        }
    }
}
