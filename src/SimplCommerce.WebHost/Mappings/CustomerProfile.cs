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
            CreateMap<CustomerDto, User>();
            CreateMap<User, CustomerDto>();
            CreateMap<CustomerAddress, CustomerAddressDto>()
                .ForPath(dest => dest.Address.City,opt => opt.MapFrom(src => src.Details.City))
                .ForPath(dest => dest.Address.State, opt => opt.MapFrom(src => src.Details.State))
                .ForPath(dest => dest.Address.CountryCode, opt => opt.MapFrom(src => src.Details.CountryCode))
                .ForPath(dest => dest.Address.Complement, opt => opt.MapFrom(src => src.Details.Complement))
                .ForPath(dest => dest.Address.ZipCode, opt => opt.MapFrom(src => src.Details.ZipCode))
                .ForPath(dest => dest.Address.Number, opt => opt.MapFrom(src => src.Details.Number))
                .ForPath(dest => dest.Address.Street, opt => opt.MapFrom(src => src.Details.Street))
                .ForPath(dest => dest.Address.AddressLine1, opt => opt.MapFrom(src => src.Details.AddressLine1))
                .ForPath(dest => dest.Address.AddressLine2, opt => opt.MapFrom(src => src.Details.AddressLine2));
            CreateMap<WriteReviewRequest, Review>();
            CreateMap<CreateCustomerRequest, User>();
            CreateMap<EditCustomerRequest, User>()
                .ForAllMembers(opt => opt.Condition((src,dest,srcMember) => srcMember != null));
            CreateMap<EditCustomerAddressRequest,CustomerAddress>();
            CreateMap<CreateShippingAddressRequest,CustomerAddress>();
            CreateMap<Wishlist, WishlistDto>();
            CreateMap<WishlistItem, WishListItemDto>();
        }
    }
}
