using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;

namespace StormyCommerce.Core.Entities.Order
{
    public class OrderItem : BaseEntity
    {
        public OrderItem(long id)
        {
            Id = id;
        }
        public OrderItem(){}        
        public int Quantity { get; set; }
        public virtual StormyProduct Product { get; set; }
        public decimal Price { get; set; }
        public long StormyProductId { get; set; }
        public long StormyOrderId { get; set; }
        public virtual StormyOrder Order { get; set; }        
        public long? ShipmentId { get; set; }
        public virtual Core.Entities.Shipping.StormyShipment Shipment { get; set; }

        public OrderItemDto ToOrderItemDto()
        {
            return new OrderItemDto(this);
        }
    }
}
