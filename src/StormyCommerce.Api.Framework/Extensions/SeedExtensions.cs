
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Api.Framework.Extensions
{
    public static class SeedExtensions
    {
        public static IEnumerable<ProductDto> ToListProductDto(this List<StormyProduct> products)
        {
            return products.Select(product => new ProductDto(product));
        }
    }
}
