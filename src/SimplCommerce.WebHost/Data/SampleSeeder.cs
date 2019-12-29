using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Infraestructure.Data;
using Bogus;
using StormyCommerce.Api.Framework.Extensions;

namespace SimplCommerce.WebHost.Data
{
    public static class SampleSeeder
    {
        public static void Seed(this StormyDbContext context)
        {
            var jsonFile = File.ReadAllText("Categories.json");            
            var categories = JsonConvert.DeserializeObject<List<Category>>(jsonFile);
            categories.Add(new Category
            {
                Id = 0,
                Name = "Boné",
                Description = "uma descrição emocionante",
                ThumbnailImage = new StormyCommerce.Core.Entities.Media.Media { 
                   
                },
            });
            categories.Add(new Category
            {
                Id = 0,
                Name = "Bermuda",
                Description = "uma descrição animadora",
                DisplayOrder = 2,
                ThumbnailImage = new StormyCommerce.Core.Entities.Media.Media
                {

                },
            });
            categories.Add(new Category
            {
                Id = 0,
                Name = "Sapato",
                Description = "uma descricão foda",
                ThumbnailImage = new StormyCommerce.Core.Entities.Media.Media
                {

                },
            });
            var products = JsonConvert.DeserializeObject<List<StormyProduct>>(File.ReadAllText("Products.json"));
            products.ForEach(p =>
            {
                var faker = new Faker<StormyProduct>();
                p.Sku = Guid.NewGuid().ToString();
                p.Slug = p.GenerateSlug();
                p.ShortDescription = "uma descrição curta";
                p.Categories.Add(new ProductCategory
                {
                    Product = p,
                    Category = categories.First(),
                });
                p.Brand.Description = "uma descrição";
                //p.
            });
        }
    }
}
