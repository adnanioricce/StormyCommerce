using StormyCommerce.Core.Entities.Common;
using System;
namespace StormyCommerce.Core.Entities.Customer
{
	public class StormyConsumer : BaseEntity
	{
        public int UserId { get; set; }
        public string FullName {get;set;}
		public string Email {get; set;}
		public char Gender {get;set;}
		public string DateOfBirth {get;set;}        
        public DateTime CreatedAt {get;set;}
		public Address Address { get; set; }		
	}
}
