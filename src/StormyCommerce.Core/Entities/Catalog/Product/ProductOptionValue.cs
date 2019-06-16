using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductOptionValue : BaseEntity
    {
        public long OptionId { get; set; }

        public ProductOption Option { get; set; }

        public long ProductId { get; set; }

        public StormyProduct Product { get; set; }

        [StringLength(450)]
        public string Value { get; set; }

        [StringLength(450)]
        public string DisplayType { get; set; }

        public int SortIndex { get; set; }
    }
}
