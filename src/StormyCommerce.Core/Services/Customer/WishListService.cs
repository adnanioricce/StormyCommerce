using System;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;

namespace StormyCommerce.Core.Services.Customer
{
    public class WishListService
    {
        private readonly IStormyRepository<Wishlist> _wishListRepository;
        public WishListService()
        {
            
        }
    }
}
