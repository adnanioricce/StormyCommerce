namespace StormyCommerce.Core.Entities
{
	public class Rating 
	{
		public int Id {get;set;}
		public Customer.StormyConsumer Author {get;set;}
		public string Title {get;set;}
		public string Comment { get;set;}
		public int RatingLevel { get; set;}
	}
}
