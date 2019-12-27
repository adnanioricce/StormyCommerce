using StormyCommerce.Core.Entities.Customer;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Customer.Extensions
{
    public interface IWorkContext
    {
        Task<StormyUser> GetCurrentCustomer();
        Task<StormyUser> GetCurrentApplicationUser();
    }
}
