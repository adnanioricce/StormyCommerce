using AutoMapper;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Module.Customer.Areas.Customer.ViewModels;
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
            CreateMap<WriteReviewRequest, Review>();
            CreateMap<CreateCustomerRequest, StormyCustomer>();
        }
    }
}
