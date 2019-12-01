using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Models;

namespace StormyCommerce.Module.Customer.Areas.Customer.Controllers
{
    [Area("Customer")]
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
            _wishListRepository.Query()
                .Include(w => w.WishlistItems)
                .Load();
        }
        [HttpPost("add_item")]        
        public async Task<IActionResult> AddItemToWishList(long productId)
        {
            var user = await _userIdentityService.GetUserByClaimPrincipal(User);
            if(!(await _userIdentityService.IsEmailConfirmedAsync(user))) 
                return BadRequest(Result.Fail("the user needs to confirm your email to perform this operation"));            
            
            if(!user.CustomerWishlist.AddItem(productId)) return BadRequest(Result.Fail("Product alreadly is on wishlist"));
            var response = await _userIdentityService.EditUserAsync(user);            
            if(!response.Success) return BadRequest(response);
            return Ok(Result.Ok(response));
        }
        [HttpPost("remove_item")]        
        public async Task<IActionResult> RemoveWishListItem(long productId)
        {
            var user = await _userIdentityService.GetUserByClaimPrincipal(User);
            if(!user.CustomerWishlist.Remove(productId)) return BadRequest(Result.Fail("There is no item to remove"));
            await _userIdentityService.EditUserAsync(user);
            return Ok(Result.Ok("item removed from wishlist"));
        }
        [HttpGet("get")]
        public async Task<Wishlist> GetWishList()
        {
            var user = await _userIdentityService.GetUserByClaimPrincipal(User);
            return user.CustomerWishlist;
        }
    }
}
