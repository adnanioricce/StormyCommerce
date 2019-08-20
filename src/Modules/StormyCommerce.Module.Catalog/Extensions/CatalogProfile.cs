using AutoMapper;
using AutoMapper.Configuration;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using System.Collections.Generic;

namespace StormyCommerce.Module.Catalog.Extensions
{
    public class CatalogProfile : Profile
    {
        public CatalogProfile()
        {
            CreateMap<StormyProduct, ProductDto>();
            CreateMap<ProductDto, StormyProduct>();
            CreateMap<StormyProduct, ProductOverviewDto>();
            CreateMap<IList<StormyProduct>, IList<ProductDto>>();
            CreateMap<IList<StormyProduct>, List<ProductDto>>();
        }        
    }
}
