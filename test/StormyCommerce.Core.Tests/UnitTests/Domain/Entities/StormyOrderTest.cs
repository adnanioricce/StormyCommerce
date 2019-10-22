using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Services.Catalog;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.Domain.Entities
{
    public class StormyOrderTest
    {
        private IProductService GetProductService()
        {
            return new ProductService(RepositoryHelper.GetRepository<StormyProduct>());
        } 
        [Fact]        
        public void SyncStock_OrderStatusEqualNew_SubtractFromTheStock()
        {
            //Given
            var order = Seeders.StormyOrderSeed().First();            
            var service = GetProductService();
            var products = new List<StormyProduct>();
            //When
            var oldOrder = order;
            order.SyncStock(OrderStatus.New);
            //Then                        
            order.Items.ForEach(async item => {
                var product = await service.GetProductByIdAsync(item.StormyProductId);                
                Assert.True(product.UnitsInStock == item.Product.UnitsInStock);
                Assert.True(product.UnitsOnOrder == item.Product.UnitsOnOrder);
                Assert.True(oldOrder.Items.Find(i => i == item).Product.UnitsInStock > item.Product.UnitsInStock);
                Assert.True(oldOrder.Items.Find(i => i == item).Product.UnitsOnOrder < item.Product.UnitsOnOrder);                
            });            
        }
    }
}
