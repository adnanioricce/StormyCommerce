namespace StormyCommerce.Core.Entities
{
    public interface IEntityBaseWithTypedId<TId>
    {
        TId Id { get; set; }
    }
}
