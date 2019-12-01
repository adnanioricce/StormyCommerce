using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;

namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders
{
    public class OrderItemDto
    {        
        public OrderItemDto(OrderItem orderItem)
        {            
            Price = orderItem.Price;
            Quantity = orderItem.Quantity;
            Product = orderItem.Product == null ? this.Product : new ProductDto(orderItem.Product);
        }
        public OrderItemDto(decimal price,int quantity,ProductDto product)
        {
            Price = price;
            Quantity = quantity;
            Product = product;
        }
        public OrderItemDto(long id,decimal price, int quantity, ProductDto product) : this(price,quantity,product)
        {
            Id = id;
        }
        public long Id { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }
        public ProductDto Product { get; private set; } = new ProductDto();       

        public OrderItem ToOrderItem()
        {
            return new OrderItem
            {                
                Quantity = this.Quantity,
                Product = this.Product.ToStormyProduct(),
                Price = this.Price
            };
        }
    }
}
