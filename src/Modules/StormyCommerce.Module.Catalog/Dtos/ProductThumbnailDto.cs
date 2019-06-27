using System;

namespace StormyCommerce.Module.Catalog.Dtos
{
    public class ProductThumbnailDto
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Slug { get; private set; }
        public decimal Price { get; private set; }
        public decimal? OldPrice { get; private set; }
        public decimal? SpecialPrice { get; private set; }
        public bool HasDiscountApplied { get; private set; }
        public bool Published { get; private set; }
        public bool AvailableForPreorder { get; private set; }
        //Maybe this will be more hard to make...
        public bool AllowCustomerReview { get; private set; }
        public int? StockQuantity { get; private set; }
        public DateTimeOffset? PreOrderAvailabilityStartDate { get; private set; }
        public MediaDto ThumbnailImage { get; private set; }        

    }
}
