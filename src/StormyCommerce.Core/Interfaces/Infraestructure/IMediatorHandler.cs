using StormyCommerce.Core.Commands;
using StormyCommerce.Core.Events;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces.Infraestructure
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T Command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
