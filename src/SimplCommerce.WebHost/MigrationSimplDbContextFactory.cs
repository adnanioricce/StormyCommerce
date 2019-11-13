using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimplCommerce.Infrastructure;
using SimplCommerce.WebHost.Extensions;
using StormyCommerce.Infraestructure.Data;
using System;
using System.IO;

namespace SimplCommerce.WebHost
{
    //just edit to my dbContext
    public class MigrationStormyDbContextFactory : IDesignTimeDbContextFactory<StormyDbContext>
    {
        public StormyDbContext CreateDbContext(string[] args)
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "";

            var contentRootPath = Directory.GetCurrentDirectory();

            var builder = new ConfigurationBuilder()
                            .SetBasePath(contentRootPath)
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
                            .AddJsonFile($"appsettings.{environmentName}.json", true);

            builder.AddUserSecrets(typeof(MigrationStormyDbContextFactory).Assembly, optional: true);
            builder.AddEnvironmentVariables();
            var _configuration = builder.Build();

            //setup DI
            IServiceCollection services = new ServiceCollection();
            GlobalConfiguration.ContentRootPath = contentRootPath;
            services.AddModules(contentRootPath);
            if(environmentName.Equals("Development")){
               services.AddDbContextPool<StormyDbContext>(options => {
                   options.UseSqlite("DataSource=database.db",b => b.MigrationsAssembly("SimplCommerce.WebHost"));
                   options.EnableDetailedErrors();
                   options.EnableSensitiveDataLogging();
               });
            } else{
                services.AddStormyDataStore(_configuration);
            }                        
            var _serviceProvider = services.BuildServiceProvider();
            return _serviceProvider.GetRequiredService<StormyDbContext>();
        }
    }
}
