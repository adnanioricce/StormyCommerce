using AutoMapper;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Core.Entities.Vendor;
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
                .ForMember(dto => dto.Vendor, opt => opt.MapFrom(src => src.Vendor));
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
            CreateMap<ProductDto, StormyProduct>();

            //CreateMap<IList<StormyProduct>, IList<ProductDto>>();
            //CreateMap<IList<StormyProduct>, List<ProductDto>>()
            //    .ForAllMembers(v => v.MapFrom(src => src));
        }
    }
}
