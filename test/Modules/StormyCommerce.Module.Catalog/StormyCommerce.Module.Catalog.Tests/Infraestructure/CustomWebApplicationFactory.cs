using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data;

namespace StormyCommerce.Module.Catalog.Tests.Infraestructure
{
    public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
    {
        protected override IWebHostBuilder CreateWebHostBuilder()
        {                                
            return base.CreateWebHostBuilder()
                .UseStartup<TStartup>();
        }
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services => 
            {
                //Create a new service provider
                var serviceProvider = new ServiceCollection()
                    .AddEntityFrameworkInMemoryDatabase()
                    .BuildServiceProvider();
                
                //Add a database context using a in-memory
                //database for testing
                services.AddDbContext<IStormyDbContext,StormyDbContext>(options => 
                {                    
                    options.UseInMemoryDatabase("InMemoryTestDb" + Guid.NewGuid().ToString("N"));
                    options.UseInternalServiceProvider(serviceProvider);
                });
                //Build the service provider 
                var sp = services.BuildServiceProvider();

                //Create a scope to obtain reference to the database
                using(var scope = sp.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var context = scopedServices.GetRequiredService<IStormyDbContext>();
                    var logger = scopedServices.GetRequiredService<ILogger<CustomWebApplicationFactory<TStartup>>>();
                    var concreteContext = (StormyDbContext)context;

                    concreteContext.Database.EnsureCreated();                    
                    try
                    {
                        Utils.Utilities.InitializeTestDb(concreteContext);
                    }
                    catch(Exception ex)
                    {
                        logger.LogError(ex,$"Error throwed when sending the database.Message:{ex.Message}");
                    }
                }
            });
        }
    }
}
