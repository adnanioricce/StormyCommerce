namespace StormyCommerce.Core.Entities
{
	public class EntityWithTypeId<TId> : ValidatableObject, IEntityWithTypeId<TId>
	{
		public virtual TId Id {get; protected set;}
	}
}
