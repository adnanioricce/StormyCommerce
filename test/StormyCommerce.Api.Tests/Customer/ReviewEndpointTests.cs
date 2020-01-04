using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using SimplCommerce.Module.Reviews.Models;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Module.Customer.Models;
using StormyCommerce.Module.Customer.Models.Requests;
using Xunit;

namespace StormyCommerce.Api.Tests.Customer
{
    public class ReviewEndpointTests
    {
        private readonly HttpClient client;
        public ReviewEndpointTests()
        {
            client = new HttpClient();
            client.BaseAddress = new System.Uri(Config.BaseUrl);
        }        
        [Fact]
        public async Task CreateReviewEndpointTest()
        {
            await client.Authenticate();
            var response = await client.PostAsJsonAsync<WriteReviewRequest>("/api/Review/create",new WriteReviewRequest { 
                Comment = "comment",
                Rating = RatingLevel.Five,
                ReviewerName = "Adnan",
                Title = "a awesome product",
                StormyProductId = 1
            });
            Assert.True(response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task GetReviewByIdEndpointTest()
        {
            await client.Authenticate();
            var response = await client.GetAsync("/api/Review/get?reviewId=1");
            Assert.True(response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task EditReviewEndpointTest()
        {
            await client.Authenticate();
            var review = new Review();
            review.Id = 1;                        
            var response = await client.PutAsJsonAsync<Review>("/api/Review/edit",review);            
            Assert.True(response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task DeleteReviewEndpointTest()
        {
            await client.Authenticate();
            var response = await client.PostAsJsonAsync<WriteReviewRequest>("/api/Review/create",new WriteReviewRequest { 
                Comment = "comment",
                Rating = RatingLevel.Five,
                ReviewerName = "Adnan",
                Title = "Title"
            });
            Assert.True(response.IsSuccessStatusCode);
        }
    }
}
