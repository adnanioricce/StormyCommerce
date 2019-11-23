using AutoMapper;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Areas.Customer.Controllers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace StormyCommerce.Modules.Tests.Customer
{
    public class ReviewControllerTests
    {
        [Fact]
        public async Task GetCustomerReviews_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var reviewController = new ReviewController(TODO, TODO, TODO);

            // Act
            var result = await reviewController.GetCustomerReviews();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetReviewById_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var reviewController = new ReviewController(TODO, TODO, TODO);
            long reviewId = 0;

            // Act
            var result = await reviewController.GetReviewById(
                reviewId);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task WriteReview_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var reviewController = new ReviewController(TODO, TODO, TODO);
            WriteReviewRequest model = null;

            // Act
            var result = await reviewController.WriteReview(
                model);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task EditReview_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var reviewController = new ReviewController(TODO, TODO, TODO);
            Review review = null;

            // Act
            var result = await reviewController.EditReview(
                review);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteReview_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var reviewController = new ReviewController(TODO, TODO, TODO);
            long reviewId = 0;

            // Act
            var result = await reviewController.DeleteReview(
                reviewId);

            // Assert
            Assert.True(false);
        }
    }
}
