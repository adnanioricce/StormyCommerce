using System;
using System.Collections.Generic;
using System.Text;

namespace StormyCommerce.Module.Orders.Area.Models.Orders
{
    public class PostBackRequest
    {
        public string Id { get; set; }
        public string Object { get; set; }
        public string Status { get; set; }
        public string Model { get; set; }
        public string ModelId { get; set; }
        public string Headers { get; set; }
        public string Payload { get; set; }
        public string RequestUrl { get; set; }
        public int Retries { get; set; }
        public DateTime NextRetry { get; set; }
        public List<object> Deliveries { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
