using System;
using System.Net.Http;

namespace StormyCommerce.Api.Tests
{
    public class CustomerFixture : IDisposable
    {
        public readonly HttpClient client;
        public CustomerFixture()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(Config.BaseUrl);
            client.Authenticate().Wait();
        }
        public void Dispose()
        {
            client.Dispose();
        }
    }
}
