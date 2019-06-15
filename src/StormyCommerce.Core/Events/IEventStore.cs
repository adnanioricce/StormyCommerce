namespace StormyCommerce.Core.Events
{
    public interface IEventStore
    {
        void Save<T>(T _event) where T : Event;
    }
}
