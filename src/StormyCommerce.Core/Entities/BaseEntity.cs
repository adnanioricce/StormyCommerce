using System;
namespace StormyCommerce.Core.Entities
{
	public class BaseEntity : EntityBaseWithTypedId<long> 
	{
		public DateTime LastModified { get; set; }

	}
}
