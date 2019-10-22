using Moq;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Services.Orders;
using StormyCommerce.Infraestructure.Data.Repositories;
using StormyCommerce.Module.Orders.Services;
using System;
using System.Linq;
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
               this.mockStormyRepositoryOrderHistory.Object,
               new ShippingService(RepositoryHelper.GetRepository<Shipment>(),null,
               new CorreiosService(new CalcPrecoPrazoWSSoapClient())));
        }

        private OrderService CreateServiceWithSampleData()
        {            
            var dbContext = DbContextHelper.GetDbContext();
            var fakeOrders = Seeders.StormyOrderSeed(1);                        
            dbContext.AddRange(fakeOrders);
            dbContext.SaveChanges();
            return new OrderService(new StormyRepository<StormyOrder>(dbContext), 
            this.mockStormyRepositoryOrderHistory.Object,
            null);
        }
        private ShippingService CreateFakeShippingService()
        {
            var mockShippingService = new Mock<ShippingService>(null,
            null,
            new CorreiosService(new CalcPrecoPrazoWSSoapClient()));
            mockShippingService
            .Setup(s => s.BuildShipmentForOrder(It.IsAny<StormyOrder>()))
            .ReturnsAsync(It.IsAny<Shipment>());
            return mockShippingService.Object;
        }        
        [Fact]
        public async Task CancelOrderAsync_ExistingEntityWithIdEqual2_ChangeIsCancelledToTrueAndChangeUnitsInStockAndUnitsOnOrderValues()
        {
            // Arrange
            var service = this.CreateServiceWithSampleData();
            long id = 1;
            // Act
            var result = await service.CancelOrderAsync(id);
            var order = await service.GetOrderByIdAsync(id);
            // Assert
            Assert.True(result.Success);
            Assert.Equal(order.Value.Status, result.Value.Status);
        }

        //TODO:Check Integrity of the entry
        [Fact]
        public async Task CreateOrderAsync_ValidOrderInput_ReturnSuccessResultWithOrderDto()
        {
            // Arrange
            var service = new OrderService(RepositoryHelper.GetRepository<StormyOrder>(),this.mockStormyRepositoryOrderHistory.Object,CreateFakeShippingService());
            var orderUniqueKey = Guid.NewGuid();
            StormyOrder entry = Seeders.StormyOrderSeed().First();
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
            long id = 1;
            var orderUniqueKey = Guid.NewGuid();
            StormyOrder entity = new StormyOrder(id)
            {
                OrderUniqueKey = orderUniqueKey,
                StormyCustomerId = 1,
                Status = OrderStatus.New,
                PickUpInStore = false,
                IsDeleted = false,                
                Comment = "fake updated comment",
                Discount = 0.00m,
                Tax = 1.00m,                
                TotalPrice = 24.99m,                
                OrderDate = DateTime.Today,                
                PaymentDate = DateTime.Today.AddDays(3),
                PaymentId = 1,
                RequiredDate = DateTime.Today.AddDays(14),
                LastModified = DateTime.UtcNow,
                Note = "a simple note",                                
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
            long id = 1;

            // Act
            var result = await service.GetOrderByIdAsync(id);

            // Assert
            Assert.True(result.Success);
            //Assert.Equal(sampleOrder.OrderUniqueKey,result.Value.OrderUniqueKey);
        }        

        [Fact]
        public async Task GetOrdersAsync_ExistingOrderWithIdEqual5_ReturnIdWithGivenId()
        {
            // Arrange
            var service = this.CreateServiceWithSampleData();
            // Act
            var result = await service.GetOrdersAsync();
            // Assert
            Assert.True(result.Success);
            Assert.Equal(1, result.Value.Count);
            //Assert.
        }
    }
}
