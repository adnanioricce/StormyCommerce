using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces.Domain.Customer
{
    public interface ICustomerService
    {
        Task CreateCustomerReviewAsync(Review review, string normalizedEmail);

        Task AddCustomerAddressAsync(CustomerAddress address, long customerIds);               

        Task<IList<CustomerAddress>> GetAllCustomerAddressByIdAsync(long id);
        
        Task<IList<StormyCustomer>> GetAllCustomersAsync();
        Task<IList<StormyCustomer>> GetAllCustomersAsync(long minLimit,long maxLimit);
        int GetCustomersCount();
        Task<StormyCustomer> GetCustomerByIdAsync(long id);

        Task<StormyCustomer> GetCustomerByUserNameOrEmail(string username, string email);        
        
        Task CreateCustomerAsync(StormyCustomer customer);        

        Task CreateCustomerAsync(CustomerDto appUser);

        Task EditCustomerAsync(CustomerDto customer);

        Task DeleteCustomerByIdAsync(long id);

        // Task
    }
}
