using System;
using System.Linq;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Models.Shipment;
using StormyCommerce.Core.Models.Shipment.Response;

namespace StormyCommerce.Core.Services.Shipping
{
    public class ShippingBuilder : IShippingBuilder
    {        
        public CalculateShippingMeasuresModel CalculateShippingMeasures(CalculateShippingMeasuresModel model)
        {
            model.Items.ToList().ForEach(item => {
                model.CalculateSpaceForItemOnShippingBOx(item);                
            });
            var adaptedModel = model.AdaptMeasuresForMultiplesItems();
            return adaptedModel;    
        }
    }
}
