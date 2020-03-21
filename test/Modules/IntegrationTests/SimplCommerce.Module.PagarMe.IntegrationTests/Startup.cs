using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimplCommerce.Infrastructure;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Module.Core.Data;
using SimplCommerce.Module.PagarMe.Services;
using SimplCommerce.Module.Payments.Interfaces;
using SimplCommerce.WebHost.Extensions;
using Xunit;
using Xunit.Abstractions;
using Xunit.DependencyInjection;

[assembly: TestFramework("SimplCommerce.Module.PagarMe.IntegrationTests.Startup","SimplCommerce.Module.PagarMe.IntegrationTests")]
namespace SimplCommerce.Module.PagarMe.IntegrationTests
{
    public class Startup : DependencyInjectionTestFramework
    {
        public Startup(IMessageSink messageSink) : base(messageSink){            }
        protected override void ConfigureServices(IServiceCollection services)
        {
            var configuration = GetIConfigurationRoot(GetSharedFolder(AppDomain.CurrentDomain.BaseDirectory));            
            GlobalConfiguration.ContentRootPath = GetSrcPath(AppDomain.CurrentDomain.BaseDirectory) + "\\SimplCommerce.WebHost\\";
            services.AddSingleton(configuration);
            services.AddModules(GlobalConfiguration.ContentRootPath);
            services.AddDbContextPool<SimplDbContext>(opt => {
                opt.EnableSensitiveDataLogging();
                opt.EnableDetailedErrors();
                // If you don't want to run a database
                opt.UseSqlite("DataSource=testDb.db", m => m.MigrationsAssembly("StormyCommerce.Module.Catalog.Tests")); 
            });
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient(typeof(IRepositoryWithTypedId<,>), typeof(RepositoryWithTypedId<,>));
            services.AddTransient<IPaymentProvider, PagarMeProcessor>();            
        }
        protected override void Configure(IServiceProvider provider){            
            BuildDbSchema(provider);                         
        }
        protected override IHostBuilder CreateHostBuilder(AssemblyName assemblyName) =>
            base.CreateHostBuilder(assemblyName)
                .ConfigureHostConfiguration(builder => builder.AddInMemoryCollection(new Dictionary<string, string> { { HostDefaults.ApplicationKey, assemblyName.Name } }));
        private IConfigurationRoot GetIConfigurationRoot(string outputPath)
        {
            return new ConfigurationBuilder()
                .SetBasePath(outputPath)                
                .AddUserSecrets("aspnet-Modular.WebHost-dca604fa-ee10-4a6c-8e7d-8cc79dca8c8f")
                .AddEnvironmentVariables()
                .Build();
        }
        private string GetSrcPath(string path){
            var hasSource = Directory.Exists(path + "\\src");
            return hasSource ? path + "\\src" : GetSrcPath(Directory.GetParent(path).FullName);
        }
        private string GetSharedFolder(string path){
            var folderExist = Directory.Exists(path + "\\Shared");
            return folderExist ? path +"\\Shared" : GetSrcPath(Directory.GetParent(path).FullName);
        }        
        private void BuildDbSchema(IServiceProvider provider)
        {
            using (var scope = provider.CreateScope())
            {
                using (var dbContext = (SimplDbContext)scope.ServiceProvider.GetService<SimplDbContext>())
                {                                                         
                    // if(dbContext.Database.GetPendingMigrations().Count() > 0){
                        dbContext.Database.EnsureDeleted();                                
                        dbContext.Database.EnsureCreated();
                    // }
                }
            }
        } 
    }
}
