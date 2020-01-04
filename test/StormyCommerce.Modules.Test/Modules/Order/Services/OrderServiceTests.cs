using SimplCommerce.Module.Orders.Models;
using StormyCommerce.Module.Orders.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Tests
{
    public class OrderServiceTests
    {
        private readonly IOrderService service;        
        public OrderServiceTests(IOrderService _orderService)
        {
            service = _orderService;            
        }
        [Fact]
        public async Task CancelOrderAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange                        
            //var order = null;
            Order order = null;
            await service.CreateOrderAsync(order);
            // Act
            var result = await service.CancelOrderAsync(order.Id);

            // Assert
            Assert.True(result.Success);
            Assert.True(result.Value.IsCancelled);
        }

        [Fact]
        public async Task CreateOrderAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Order entry = null;

            // Act
            var result = await service.CreateOrderAsync(entry);

            // Assert
            Assert.True(result.Success);
        }

        [Fact]
        public async Task EditOrderAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            long id = 1;
            Order entity = null;
            entity.Id = id;
            // Act
            var result = await service.EditOrderAsync(id,entity);

            // Assert
            Assert.True(result.Success);
        }

        [Fact]
        public async Task GetOrderByUniqueIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange      
            Order order = null;
            Guid uniqueId = order.OrderUniqueKey;
            order.OrderUniqueKey = uniqueId;
            await service.CreateOrderAsync(order);
            // Act
            var result = await service.GetOrderByUniqueIdAsync(uniqueId);

            // Assert
            Assert.Equal(uniqueId,result.Value.OrderUniqueKey);
        }

        [Fact]
        public async Task GetOrderByIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            long id = 1;

            // Act
            var result = await service.GetOrderByIdAsync(id);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.Success);
        }
        

        [Fact]
        public async Task GetOrdersAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            

            // Act
            var result = await service.GetOrdersAsync();

            // Assert
            Assert.True(result.Success);
            Assert.True(result.Value.Count > 0);
        }

        [Fact]
        public async Task EditOrderAsync_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange                        
            Order entity = null;

            // Act
            var result = await service.EditOrderAsync(entity.OrderUniqueKey,entity);

            // Assert
            Assert.True(result.Success);
        }
    }
}
