using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Models;
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
        private readonly IMapper _mapper;
        public ReviewController(IReviewService reviewService, IMapper mapper)
        {
            _reviewService = reviewService;
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
            await _reviewService.CreateReviewCustomerAsync(review);            
            return Ok(Result.Ok("Review was added with sucess"));
        }

    }
}
