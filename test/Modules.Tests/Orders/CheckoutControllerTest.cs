using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Stormycommerce.Module.Orders.Area.ViewModels;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Interfaces.Infraestructure.ExternalServices;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Module.Orders.Area.Controllers;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Modules.Test.Orders
{
    public class CheckoutControllerTest
    {
        private CheckoutController CreateController()
        {
            return new CheckoutController(CreateOrderService(), CreatePaymentService(), CreateShippingService(), CreateLoggerService());
            IOrderService CreateOrderService()
            {
                var mockService = new Mock<IOrderService>();
                mockService.Setup(f => f.CreateOrderAsync(It.IsAny<StormyOrder>()));
                return mockService.Object;
            }
            IPaymentService CreatePaymentService()
            {
                var mockService = new Mock<IPaymentService>();
                mockService.Setup(f => f.Charge(It.IsAny<PaymentDto>()))
                    .ReturnsAsync(Result<object>.Ok(new object()));
                return mockService.Object;
            }
            IShippingService CreateShippingService()
            {
                var mockService = new Mock<IShippingService>();
                mockService.Setup(f => f.CreateShipmentAsync(It.IsAny<Shipment>()))
                .Returns(Task.FromResult(new Shipment()));
                return mockService.Object;
            }
            ILogger CreateLoggerService()
            {
                var mockService = new Mock<ILogger>();
                mockService.Setup(f => f.LogInformation(It.IsAny<string>(), It.IsAny<string>()))
                .Callback((string message) => Console.WriteLine(message));
                return mockService.Object;
            }
        }

        [Fact]
        public async Task CheckoutBoleto_ValidInputFromAuthenticatedUser_ShouldReturnOrderAndBoletoToUser()
        {
            //Arrange
            var controller = CreateController();
            var seed = Seeders.AddressSeed().First();
            var checkoutObj = new CheckoutOrderVm
            {
                // DeliveryCost = seed.DeliveryCost,
                // Discount = seed.,
                Address = new AddressVm
                {
                    City = seed.City,
                    Complement = seed.Complement,
                    // CPF = seed.c,
                    FirstAddress = seed.FirstAddress,
                    Number = seed.Number,
                    PostalCode = seed.PostalCode,
                    Street = seed.Street,
                    State = seed.State,
                    SecondAddress = seed.SecondAddress,
                    WhoReceives = "aguinobaldo"
                },
                TotalPrice = 29.90m,
                ShippingFee = 9.90m,
                PaymentMethod = "Boleto",
                Items = Seeders.StormyProductSeed(2).ToListProductDto().ToList()
            };
            //Act
            var result = await controller.CheckoutBoleto(checkoutObj);
            //Assert
            var returnResult = Assert.IsAssignableFrom<OkObjectResult>(result);
            var returnedObject = (returnResult.Value as OrderDto);
            Assert.Equal(200, returnResult.StatusCode);
            Assert.IsAssignableFrom<OrderDto>(returnResult.Value);
            Assert.Equal(checkoutObj.TotalPrice, returnedObject.TotalPrice);
            // Assert.Equal(checkoutObj.Items,returnedObject.Items);
            Assert.Equal(OrderStatus.PendingPayment, returnedObject.Status);
        }

        //[Fact]
        //public async Task Checkout_ValidInputFromAuthenticatedUser_ReturnOrderToUser()
        //{
        // //Arrange
        // //Act
        // //Assert
        // Assert.True(false);
        //}
        //[Fact]
        //public async Task CancelOrder_OrderStatusEqualNotShippedAndAuthenticatedUser_CancelOrderAndReturnOk()
        //{
        // //Arrange
        // //Act
        // //Assert
        // Assert.True(false);
        //}
        //[Fact]
        //public async Task GetOrderById_IdEqual1AndOwnerIsTheAuthenticatedUser_ReturnSpecifiedId()
        //{
        // //Arrange
        // //Act
        // //Assert
        // Assert.True(false);
        //}
    }
}
