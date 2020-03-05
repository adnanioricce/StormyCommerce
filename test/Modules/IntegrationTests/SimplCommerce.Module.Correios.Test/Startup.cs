using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Infrastructure.Logging;
using SimplCommerce.Infrastructure;
//using SimplCommerce.WebHost.Extensions;
using Xunit;
using Xunit.Abstractions;
using Xunit.DependencyInjection;
using System.IO;
using System.Linq;
using SimplCommerce.Infrastructure.Modules;
using Microsoft.EntityFrameworkCore;
using SimplCommerce.Module.Core.Data;
using SimplCommerce.WebHost.Extensions;

[assembly: TestFramework("SimplCommerce.Module.Correios.Tests.Startup", "SimplCommerce.Module.Correios.Tests")]
namespace SimplCommerce.Module.Correios.Tests
{
    public class Startup : DependencyInjectionTestFramework
    {
        public Startup(IMessageSink messageSink) : base(messageSink)
        {
        }

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
        }
        //TODO: Generate classlib for common code
        private IConfigurationRoot GetIConfigurationRoot(string outputPath)
        {
            return new ConfigurationBuilder()
                .SetBasePath(outputPath)
                .AddUserSecrets("aspnet-Modular.WebHost-dca604fa-ee10-4a6c-8e7d-8cc79dca8c8f")
                .AddEnvironmentVariables()
                .Build();
        }
        private string GetSrcPath(string path)
        {
            var hasSource = Directory.Exists(path + "\\src");
            return hasSource ? path + "\\src" : GetSrcPath(Directory.GetParent(path).FullName);
        }
        private string GetSharedFolder(string path)
        {
            var folderExist = Directory.Exists(path + "\\Shared");
            return folderExist ? path + "\\Shared" : GetSrcPath(Directory.GetParent(path).FullName);
        }
    }
}
