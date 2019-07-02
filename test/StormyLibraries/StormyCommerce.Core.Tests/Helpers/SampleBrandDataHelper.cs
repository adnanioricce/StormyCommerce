using System;
using StormyCommerce.Core.Entities.Catalog.Product;

namespace StormyCommerce.Core.Tests.Helpers
{
    public static class SampleBrandDataHelper
    {
        public static Brand GetSampleData()
        {
            return new Brand
            {
                Name = "Nike",
                Slug = "Nike-brand",
                Deleted = false,
                Description = "Nike brand is a brand that create fashion products",
                Website = "www.nike.com.br",
                LastModified = DateTime.UtcNow,
                LogoImage = "logo.img"                
            };
        }
    }
}