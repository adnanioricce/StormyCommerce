﻿using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Design;
using SimplCommerce.WebHost.Extensions;
using SimplCommerce.Infrastructure;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Extensions;
using SimplCommerce.Module.SampleData.Extensions;

namespace SimplCommerce.WebHost
{
    //just edit to my dbContext
    public class MigrationStormyDbContextFactory : IDesignTimeDbContextFactory<StormyDbContext>
    {
        public StormyDbContext CreateDbContext(string[] args)
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var contentRootPath = Directory.GetCurrentDirectory();

            var builder = new ConfigurationBuilder()
                            .SetBasePath(contentRootPath)
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                            .AddJsonFile($"appsettings.{environmentName}.json", true);

            builder.AddUserSecrets(typeof(MigrationStormyDbContextFactory).Assembly, optional: true);
            builder.AddEnvironmentVariables();
            var _configuration = builder.Build();

            //setup DI
            IServiceCollection services = new ServiceCollection();
            GlobalConfiguration.ContentRootPath = contentRootPath;
            services.AddModules(contentRootPath);
            services.AddStormyDataStore(_configuration);
            var _serviceProvider = services.BuildServiceProvider();
            var dbContext = _serviceProvider.GetRequiredService<StormyDbContext>();
            dbContext.SeedDbContext();
            return dbContext;
        }
    }
}
