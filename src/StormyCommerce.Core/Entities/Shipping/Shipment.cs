using System;
using StormyCommerce.Core.Entities.Common;
using System.Collections.Generic;
namespace StormyCommerce.Core.Entities 
{
	//! Is to little info, should this exist?
    //TODO:Is the reference to StormyCustomerId useful?Why not use only the UserId?
    //TODO:Define a property to know the "metrics" of a shipment object
	public class Shipment : BaseEntity
	{
        public Shipment(int id)
        {
            Id = id;
        }
        public Shipment()
        {

        }        
        
        public long StormyCustomerId { get; set; }
        public string UserId { get; set; }
        // public long OrderId { get; set; }
        // public StormyOrder Order { get; set; }
        public StormyCustomer Customer { get; set; }        
        public string WhoReceives { get; set; }
        public string TrackNumber { get; set; }
        public string ShipmentMethod { get; set; }
        public string ShipmentProviderName { get; set; }
        public decimal TotalWeight { get; set; }       
        public DateTime CreatedOn { get; set; }
		public DateTime ShippedDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Comment { get; set; }
        public decimal Price { get; set; }		
		public decimal DeliveryCost { get; set; }        
        public long BillingAddressId { get; set; }
        public Address BillingAddress { get; set; }
        public long DestinationAddressId { get; set; }
        public Address DestinationAddress { get; set; }
        public List<ShipmentItem> Items { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Diameter { get; set; }
        // public decimal ValorDeclarado { get; set; }
        // public string AvisoDeRecebimento { get; set; }

	}
}
