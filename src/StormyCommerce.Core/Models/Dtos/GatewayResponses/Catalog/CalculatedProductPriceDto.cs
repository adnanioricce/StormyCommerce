namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog
{
    public class CalculatedProductPriceDto
    {
        public decimal? OldPrice { get; private set; }
        public decimal Price { get; private set; }
        public int PercentsOfSaving { get; private set; }
        public CalculatedProductPriceDto(decimal? oldPrice,decimal price,int percentsOfSaving)
        {
            OldPrice = oldPrice;
            Price = price;
            PercentsOfSaving = percentsOfSaving;
        }
    }
}
