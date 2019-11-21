using Microsoft.Extensions.DependencyInjection;
using SimplCommerce.WebHost.Extensions;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Core.Services.Orders;
using Xunit;
using Xunit.Abstractions;
using Xunit.DependencyInjection;

[assembly: TestFramework("StormyCommerce.Modules.Test.Startup", "AssemblyName")]

namespace Your.Test.Project
{
    public class Startup : DependencyInjectionTestFramework
    {
        public Startup(IMessageSink messageSink) : base(messageSink) { }

        protected override void ConfigureServices(IServiceCollection services)
        {
            services.AddMappings();
            services.AddTransient<IProductService,ProductService>();
            services.AddTransient<IBrandService,BrandService>();
            services.AddTransient<ICategoryService,CategoryService>();
            services.AddTransient<IOrderService,OrderService>();
        }
    }
}