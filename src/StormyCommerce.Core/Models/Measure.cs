using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Extensions;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;

namespace StormyCommerce.Core.Models
{
    public class Measure
        {
            public Measure(){}
            public Measure(OrderItemDto item)
            {
                Height += item.Quantity * item.Product.Height;
                Width += item.Quantity * item.Product.Width;
                Length += item.Quantity * item.Product.Length;
                Weight += item.Quantity * (decimal)item.Product.UnitWeight;
                Area += item.Quantity * item.Product.GetDimensions();
            }
            public Measure(OrderItem item)
            {
                Height += item.Quantity * item.Product.Height;
                Width += item.Quantity * item.Product.Width;
                Length += item.Quantity * item.Product.Length;                
                Weight += item.Quantity * (decimal)item.Product.UnitWeight;
                Area += item.Product.CalculateDimensions(item.Quantity);
            }
            public decimal Area { get; set; }
            public decimal Height { get; set; }
            public decimal Width { get; set; }
            public decimal Weight { get; set; }
            public decimal Length { get; set; }
            public decimal Diameter { get; set; }
        }
}