namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class Brand : BaseEntity
    {
        public Brand(int id)
        {
            Id = id;
        }

        public Brand()
        {
        }

        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public string LogoImage { get; set; }
    }
}
