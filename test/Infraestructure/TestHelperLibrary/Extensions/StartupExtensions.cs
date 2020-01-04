using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PagarMe;
using SimplCommerce.Module.EmailSenderSendgrid;
using SimplCommerce.Module.Shipments.Interfaces;
using SimplCommerce.Module.Shipments.Services;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Catalog.Interfaces;
using StormyCommerce.Module.Catalog.Services;
using StormyCommerce.Module.Customer.Services;
using StormyCommerce.Module.Orders.Interfaces;
using StormyCommerce.Module.Orders.Services;
using StormyCommerce.Module.Payments.Interfaces;
using StormyCommerce.Module.PaymentsPagarMe.Services;

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
            services.AddSingleton<IShippingBuilder, ShippingBuilder>();
            services.AddSingleton<IShippingProvider, CorreiosService>();
            services.AddTransient<IShippingService, ShippingService>();
            services.AddTransient<IPaymentProcessor, PaymentProcessor>();
            services.AddTransient<CorreiosService>();
            PagarMeService.DefaultApiKey = Container.Configuration["PagarMe:ApiKey"];
            PagarMeService.DefaultEncryptionKey = Container.Configuration["PagarMe:EncryptionKey"];
            var pagarMe = PagarMeService.GetDefaultService();
            services.AddSingleton(pagarMe);
            services.AddSingleton<PagarMeWrapper>();
            return services;
        }
        public static IServiceCollection AddCustomerDependencies(this IServiceCollection services)
        {
            services.AddTransient<ITokenService, TokenService>();
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddScoped<UserManager<User>>();
            services.AddScoped<SignInManager<User>>();
            services.AddScoped<RoleManager<Role>>();            
            services.AddScoped<IUserIdentityService, UserIdentityService>();            
            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<StormyDbContext>()                                
                .AddDefaultTokenProviders();
            return services;
        }
    }
}
