using System.Linq;
using System.Threading.Tasks;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Services.Customer;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.Services.Customers
{
    public class ReviewServiceTest
    {
        [Fact]
        public async Task CreateReviewCustomerAsync_ReceivesCustomerReview_ShouldAddNewReviewToCustomerAccountAndProduct()
        {
            //Arrange 
            var review = Seeders.ReviewSeed().First();
            var repository = RepositoryHelper.GetRepository<Review>();
            var service = (IReviewService)(new ReviewService(repository));
            //Act 
            await service.CreateReviewAsync(review);
            var createdReview = repository.Table.Last();
            //Assert
            Assert.Equal(review, createdReview);
        }
        [Fact]
        public async Task GetCustomerReviews_ReceivesCustomerId_ShouldReturnAllReviewsRelatedToCustomerId() 
        {
            //Arrange
            var reviews = Seeders.ReviewSeed(2);
            using (var dbContext = DbContextHelper.GetDbContext(DbContextHelper.GetDbOptions())) {
                var customer = Seeders.StormyCustomerSeed().First();
                dbContext.Add(customer);
                dbContext.SaveChanges();
                reviews.ForEach(r => r.Author = customer);
                dbContext.AddRange(reviews);
                dbContext.SaveChanges();
                var repository = RepositoryHelper.GetRepository<Review>(dbContext);
                var service = (IReviewService)(new ReviewService(repository));
                //Act
                var entries = await service.GetCustomerReviews(customer.UserId);
                //Assert
                Assert.Equal(reviews, entries);
            }
        }
        [Fact]
        public async Task GetCustomerReviewById_ReceivesReviewId_ShouldReturnReviewWithGivenId()
        {
            //Arrange
            var review = Seeders.ReviewSeed().First();
            using (var dbContext = DbContextHelper.GetDbContext(DbContextHelper.GetDbOptions()))
            {
                dbContext.Add(review);
                dbContext.SaveChanges();
                var repository = RepositoryHelper.GetRepository<Review>(dbContext);
                var service = (IReviewService)new ReviewService(repository);
                //Act
                var entry = await service.GetCustomerReviewByIdAsync(1);
                //Assert
                Assert.Equal(review, entry);
            }
        }
    }
}
