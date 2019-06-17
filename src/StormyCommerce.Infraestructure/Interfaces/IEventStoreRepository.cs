using StormyCommerce.Core.Events;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Infraestructure.Interfaces
{
    public interface IEventStoreRepository : IDisposable
    {
        void Store(StoredEvent theEvent);
        IList<StoredEvent> All(Guid aggregateId);
    }
}
