namespace StormyCommerce.Core.Entities
{
    public interface IEntityWithBaseTypeId<TId>
    {
        TId Id { get; }
    }
}
