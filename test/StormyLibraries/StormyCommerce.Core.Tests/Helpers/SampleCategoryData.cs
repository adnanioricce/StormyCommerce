using StormyCommerce.Core.Entities.Catalog;
using System.Collections.Generic;

namespace StormyCommerce.Core.Tests.Helpers
{
    public static class SampleCategoryData
    {
        public static List<Category> GetSampleCategoryData()
        {
            return new List<Category>
            {
                new Category
                {
                    Name = "Camisas",
                    Description = "Descrição Camisas",
                    IsPublished = true,
                    Parent = new Category
                    {
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
                Description = "Descrição Camisas",
                IsPublished = true,
                Parent = new Category
                {
                    ParentId = 1,
                    Name = "Roupas",
                    IsPublished = true
                },
            };
        }
    }
}
