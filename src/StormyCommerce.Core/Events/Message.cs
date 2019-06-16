using MediatR;
using System;

namespace StormyCommerce.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get; protected set; }
        public Guid Key { get; set; }
        protected Message()
        {
            MessageType = this.GetType().Name;
        }
    }
}
