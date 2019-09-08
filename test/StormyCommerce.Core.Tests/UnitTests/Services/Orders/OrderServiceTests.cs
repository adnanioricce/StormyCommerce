using Moq;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Services.Orders;
using StormyCommerce.Infraestructure.Data.Repositories;
using System;
using System.Threading.Tasks;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.Services.Orders
{
    public class OrderServiceTests : IDisposable
    {
        private MockRepository mockRepository;
        private Mock<IStormyRepository<StormyOrder>> mockStormyRepositoryStormyOrder;
        private Mock<IStormyRepository<OrderHistory>> mockStormyRepositoryOrderHistory;

        public OrderServiceTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockStormyRepositoryStormyOrder = this.mockRepository.Create<IStormyRepository<StormyOrder>>();
            this.mockStormyRepositoryOrderHistory = this.mockRepository.Create<IStormyRepository<OrderHistory>>();
        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private OrderService CreateService()
        {
            return new OrderService(
                RepositoryHelper.GetRepository<StormyOrder>(),
               this.mockStormyRepositoryOrderHistory.Object);
        }

        private OrderService CreateServiceWithSampleData()
        {
            var dbContext = DbContextHelper.GetDbContext();
            var fakeOrders = Seeders.StormyOrderSeed(5);
            dbContext.AddRange(fakeOrders);
            dbContext.SaveChanges(true);
            return new OrderService(new StormyRepository<StormyOrder>(dbContext), this.mockStormyRepositoryOrderHistory.Object);
        }

        [Fact]
        public async Task CancelOrderAsync_ExistingEntityWithIdEqual2_ChangeIsCancelledToTrueAndChangeUnitsInStockAndUnitsOnOrderValues()
        {
            // Arrange
            var service = this.CreateServiceWithSampleData();
            long id = 2;
            // Act
            var result = await service.CancelOrderAsync(id);
            var order = await service.GetOrderByIdAsync(id);
            // Assert
            Assert.True(result.Success);
            Assert.Equal(order.Value.IsCancelled, result.Value.IsCancelled);
        }

        //TODO:Check Integrity of the entry
        [Fact]
        public async Task CreateOrderAsync_ValidOrderInput_ReturnSuccessResultWithOrderDto()
        {
            // Arrange
            var service = this.CreateService();
            var orderUniqueKey = Guid.NewGuid();
            StormyOrder entry = new StormyOrder(0)
            {
                OrderUniqueKey = orderUniqueKey,
                CustomerId = 1,
                Status = OrderStatus.New,
                PickUpInStore = false,
                IsDeleted = false,
                ShippingMethod = "fake Sedex",
                TrackNumber = Guid.NewGuid().ToString("N"),
                Comment = "fake comment",
                Discount = 0.00m,
                Tax = 1.00m,
                TotalWeight = 0.300m,
                TotalPrice = 50.00m,
                DeliveryCost = 14.99m,
                OrderDate = DateTime.Today,
                DeliveryDate = DateTime.Today.AddDays(4),
                PaymentDate = DateTime.Today.AddDays(3),
                PaymentId = 1,
                RequiredDate = DateTime.Today.AddDays(10),
                LastModified = DateTime.UtcNow,
                Note = "fake note",
                ShippedDate = DateTime.Today,
                ShippingStatus = Entities.Shipping.ShippingStatus.Shipped,
                Payment = new Entities.Payments.Payment(0)
                {
                },
            };
            // Act
            Result<OrderDto> result = await service.CreateOrderAsync(
                entry);

            // Assert
            Assert.True(result.Success);
            Assert.Equal(entry.OrderUniqueKey, result.Value.OrderUniqueKey);
        }

        [Fact]
        public async Task EditOrderAsync_ValidInputToUpdateExistingEntityWithIdEqual1_ShouldUpdateEntityAndReturnTrue()
        {
            // Arrange
            var service = this.CreateServiceWithSampleData();
            long id = 2;
            var orderUniqueKey = Guid.NewGuid();
            StormyOrder entity = new StormyOrder(2)
            {
                OrderUniqueKey = orderUniqueKey,
                CustomerId = 1,
                Status = OrderStatus.New,
                PickUpInStore = false,
                IsDeleted = false,
                ShippingMethod = "Sedex",
                TrackNumber = Guid.NewGuid().ToString("N"),
                Comment = "fake updated comment",
                Discount = 0.00m,
                Tax = 1.00m,
                TotalWeight = 0.100m,
                TotalPrice = 24.99m,
                DeliveryCost = 14.99m,
                OrderDate = DateTime.Today,
                DeliveryDate = DateTime.Today.AddDays(7),
                PaymentDate = DateTime.Today.AddDays(3),
                PaymentId = 1,
                RequiredDate = DateTime.Today.AddDays(14),
                LastModified = DateTime.UtcNow,
                Note = "a simple note",
                ShippedDate = DateTime.Today,
                ShippingStatus = Entities.Shipping.ShippingStatus.Shipped
            };

            // Act
            var result = await service.EditOrderAsync(id, entity);

            // Assert
            Assert.True(result.Success);
        }

        [Fact]
        public async Task GetOrderByIdAsync_ExistingEntityWithIdEqual1_ReturnDtoForGivenEntity()
        {
            // Arrange
            var service = this.CreateServiceWithSampleData();
            long id = 5;

            // Act
            var result = await service.GetOrderByIdAsync(id);

            // Assert
            Assert.True(result.Success);
            //Assert.Equal(sampleOrder.OrderUniqueKey,result.Value.OrderUniqueKey);
        }

        //[Fact]
        //public async Task GetOrderHistoryAsync_ExistingStormyOrderWithIdEqual1_GetAllChangesRecordsOfTheOrder()
        //{
        //    // Arrange
        //    var service = this.CreateService();

        //    // Act
        //    var result = await service.GetOrderHistoryAsync();

        //    // Assert
        //    Assert.True(false);
        //}

        [Fact]
        public async Task GetOrdersAsync_ExistingOrderWithIdEqual5_ReturnIdWithGivenId()
        {
            // Arrange
            var service = this.CreateServiceWithSampleData();
            // Act
            var result = await service.GetOrdersAsync();
            // Assert
            Assert.True(result.Success);
            Assert.Equal(5, result.Value.Count);
            //Assert.
        }
    }
}
