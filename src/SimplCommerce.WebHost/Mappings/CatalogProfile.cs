using System;
using System.Linq;
using AutoMapper;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Core.Entities.Vendor;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Core.Models.Requests;
using StormyCommerce.Module.Catalog.Dtos;

namespace StormyCommerce.WebHost.Mappings
{
    public class CatalogProfile : Profile
    {
        public CatalogProfile()
        {                          
            CreateMap<Brand, BrandDto>();                                                   
            CreateMap<VendorDto, StormyVendor>();            
            CreateMap<BrandDto, Brand>();
            CreateMap<StormyVendor, VendorDto>();                                        
            CreateMap<Media, MediaDto>();
            CreateMap<Media, ProductMediaDto>();                
            CreateMap<ProductMediaDto,MediaDto>();                
            CreateMap<ProductMedia,ProductMediaDto>();  
            CategoryMap();
            ProductMap();              
        }        
        public void CategoryMap()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>()
                .ForMember(c => c.Id,opt => opt.MapFrom(cdto => cdto.Id));
            CreateMap<ProductCategory,ProductCategoryDto>();            
        }
        public void ProductMap()
        {
            CreateMap<StormyProduct, ProductDto>()                                              
                .ForPath(dto => dto.Price,opt => opt.MapFrom(src => src.Price.Value));                
            CreateMap<StormyProduct, ProductSearchResponse>();                                    
            CreateMap<StormyProduct, ProductOverviewDto>();                                
            CreateMap<CreateProductRequest,StormyProduct>();                          
            CreateMap<ProductDto, StormyProduct>()                                                
                .ForPath(src => src.Price.Value,opt => opt.MapFrom(src => Price.GetPriceFromString(src.Price)));
        }
    }

}
