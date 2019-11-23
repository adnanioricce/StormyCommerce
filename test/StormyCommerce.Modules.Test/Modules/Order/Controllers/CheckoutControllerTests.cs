using AutoMapper;
using PagarMe.Model;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Orders.Area.Controllers;
using StormyCommerce.Module.Orders.Area.Models.Orders;
using System;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Tests.Order
{
    public class CheckoutControllerTests
    {
        private readonly CheckoutController _controller;
        public CheckoutControllerTests(IUserIdentityService identityService,IOrderService orderService,IMapper mapper)
        {
            _controller = new CheckoutController(identityService, orderService, mapper);
        }
        [Fact]
        public async Task SimpleCheckoutBoleto_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            SimpleBoletoCheckoutRequest request = new SimpleBoletoCheckoutRequest{
                Amount = 12.00m
            };

            // Act
            var result = await _controller.SimpleCheckoutBoleto(request);

            // Assert
            Assert.True(result.Value.Result.Success);
        }        
    }
}
