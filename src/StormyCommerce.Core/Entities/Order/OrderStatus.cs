using System;

namespace StormyCommerce.Core.Entities
{
    public class OrderStatus
    {
        public int id { get; set; }
        public string StatusName { get; set; }
        public int ShipId { get; set; }
        public int OrderId { get; set; }        
        public DateTime LastModified { get; set; }
        public Rating OrderRating { get; set; }
    }
}