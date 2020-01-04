namespace SimplCommerce.Module.Shipments.Models
{
    public enum ShipmentStatus
    {
        PickUpInStore = 1,
        NotShippedYet = 5,
        PartiallyShipped = 10,
        Shipped = 15,
        Delivered = 20
    }
}
