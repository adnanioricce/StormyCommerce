namespace StormyCommerce.Core.Entities
{
    //TODO: I believe that each provider has your own way to define a ship, so make little research first
    public class ShipProvider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
    }
}