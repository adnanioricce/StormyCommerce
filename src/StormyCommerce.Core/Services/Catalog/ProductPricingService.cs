
using System;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
//Literally just ported the code to my model
//Prefer to use this than add a dependency to another module
namespace StormyCommerce.Core.Services.Catalog
{
    public class ProductPricingService : IProductPricingService
    {
        public CalculatedProductPriceDto calculatedProductPriceDto(ProductOverviewDto productOverviewDto)
        {
            throw new NotImplementedException();
        }

        public CalculatedProductPriceDto CalculateProductPrice(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public CalculatedProductPriceDto CalculateProductPrice(decimal price, decimal? oldPrice, decimal? specialPrice, DateTimeOffset? specialPriceStart, DateTimeOffset? specialPriceEnd)
        {
            var percentOfSaving = 0;
            var calculatedPrice = price;

            if (specialPrice.HasValue && specialPriceStart < DateTimeOffset.Now && DateTimeOffset.Now < specialPriceEnd)
            {
                calculatedPrice = specialPrice.Value;

                if (!oldPrice.HasValue || oldPrice < price)
                {
                    oldPrice = price;
                }
            }

            if (oldPrice.HasValue && oldPrice.Value > 0 && oldPrice > calculatedPrice)
            {
                percentOfSaving = (int)(100 - Math.Ceiling((calculatedPrice / oldPrice.Value) * 100));
            }

            return new CalculatedProductPriceDto
            (
                oldPrice,
                calculatedPrice,                
                percentOfSaving
            );
        }
    }
}
