using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PagarMe;
using SimplCommerce.Module.EmailSenderSendgrid;
using SimplCommerce.Module.SampleData;
using SimplCommerce.WebHost.Extensions;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Core.Services.Customer;
using StormyCommerce.Core.Services.Orders;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;
using StormyCommerce.Infraestructure.Data.Stores;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Infraestructure.Logging;
using StormyCommerce.Module.Customer.Data;
using StormyCommerce.Module.Customer.Services;
using StormyCommerce.Module.Orders.Interfaces;
using StormyCommerce.Module.Orders.Services;
using Xunit;
using Xunit.Abstractions;
using Xunit.DependencyInjection;

[assembly: TestFramework("StormyCommerce.Modules.Test.Startup", "StormyCommerce.Modules.IntegrationTest")]

namespace StormyCommerce.Modules.IntegrationTest
{
    public class Startup : DependencyInjectionTestFramework
    {
        public Startup(IMessageSink messageSink) : base(messageSink) { }

        protected override void ConfigureServices(IServiceCollection services)
        {
            services.AddMappings();
            services.AddDbContextPool<StormyDbContext>(options => {
                options.UseLazyLoadingProxies();                                
                options.UseSqlite("DataSource=testDb.db", b => b.MigrationsAssembly("StormyCommerce.Modules.IntegrationTest"));
                options.EnableDetailedErrors();
                options.EnableSensitiveDataLogging();
            });
            services.AddTransient<IProductService,ProductService>();
            services.AddTransient<IBrandService,BrandService>();
            services.AddTransient<ICategoryService,CategoryService>();
            services.AddTransient<IOrderService,OrderService>();
            services.AddTransient<IEmailSender,EmailSender>();
            services.AddTransient<ITokenService, TokenService>();
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddScoped<UserManager<StormyCustomer>>();
            services.AddScoped<SignInManager<StormyCustomer>>();
            services.AddScoped<RoleManager<ApplicationRole>>();
            services.AddTransient<StormyUserStore>();
            services.AddScoped<IUserIdentityService, UserIdentityService>();            
            services.AddTransient<IReviewService, ReviewService>();
            services.AddTransient(typeof(IStormyRepository<>), typeof(StormyRepository<>));
            services.AddTransient(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddTransient<ICalcPrecoPrazoWSSoap,CalcPrecoPrazoWSSoapClient>();
            services.AddTransient<IShippingService, ShippingService>();
            services.AddTransient<CorreiosService>();
            PagarMeService.DefaultApiKey = "";
            PagarMeService.DefaultEncryptionKey = "";
            var pagarme = new PagarMeService(PagarMeService.DefaultApiKey,PagarMeService.DefaultEncryptionKey);
            services.AddSingleton(pagarme);

        }
        protected override IHostBuilder CreateHostBuilder(System.Reflection.AssemblyName assemblyName){
            return base.CreateHostBuilder(assemblyName)
                        .ConfigureHostConfiguration(builder => builder.AddInMemoryCollection(new Dictionary<string,string>{{
                            HostDefaults.ApplicationKey, assemblyName.Name
                        }}));
        }
        protected override void Configure(System.IServiceProvider provider){
            using (var scope = provider.CreateScope())
            {
                using (var dbContext = (StormyDbContext)scope.ServiceProvider.GetService<StormyDbContext>())
                {
                    if (dbContext.Database.IsSqlite())
                    {
                        if (dbContext.Database.EnsureDeleted())
                        {
                            dbContext.Database.ExecuteSqlCommand(dbContext.Database.GenerateCreateScript());
                        }
                    }
                    if (!dbContext.Database.IsSqlServer())
                    {
                        var userManager = scope.ServiceProvider.GetService<UserManager<StormyCustomer>>();
                        var roleManager = scope.ServiceProvider.GetService<RoleManager<ApplicationRole>>();
                        new IdentityInitializer(dbContext, userManager, roleManager).Initialize();
                        dbContext.SeedDbContext();
                    }
                }
            }
        }
    }
}