using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Product;
using System;

namespace StormyCommerce.Core.Entities.Order
{
    public class OrderItem : EntityWithTypeId<Guid>
    {        
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public string ProductName { get; set; }        
        public decimal OldProductCost { get; set; }
        public decimal ActualProductCost { get; set; }
        public StormyOrder Order { get; set; }
        public StormyProduct Product { get; set; }
    }
}
