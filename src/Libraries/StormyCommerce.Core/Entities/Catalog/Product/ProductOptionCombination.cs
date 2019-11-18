using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductOptionCombination : BaseEntity
    {
        public long ProductId { get; set; }
        public virtual StormyProduct Product { get; set; }
        public long OptionId { get; set; }
        public virtual ProductOption Option { get; set; }
        public string Value { get; set; }
        public int SortIndex { get; set; }
    }
}
