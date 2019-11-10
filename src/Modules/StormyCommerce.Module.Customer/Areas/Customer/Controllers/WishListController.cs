using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Models;

namespace StormyCommerce.Module.Customer.Areas.Customer.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    [EnableCors("Default")]
    [Authorize(Roles.Customer)]
    public class WishListController : Controller
    {
        private readonly IStormyRepository<Wishlist> _wishListRepository;                
        private readonly IUserIdentityService _userIdentityService;
        public WishListController(IStormyRepository<Wishlist> wishListRepository,IUserIdentityService userIdentityService)
        {
            _wishListRepository = wishListRepository;
            _userIdentityService = userIdentityService;
        }
        [HttpPost("add_item")]        
        public async Task<IActionResult> WishList(long productId)
        {
            var user = await _userIdentityService.GetUserByClaimPrincipal(User);
            if(!(await _userIdentityService.IsEmailConfirmedAsync(user))) 
                return BadRequest(Result.Fail("the user needs to confirm your email to perform this operation"));
            
            if(user.CustomerWishlistId == null){
                var newWishList = new Wishlist{
                    StormyCustomerId = user.Id                    
                };
                newWishList.AddItem(productId);
                newWishList.Id = 0;     
                          
                await _wishListRepository.AddAsync(newWishList);
                return Ok(Result.Ok("item added to wishlist"));
            }
            var wishList = await _wishListRepository.GetByIdAsync();
            wishList.AddItem(productId);
            await _wishListRepository.UpdateAsync(wishList);            
            return Ok(Result.Ok("item added to wishlist"));
        }
        [HttpPost("remove_item")]
        public async Task<IActionResult> RemoveWishListItem(long productId)
        {
            var user = await _userIdentityService.GetUserByClaimPrincipal(User);
            if(user.CustomerWishlistId == null) return BadRequest(Result.Fail("the user don't have any item on your wishlist"));
            var wishList = await _wishListRepository.GetByIdAsync(user.CustomerWishlistId);
            wishList.Remove(productId);
            await _wishListRepository.UpdateAsync(wishList);
            return Ok(Result.Ok("item removed from wishlist"));
        }
    }
}
