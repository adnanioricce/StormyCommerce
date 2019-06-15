using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StormyCommerce.Core.Entities
{
	public class BaseEntity : IEntityWithBaseTypeId<long>
	{        
        public long Id { get; set; }
        public DateTime LastModified { get; set; }
        
    }
}
