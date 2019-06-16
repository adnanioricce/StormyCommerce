using System;

namespace StormyCommerce.Core.Entities.Order
{
    public class OrderNote : BaseEntity
    {
        public int OrderId { get; set; }
        public bool DisplayToCustomer { get; set; }                
        public string Note { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public StormyOrder Order { get; set; }
    }
}
