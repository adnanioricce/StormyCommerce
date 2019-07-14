using StormyCommerce.Core.Entities.Catalog;
using System.Collections.Generic;

namespace StormyCommerce.Core.Tests.Helpers
{
    public static class SampleCategoryDataHelper
    {
        public static List<Category> GetSampleCategoryData()
        {
            return new List<Category>
            {
                new Category
                {
                    Slug = "categoria-camisas",
                    Name = "Camisas",
                    Description = "Descrição Camisas",
                    IsPublished = true,
                    Parent = new Category
                    {
                        Slug = "categoria-vestimentas",
                        ParentId = 1,
                        Name = "Roupas",
                        IsPublished = true
                    },                     
                }
            };
        }
        public static Category GetSingleCategoryData()
        {
            return new Category
            {
                Name = "Camisas",
                Slug = "categoria-roupas-camisas",
                Description = "Descrição Camisas",
                IsPublished = true,                
            };
        }
        public static Category GetSingleCategoryForUpdateOperations(long id)
        {
            return new Category(id)
            {
                Slug = "categoria-vestimentas-camisas",
                Description = "Descrição Camisas",
                IsPublished = true,                
            };
        }
    }
}
