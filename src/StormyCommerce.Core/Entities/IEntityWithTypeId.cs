namespace StormyCommerce.Core.Entities
{
	public interface IEntityWithTypeId<TId>
	{
		TId Id { get; }
	}
}
