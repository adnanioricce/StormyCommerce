using System.Linq;
using System.Threading.Tasks;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Models;
using StormyCommerce.Infraestructure.Interfaces;

namespace StormyCommerce.Module.Customer.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IUserIdentityService _identityService;
        private readonly IStormyRepository<CustomerAddress> _addressRepository;
        public CustomerService(IUserIdentityService identityService,IStormyRepository<CustomerAddress> addressRepository)
        {
            _identityService = identityService;
            _addressRepository = addressRepository;
        }
        public Task AddCustomerAddressAsync(CustomerAddress address, string customerId)
        {
            throw new System.NotImplementedException();
        }

        public Task AddWishListItem(User customer, long productId)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateCustomerReviewAsync(Review review, string normalizedEmail)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Result> DeleteAddress(User customer, long addressId)
        {
            if (customer.Addresses.Any(a => a.Id == addressId))
            {
                customer.RemoveAddress(addressId);
                var result = await _identityService.EditUserAsync(customer);
                if (!result.Success) return Result.Fail(result.Message);
                return result;
            }            

            return Result.Fail("no address was deleted, no Id finded to remove");
        }
    }
}
