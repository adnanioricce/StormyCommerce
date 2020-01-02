using System.Collections.Generic;
using System.Linq;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;


namespace StormyCommerce.Core.Extensions
{
    public static class StormyProductExtensions
    {
        //public static double GetDimensions(this ProductDto productDto)
        //{            
        //    return CalculateDimensions(productDto.Height,productDto.Height,productDto.Length);
        //}
                
        //private static double CalculateDimensions(double height,double width,double length)
        //{
        //    return length * height * width;
        //}
        //public static bool HasStockForOrderItems(this IEnumerable<OrderItemDto> items)
        //{
        //    return items.All(p => (p.Product.UnitsInStock - p.Product.UnitsOnOrder) >= p.Quantity);            
        //}
        //public static bool HasStockForOrderItems(this IEnumerable<CartItem> items,IEnumerable<StormyProduct> products)
        //{
        //    return MergeToItemProductDictonary(items,products)
        //    .All(p => p.Value.CanOrderQuantity(p.Key.Quantity));
        //}
        //public static bool HasStockForOrderItems(this IDictionary<CartItem,StormyProduct> items)
        //{
        //    return items.All(p => (p.Value.UnitsInStock - p.Value.UnitsOnOrder) >= p.Key.Quantity);
        //}
        //public static IDictionary<CartItem,StormyProduct> MergeToItemProductDictonary(this IEnumerable<CartItem> items,IEnumerable<StormyProduct> products)
        //{
        //    return items           
        //    .Select((item,index) => new {item,product = products.FirstOrDefault(p => p.Id == item.ProductId)})             
        //    .ToDictionary(i => i.item,i => i.product);
        //}                
    }
}
