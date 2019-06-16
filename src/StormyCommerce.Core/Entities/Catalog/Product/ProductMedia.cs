namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductMedia : BaseEntity
    {
        public long ProductId { get; set; }

        public StormyProduct Product { get; set; }

        public long MediaId { get; set; }

        public Media.Media Media { get; set; }

        public int DisplayOrder { get; set; }
    }
}
