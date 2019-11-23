using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PagarMe;
using SimplCommerce.Module.EmailSenderSendgrid;
using SimplCommerce.Module.SampleData;
using SimplCommerce.WebHost.Extensions;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Core.Services.Customer;
using StormyCommerce.Core.Services.Orders;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;
using StormyCommerce.Infraestructure.Data.Stores;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Infraestructure.Logging;
using StormyCommerce.Module.Catalog.Services;
using StormyCommerce.Module.Customer.Services;
using StormyCommerce.Module.Orders.Interfaces;
using StormyCommerce.Module.Orders.Services;
using StormyCommerce.Modules.Tests.Modules.Extensions;
using Xunit;
using Xunit.Abstractions;
using Xunit.DependencyInjection;
[assembly: TestFramework("Modules.Tests.Startup", "Modules.Tests")]
namespace Modules.Tests
{
    public class Startup : DependencyInjectionTestFramework
    {
        public Startup(IMessageSink messageSink) : base(messageSink) { }

        protected override void ConfigureServices(IServiceCollection services)
        {
            services.AddMappings();
            services.AddDbContextPool<StormyDbContext>(opt => {
                opt.EnableSensitiveDataLogging();
                opt.EnableDetailedErrors();
                opt.UseSqlite("DataSource=testDb.db",m => m.MigrationsAssembly("Modules.Tests"));
            });
            services.AddTransient(typeof(IStormyRepository<>), typeof(StormyRepository<>));
            services.AddTransient(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddCatalogDependencies();
            services.AddOrderDependencies();
            services.AddCustomerDependencies();
            services.AddCustomizedIdentity();
            
            //TODO: add extension method for asp.net identity configuration
        }
        protected override void Configure(IServiceProvider provider){
           using (var scope = provider.CreateScope())
            {
                using (var dbContext = (StormyDbContext)scope.ServiceProvider.GetService<StormyDbContext>())
                {                    
                    if (dbContext.Database.EnsureDeleted())
                    {
                        dbContext.Database.ExecuteSqlCommand(dbContext.Database.GenerateCreateScript());
                    }                                            
                    dbContext.SeedDbContext();                    
                }
            }
        }
        protected override IHostBuilder CreateHostBuilder(AssemblyName assemblyName) =>
            base.CreateHostBuilder(assemblyName)
                .ConfigureHostConfiguration(builder => builder.AddInMemoryCollection(new Dictionary<string, string> { { HostDefaults.ApplicationKey, assemblyName.Name } }));
        
    }
}
