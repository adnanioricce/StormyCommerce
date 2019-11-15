using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Models;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Models;
using StormyCommerce.Module.Customer.Models.Requests;

namespace StormyCommerce.Module.Customer.Areas.Customer.Controllers
{
    [Area("Customer")]
    [ApiController]
    [Route("api/[Controller]")]
    [EnableCors("Default")]
    [Authorize(Roles.Customer)]
    public class ReviewController : Controller
    {
        private readonly IReviewService _reviewService;
        private readonly IUserIdentityService _identityService;
        private readonly IMapper _mapper;
        public ReviewController(IReviewService reviewService, IUserIdentityService identityService, IMapper mapper)
        {
            _reviewService = reviewService;
            _identityService = identityService;
            _mapper = mapper;
        }
        [HttpGet("list")]
        public async Task<List<Review>> GetCustomerReviews(string customerId)
        {
            return await _reviewService.GetCustomerReviews(customerId);
        }
        [HttpGet("get")]        
        public async Task<Review> GetReviewById(long reviewId)
        {
            return await _reviewService.GetCustomerReviewByIdAsync(reviewId);
        }
        [HttpPost("create")]
        [ValidateModel]
        public async Task<IActionResult> WriteReview(WriteReviewRequest model)
        {
            var review = _mapper.Map<Review>(model);
            var customer = GetCurrentCustomer();
            review.StormyCustomerId = customer.Id;            
            await _reviewService.CreateReviewAsync(review);            
            return Ok(Result.Ok("Review was added with sucess"));
        }
        [HttpPost("edit")]
        [ValidateModel]
        public async Task<IActionResult> EditReview(Review review)
        {
            try
            {
                await _reviewService.EditReviewAsync(review);                
            }
            catch(DbUpdateException ex)
            {
                throw ex;
            }
            return Ok();
        }
        [HttpPost("delete")]
        [ValidateModel]
        public async Task<IActionResult> DeleteReview(long reviewId)
        {
            await _reviewService.DeleteReviewAsync(reviewId);
            return Ok();
        }        
        private StormyCustomer GetCurrentCustomer()
        {
            return _identityService.GetUserByEmail(this.HttpContext.User.Claims.FirstOrDefault(c => c.Type.Contains("emailaddress")).Value);
        }
    }
}
