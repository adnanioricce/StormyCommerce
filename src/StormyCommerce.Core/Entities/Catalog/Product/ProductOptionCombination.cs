using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductOptionCombination : BaseEntity
    {
        public long ProductId { get; set; }

        public StormyProduct Product { get; set; }

        public long OptionId { get; set; }

        public ProductOption Option { get; set; }

        [StringLength(450)]
        public string Value { get; set; }

        public int SortIndex { get; set; }
    }
}
