using StormyCommerce.Core.Entities.Customer;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductPriceHistory : BaseEntity
    {
        public ProductPriceHistory()
        {
            CreatedOn = DateTimeOffset.Now;
        }

        public StormyProduct Product { get; set; }

        public long CreatedById { get; set; }

        public StormyCustomer CreatedBy { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public decimal? Price { get; set; }

        public decimal? OldPrice { get; set; }

        public decimal? SpecialPrice { get; set; }

        public DateTimeOffset? SpecialPriceStart { get; set; }

        public DateTimeOffset? SpecialPriceEnd { get; set; }

        [NotMapped]
        public bool IsPriceChange { get; set; }
    }
}
