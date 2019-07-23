using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimplCommerce.WebHost;
using StormyCommerce.Infraestructure.Data;
using System.IO;

namespace StormyCommerce.Modules.IntegrationTest
{
    public class TestFixture<TStartup> : WebApplicationFactory<Startup>
    {
        protected override TestServer CreateServer(IWebHostBuilder builder)
        {
            return new TestServer(builder);
        }
        protected override IWebHostBuilder CreateWebHostBuilder()
        {
            var builder = new WebHostBuilder()                
                .UseContentRoot(GetContentRoot())
                .UseStartup<Startup>();            
            return builder;
        }
        private string GetContentRoot()
        {
            return (Directory.GetParent("../src/SimplCommerce.WebHost")).FullName;
        }
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services => {
                var serviceProvider = new ServiceCollection()
                //TODO:Change to a real database
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();
                services.AddDbContext<StormyDbContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryDatabaseTesting");
                    options.UseInternalServiceProvider(serviceProvider);
                });
            });
            base.ConfigureWebHost(builder);
        }
    }
}
