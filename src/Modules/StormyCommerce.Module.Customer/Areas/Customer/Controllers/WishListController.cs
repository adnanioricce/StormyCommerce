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
            _wishListRepository.Table
                .Include(w => w.WishlistItems)
                .Load();
        }
        [HttpPost("add_item")]        
        public async Task<IActionResult> AddItemToWishList(long productId)
        {
            var user = await _userIdentityService.GetUserByClaimPrincipal(User);
            if(!(await _userIdentityService.IsEmailConfirmedAsync(user))) 
                return BadRequest(Result.Fail("the user needs to confirm your email to perform this operation"));
            // var list = await _wishListRepository.Table.Where(w => string.Equals(w.StormyCustomerId, user.Id))?.FirstOrDefaultAsync();
            if(user.CustomerWishlist == null){
                user.CustomerWishlist = new Wishlist();
                user.CustomerWishlist.AddItem(productId);                
                          
                await _userIdentityService.EditUserAsync(user);
                return Ok(Result.Ok("item added to wishlist"));
            }            
            user.CustomerWishlist.AddItem(productId);
            await _userIdentityService.EditUserAsync(user);            
            return Ok(Result.Ok("item added to wishlist"));
        }
        [HttpPost("remove_item")]
        [Authorize(Roles.Customer)]
        public async Task<IActionResult> RemoveWishListItem(long productId)
        {
            var user = await _userIdentityService.GetUserByClaimPrincipal(User);
            var list = await _wishListRepository.Table.Where(w => string.Equals(w.StormyCustomerId, user.Id)).FirstOrDefaultAsync();
            if (list == null || list.WishlistItems.Count == 0) return BadRequest(Result.Fail("the user don't have any item on your wishlist"));            
            list.Remove(productId);
            await _wishListRepository.UpdateAsync(list);
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
