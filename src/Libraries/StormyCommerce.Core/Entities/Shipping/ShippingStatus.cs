namespace StormyCommerce.Core.Entities.Shipping
{
    public enum ShippingStatus
    {
        PickUpInStore = 1,
        NotShippedYet = 5,
        PartiallyShipped = 10,
        Shipped = 15,
        Delivered = 20
    }
}
