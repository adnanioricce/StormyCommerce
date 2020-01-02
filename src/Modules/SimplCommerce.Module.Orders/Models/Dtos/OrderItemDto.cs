using SimplCommerce.Module.Orders.Models;
using StormyCommerce.Module.Catalog.Models.Dtos;

namespace StormyCommerce.Module.Orders.Models.Dtos
{
    public class OrderItemDto
    {        
        public OrderItemDto(OrderItem orderItem)
        {            
            ProductPrice = orderItem.ProductPrice;
            Quantity = orderItem.Quantity;
            Product = orderItem.Product == null ? this.Product : new ProductDto(orderItem.Product);
        }
        public OrderItemDto(decimal price,int quantity,ProductDto product)
        {
            ProductPrice = price;
            Quantity = quantity;
            Product = product;
        }
        public OrderItemDto(long id,decimal price, int quantity, ProductDto product) : this(price,quantity,product)
        {
            Id = id;
        }
        public long Id { get; private set; }
        public decimal ProductPrice { get; private set; }
        public int Quantity { get; private set; }
        public ProductDto Product { get; private set; } = new ProductDto();       

        public OrderItem ToOrderItem()
        {
            return new OrderItem
            {                
                Quantity = this.Quantity,
                Product = this.Product.ToStormyProduct(),
                ProductPrice = this.ProductPrice
            };
        }
    }
}
