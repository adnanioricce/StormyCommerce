using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace StormyCommerce.Api.Tests.Catalog
{
    public class ProductEndpointTest
    {
        private readonly HttpClient client;
        public ProductEndpointTest()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(Config.BaseUrl);
        }

    }
}
