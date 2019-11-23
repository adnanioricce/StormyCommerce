﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IStormyRepository<Wishlist> _wishlistRepository;
        private readonly UserManager<StormyCustomer> _userManager;
        public WishListControllerTests(IStormyRepository<Wishlist> wishlistRepo,
            IUserIdentityService identityService,
            UserManager<StormyCustomer> userManager)
        {
            _wishlistRepository = wishlistRepo;
            _userManager = userManager;
            _controller = new WishListController(wishlistRepo,identityService);
            _controller.ControllerContext = _userManager.CreateTestContext();
        }
        [Fact]
        public async Task AddItemToWishList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange                                    
            long productId = 1;

            // Act
            var response = (await _controller.AddItemToWishList(productId)) as OkObjectResult;
            // Assert
            Assert.Equal(200,(int)response.StatusCode);
        }

        [Fact]
        public async Task RemoveWishListItem_StateUnderTest_ExpectedBehavior()
        {
            // Arrange                        
            long productId = 1;

            // Act
            var response = (await _controller.RemoveWishListItem(productId)) as OkObjectResult;

            // Assert
            Assert.Equal(200,(int)response.StatusCode);
        }

        [Fact]
        public async Task GetWishList_StateUnderTest_ExpectedBehavior()
        {
            // Act                      
            var result = await _controller.GetWishList();

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(result.WishlistItems);
            Assert.True(result.WishlistItems.Count > 0);
        }        
    }
}
