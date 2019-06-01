using StormyCommerce.Core.Entities.Product;

namespace StormyCommerce.Core.Entities
{
    public class ShipmentDetails
    {
        public int ShipmentId { get; set; }
        
        public StormyProduct Product { get; set; }                
    }
}