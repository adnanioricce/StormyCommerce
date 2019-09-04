using System;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
namespace StormyCommerce.Api.Framework.Extensions
{
    public static class SeedExtensions
    {
        public static List<ProductDto> ToListProductDto(this List<StormyProduct> products)
        {
            return products.Select(product => product.ToProductDto());
        }
    }
}
