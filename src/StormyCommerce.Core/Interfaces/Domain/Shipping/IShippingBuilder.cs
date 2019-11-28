using System;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Models.Shipment;

namespace StormyCommerce.Core.Interfaces.Domain.Shipping
{
    public interface IShippingBuilder
    {
        Entities.Shipment CalculateShippingMeasures(OrderDto request);
    }
}
