using System;
using System.ComponentModel.DataAnnotations.Schema;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductPriceHistory : BaseEntity
    {
        public ProductPriceHistory()
        {
            CreatedOn = DateTimeOffset.Now;
        }

        public Product Product { get; set; }

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
