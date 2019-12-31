using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PagarMe;
using SimplCommerce.Module.Payments.Models;
using SimplCommerce.Module.ShoppingCart.Models;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;

using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Interfaces;



using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Models;
 

 

using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Catalog.Interfaces;
using StormyCommerce.Module.Orders.Area.Controllers;
using StormyCommerce.Module.Orders.Area.Models.Orders;
using StormyCommerce.Module.Orders.Interfaces;
using StormyCommerce.Module.Orders.Models.Requests;
using StormyCommerce.Module.Orders.Models.Responses;
using StormyCommerce.Module.Orders.Services;
using StormyCommerce.Module.Payments.Interfaces;
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
            UserManager<User> userManager,
            IPaymentProcessor paymentProcessor,
            IProductService productService,
            IShippingService shippingService,
            IAppLogger<CheckoutController> logger,
            IEmailSender emailSender)
        {
            _controller = new CheckoutController(identityService, paymentProcessor,orderService,productService,shippingService,logger,emailSender, mapper);
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
            var request = new CheckoutBoletoRequest{
                Amount = 12.00m,
                Items = new List<CartItem>
                {
                    new CartItem
                    {
                        Quantity = quantity,
                        ProductId = firstProduct.Id
                    },
                    new CartItem
                    {
                        Quantity = quantity,
                        ProductId = secondProduct.Id
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
            Assert.True(firstProduct.UnitsInStock >= 0 && secondProduct.UnitsInStock >= 0);
            Assert.True(value.Order.Items.Count > 0);                        
            Assert.NotNull(value.Shipment);
            Assert.NotNull(value.Shipment.DestinationAddress);                   
        }        
        [Fact,TestPriority(0)]
        public async Task CheckoutCreditCard_ReceivesCheckoutRequest_ShouldReturnOrderWithPaymentAndShipment()
        {
            var firstProduct = await _productService.GetProductByIdAsync(3);
            var secondProduct = await _productService.GetProductByIdAsync(4);
            int quantity = 2;
            //Arrange
            var request = new CheckoutCreditCardRequest
            {
                Amount = 12.00m,
                Items = new List<CartItem>
                {
                    new CartItem
                    {
                        Quantity = quantity,
                        ProductId = firstProduct.Id
                    },
                    new CartItem
                    {
                        Quantity = quantity,
                        ProductId = secondProduct.Id
                    }
                },
                PickUpOnStore = false,
                ShippingMethod = ShippingMethod.Sedex,
                PostalCode = "08621030",
                CardNumber = "4716854604523016",
                CardExpirationDate = "0720",
                CardCvv = "996",
                CardHolderName = "Test User"
            };                        
            //Act
            var response = await _controller.CreditCardCheckout(request);
            //Assert
            var result = response.Result as OkObjectResult;
            var value = result.Value as CreditCardCheckoutResponse;
            Assert.Equal(200, (int)result.StatusCode);
            Assert.NotNull(value.Order);
            Assert.NotNull(value.Payment);
            Assert.NotNull(value.Shipment);
        }

    }
}
