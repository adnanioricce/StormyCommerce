using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Models.Shipment;
using StormyCommerce.Core.Services.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace StormyCommerce.Modules.Tests.Services.Shipping
{
    public class ShippingBuilderTests
    {
        [Theory]
        [InlineData(16,11,2,0,1,3)]        
        public void CalculateShippingMeasures_StateUnderTest_ExpectedBehavior(double width,double length,double height, double diameter,double unitWeigth,int quantity)
        {
            // Arrange
            var shippingBuilder = new ShippingBuilder();
            OrderDto order = new OrderDto(new Core.Entities.StormyOrder
            {
                Items = new List<OrderItem>
                {
                    new OrderItem
                    {
                        Quantity = quantity,
                        Product = new StormyProduct
                        {
                            Width = width,
                            Length = length,
                            Height = height,
                            Diameter = diameter,
                            UnitWeight = unitWeigth
                        }
                    }
                }
            });            
            // Act
            var result = shippingBuilder.CalculateShippingMeasures(new CalculateShippingMeasuresModel(order.Items));
            var cubeRoot = Math.Ceiling(Math.Pow((width * quantity) + (length * quantity) + (height * quantity) , (double)1 / 3));
            // Assert
            Assert.True(width <= result.TotalWidth || cubeRoot == result.TotalWidth );
            Assert.True(length <= result.TotalLength || cubeRoot == result.TotalLength);
            Assert.True(height <= result.TotalHeight || cubeRoot == result.TotalHeight);
            Assert.Equal(unitWeigth * quantity, result.TotalWeight);
            //Assert
        }
    }
}
