using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Api.Tests.Account
{
    public class AccountEndpointTest
    {
        private readonly HttpClient client;
        public AccountEndpointTest()
        {
            client = new HttpClient();            
        }
        
    }
}
