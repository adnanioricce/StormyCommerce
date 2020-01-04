﻿//using AutoMapper;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using SimplCommerce.Module.Reviews.Models;
//using StormyCommerce.Core.Entities;
//using StormyCommerce.Core.Entities.Customer;
//using StormyCommerce.Core.Interfaces;
//using StormyCommerce.Core.Interfaces.Domain.Customer;
//using StormyCommerce.Core.Models;
//using StormyCommerce.Infraestructure.Interfaces;
//using StormyCommerce.Module.Customer.Areas.Customer.Controllers;
//using StormyCommerce.Module.Customer.Models;
//using StormyCommerce.Module.Customer.Models.Requests;
//using System;
//using System.Linq;
//using System.Threading.Tasks;
//using TestHelperLibrary.Extensions;
//using Xunit;

//namespace StormyCommerce.Modules.Tests
//{
//    public class ReviewControllerTests
//    {
//        private readonly ReviewController _controller;
//        private readonly IStormyRepository<Review> _reviewRepository;
//        private readonly User requestUser;
//        public ReviewControllerTests(IUserIdentityService identityService
//            ,IStormyRepository<Review> reviewRepository
//            ,IMapper mapper,UserManager<User> _userManager)
//        {
//            _controller = new ReviewController(null, identityService, mapper);
//            _reviewRepository = reviewRepository;
//            requestUser = _userManager.GetTestCustomer();
//            _reviewRepository.AddAsync(new Review
//            {
//                Title = "title",
//                Comment = "comment",
//                Rating = (int)RatingLevel.Five,
//                ReviewerName = "aguinobaldo",
//                Status = ReviewStatus.Approved,
//                UserId = requestUser.Id
//            });
//            _reviewRepository.AddAsync(new Review
//            {
//                Title = "title",
//                Comment = "comment",
//                Rating = (int)RatingLevel.Five,
//                ReviewerName = "aguinobaldo",
//                Status = ReviewStatus.Approved,
//                UserId = requestUser.Id
//            });
//            _reviewRepository.AddAsync(new Review
//            {
//                Title = "title",
//                Comment = "comment",
//                Rating= (int)RatingLevel.Five,
//                ReviewerName = "aguinobaldo",
//                Status = ReviewStatus.Approved,
//                UserId = requestUser.Id                
//            });
//            Task.WaitAll();
//            _controller.ControllerContext = _userManager.CreateTestContext();
//        }
//        [Fact,TestPriority(3)]
//        public async Task GetCustomerReviews_StateUnderTest_ExpectedBehavior()
//        {
//            // Act                     
//            var result = await _controller.GetCustomerReviews();

//            // Assert
//            Assert.NotNull(result);
//            Assert.True(result.Count() > 0);
//        }

//        [Fact,TestPriority(3)]
//        public async Task GetReviewById_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange          
//            long reviewId = 1;

//            // Act
//            var result = await _controller.GetReviewById(reviewId);

//            // Assert
//            Assert.Equal(reviewId,result.Id);
//        }

//        [Fact,TestPriority(1)]
//        public async Task WriteReview_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange            
//            WriteReviewRequest model = new WriteReviewRequest { 
//                Title = "title",
//                Comment = "comment",
//                Rating = Module.Customer.Models.RatingLevel.One,
//                ReviewerName = "aguinobaldo",
//                StormyProductId = 1
                
//            };

//            // Act
//            var response = await _controller.WriteReview(model);
//            var result = response.Value as Result;
//            // Assert
//            Assert.True(result.Success);
//        }

//        [Fact,TestPriority(4)]
//        public async Task EditReview_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange            
//            Review review = await _reviewRepository.GetByIdAsync(1);
//            review.Comment += "updated";
//            // Act
//            var response = await _controller.EditReview(review);
//            var result = response.Value as Result;
//            // Assert
//            Assert.True(result.Success);
//        }

//        [Fact,TestPriority(-10)]
//        public async Task DeleteReview_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange                        
//            long reviewId = 1;

//            // Act
//            var response = await _controller.DeleteReview(reviewId);
//            var result = response.Value as Result;
//            // Assert
//            Assert.True(result.Success);
//        }
//    }
//}
