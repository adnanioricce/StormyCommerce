using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Entities.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Core.Entities
{
	public class StormyOrder : BaseEntity
	{
        public Guid OrderUniqueKey { get; set; }
        public int CustomerId {get;set;}
        public int StatusId { get; set; }
        public int ShippingId { get; set; }
        public int ShippingStatusId { get; set; }
        public int PaymentId { get; set; }
        public int PaymentStatusId { get; set; }
        public bool PickUpInStore { get; set; }
        public bool IsDeleted { get; set; }
        public string ShippingMethod { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        //public Payment Payment {get;set;}
        public StormyCustomer Customer { get; set; }
        public Address ShippingAddress { get; set; }        
        public DateTime OrderDate {get;set;}
		public DateTime RequiredDate {get;set;}
		public DateTime ShipDate {get;set;}
        public DateTime? PaidDate { get; set; }
        public IList<OrderItem> Items { get; set; }
        public IList<OrderNote> Notes { get; set; }
        public IList<Shipment> Shipments { get; set; }
        public OrderStatus Status { get; set; }
        public ShippingStatus ShippingStatus { get; set; }
        public decimal GetTotalOrderPrice()
		{
            throw new NotImplementedException();
		}
	}
}
