using System.ComponentModel.DataAnnotations;
using StormyCommerce.Core.Entities;

namespace SimplCommerce.Module.Catalog.Models
{
    public class Brand : EntityBase
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string Slug { get; set; }

        public string Description { get; set; }

        public bool IsPublished { get; set; }        
        public string Website { get; set; }
    }
}
