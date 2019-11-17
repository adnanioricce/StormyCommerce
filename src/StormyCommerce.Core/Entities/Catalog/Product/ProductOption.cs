using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductOption : BaseEntity
    {
        public ProductOption(){}

        public ProductOption(long id)
        {
            Id = id;
        }        
        public string Name { get; set; }
    }
}
