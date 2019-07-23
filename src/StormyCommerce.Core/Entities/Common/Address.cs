namespace StormyCommerce.Core.Entities.Common
{
	public class Address : BaseEntity
	{		
		public string Street {get;set;}
		public string FirstAddress {get;set;}
		public string SecondAddress {get;set;}
		public string City {get;set;}
		public string State {get;set;}
		public string PostalCode {get;set;}
		public string Number {get;set;}
		public string Complement {get;set;}
		public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public long OwnerId { get; set; }
    }
}
