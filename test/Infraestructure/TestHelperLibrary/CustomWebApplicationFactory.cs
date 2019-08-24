using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SimplCommerce.Infrastructure.Modules;
using SimplCommerce.Module.SampleData;
using SimplCommerce.WebHost;
using SimplCommerce.WebHost.Extensions;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data;

namespace TestHelperLibrary
{
    public class CustomWebApplicationFactory : WebApplicationFactory<Startup>
    {
        private const string _relativeTargetProjectParentDir = @"src\SimplCommerce.WebHost";        
        public static string GetProjectPath(string projectRelativePath,Assembly startupAssembly)
        {
            var projectName = startupAssembly.GetName().Name;
            var applicationBasePath = AppContext.BaseDirectory;
            var directoryInfo = new DirectoryInfo(applicationBasePath);
            do
            {                
                var projectDirectoryInfo = new DirectoryInfo(Path.Combine(directoryInfo.FullName, projectRelativePath));
                
                if (projectDirectoryInfo.Exists)
                    if (new FileInfo(Path.Combine(projectDirectoryInfo.FullName, projectName, $"{projectName}.csproj")).Exists)
                        return Path.Combine(projectDirectoryInfo.FullName, projectName);
            }
            while (directoryInfo.Parent != null);

            throw new Exception($"Project root could not be located using the application root {applicationBasePath}.");
        }
        
        protected override IWebHostBuilder CreateWebHostBuilder()
        {
            var startupAssembly = typeof(Startup).GetTypeInfo().Assembly;
            var contentRoot = GetProjectPath(_relativeTargetProjectParentDir,startupAssembly);            
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(contentRoot)
                .AddJsonFile("appsettings.json");
            var configuration = configurationBuilder.Build();
            var builder = base.CreateWebHostBuilder()
                .UseContentRoot(contentRoot)
                .UseConfiguration(configuration)
                .UseEnvironment("Development")
                .UseStartup<Startup>();
            ConfigureWebHost(builder);
            return builder;
        }
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services => 
            {
                //TODO:Encapsulate all on this method and give it like a argument to the ConfigureServices Method
                InitializeServices(services);
                //Create a new service provider
                var serviceProvider = new ServiceCollection()
                    .AddEntityFrameworkInMemoryDatabase()
                    .BuildServiceProvider();               
                //TODO:Give a look to the AddApplicationPart on the ServicesCollectionExtensions on SimplCommerce.WebHost
                services.AddModules("src/SimplCommerce.WebHost");
                services.AddDbContext<StormyDbContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryTestDb-" + Guid.NewGuid().ToString("N"));
                    options.UseInternalServiceProvider(serviceProvider);
                });                
                //Build the service provider 
                var sp = services.BuildServiceProvider();
                var moduleInitializers = sp.GetServices<IModuleInitializer>();
                moduleInitializers.ToList().ForEach(moduleInitializer => {
                    moduleInitializer.ConfigureServices(services);
                });
                //Create a scope to obtain reference to the database
                using(var scope = sp.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var context = scopedServices.GetRequiredService<IStormyDbContext>();
                    var logger = scopedServices.GetRequiredService<ILogger<CustomWebApplicationFactory>>();
                    var concreteContext = (StormyDbContext)context;

                    concreteContext.Database.EnsureCreated();                    
                    try
                    {
                        concreteContext.SeedDbContext();                        
                    }
                    catch(Exception ex)
                    {
                        logger.LogError(ex,$"Error throwed when sending the database.Message:{ex.Message}");
                    }
                }
                
            });            

            base.ConfigureWebHost(builder);
        }
        protected virtual void InitializeServices(IServiceCollection services)
        {
            var startupAssembly = typeof(Startup).GetTypeInfo().Assembly;
            var manager = new ApplicationPartManager
            {
                ApplicationParts =
                {
                    new AssemblyPart(startupAssembly)
                },
                FeatureProviders =
                {
                    new ControllerFeatureProvider(),
                    new ViewComponentFeatureProvider()
                }

            };
            services.AddSingleton(manager);
        }        
        protected override void ConfigureClient(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:49206");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            base.ConfigureClient(client);
        }
    }
}
