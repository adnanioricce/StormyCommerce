
namespace StormyCommerce.Core.Entities
{
    public class EntityWithBaseTypeId<TId> : ValidatableObject,IEntityWithBaseTypeId<TId>
    {
        public virtual TId Id { get; protected set; }
    }
}
