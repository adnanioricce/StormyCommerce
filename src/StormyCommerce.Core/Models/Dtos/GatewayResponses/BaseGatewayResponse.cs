using System.Collections.Generic;

namespace StormyCommerce.Core.Models.Dtos.GatewayResponses
{
    public abstract class BaseGatewayResponse
    {
        public bool Success { get; private set; }
        public IEnumerable<Error> Errors { get; private set; }
    }
}
