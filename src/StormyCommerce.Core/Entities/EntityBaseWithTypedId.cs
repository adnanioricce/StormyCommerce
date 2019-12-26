using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Core.Entities
{
    public abstract class EntityBaseWithTypedId<TId> : ValidatableObject, IEntityBaseWithTypedId<TId>
    {
        [Key]
        public virtual TId Id { get; set; }
    }
}
