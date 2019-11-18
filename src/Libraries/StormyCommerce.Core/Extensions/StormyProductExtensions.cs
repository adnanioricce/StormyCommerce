using System;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;

namespace StormyCommerce.Core.Extensions
{
    public static class StormyProductExtensions
    {
        public static double GetDimensions(this ProductDto productDto)
        {            
            return CalculateDimensions(productDto.Height,productDto.Height,productDto.Length);
        }
                
        private static double CalculateDimensions(double height,double width,double length)
        {
            return length * height * width;
        }
        
    }
}
