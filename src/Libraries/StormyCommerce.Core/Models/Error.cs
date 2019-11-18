using System;

namespace StormyCommerce.Core.Models
{
    public sealed class Error
    {
        public string Code { get; }
        public string Description { get; }
        public Exception ThrowedException { get; set; }

        public Error(string code, string description, Exception throwedException)
        {
            Code = code;
            Description = description;
            ThrowedException = throwedException;
        }
    }
}
