using AutoMapper;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Models.Dtos;

namespace StormyCommerce.Module.Mapping.Mappings
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            //TODO: is this necessary?
            CreateMap<CustomerReviewDto, Review>();
               
        }
    }
}
