using StormyCommerce.Core.Commands;
using StormyCommerce.Core.Events;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
