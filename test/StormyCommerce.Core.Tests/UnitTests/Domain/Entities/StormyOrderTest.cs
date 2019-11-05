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
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.Domain.Entities
{
    public class StormyOrderTest
    {
        private IProductService GetProductService(StormyDbContext dbContext)
        {
            return new ProductService(new StormyRepository<StormyProduct>(dbContext),null,null,null,null);
        }        
        [Fact]        
        public void SyncStock_OrderStatusEqualNew_SubtractFromTheStock()
        {
            //Given
            var order = Seeders.StormyOrderSeed().First();
            using (var dbContext = DbContextHelper.GetDbContext(DbContextHelper.GetDbOptions()))
            {
                dbContext.Add(order);
                dbContext.SaveChanges();                        
                var service = GetProductService(dbContext);            
                var products = new List<StormyProduct>();
                var totalUnitsInStockBefore = order.Items.Max(p => p.Product.UnitsInStock);
                var totalUnitsInOrderBefore = order.Items.Max(p => p.Product.UnitsOnOrder);                                
                //When

                order.SyncStock(OrderStatus.New);
                //Then                        
                Assert.NotEqual(totalUnitsInStockBefore, order.Items.Max(p => p.Product.UnitsInStock));
                Assert.NotEqual(totalUnitsInOrderBefore, order.Items.Max(p => p.Product.UnitsOnOrder));
            }
        }
    }
}
