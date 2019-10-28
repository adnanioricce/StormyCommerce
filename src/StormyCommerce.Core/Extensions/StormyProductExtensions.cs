using System;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;

namespace StormyCommerce.Core.Extensions
{
    public static class StormyProductExtensions
    {
        public static decimal GetDimensions(this ProductDto productDto)
        {            
            return CalculateDimensions(productDto.Height,productDto.Height,productDto.Length);
        }
        
        private static decimal CalculateClothingDimensions(decimal height,decimal width)
        {
            throw new NotImplementedException();
        }
        private static decimal CalculateDimensions(decimal height,decimal width,decimal length)
        {
            return ((length * height) * 2) + ((width * length) * 2) + ((height * width) * 2);
        }
    }
}
