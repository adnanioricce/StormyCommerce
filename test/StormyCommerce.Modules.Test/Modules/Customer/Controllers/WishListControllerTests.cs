using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Areas.Customer.Controllers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Tests.Customer
{
    public class WishListControllerTests
    {
        [Fact]
        public async Task AddItemToWishList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var wishListController = new WishListController(TODO, TODO);
            long productId = 0;

            // Act
            var result = await wishListController.AddItemToWishList(
                productId);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task RemoveWishListItem_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var wishListController = new WishListController(TODO, TODO);
            long productId = 0;

            // Act
            var result = await wishListController.RemoveWishListItem(
                productId);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetWishList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var wishListController = new WishListController(TODO, TODO);

            // Act
            var result = await wishListController.GetWishList();

            // Assert
            Assert.True(false);
        }
    }
}
