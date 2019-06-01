using System;

namespace StormyCommerce.Core.Entities 
{
	//! Is to little info, should this exist?
	public class Ship : BaseEntity
	{		
		public ShipType Type {get;set;}
		public DateTime CreatedOn { get; set; }
		public DateTime ShipDate { get; set; }
		public decimal Price {get;set;}
		//TODO:In the case that the cost and price for the end user being different
		public decimal DeliveryCost { get; set; }
	}
}
