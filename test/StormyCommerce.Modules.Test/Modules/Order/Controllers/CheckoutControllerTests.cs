using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Interfaces.Domain.Payments;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Order;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Orders.Area.Controllers;
using StormyCommerce.Module.Orders.Area.Models.Orders;
using StormyCommerce.Module.Orders.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestHelperLibrary.Extensions;
using Xunit;

namespace StormyCommerce.Modules.Tests
{
    public class CheckoutControllerTests
    {
        private readonly CheckoutController _controller;
        private readonly IProductService _productService;
        public CheckoutControllerTests(IUserIdentityService identityService,
            IOrderService orderService,
            IMapper mapper,
            UserManager<StormyCustomer> userManager,
            IPaymentProcessor paymentProcessor,
            IProductService productService,
            PagarMeWrapper pagarMeWrapper)
        {
            _controller = new CheckoutController(identityService, paymentProcessor,orderService, mapper);
            _controller.ControllerContext = userManager.CreateTestContext();
            _productService = productService;
        }
        [Fact]
        public async Task SimpleCheckoutBoleto_StateUnderTest_ExpectedBehavior()
        {
            // Arrange    
            var firstProduct = await _productService.GetProductByIdAsync(1);
            var secondProduct = await _productService.GetProductByIdAsync(2);
            var firstProductStock = firstProduct.UnitsInStock;
            var secondProductStock = secondProduct.UnitsInStock;
            var oldStockQuantity = _productService.GetTotalStockQuantity();
            int quantity = 1;
            var request = new SimpleBoletoCheckoutRequest{
                Amount = 12.00m,
                Items = new List<CartItem>
                {
                    new CartItem
                    {
                        Quantity = quantity,
                        StormyProductId = firstProduct.Id
                    },
                    new CartItem
                    {
                        Quantity = quantity,
                        StormyProductId = secondProduct.Id
                    }
                },
                PickUpOnStore = false
            };
            
            
            // Act
            var response = await _controller.SimpleCheckoutBoleto(request);
            var result = response.Result as OkObjectResult;
            var value = result.Value as Result;

            // Assert
            var actualStockQuantity = _productService.GetTotalStockQuantity();
            Assert.Equal(200,(int)result.StatusCode);
            Assert.Equal(oldStockQuantity - (quantity * request.Items.Count), actualStockQuantity);
            Assert.Equal(firstProductStock - quantity, firstProduct.UnitsInStock);
            Assert.Equal(secondProductStock - quantity, secondProduct.UnitsInStock);
            Assert.True(value.Success);            
            Assert.True(firstProduct.UnitsInStock >= 0 && secondProduct.UnitsInStock >= 0);
        }        

    }
}
