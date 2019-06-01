namespace StormyCommerce.Core.Entities.Payments
{
	public class Payment : BaseEntity
	{		
		public string PaymentType {get;set;}
		public PaymentDetail PaymentDetails {get;set;}
	}
}
