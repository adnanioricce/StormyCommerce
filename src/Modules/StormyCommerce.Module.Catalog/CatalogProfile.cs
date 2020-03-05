using AutoMapper;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Module.Core.Models;
using StormyCommerce.Module.Catalog.Models.Dtos;
using StormyCommerce.Module.Catalog.Models.Requests;
using StormyCommerce.Module.Catalog.Models.Responses;

namespace StormyCommerce.Module.Catalog
{
    public class CatalogProfile : Profile
    {
        public CatalogProfile()
        {                          
            CreateMap<Brand, BrandDto>();                                                               
            CreateMap<BrandDto, Brand>();            
            CreateMap<Media, MediaDto>();
            CreateMap<Media, ProductMediaDto>();                            
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
            CreateMap<Product, ProductDto>();                                                              
            CreateMap<Product, ProductSearchResponse>();                                    
            CreateMap<Product, ProductOverviewDto>();                                
            CreateMap<CreateProductRequest,Product>();                              
            CreateMap<EditProductRequest, Product>()
                    .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<ProductDto, Product>();                                                                
            CreateMap<ProductMediaDto, MediaDto>();
            CreateMap<ProductMedia, ProductMediaDto>();            
        }
    }
}