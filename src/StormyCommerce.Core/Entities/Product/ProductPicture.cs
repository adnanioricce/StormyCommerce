using StormyCommerce.Core.Entities.Media;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StormyCommerce.Core.Entities.Product
{
    public class ProductPictures : BaseEntity
    {
        [NotMapped]
        public StormyProduct Product { get; set; }
        public int ProductId { get; set; }
        public ICollection<Picture> Pictures { get; set; }

    }
}
