using System;
namespace StormyCommerce.Core.Entities
{
    public class BaseEntity : IEntityWithBaseTypeId<long>
    {
        public long Id { get; set; }
        public DateTime LastModified { get; set; }

    }
}
