namespace StormyCommerce.Module.Catalog.Models.Responses
{
    public class ProductSearchResponse
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string ThumbnailImage { get; private set; }
        public string Slug { get; private set; }
        public string ShortDescription { get; private set; }
        public string UnitPrice { get; private set; }
    }
}
