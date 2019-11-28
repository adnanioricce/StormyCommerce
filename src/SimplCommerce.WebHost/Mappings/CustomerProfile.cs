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
            CreateMap<CustomerReviewDto, Review>();
            CreateMap<Review, CustomerReviewDto>();
            CreateMap<CustomerDto, StormyCustomer>();
            CreateMap<StormyCustomer, CustomerDto>();                            
            CreateMap<WriteReviewRequest, Review>();
            CreateMap<CreateCustomerRequest, StormyCustomer>();
            CreateMap<EditCustomerRequest, StormyCustomer>()
                .ForAllMembers(opt => opt.Condition((src,dest,srcMember) => srcMember != null));
            CreateMap<EditCustomerAddressRequest,CustomerAddress>();
            CreateMap<CreateShippingAddressRequest,CustomerAddress>();
            CreateMap<Wishlist, WishlistDto>();
            CreateMap<WishlistItem, WishListItemDto>();
        }
    }
}
