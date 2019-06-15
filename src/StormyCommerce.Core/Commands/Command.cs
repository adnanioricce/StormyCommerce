using StormyCommerce.Core.Events;
using System;
using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime TimeStamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }
        protected Command()
        {
            TimeStamp = DateTime.UtcNow;
        }
        public abstract bool IsValid();
    }
}
