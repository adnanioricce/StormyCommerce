using System;
using AutoMapper;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Core.Entities.Vendor;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Module.Catalog.Dtos;

namespace StormyCommerce.Module.Mapping.Mappings
{
    public class CatalogProfile : Profile
    {
        public CatalogProfile()
        {
            CreateMap<StormyProduct, ProductDto>()
                .ForMember(dto => dto.Brand, opt => opt.MapFrom(src => src.Brand))
                .ForMember(dto => dto.Category, opt => opt.MapFrom(src => src.Category))
                .ForMember(dto => dto.Vendor, opt => opt.MapFrom(src => src.Vendor))
                //TODO:This will not work well, define a type to handle this kind of operation
                .ForMember(dto => dto.UnitSize,opt => opt.MapFrom(src => src.UnitSize.ToString() + "cm"))
                .ForMember(dto => dto.Price,opt => opt.MapFrom(src => src.Price.Value));
            CreateMap<StormyProduct, VendorDto>();
            CreateMap<StormyProduct, BrandDto>();
            CreateMap<StormyProduct, CategoryDto>();
            CreateMap<StormyProduct, MediaDto>();
            CreateMap<StormyProduct, ProductOverviewDto>()
                .ForMember(dto => dto.Category, opt => opt.MapFrom(src => src.Category))
                .ForMember(dto => dto.Medias, opt => opt.MapFrom(src => src.Medias))
                .ForMember(dto => dto.ThumbnailImage, opt => opt.MapFrom(src => src.ThumbnailImage));
            CreateMap<Brand, BrandDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<StormyVendor, VendorDto>();
            CreateMap<Media, MediaDto>();
            CreateMap<VendorDto, StormyVendor>();
            CreateMap<CategoryDto, Category>();
            CreateMap<BrandDto, Brand>();
            CreateMap<ProductDto, StormyProduct>()
                .ForMember(src => src.UnitSize,opt => opt.MapFrom(src => Convert.ToDecimal(src.UnitSize.Replace("cm",""))))
                .ForMember(src => src.Price,opt => opt.MapFrom(src => Price.GetPriceFromString(src.Price)));            
        }
    }
}
