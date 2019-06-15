using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Media;
namespace SimplCommerce.Module.Catalog.Models
{
    public class ProductMedia : BaseEntity
    {
        public long ProductId { get; set; }

        public StormyProduct Product { get; set; }

        public long MediaId { get; set; }

        public Media Media { get; set; }

        public int DisplayOrder { get; set; }
    }
}
