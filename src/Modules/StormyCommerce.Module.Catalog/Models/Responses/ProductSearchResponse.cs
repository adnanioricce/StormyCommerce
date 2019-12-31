namespace StormyCommerce.Core.Models.Requests
{
    public class ProductSearchResponse
    {
        public long Id { get; private set; }
        public string ProductName { get; private set; }
        public string ThumbnailImage { get; private set; }
        public string Slug { get; private set; }
        public string ShortDescription { get; private set; }
        public string UnitPrice { get; set; }
    }
}
