using System;
using StormyCommerce.Core.Models.Dtos;

namespace SimplCommerce.Module.Shipments.Models.Dtos
{
    public class ShipmentDto
    {
        public ShipmentDto(){}
        public ShipmentDto(Shipment shipment)
        {
            DeliveryCost = shipment.DeliveryCost;
            DestinationAddress = new CustomerAddressDto(shipment.DestinationAddress);
            CreatedOn = shipment.CreatedOn;
            ShippedDate = shipment.ShippedDate;
            DeliveryDate = shipment.DeliveryDate;
            ExpectedDeliveryDate = shipment.ExpectedDeliveryDate;
            ExpectedHourOfDay = shipment.ExpectedHourOfDay;
            ShipmentProvider = shipment.ShipmentProvider;
            ShipmentMethod = shipment.ShipmentMethod;
            TrackingNumber = shipment.TrackingNumber;
            Status = shipment.Status;
        }        
        public decimal DeliveryCost { get; private set; }
        public virtual CustomerAddressDto DestinationAddress { get; private set; } = new CustomerAddressDto();
        public DateTimeOffset CreatedOn { get; private set; }
        public DateTimeOffset? ShippedDate { get; private set; }
        public DateTimeOffset? DeliveryDate { get; private set; }
        public DateTimeOffset? ExpectedDeliveryDate { get; private set; }
        public DateTimeOffset? ExpectedHourOfDay { get; private set; }
        public ShippingMethod ShipmentMethod { get; private set; }
        public ShipmentStatus Status { get; private set; }
        public string TrackingNumber { get; private set; }
        public string ShipmentProvider { get; private set; }
    }
}
