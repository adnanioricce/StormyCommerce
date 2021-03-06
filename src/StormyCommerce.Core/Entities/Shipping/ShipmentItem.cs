﻿namespace StormyCommerce.Core.Entities.Shipping
{
    public class ShipmentItem : BaseEntity
    {
        public int ShipmentId { get; set; }
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitWeight { get; set; }
        public virtual Shipment Shipment { get; set; }
    }
}
