namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class Brand : BaseEntity
    {        
        public string Name { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public string LogoImage { get; set; }
        public bool Deleted { get; set; }
    }
}
