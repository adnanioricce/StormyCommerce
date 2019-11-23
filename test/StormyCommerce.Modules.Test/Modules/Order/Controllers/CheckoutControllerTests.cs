using AutoMapper;
using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Orders.Area.Controllers;
using StormyCommerce.Module.Orders.Area.Models.Orders;
using System.Threading.Tasks;
using TestHelperLibrary.Extensions;
using Xunit;

namespace StormyCommerce.Modules.Tests
{
    public class CheckoutControllerTests
    {
        private readonly CheckoutController _controller;        
        public CheckoutControllerTests(IUserIdentityService identityService,IOrderService orderService,IMapper mapper,UserManager<StormyCustomer> userManager)
        {
            _controller = new CheckoutController(identityService, orderService, mapper);
            _controller.ControllerContext = userManager.CreateTestContext();
        }
        [Fact]
        public async Task SimpleCheckoutBoleto_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            var request = new SimpleBoletoCheckoutRequest{
                Amount = 12.00m
            };

            // Act
            var result = await _controller.SimpleCheckoutBoleto(request);

            // Assert
            Assert.True(result.Value.Result.Success);
        }        
    }
}
