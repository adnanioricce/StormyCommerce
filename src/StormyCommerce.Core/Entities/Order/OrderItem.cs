using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;

namespace StormyCommerce.Core.Entities.Order
{
    public class OrderItem : BaseEntity
    {
        public OrderItem(int id)
        {
            Id = id;
        }
        public OrderItem()
        {

        }
        public int Quantity { get; set; }        
        public StormyProduct Product { get; set; }
        public string Price { get; set; }
        public long StormyProductId { get; set; }
        public long StormyOrderId { get; set; }
        public StormyOrder Order { get; set; }
        public string ProductName { get; set; }
        public long ShipmentId { get; set; }
        public Shipment Shipment { get; set; }
        public OrderItemDto ToOrderItemDto()
        {
            return new OrderItemDto(this);
        }
    }
}
