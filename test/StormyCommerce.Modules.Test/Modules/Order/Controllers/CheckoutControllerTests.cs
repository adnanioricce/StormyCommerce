using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Interfaces.Domain.Payments;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Models.Order;
using StormyCommerce.Core.Models.Order.Request;
using StormyCommerce.Core.Models.Order.Response;
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
            IShippingService shippingService,
            IAppLogger<CheckoutController> logger,
            PagarMeWrapper pagarMeWrapper)
        {
            _controller = new CheckoutController(identityService, paymentProcessor,orderService,productService,shippingService,logger, mapper);
            _controller.ControllerContext = userManager.CreateTestContext();
            _productService = productService;
        }
        [Fact,TestPriority(-1)]
        public async Task CheckoutBoleto_ReceivesBoletoCheckoutRequestWithTwoItemsAndValidAmount_ReturnOrderWithPaymentAndShipment()
        {
            // Arrange    
            var firstProduct = await _productService.GetProductByIdAsync(1);
            var secondProduct = await _productService.GetProductByIdAsync(2);
            var firstProductStock = firstProduct.UnitsInStock;
            var secondProductStock = secondProduct.UnitsInStock;            
            int quantity = 1;
            var request = new CheckoutRequest{
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
                PickUpOnStore = false,
                ShippingMethod = Core.Entities.Shipping.ShippingMethod.Sedex,
                PostalCode = "08621030"                
            };
            
            
            // Act
            var response = await _controller.BoletoCheckout(request);
            // Assert            
            var result = response.Result as OkObjectResult;
            var value = result.Value as CheckoutResponse;
            Assert.Equal(200,(int)result.StatusCode);            
            Assert.Equal(firstProductStock - quantity, firstProduct.UnitsInStock);
            Assert.Equal(secondProductStock - quantity, secondProduct.UnitsInStock);
            Assert.Equal(PaymentStatus.Pending, value.Payment.PaymentStatus);            
            Assert.True(firstProduct.UnitsInStock >= 0 && secondProduct.UnitsInStock >= 0);
            Assert.True(value.Order.Items.Count > 0);            
            Assert.NotNull(value.Payment);
            Assert.NotNull(value.Shipment);
            Assert.NotNull(value.Shipment.DestinationAddress);
            Assert.NotNull(value.Payment.GatewayTransactionId);            
        }        
        [Fact,TestPriority(0)]
        public async Task CheckoutCreditCard_ReceivesCheckoutRequest_ShouldReturnOrderWithPaymentAndShipment()
        {
            var firstProduct = await _productService.GetProductByIdAsync(3);
            var secondProduct = await _productService.GetProductByIdAsync(4);
            int quantity = 2;
            //Arrange
            var request = new CheckoutRequest
            {
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
                PickUpOnStore = false,
                ShippingMethod = ShippingMethod.Sedex,
                PostalCode = "08621030",
                CardHash = "card_ci6l9fx8f0042rt16rtb477gj"
            };
            //Act
            var response = await _controller.CreditCardCheckout(request);
            //Assert
            var result = response.Result as OkObjectResult;
            var value = result.Value as CheckoutResponse;
            Assert.Equal(200, (int)result.StatusCode);
            Assert.NotNull(value.Order);
            Assert.NotNull(value.Payment);
            Assert.NotNull(value.Shipment);
        }

    }
}
