using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Entities.Payments;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace StormyCommerce.Core.Entities
{
	public class StormyOrder : BaseEntity
	{		
		public int CustomerId {get;set;}
        public int StatusId { get; set; }
        public int ShippingId { get; set; }
        public int PaymentId { get; set; }
        public Basket OrderBasket { get; set; }
        [NotMapped]
		public Payment Payment {get;set;}
        [NotMapped]
		public Ship Shipping { get; set; }
		public DateTime OrderDate {get;set;}
		public DateTime RequiredDate {get;set;}
		public DateTime ShipDate {get;set;}
        
        public OrderStatus Status { get; set; }
		public decimal GetTotalOrderPrice()
		{
			//?Ok, maybe I need learn LINQ for real...What select will do in detail here
			var result = OrderBasket.Items.Select(f => f.Price - f.Discount).Sum();
			return result;
		}
	}
}
