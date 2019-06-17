using StormyCommerce.Core.Events;

namespace StormyCommerce.Infraestructure.Data.EventSourcing
{
    public class SqlEventStore : IEventStore
    {
        private readonly IEventStoreRepository
        public SqlEventStore()
        {

        }
        public void Save<T>(T _event) where T : Event
        {
            throw new System.NotImplementedException();
        }
    }
}
