//!This Code probably Will be deleted
using StormyCommerce.Core.Entities.Catalog.Product;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities
{
    public class Stock : BaseEntity
    {
        public virtual IEnumerable<StormyProduct> Products { get; set; }

        //?Why not put this on Product Instead?
        public virtual IEnumerable<StormyOrder> Orders { get; set; }
    }
}
