using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StormyCommerce.Core.Entities
{
	public class BaseEntity 
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id {get;set;} 		
		public DateTime LastModified { get; set; }

	}
}
