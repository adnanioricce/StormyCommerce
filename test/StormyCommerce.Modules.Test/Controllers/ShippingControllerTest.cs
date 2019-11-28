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
using StormyCommerce.Module.Orders.Services;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using AutoMapper;
using StormyCommerce.Module.Orders.Area.Controllers;
using SimplCommerce.WebHost;
using StormyCommerce.Core.Shipment;
using StormyCommerce.Core.Models.Shipment.Response;

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
                ServiceCode = "40010",
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
            Assert.Equal("26,10",serviceCost.Price);
        }
    }
}
