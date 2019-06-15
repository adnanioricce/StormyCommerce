using System.ComponentModel.DataAnnotations;
namespace StormyCommerce.Core.Entities.Catalog.Product
{
    public class ProductOption : BaseEntity
    {
        public ProductOption()
        {

        }

        public ProductOption(long id)
        {
            Id = id;
        }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string Name { get; set; }
    }
}
