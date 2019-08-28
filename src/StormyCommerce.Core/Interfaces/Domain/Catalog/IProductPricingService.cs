using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using System;

namespace StormyCommerce.Core.Interfaces.Domain.Catalog
{
    public interface IProductPricingService
    {
        CalculatedProductPriceDto calculatedProductPriceDto(ProductOverviewDto productOverviewDto);
        CalculatedProductPriceDto CalculateProductPrice(ProductDto product);
        CalculatedProductPriceDto CalculateProductPrice(decimal price, decimal? oldPrice, decimal? specialPrice, DateTimeOffset? specialPriceStart, DateTimeOffset? specialPriceEnd);
    }
}
