using System.Collections.Generic;
using System.Linq;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Module.Catalog.Models.Dtos;
using SimplCommerce.Module.ShoppingCart.Models;
using StormyCommerce.Module.Orders.Models.Dtos;

namespace StormyCommerce.Module.Catalog.Extensions
{
    public static class IStormyRepositoryExtensions
    {
        public static double GetDimensions(this ProductDto productDto)
        {            
            return CalculateDimensions(productDto.Height,productDto.Height,productDto.Length);
        }
                
        private static double CalculateDimensions(double height,double width,double length)
        {
            return length * height * width;
        }
        //TODO:Move this to Orders Module
        public static bool HasStockForOrderItems(this IEnumerable<OrderItemDto> items)
        {
            return items.All(p => (p.Product.UnitsInStock - p.Product.UnitsOnOrder) >= p.Quantity);            
        }
        public static bool HasStockForOrderItems(this IEnumerable<CartItem> items,IEnumerable<Product> products)
        {
            return MergeToItemProductDictonary(items,products)
            .All(p => p.Value.CanOrderQuantity(p.Key.Quantity));
        }
        public static bool HasStockForOrderItems(this IDictionary<CartItem, Product> items)
        {
            return items.All(p => (p.Value.UnitsInStock - p.Value.UnitsOnOrder) >= p.Key.Quantity);
        }
        public static IDictionary<CartItem,Product> MergeToItemProductDictonary(this IEnumerable<CartItem> items,IEnumerable<Product> products)
        {
            return items           
            .Select((item,index) => new {item,product = products.FirstOrDefault(p => p.Id == item.ProductId)})             
            .ToDictionary(i => i.item,i => i.product);
        }                
    }
}
