namespace StormyCommerce.Core.Entities
{
    public class ShipType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ShipmentDetails ShipDetails { get; set; }
    }
}