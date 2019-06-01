using System.Collections.Generic;

namespace StormyCommerce.Core.Models.GatewayResponses
{
    public abstract class BaseGatewayResponse
    {
        public bool Success { get; private set; }
        public IEnumerable<Error> Errors { get; private set; }
    }
}