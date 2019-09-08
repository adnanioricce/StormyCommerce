using StormyCommerce.Core.Entities.Catalog.Product;
using System;

namespace StormyCommerce.Core.Tests.Helpers
{
    public static class BrandDataSeeder
    {
        public static Brand GetSampleData()
        {
            return new Brand
            {
                Id = 3,
                Name = "Nices",
                Slug = "Nices-brand",
                IsDeleted = false,
                Description = "Nice brand is a brand that create fashion products",
                Website = "www.nice.com.br",
                LastModified = DateTime.UtcNow,
                LogoImage = "logo.img"
            };
        }

        public static Brand GetSingleBrandData()
        {
            return new Brand
            {
                Id = 1,
                Name = "Ardidas",
                Slug = "brand-adidas",
                IsDeleted = false,
                Description = "Ardidas is a brand",
                LastModified = DateTime.UtcNow,
                Website = "www.ardidas.com.br"
            };
        }
    }
}
