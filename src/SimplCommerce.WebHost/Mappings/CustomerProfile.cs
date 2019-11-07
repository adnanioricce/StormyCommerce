﻿using AutoMapper;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Module.Customer.Models.Requests;

namespace StormyCommerce.WebHost.Mappings
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            //TODO: is this necessary?
            CreateMap<CustomerReviewDto, Review>();
            CreateMap<Review, CustomerReviewDto>();
            CreateMap<CustomerDto, StormyCustomer>();
            CreateMap<StormyCustomer, CustomerDto>();                
            CreateMap<StormyCustomer, ApplicationUser>();                
            CreateMap<ApplicationUser, StormyCustomer>();
            CreateMap<WriteReviewRequest, Review>();
        }
    }
}
