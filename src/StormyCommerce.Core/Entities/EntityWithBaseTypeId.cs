using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Core.Entities
{
    public abstract class EntityWithBaseTypeId<TId> : ValidatableObject,IEntityWithBaseTypeId<TId>
    {
        [Key]
        public virtual TId Id { get; protected set; }       
    }
}
