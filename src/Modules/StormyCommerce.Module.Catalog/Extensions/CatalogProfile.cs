using AutoMapper;
using AutoMapper.Configuration;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Vendor;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using System.Collections.Generic;

namespace StormyCommerce.Module.Catalog.Extensions
{
    public class CatalogProfile : Profile
    {
        public CatalogProfile()
        {
            CreateMap<StormyProduct, ProductDto>()
                .ForMember(dto => dto.Brand, opt => opt.MapFrom(src => src.Brand))
                .ForMember(dto => dto.Category, opt => opt.MapFrom(src => src.Category))
                .ForMember(dto => dto.Vendor, opt => opt.MapFrom(src => src.Vendor));
                            
            CreateMap<StormyProduct, ProductOverviewDto>()
                .ForMember(dto => dto.Category, opt => opt.MapFrom(src => src.Category))
                .ForMember(dto => dto.Medias, opt => opt.MapFrom(src => src.Medias))
                .ForMember(dto => dto.ThumbnailImage, opt => opt.MapFrom(src => src.ThumbnailImage));
            CreateMap<Brand, BrandDto>();
            CreateMap<Category, CategoryDto>();                
            CreateMap<StormyVendor, VendorDto>();
            CreateMap<VendorDto, StormyVendor>();
            CreateMap<CategoryDto, Category>();
            CreateMap<BrandDto, Brand>();
            CreateMap<ProductDto, StormyProduct>();
            
            //CreateMap<IList<StormyProduct>, IList<ProductDto>>();
            //CreateMap<IList<StormyProduct>, List<ProductDto>>()
            //    .ForAllMembers(v => v.MapFrom(src => src));
        }        
    }
}
