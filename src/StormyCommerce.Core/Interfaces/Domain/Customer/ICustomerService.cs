using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces.Domain.Customer
{
    public interface ICustomerService
    {
        Task CreateCustomerReviewAsync(Review review, string normalizedEmail);
        Task AddCustomerAddressAsync(CustomerAddress address, string customerId);
        Task AddWishListItem(StormyCustomer customer,long productId);
        Result DeleteAddress(StormyCustomer customer,long addressId);
    }
}
