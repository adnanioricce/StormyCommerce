using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Module.Orders.Models;
using SimplCommerce.Module.Shipments.Services;
using StormyCommerce.Core.Models.Shipment;
using StormyCommerce.Module.Orders.Models.Dtos;
using System;
using System.Collections.Generic;
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
            OrderDto order = new OrderDto(new Order
            {
                //TODO:this dto is not readonly yet
                //Items = new List<OrderItem>
                //{
                //    new OrderItem
                //    {
                //        Quantity = quantity,
                //        Product = new Product
                //        {
                //            Width = width,
                //            Length = length,
                //            Height = height,
                //            Diameter = diameter,
                //            UnitWeight = unitWeigth
                //        }
                //    }
                //}
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
