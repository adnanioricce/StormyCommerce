using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SimplCommerce.Infrastructure.Modules;
using SimplCommerce.Module.EmailSenderSendgrid;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Core.Services.Customer;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Infraestructure.Models;
using StormyCommerce.Module.Customer.Services;
using System;
using System.Text;

namespace StormyCommerce.Module.Customer
{
    public class ModuleInitializer : IModuleInitializer
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();
            //app.UseWhen(
            //    context => context.Request.Path.StartsWithSegments("/api"),
            //    a => a.Use(async (context, next) =>
            //    {
            //        var principal = new ClaimsPrincipal();

            //        var cookiesAuthResult = await context.AuthenticateAsync("Identity.Application");
            //        if (cookiesAuthResult?.Principal != null)
            //        {
            //            principal.AddIdentities(cookiesAuthResult.Principal.Identities);
            //        }

            //        var bearerAuthResult = await context.AuthenticateAsync(JwtBearerDefaults.AuthenticationScheme);
            //        if (bearerAuthResult?.Principal != null)
            //        {
            //            principal.AddIdentities(bearerAuthResult.Principal.Identities);
            //        }

            //        context.User = principal;
            //        await next();
            //    }));
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            AddCustomizedIdentity(serviceCollection);
            serviceCollection.AddTransient<ITokenService, TokenService>();
            serviceCollection.AddTransient<IEmailSender, EmailSender>();
            serviceCollection.AddScoped<UserManager<ApplicationUser>>();
            serviceCollection.AddScoped<SignInManager<ApplicationUser>>();
            serviceCollection.AddScoped<RoleManager<IdentityRole>>();
            serviceCollection.AddScoped<IUserIdentityService, UserIdentityService>();
            serviceCollection.AddScoped<ICustomerService, CustomerService>();
            serviceCollection.AddTransient<IReviewService, ReviewService>();
        }
        

        //TODO: Move this to a extension method, like used on WebHost
        private void AddCustomizedIdentity(IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddRoles<ApplicationRole>()
                .AddEntityFrameworkStores<StormyDbContext>()                
                .AddDefaultTokenProviders();
            //var signingConfigurations = new SigningConfigurations();
            //services.AddSingleton(signingConfigurations);
            var tokenConfigurations = new TokenConfigurations();
            new ConfigureFromConfigurationOptions<TokenConfigurations>(
                Container.Configuration.GetSection("Jwt"))
                    .Configure(tokenConfigurations);
            services.Configure<IdentityOptions>(options =>
            {
                //Default Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;
                // Default Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
                //User Settings
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
                //Sign In Settings
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });
            services.Configure<AuthMessageSenderOptions>(Container.Configuration);
            services.AddAuthentication(options => options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        //TODO: you probably don't need of theses classes:SigningConfigurations and TokenConfigurations
                        ValidateIssuer = true,
                        ValidIssuer = Container.Configuration["Authentication:Jwt:Issuer"],
                        ValidateAudience = false,
                        ValidAudience = "Anyone",
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Container.Configuration["Authentication:Jwt:Key"])),
                        RequireExpirationTime = false,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,
                    };
                });
            services.AddAuthorization(auth =>
            {
                //auth.AddPolicy("Admin", policy => {
                //    policy.RequireClaim(Roles.Admin);
                //    policy.RequireRole(Roles.Admin);

                //    });
                auth.AddPolicy("Customer",new AuthorizationPolicyBuilder()
                .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                .RequireAuthenticatedUser()
                .Build());
                auth.AddPolicy("Admin", new AuthorizationPolicyBuilder()
                    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser()
                    .Build());
            });            
        }
    }
}
