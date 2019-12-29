using StormyCommerce.Core.Entities.Customer;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Customer.Extensions
{
    public interface IWorkContext
    {
        Task<User> GetCurrentCustomer();
        Task<User> GetCurrentApplicationUser();
    }
}
