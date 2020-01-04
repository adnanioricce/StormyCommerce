using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SimplCommerce.Module.WishList.Areas.WishList.Controllers;
using SimplCommerce.Module.WishList.Models;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Areas.Customer.Controllers;
using System.Threading.Tasks;
using TestHelperLibrary.Extensions;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Modules.Tests
{
    public class WishListControllerTests
    {
        private readonly WishListController _controller;
        private readonly IStormyRepository<WishList> _wishlistRepository;
        private readonly UserManager<User> _userManager;
        public WishListControllerTests(IStormyRepository<WishList> wishlistRepo,
            IUserIdentityService identityService,
            UserManager<User> userManager)
        {
            _wishlistRepository = wishlistRepo;
            _userManager = userManager;
            _controller = null;
            _controller.ControllerContext = _userManager.CreateTestContext();
        }
        //[Fact,TestPriority(-1)]
        //public async Task AddItemToWishList_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange                                    
        //    long productId = 1;

        //    // Act
        //    var response = (await _controller.AddItemToWishList(productId)) as OkObjectResult;
        //    // Assert
        //    Assert.Equal(200,(int)response.StatusCode);
        //}

        //[Fact,TestPriority(1)]
        //public async Task RemoveWishListItem_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange                        
        //    long productId = 1;

        //    // Act
        //    var response = (await _controller.RemoveWishListItem(productId)) as OkObjectResult;

        //    // Assert
        //    Assert.Equal(200,(int)response.StatusCode);
        //}

        //[Fact,TestPriority(0)]
        //public async Task GetWishList_StateUnderTest_ExpectedBehavior()
        //{
        //    // Act                      
        //    var result = await _controller.GetWishList();

        //    // Assert
        //    Assert.NotNull(result);
        //    Assert.NotNull(result.Items);
        //    Assert.True(result.Items.Count > 0);
        //}        
    }
}
