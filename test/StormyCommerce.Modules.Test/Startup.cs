﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimplCommerce.Module.SampleData;
using SimplCommerce.WebHost.Extensions;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.User;
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
            var configBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            Container.Configuration = configBuilder;
            services.AddSingleton(configBuilder);
            services.AddMappings();
            services.AddDbContextPool<StormyDbContext>(opt => {
                opt.UseLazyLoadingProxies();
                opt.EnableSensitiveDataLogging();
                opt.EnableDetailedErrors();
                opt.UseSqlite(Container.Configuration.GetConnectionString("Sqlite"),m => m.MigrationsAssembly("Modules.Tests"));
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
                    if ((dbContext.Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists()){
                        dbContext.Database.EnsureDeleted();
                        dbContext.Database.ExecuteSqlCommand(dbContext.Database.GenerateCreateScript());
                        var userManager = scope.ServiceProvider.GetService<UserManager<StormyUser>>();
                        var roleManager = scope.ServiceProvider.GetService<RoleManager<Role>>();
                        new IdentityInitializer(dbContext, userManager, roleManager).Initialize();
                        dbContext.SeedDbContext();
                    }
                }
            }
        }
        protected override IHostBuilder CreateHostBuilder(AssemblyName assemblyName) =>
            base.CreateHostBuilder(assemblyName)
                .ConfigureHostConfiguration(builder => builder.AddInMemoryCollection(new Dictionary<string, string> { { HostDefaults.ApplicationKey, assemblyName.Name } }));
        
    }
}
