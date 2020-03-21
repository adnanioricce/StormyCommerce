using SimplCommerce.Infraestructure.Modules;
namespace SimplCommerce.Module.PagarMe
{
    public class PagarMeModuleInitializer : IModuleInitializer
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {            
            serviceCollection.AddTransient<PagarMeProcessor,IPaymentProvider>();            
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
        }
    }
}