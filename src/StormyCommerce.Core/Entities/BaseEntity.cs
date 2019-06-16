using System;
namespace StormyCommerce.Core.Entities
{
    public class BaseEntity : EntityWithBaseTypeId<long>
    {        
        public DateTime LastModified { get; set; }
    }
}
