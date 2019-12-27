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
        Task AddWishListItem(StormyUser customer,long productId);
        Task<Result> DeleteAddress(StormyUser customer,long addressId);
    }
}
