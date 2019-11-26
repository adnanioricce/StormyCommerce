using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PagarMe;
using SimplCommerce.Module.EmailSenderSendgrid;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Interfaces.Domain.Payments;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Core.Services.Customer;
using StormyCommerce.Core.Services.Orders;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Stores;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Catalog.Services;
using StormyCommerce.Module.Customer.Services;
using StormyCommerce.Module.Orders.Interfaces;
using StormyCommerce.Module.Orders.Services;
using Xunit.Abstractions;
using Xunit.DependencyInjection;

namespace StormyCommerce.Modules.Tests.Modules.Extensions
{
    public static class TestHelperLibrary
    {        
        public static IServiceCollection AddCatalogDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IEntityService, EntityService>();
            services.AddScoped<IMediaService, MediaService>();
            services.AddScoped<IProductTemplateService, ProductTemplateService>();
            services.AddTransient<IBrandService, BrandService>();
            services.AddTransient<IMediaService, MediaService>();
            services.AddTransient<IStorageService, LocalStorageService>();
            return services;
        }
        public static IServiceCollection AddOrderDependencies(this IServiceCollection services)
        {            
            services.AddTransient<ICalcPrecoPrazoWSSoap, CalcPrecoPrazoWSSoapClient>();
            services.AddTransient<IShippingService, ShippingService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IPaymentProcessor, PaymentProcessor>();
            services.AddTransient<CorreiosService>();
            PagarMeService.DefaultApiKey = Container.Configuration["PagarMe:ApiKey"];
            PagarMeService.DefaultEncryptionKey = Container.Configuration["PagarMe:EncryptionKey"];            
            services.AddSingleton<PagarMeWrapper>();
            return services;
        }
        public static IServiceCollection AddCustomerDependencies(this IServiceCollection services)
        {
            services.AddTransient<ITokenService, TokenService>();
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddScoped<UserManager<StormyCustomer>>();
            services.AddScoped<SignInManager<StormyCustomer>>();
            services.AddScoped<RoleManager<ApplicationRole>>();
            services.AddTransient<StormyUserStore>();
            services.AddScoped<IUserIdentityService, UserIdentityService>();
            services.AddTransient<IReviewService, ReviewService>();
            services.AddIdentity<StormyCustomer, ApplicationRole>()
                .AddEntityFrameworkStores<StormyDbContext>()
                .AddUserStore<StormyUserStore>()
                .AddRoles<ApplicationRole>()
                .AddDefaultTokenProviders();
            return services;
        }
    }
}
