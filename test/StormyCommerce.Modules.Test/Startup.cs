using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimplCommerce.Module.SampleData;
using SimplCommerce.WebHost.Extensions;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;
using StormyCommerce.Infraestructure.Logging;
using StormyCommerce.Module.Customer.Data;
using StormyCommerce.Modules.Tests.Modules.Extensions;
using Xunit;
using Xunit.Abstractions;
using Xunit.DependencyInjection;
[assembly: TestFramework("StormyCommerce.Modules.Tests.Startup", "StormyCommerce.Modules.Tests")]
namespace StormyCommerce.Modules.Tests
{
    public class Startup : DependencyInjectionTestFramework
    {
        public Startup(IMessageSink messageSink) : base(messageSink) { }

        protected override void ConfigureServices(IServiceCollection services)
        {
            services.AddMappings();
            services.AddDbContextPool<StormyDbContext>(opt => {
                opt.UseLazyLoadingProxies();
                opt.EnableSensitiveDataLogging();
                opt.EnableDetailedErrors();
                opt.UseSqlite("DataSource=testDb.db",m => m.MigrationsAssembly("Modules.Tests"));
            });
            services.AddTransient(typeof(IStormyRepository<>), typeof(StormyRepository<>));
            services.AddTransient(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddCatalogDependencies();
            services.AddOrderDependencies();
            services.AddCustomerDependencies();
            //services.AddCustomizedIdentity();
            
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
                    var userManager = scope.ServiceProvider.GetService<UserManager<StormyCustomer>>();
                    var roleManager = scope.ServiceProvider.GetService<RoleManager<ApplicationRole>>();
                    new IdentityInitializer(dbContext, userManager, roleManager).Initialize();
                    dbContext.SeedDbContext();                    
                }
            }
        }
        protected override IHostBuilder CreateHostBuilder(AssemblyName assemblyName) =>
            base.CreateHostBuilder(assemblyName)
                .ConfigureHostConfiguration(builder => builder.AddInMemoryCollection(new Dictionary<string, string> { { HostDefaults.ApplicationKey, assemblyName.Name } }));
        
    }
}
