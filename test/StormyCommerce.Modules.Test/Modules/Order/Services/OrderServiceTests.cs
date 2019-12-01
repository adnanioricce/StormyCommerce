using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Services.Orders;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Tests.Services.Orders
{
    public class OrderServiceTests
    {
        private readonly IOrderService service;
        private readonly OrderDto sampleEditOrder;
        public OrderServiceTests(IOrderService _orderService)
        {
            service = _orderService;            
        }
        [Fact]
        public async Task CancelOrderAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            long id = 1;
            // Act
            var result = await service.CancelOrderAsync(id);

            // Assert
            Assert.True(result.Success);
            Assert.True(result.Value.IsCancelled);
        }

        [Fact]
        public async Task CreateOrderAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            StormyOrder entry = Seeders.StormyOrderSeed().First();

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
            StormyOrder entity = Seeders.StormyOrderSeed().First();            

            // Act
            var result = await service.EditOrderAsync(id,entity);

            // Assert
            Assert.True(result.Success);
        }

        [Fact]
        public async Task GetOrderByUniqueIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            Guid uniqueId = default(global::System.Guid);

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
            StormyOrder entity = Seeders.StormyOrderSeed().First();

            // Act
            var result = await service.EditOrderAsync(entity.OrderUniqueKey,entity);

            // Assert
            Assert.True(result.Success);
        }
    }
}
