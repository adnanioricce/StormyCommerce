using System.Linq;
using SimplCommerce.Module.Shipments.Interfaces;
using StormyCommerce.Core.Models.Shipment;

namespace SimplCommerce.Module.Shipments.Services
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
