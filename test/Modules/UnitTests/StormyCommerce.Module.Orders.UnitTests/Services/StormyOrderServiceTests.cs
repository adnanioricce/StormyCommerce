using Moq;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Orders.Areas.Orders.ViewModels;
using SimplCommerce.Module.Orders.Models;
using SimplCommerce.Module.Shipments.Models.Requests;
using SimplCommerce.Module.Shipments.Services;
using SimplCommerce.Module.ShoppingCart.Models;
using SimplCommerce.Module.ShoppingCart.Services;
using SimplCommerce.Tests;
using SimplCommerce.Tests.Seeders;
using StormyCommerce.Module.Orders.Services;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Module.Orders.UnitTests.Services
{
    public class StormyOrderServiceTests
    {                

        public StormyOrderServiceTests()
        {           
        }
        

        [Fact]
        public void CancelOrder_StateUnderTest_ExpectedBehavior()
        {
            // Given
            var service = new StormyOrderService(null,null);
            Order order = null;

            // When
            service.CancelOrder(order);

            // Then
            Assert.True(false);            
        }
        #region Valid Test Cases
        [Fact]
        public async Task CreateOrder_ReceivesCartIdWithPaymentMethodAndFee_ShouldBuildAOrderEntityToBeValidatedAndProcessedInNextCreateOrderMethod()
        {
            // Given
            var fakeCartRepository = new FakeRepository<Cart>();
            var cart = OrderServiceSeeders.GetCart();
            cart.ShippingData = JsonSerializer.Serialize(new
            {
                ShippingAddressId = 1,
                BillingAddressId = 1
            });
            fakeCartRepository.Add(cart);
            var service = new StormyOrderService(fakeCartRepository, GetFakeFreightCalculator());
            long cartId = 1;
            string paymentMethod = "boleto";
            decimal paymentFeeAmount = 0;
            OrderStatus orderStatus = OrderStatus.New;

            // When
            var result = await service.CreateOrder(
                cartId,
                paymentMethod,
                paymentFeeAmount,
                orderStatus);

            // Then
            Assert.True(result.Success);            
        }

        [Fact]
        public async Task CreateOrder_StateUnderTest_ExpectedBehavior1()
        {
            // Given
            var service = new StormyOrderService(null,null);
            long cartId = 0;
            string paymentMethod = null;
            decimal paymentFeeAmount = 0;
            string shippingMethod = null;
            Address billingAddress = null;
            Address shippingAddress = null;
            OrderStatus orderStatus = default(global::SimplCommerce.Module.Orders.Models.OrderStatus);

            // When
            var result = await service.CreateOrder(
                cartId,
                paymentMethod,
                paymentFeeAmount,
                shippingMethod,
                billingAddress,
                shippingAddress,
                orderStatus);

            // Then
            Assert.True(false);            
        }

        [Fact]
        public async Task GetTax_StateUnderTest_ExpectedBehavior()
        {
            // Given
            var service = new StormyOrderService(null,null);
            long cartId = 0;
            string countryId = null;
            long stateOrProvinceId = 0;
            string zipCode = null;

            // When
            var result = await service.GetTax(
                cartId,
                countryId,
                stateOrProvinceId,
                zipCode);

            // Then
            Assert.True(false);            
        }

        [Fact]
        public async Task UpdateTaxAndShippingPrices_StateUnderTest_ExpectedBehavior()
        {
            // Given
            var service = new StormyOrderService(null,null);
            long cartId = 0;
            TaxAndShippingPriceRequestVm model = null;

            // When
            var result = await service.UpdateTaxAndShippingPrices(
                cartId,
                model);

            // Then
            Assert.True(false);            
        }
        #endregion
        #region Invalid Test cases
        [Fact]
        public async Task CreateOrder_ReceivesCartWithLockedCheckout_ShouldReturnResultWithSuccessEqualFalse()
        {
            //Given
            var fakeCartRepository = new FakeRepository<Cart>();
            var cart = OrderServiceSeeders.GetCart();
            cart.ShippingData = JsonSerializer.Serialize(new
            {
                ShippingAddressId = 1,
                BillingAddressId = 1
            });
            cart.LockedOnCheckout = true;
            fakeCartRepository.Add(cart);
            var service = new StormyOrderService(fakeCartRepository, GetFakeFreightCalculator());
            long cartId = 1;
            string paymentMethod = "boleto";
            decimal paymentFeeAmount = 0;
            OrderStatus orderStatus = OrderStatus.New;
            //When
            var result = await service.CreateOrder(
                cartId,
                paymentMethod,
                paymentFeeAmount,
                orderStatus);
            //Then
            Assert.False(result.Success);
        }
        #endregion
        private IFreightCalculator GetFakeFreightCalculator()
        {
            var mockFreightCalculator = new Mock<IFreightCalculator>();
            mockFreightCalculator.Setup(m => m.CalculateFreightForPackage(It.IsAny<CalculatePackageFreightRequest>()))
                .ReturnsAsync(new SimplCommerce.Module.Shipments.Models.Responses.CalculateFreightResponse { 
                    Options = new System.Collections.Generic.List<SimplCommerce.Module.Shipments.Models.Responses.CalculateFreightOptionResponse>
                    {
                       new SimplCommerce.Module.Shipments.Models.Responses.CalculateFreightOptionResponse
                       {
                            DeliveryDate = DateTimeOffset.UtcNow.AddDays(1),
                            Price = 12.99m,
                            ServiceName = "sedex"
                       }
                    }
                });
            return mockFreightCalculator.Object;
        }
    }
}
