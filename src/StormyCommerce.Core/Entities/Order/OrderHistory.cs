using StormyCommerce.Core.Entities.Customer;
using System;

namespace StormyCommerce.Core.Entities.Order
{
    public class OrderHistory : EntityBase
    {
        public long StormyOrderId { get; set; }
        public virtual StormyOrder Order { get; set; }
        public OrderStatus? CurrentStatus { get; set; }
        public OrderStatus? OldStatus { get; set; }
        public DateTimeOffset CreatedOn { get; set; } = DateTime.UtcNow;
        public long CreatedById { get; set; }
        public virtual User CreatedBy { get; set; }        
    }
}
