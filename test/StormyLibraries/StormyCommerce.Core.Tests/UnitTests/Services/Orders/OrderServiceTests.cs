using Moq;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Services.Orders;
using StormyCommerce.Core.Tests.Helpers;
using StormyCommerce.Infraestructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.Services.Orders
{
    public class OrderServiceTests : IDisposable
    {
        private static readonly StormyOrder sampleOrder = StormyOrderDataSeeder.GetOrderData(Guid.NewGuid());
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
            var dbContext = DbContextHelper.GetDbContext();                            
            return new OrderService(
                new StormyRepository<StormyOrder>(dbContext),
               this.mockStormyRepositoryOrderHistory.Object);                      
        }
        private OrderService CreateServiceWithSampleData()
        {
            var dbContext = DbContextHelper.GetDbContext();
            dbContext.Add(StormyOrderDataSeeder.GetOrderData(Guid.NewGuid()));
            dbContext.SaveChanges();
            return new OrderService(new StormyRepository<StormyOrder>(dbContext),this.mockStormyRepositoryOrderHistory.Object);
        }

        [Fact]
        public async Task CancelOrderAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateServiceWithSampleData();
            long id = 1;

            // Act
            var result = await service.CancelOrderAsync(
                id);
            var order = await service.GetOrderByIdAsync(id);
            List<OrderItemDto> orderDtos = new List<OrderItemDto>();
            order.Value.Items.ToList().ForEach(o =>
            {
                orderDtos.Add(o);
            });            
            // Assert
            Assert.True(result.Success);
            Assert.Equal(orderDtos.Count, result.Value.Items.Count);
        }        
        //TODO:Check Integrity of the entry
        [Fact]
        public async Task CreateOrderAsync_ValidOrderInput_ReturnSuccessResultWithOrderDto()
        {
            // Arrange
            var service = this.CreateService();
            StormyOrder entry = sampleOrder;

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
            StormyOrder entity = StormyOrderDataSeeder.GetOrderEditData(sampleOrder.OrderUniqueKey);

            // Act
            var result = await service.EditOrderAsync(
                id,
                entity);

            // Assert
            Assert.True(result.Success);
            //Assert.Equal(result)
        }

        [Fact]
        public async Task GetOrderByIdAsync_ExistingEntityWithIdEqual1_ReturnDtoForGivenEntity()
        {
            // Arrange
            var service = this.CreateServiceWithSampleData();
            long id = 1;

            // Act
            var result = await service.GetOrderByIdAsync(
                id);

            // Assert
            Assert.True(result.Success);
            //Assert.Equal(sampleOrder.OrderUniqueKey,result.Value.OrderUniqueKey);
        }

        [Fact]
        public async Task GetOrderHistoryAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateService();

            // Act
            var result = await service.GetOrderHistoryAsync();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetOrdersAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = this.CreateServiceWithSampleData();
            // Act
            var result = await service.GetOrdersAsync();
            // Assert
            Assert.True(result.Success);
            Assert.Equal(1,result.Value.Count);            
            //Assert.
        }
    }
}
