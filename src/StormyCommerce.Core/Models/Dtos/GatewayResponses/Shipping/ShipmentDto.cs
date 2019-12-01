using System;
using StormyCommerce.Core.Entities.Shipping;

namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Shipping
{
    public class ShipmentDto
    {
        public ShipmentDto(){}
        public ShipmentDto(StormyShipment shipment)
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
            TrackNumber = shipment.TrackNumber;
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
        public ShippingStatus Status { get; private set; }
        public string TrackNumber { get; private set; }
        public string ShipmentProvider { get; private set; }
    }
}
