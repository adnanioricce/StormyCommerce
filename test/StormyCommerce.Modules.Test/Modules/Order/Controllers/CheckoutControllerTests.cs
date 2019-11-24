using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Models;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Orders.Area.Controllers;
using StormyCommerce.Module.Orders.Area.Models.Orders;
using StormyCommerce.Module.Orders.Services;
using System.Threading.Tasks;
using TestHelperLibrary.Extensions;
using Xunit;

namespace StormyCommerce.Modules.Tests
{
    public class CheckoutControllerTests
    {
        private readonly CheckoutController _controller;        
        public CheckoutControllerTests(IUserIdentityService identityService,
            IOrderService orderService,
            IMapper mapper,
            UserManager<StormyCustomer> userManager,
            PagarMeWrapper pagarMeWrapper)
        {
            _controller = new CheckoutController(identityService, orderService, pagarMeWrapper, mapper);
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
            var response = await _controller.SimpleCheckoutBoleto(request);
            var result = response.Result as OkObjectResult;
            var value = result.Value as Result;

            // Assert
            Assert.Equal(200,(int)result.StatusCode);
            Assert.True(value.Success);
            
        }        
    }
}
