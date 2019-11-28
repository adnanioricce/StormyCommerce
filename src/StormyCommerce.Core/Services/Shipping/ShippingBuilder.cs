using System;
using System.Linq;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Models.Shipment;

namespace StormyCommerce.Core.Services.Shipping
{
    public class ShippingBuilder : IShippingBuilder
    {        
        public Entities.Shipment CalculateShippingMeasures(OrderDto order)
        {
            var measureModel = new ShipmentCalculationForOrderModel();
            order.Items.ToList().ForEach(item => {
                measureModel.TotalHeight += item.Product.Height;
                measureModel.TotalWidth += item.Product.Width;
                measureModel.TotalLength += item.Product.Length;                
                measureModel.TotalWeight += item.Product.UnitWeight * item.Quantity;
                measureModel.TotalArea += item.Product.Height * item.Product.Width * item.Product.Length * item.Quantity;
            });
            var adaptedModel = measureModel.AdaptMeasuresForMultiplesItems();
            return new Entities.Shipment
            {
                TotalLength = adaptedModel.TotalLength,
                TotalHeight = adaptedModel.TotalHeight,
                TotalWidth = adaptedModel.TotalWidth,
                TotalArea = adaptedModel.TotalArea,
                TotalWeight = adaptedModel.TotalWeight
            };            
        }
    }
}
