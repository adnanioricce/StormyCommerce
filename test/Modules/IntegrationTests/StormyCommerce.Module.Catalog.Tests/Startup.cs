using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SimplCommerce.Module.StorageLocal;
using SimplCommerce.Module.Core.Services;
using SimplCommerce.Module.Core.Data;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Infrastructure.Logging;
using SimplCommerce.Infrastructure;
using SimplCommerce.WebHost.Extensions;
using StormyCommerce.Module.Catalog.Interfaces;
using StormyCommerce.Module.Catalog.Services;
using Xunit;
using Xunit.Abstractions;
using Xunit.DependencyInjection;
using System.IO;
using System.Linq;
using SimplCommerce.Infrastructure.Modules;
using SimplCommerce.Module.SampleData.Extensions;
using SimplCommerce.Module.SampleData.Data;

[assembly: TestFramework("StormyCommerce.Module.Catalog.Tests.Startup", "StormyCommerce.Module.Catalog.Tests")]
namespace StormyCommerce.Module.Catalog.Tests
{
    public class Startup : DependencyInjectionTestFramework
    {
        public Startup(IMessageSink messageSink) : base(messageSink) { }

        protected override void ConfigureServices(IServiceCollection services)
        {                       
            GlobalConfiguration.ContentRootPath = GetSrcPath("",AppDomain.CurrentDomain.BaseDirectory) + "\\SimplCommerce.WebHost\\";                                                      
            services.AddModules(GlobalConfiguration.ContentRootPath);
            services.AddDbContextPool<SimplDbContext>(opt => {
                opt.EnableSensitiveDataLogging();
                opt.EnableDetailedErrors();
                opt.UseSqlite("DataSource=testDb.db",m => m.MigrationsAssembly("StormyCommerce.Module.Catalog.Tests"));
            });                                                
            services.AddTransient<IStormyProductService, StormyProductService>();                                    
            services.AddTransient<IMediaService, MediaService>();                        
            services.AddTransient<IStorageService, LocalStorageService>();                                                            
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient(typeof(IAppLogger<>), typeof(LoggerAdapter<>));    
            services.AddMappings();
            foreach(var module in GlobalConfiguration.Modules)
            {
                var moduleInitializerType = module.Assembly.GetTypes()
                   .FirstOrDefault(t => typeof(IModuleInitializer).IsAssignableFrom(t));
                if ((moduleInitializerType != null) && (moduleInitializerType != typeof(IModuleInitializer)))
                {
                    var moduleInitializer = (IModuleInitializer)Activator.CreateInstance(moduleInitializerType);
                    services.AddSingleton(typeof(IModuleInitializer), moduleInitializer);
                    moduleInitializer.ConfigureServices(services);
                }
            }        
        }
        protected override void Configure(IServiceProvider provider){            
            BuildDbSchema(provider);                        
        }
        protected override IHostBuilder CreateHostBuilder(AssemblyName assemblyName) =>
            base.CreateHostBuilder(assemblyName)
                .ConfigureHostConfiguration(builder => builder.AddInMemoryCollection(new Dictionary<string, string> { { HostDefaults.ApplicationKey, assemblyName.Name } }));
        private string GetSrcPath(string currentFolder,string path){
            var hasSource = Directory.Exists(path + "\\src");
            return hasSource ? path + "\\src" : GetSrcPath(Directory.GetParent(path).Name,Directory.GetParent(path).FullName);
        }
        private void SeedDatabase(IServiceProvider provider)
        {
            var sqlRepository = (SqlRepository)provider.GetService<ISqlRepository>();
            var filePath = Path.Combine(GlobalConfiguration.ContentRootPath,"Modules", "SimplCommerce.Module.SampleData", "SampleContent", "Fashion","ResetToSampleData_SQLite.sql");
            var lines = File.ReadLines(filePath);
            var commands = sqlRepository.PostgresCommands(lines);
            sqlRepository.RunCommands(commands);
        }
        private void BuildDbSchema(IServiceProvider provider)
        {
            using (var scope = provider.CreateScope())
            {
                using (var dbContext = (SimplDbContext)scope.ServiceProvider.GetService<SimplDbContext>())
                {                                                         
                    if(dbContext.Database.GetPendingMigrations().Count() > 0){
                        dbContext.Database.EnsureDeleted();                                
                        dbContext.Database.EnsureCreated();
                    }
                }
            }
        }        
    }
}
