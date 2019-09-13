using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Infraestructure.Entities;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Customer.Extensions
{
    public interface IWorkContext
    {
        Task<StormyCustomer> GetCurrentCustomer();
        Task<ApplicationUser> GetCurrentApplicationUser();
    }
}
