using System;

namespace StormyCommerce.Core.Entities 
{
	//! Is to little info, should this exist?
	public class Shipment : BaseEntity
	{
        public Shipment(int id)
        {
            Id = id;
        }
        public Shipment()
        {

        }
        public string TrackNumber { get; set; }
        public decimal TotalWeight { get; set; }       
        public DateTime CreatedOn { get; set; }
		public DateTime? ShippedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Comment { get; set; }
        public decimal Price { get; set; }		
		public decimal DeliveryCost { get; set; }
	}
}
